using MailKit;
using Microsoft.AspNetCore.Mvc;
using MoonSiteTask.Models;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging; 
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using System.Text.Json;
using static MoonSiteTask.DbTest.AddCommentsTable;
using static MoonSiteTask.DbTest.AddReciptsTable;

namespace MoonSiteTask.Controllers
{
    //Form submit handler
    public class PaymentFormController : SurfaceController
    {
        private readonly IUmbracoDatabaseFactory _databaseFactory;
        public PaymentFormController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider) 
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {_databaseFactory = databaseFactory;}
        
        [HttpPost]
        public async Task<IActionResult> Submit(PaymentFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMsg"] = "Invalid Form";
                    return CurrentUmbracoPage();
            }
            using (var HttpClient = new HttpClient()){
            string uri = ("https://localhost:44327/umbraco/api/PaymentsApi/GetPaymentsByApt?Apt=" + model.AptNum);
            var res = await HttpClient.GetAsync(uri);
            if(res.IsSuccessStatusCode){
            var resString = await res.Content.ReadAsStringAsync();
            var PaymentsVals = JsonSerializer.Deserialize<List<Payment>>(resString,
            new JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
            if(PaymentsVals != null){
            foreach(var payid in PaymentsVals){
                foreach(int month in model.PayMonth!)
                if(month == payid.Month){
                    TempData["ErrorMsg"] = "already exists";
                    return CurrentUmbracoPage();
                }
            }}
            }}
            var scope = _databaseFactory.CreateDatabase();
            //day paid
            var day = new DateTime();
            day = DateTime.Today;
            string str = day.ToShortDateString();
            //months from arr to string (sqlite doesnt support arrays)
            string months = "";
            if(model.PayMonth != null){
            foreach(int month in model.PayMonth){
                months = months + month + ',';
            }
            months = months.Substring(0,months.Length - 1);
            }
            if(model.PayedWith != null && model.ResName != null){
            //insert recipt to array
            var b = new ReciptSchema(model.AptNum , model.Amount, months , model.PayedWith , str);
            scope.Insert<ReciptSchema>(b);
            //save recipt id for later use to connect to payments db
            int ReciptIdNum = b.Id;
            scope.CompleteTransaction();
            
            if(model.PayMonth != null){
            int len = model.PayMonth.Length;
            //insert each month payed to payment data db
            foreach(int month in model.PayMonth){
            var a = new PaymentSchema(model.AptNum, model.ResName, model.Amount/len, month, model.PayedWith, ReciptIdNum);
            scope.Insert<PaymentSchema>(a);
            scope.CompleteTransaction();
            }
            }
          
            }
            return RedirectToCurrentUmbracoPage();

    }

}}