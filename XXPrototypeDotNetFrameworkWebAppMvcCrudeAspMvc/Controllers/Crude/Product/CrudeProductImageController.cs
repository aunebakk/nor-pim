/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:08:43 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductImageController : Controller {

        [HttpGet]
        public ActionResult CrudeProductImageIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageIndex.cshtml",
                new CrudeProductImageServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageIndex.cshtml",
                new CrudeProductImageServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageDetails(System.Guid productImageId) {

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageDetails.cshtml",
                new CrudeProductImageServiceClient().FetchByProductImageId(productImageId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageEdit(
            System.Guid productImageId
            ) {

            CrudeProductImageContract contract = new CrudeProductImageServiceClient().FetchByProductImageId(productImageId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                contract.ProductImageTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageEdit([Bind()] CrudeProductImageContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductImageServiceClient().Update(contract);

                return RedirectToAction("CrudeProductImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductImageContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                contract.ProductImageTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageCreate([Bind()] CrudeProductImageContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductImageServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageDelete(
            System.Guid productImageId
            ) {
            new CrudeProductImageServiceClient().Delete(productImageId);

            return RedirectToAction("CrudeProductImageIndex");
        }
    }
}
