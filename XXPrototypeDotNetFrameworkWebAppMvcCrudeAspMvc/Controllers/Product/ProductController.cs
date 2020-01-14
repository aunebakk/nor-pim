using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

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

            Response.Redirect("http://NorSolutionPimCore.azurewebsites.net/api/1/cartproductsearchservice/getcartproducttypescript");
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
            cartProductContract.ClientId = userId;
            cartProductContract.Amount = 666;
            cartProductContract.FinancialCurrencyId = financialCurrencyContracts[0].FinancialCurrencyId;
            cartProductContract.StateRcd = DefaultStateRef.Created;
            cartProductContract.UserId = userId;
            cartProductContract.DateTime = DateTime.UtcNow;

            new CrudeCartProductServiceClient ( ).Insert ( cartProductContract );

            Response.Redirect ( "http://NorSolutionPimCore.azurewebsites.net/api/1/cartproductsearchservice/getcartproducttypescript", true );

            return null; 
        }

        [HttpGet]
        public ActionResult PIMDetails(
            Guid productId
            ) {
            var productContract = new ProductDetailsContract();

            Logging.ActionLog(Request, "ProductPIMDetailsLiveController PIMDetails ( ASP MVC WCF )");

            var efo =
                new CrudeDefaultSystemSettingServiceClient().FetchByDefaultSystemSettingRcd(
                    DefaultSystemSettingRef.ElektroforeningenWebLink);
            if (efo.Count > 0)
                productContract.EFOLink = efo[0].DefaultSystemSettingValue;

            var fdv =
                new CrudeDefaultSystemSettingServiceClient().FetchByDefaultSystemSettingRcd(
                    DefaultSystemSettingRef.FDVWebLink);
            if (fdv.Count > 0)
                productContract.FVDLink = fdv[0].DefaultSystemSettingValue;

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
