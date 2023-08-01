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
using static MoonSiteTask.DbTest.AddCommentsTable;
using static MoonSiteTask.DbTest.AddReciptsTable;

namespace MoonSiteTask.Controllers
{
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
        public IActionResult Submit(PaymentFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }
            
            var scope = _databaseFactory.CreateDatabase();
            var a = new PaymentSchema(2, "aviv", 350, 4, "Transfer");
            scope.Insert<PaymentSchema>(a);
            scope.CompleteTransaction();
            var day = new DateTime();
            string str = day.ToShortDateString();
            int[] arr = {3,4};
            var b = new ReciptSchema(3, "chop", 500, "4,7", "Cash", str);
            scope.Insert<ReciptSchema>(b);
            scope.CompleteTransaction();
            return RedirectToCurrentUmbracoPage();
        }
    }

}