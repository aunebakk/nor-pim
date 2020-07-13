/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:51:14 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductIdentifierController : Controller {

        [HttpGet]
        public ActionResult CrudeProductIdentifierIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifier/CrudeProductIdentifierIndex.cshtml",
                new CrudeProductIdentifierServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifier/CrudeProductIdentifierIndex.cshtml",
                new CrudeProductIdentifierServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierDetails(System.Guid productIdentifierId) {

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifier/CrudeProductIdentifierDetails.cshtml",
                new CrudeProductIdentifierServiceClient().FetchByProductIdentifierId(productIdentifierId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierEdit(
            System.Guid productIdentifierId
            ) {

            CrudeProductIdentifierContract contract = new CrudeProductIdentifierServiceClient().FetchByProductIdentifierId(productIdentifierId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductIdentifierRcd =
                new SelectList( new CrudeProductIdentifierRefServiceClient().FetchAll(),
                                "ProductIdentifierRcd",
                                "ProductIdentifierName",
                                contract.ProductIdentifierRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductIdentifier/CrudeProductIdentifierEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierEdit([Bind()] CrudeProductIdentifierContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductIdentifierServiceClient().Update(contract);

                return RedirectToAction("CrudeProductIdentifierIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifier/CrudeProductIdentifierEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductIdentifierContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductIdentifierRcd =
                new SelectList( new CrudeProductIdentifierRefServiceClient().FetchAll(),
                                "ProductIdentifierRcd",
                                "ProductIdentifierName",
                                contract.ProductIdentifierRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductIdentifier/CrudeProductIdentifierCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierCreate([Bind()] CrudeProductIdentifierContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductIdentifierServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductIdentifierIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifier/CrudeProductIdentifierCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierDelete(
            System.Guid productIdentifierId
            ) {
            new CrudeProductIdentifierServiceClient().Delete(productIdentifierId);

            return RedirectToAction("CrudeProductIdentifierIndex");
        }
    }
}
