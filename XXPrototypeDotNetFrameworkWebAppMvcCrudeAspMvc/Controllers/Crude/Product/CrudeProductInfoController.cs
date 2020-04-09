/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:25:16 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductInfoController : Controller {

        [HttpGet]
        public ActionResult CrudeProductInfoIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoIndex.cshtml",
                new CrudeProductInfoServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoIndex.cshtml",
                new CrudeProductInfoServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoDetails(System.Guid productInfoId) {

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoDetails.cshtml",
                new CrudeProductInfoServiceClient().FetchByProductInfoId(productInfoId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoEdit(
            System.Guid productInfoId
            ) {

            CrudeProductInfoContract contract = new CrudeProductInfoServiceClient().FetchByProductInfoId(productInfoId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                contract.ProductInfoRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoEdit([Bind()] CrudeProductInfoContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductInfoServiceClient().Update(contract);

                return RedirectToAction("CrudeProductInfoIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductInfoContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                contract.ProductInfoRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoCreate([Bind()] CrudeProductInfoContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductInfoServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductInfoIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoDelete(
            System.Guid productInfoId
            ) {
            new CrudeProductInfoServiceClient().Delete(productInfoId);

            return RedirectToAction("CrudeProductInfoIndex");
        }
    }
}
