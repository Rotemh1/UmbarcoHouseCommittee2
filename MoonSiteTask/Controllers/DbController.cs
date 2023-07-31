using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Umbraco.Cms.Infrastructure.Scoping;
using Umbraco.Cms.Web.Common.Controllers;
using static MoonSiteTask.DbTest.AddCommentsTable;

namespace MoonSiteTask.Controllers
{
    public class PaymentsApiController : UmbracoApiController
    {
        private readonly IScopeProvider _scopeProvider;
        public PaymentsApiController(IScopeProvider scopeProvider)
        {
            _scopeProvider = scopeProvider;
        }
        [HttpGet]
        public IEnumerable<PaymentSchema> GetComments(int umbracoNodeId)
        {
            using var scope = _scopeProvider.CreateScope();
            var queryResults = scope.Database.Fetch<PaymentSchema>("SELECT * FROM Payments WHERE BlogPostUmbracoId = @0", umbracoNodeId);
            scope.Complete();
            return queryResults;
        }
        [HttpPost]
        public void InsertComment(PaymentSchema payment)
        {
            using var scope = _scopeProvider.CreateScope();
            scope.Database.Insert<PaymentSchema>(payment);
            scope.Complete();
        }
    }
}