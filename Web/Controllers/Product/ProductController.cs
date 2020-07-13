using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using System.Web.SessionState;

namespace SolutionNorSolutionPim.mvc.Controllers {
    public class ProductController : Controller {
        [HttpGet]
        public void UnOrder(
            Guid cartProductId
        ) {
            var cartProductContract = new CrudeCartProductServiceClient().FetchByCartProductId(cartProductId);
            cartProductContract.StateRcd = DefaultStateRef.Invalidated;
            cartProductContract.UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            cartProductContract.DateTime = DateTime.UtcNow;

            new CrudeCartProductServiceClient().Update(cartProductContract);

            Response.Redirect("../CartProduct/CartProductIndexLive", true);
        }

        [HttpGet]
        public ActionResult Order (
            Guid productId
        ) {
            Guid userId = Logging.UserId(User.Identity, ViewBag);

            // get currency
            List<CrudeFinancialCurrencyContract> financialCurrencyContracts = new 
                CrudeFinancialCurrencyServiceClient ( ).FetchAllWithLimit ( 1 );

            var cartProductContract = new CrudeCartProductContract ( );
            cartProductContract.ProductId = productId;

            // our internal default_user_id becomes the client id... hmm
            cartProductContract.ClientId = userId;

            // save it if we got it
            if (!string.IsNullOrEmpty(Session.SessionID))
                cartProductContract.SessionId = Guid.Parse( Session.SessionID );

            // oauth id
            if (!string.IsNullOrEmpty(User.Identity.GetUserId()))
                cartProductContract.AspId = Guid.Parse( User.Identity.GetUserId() );

            cartProductContract.Amount = 666;
            cartProductContract.FinancialCurrencyId = financialCurrencyContracts[0].FinancialCurrencyId;
            cartProductContract.StateRcd = DefaultStateRef.Created;
            cartProductContract.UserId = userId;
            cartProductContract.DateTime = DateTime.UtcNow;

            new CrudeCartProductServiceClient ( ).Insert ( cartProductContract );

            Response.Redirect("../CartProduct/CartProductIndexLive", true);

            return null; 
        }

        [HttpGet]
        public ActionResult PIMDetails(
            Guid productId
            ) {
            var productContract = new ProductDetailsContract();

            Logging.ActionLog(Request, "ProductPIMDetailsLiveController PIMDetails ( ASP MVC WCF )");

            productContract.Product = new CrudeProductServiceClient().FetchByProductId(productId);
            productContract.ProductMaintenanceAttributeIndexWithFilter =
                new ProductMaintenanceSearchService().ProductMaintenanceAttributeIndexWithFilter(productId);
            productContract.ProductMaintenanceDocumentationIndexWithFilter =
                new ProductMaintenanceSearchService().ProductMaintenanceDocumentationIndexWithFilter(productId);
            productContract.ProductMaintenanceIdentifierIndexWithFilter =
                new ProductMaintenanceSearchService().ProductMaintenanceIdentifierIndexWithFilter(productId);
            productContract.ProductMaintenanceImageIndexWithFilter =
                new ProductMaintenanceSearchService().ProductMaintenanceImageIndexWithFilter(productId);
            productContract.ProductMaintenanceInfoIndexWithFilter =
                new ProductMaintenanceSearchService().ProductMaintenanceInfoIndexWithFilter(productId);

            if (MVCHelper.IsMobile(Request)) {
                return View(
                    "~/Views/Durian/ProductMaintenanceSearch/PIMDetailsLiveMobileAttributes.cshtml",
                    productContract
                    );
            }

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/PIMDetailsLiveAttributes.cshtml",
                productContract
                );
        }
    }
}
