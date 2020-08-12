/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:46:42 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductCategoryImageController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryImageIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageIndex.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageByProductCategoryIndex(System.Guid productCategoryId) {
            ViewBag.ProductCategoryId = productCategoryId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageIndex.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageDetails(System.Guid productCategoryImageId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageDetails.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchByProductCategoryImageId(productCategoryImageId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageEdit(
            System.Guid productCategoryImageId
            ) {

            CrudeProductCategoryImageContract contract = new CrudeProductCategoryImageServiceClient().FetchByProductCategoryImageId(productCategoryImageId);
            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductCategoryImageTypeRcd =
                new SelectList( new CrudeProductCategoryImageTypeRefServiceClient().FetchAll(),
                                "ProductCategoryImageTypeRcd",
                                "ProductCategoryImageTypeName",
                                contract.ProductCategoryImageTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageEdit([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryImageServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageCreate(System.Guid? productCategoryId, System.Guid? userId) {
            var contract = new CrudeProductCategoryImageContract();
            if (productCategoryId != null) contract.ProductCategoryId = (System.Guid) productCategoryId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductCategoryImageTypeRcd =
                new SelectList( new CrudeProductCategoryImageTypeRefServiceClient().FetchAll(),
                                "ProductCategoryImageTypeRcd",
                                "ProductCategoryImageTypeName",
                                contract.ProductCategoryImageTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageCreate([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryImageServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageDelete(
            System.Guid productCategoryImageId
            ) {
            new CrudeProductCategoryImageServiceClient().Delete(productCategoryImageId);

            return RedirectToAction("CrudeProductCategoryImageIndex");
        }
    }
}
