/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:17:37 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductAttributeController : Controller {

        [HttpGet]
        public ActionResult CrudeProductAttributeIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductAttribute/CrudeProductAttributeIndex.cshtml",
                new CrudeProductAttributeServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductAttribute/CrudeProductAttributeIndex.cshtml",
                new CrudeProductAttributeServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeDetails(System.Guid productAttributeId) {

            return View(
                "~/Views/Crude/Product/CrudeProductAttribute/CrudeProductAttributeDetails.cshtml",
                new CrudeProductAttributeServiceClient().FetchByProductAttributeId(productAttributeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeEdit(
            System.Guid productAttributeId
            ) {

            CrudeProductAttributeContract contract = new CrudeProductAttributeServiceClient().FetchByProductAttributeId(productAttributeId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                contract.ProductAttributeRcd
                                );

            ViewBag.ProductAttributeUnitRcd =
                new SelectList( new CrudeProductAttributeUnitRefServiceClient().FetchAll(),
                                "ProductAttributeUnitRcd",
                                "ProductAttributeUnitName",
                                contract.ProductAttributeUnitRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductAttribute/CrudeProductAttributeEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeEdit([Bind()] CrudeProductAttributeContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductAttributeServiceClient().Update(contract);

                return RedirectToAction("CrudeProductAttributeIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttribute/CrudeProductAttributeEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductAttributeContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                contract.ProductAttributeRcd
                                );

            ViewBag.ProductAttributeUnitRcd =
                new SelectList( new CrudeProductAttributeUnitRefServiceClient().FetchAll(),
                                "ProductAttributeUnitRcd",
                                "ProductAttributeUnitName",
                                contract.ProductAttributeUnitRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductAttribute/CrudeProductAttributeCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeCreate([Bind()] CrudeProductAttributeContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductAttributeServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductAttributeIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttribute/CrudeProductAttributeCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeDelete(
            System.Guid productAttributeId
            ) {
            new CrudeProductAttributeServiceClient().Delete(productAttributeId);

            return RedirectToAction("CrudeProductAttributeIndex");
        }
    }
}
