/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:27:25 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductIdentifierRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefIndex.cshtml",
                new CrudeProductIdentifierRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefDetails(System.String productIdentifierRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefDetails.cshtml",
                new CrudeProductIdentifierRefServiceClient().FetchByProductIdentifierRcd(productIdentifierRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefEdit(
            System.String productIdentifierRcd
            ) {

            CrudeProductIdentifierRefContract contract = new CrudeProductIdentifierRefServiceClient().FetchByProductIdentifierRcd(productIdentifierRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierRefEdit([Bind()] CrudeProductIdentifierRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductIdentifierRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductIdentifierRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefCreate(System.Guid? userId) {
            var contract = new CrudeProductIdentifierRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierRefCreate([Bind()] CrudeProductIdentifierRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductIdentifierRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductIdentifierRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefDelete(
            System.String productIdentifierRcd
            ) {
            new CrudeProductIdentifierRefServiceClient().Delete(productIdentifierRcd);

            return RedirectToAction("CrudeProductIdentifierRefIndex");
        }
    }
}
