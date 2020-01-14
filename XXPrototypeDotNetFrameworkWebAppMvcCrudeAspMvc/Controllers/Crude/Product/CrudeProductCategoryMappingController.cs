/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:27:32 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductCategoryMappingController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingIndex.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingByProductCategoryIndex(System.Guid productCategoryId) {
            ViewBag.ProductCategoryId = productCategoryId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingIndex.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingIndex.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingDetails(System.Guid productCategoryMappingId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingDetails.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchByProductCategoryMappingId(productCategoryMappingId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingEdit(
            System.Guid productCategoryMappingId
            ) {

            CrudeProductCategoryMappingContract contract = new CrudeProductCategoryMappingServiceClient().FetchByProductCategoryMappingId(productCategoryMappingId);
            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryMappingEdit([Bind()] CrudeProductCategoryMappingContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryMappingServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryMappingIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingCreate(System.Guid? productCategoryId, System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductCategoryMappingContract();
            if (productCategoryId != null) contract.ProductCategoryId = (System.Guid) productCategoryId;
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryMappingCreate([Bind()] CrudeProductCategoryMappingContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryMappingServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryMappingIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingDelete(
            System.Guid productCategoryMappingId
            ) {
            new CrudeProductCategoryMappingServiceClient().Delete(productCategoryMappingId);

            return RedirectToAction("CrudeProductCategoryMappingIndex");
        }
    }
}
