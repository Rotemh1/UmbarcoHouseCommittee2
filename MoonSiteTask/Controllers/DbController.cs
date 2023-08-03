using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Umbraco.Cms.Infrastructure.Scoping;
using Umbraco.Cms.Web.Common.Controllers;
using static MoonSiteTask.DbTest.AddCommentsTable;
using static MoonSiteTask.DbTest.AddReciptsTable;

namespace MoonSiteTask.Controllers
{
    //db api controller
    public class PaymentsApiController : UmbracoApiController
    {
        private readonly IScopeProvider _scopeProvider;
        public PaymentsApiController(IScopeProvider scopeProvider)
        {
            _scopeProvider = scopeProvider;
        }
        //get all Payments 
        [HttpGet]
        public IEnumerable<PaymentSchema> GetMonths()
        {
            using var scope = _scopeProvider.CreateScope();
            var queryResults = scope.Database.Fetch<PaymentSchema>("SELECT * FROM Payments");
            scope.Complete();
            return queryResults;
        }
        //get request for double payments validation
        [HttpGet]
        public IEnumerable<PaymentSchema> GetPaymentsByApt(int Apt)
        {
            using var scope = _scopeProvider.CreateScope();
            string sqlquery = "SELECT * FROM Payments WHERE AptNum = " + Apt;
            var queryResults = scope.Database.Fetch<PaymentSchema>(sqlquery);
            scope.Complete();
            return queryResults;
        }
        //post request for payments
        [HttpPost]
        public void InsertComment(PaymentSchema payment)
        {
            using var scope = _scopeProvider.CreateScope();
            scope.Database.Insert<PaymentSchema>(payment);
            scope.Complete();
        }
    }
        public class ReciptsApiController : UmbracoApiController
    {
        private readonly IScopeProvider _scopeProvider;
        public ReciptsApiController(IScopeProvider scopeProvider)
        {
            _scopeProvider = scopeProvider;
        }
        //get all recipts
        [HttpGet]
        public IEnumerable<ReciptSchema> GetRecipts()
        {
            using var scope = _scopeProvider.CreateScope();
            var queryResults = scope.Database.Fetch<ReciptSchema>("SELECT * FROM Recipts");
            scope.Complete();
            return queryResults;
        }
        //post request for recipts
        [HttpPost]
        public void InsertComment(ReciptSchema recipt)
        {
            using var scope = _scopeProvider.CreateScope();
            scope.Database.Insert<ReciptSchema>(recipt);
            scope.Complete();
        }
    }
}