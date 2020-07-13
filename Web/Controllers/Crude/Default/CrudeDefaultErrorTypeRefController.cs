/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:54:11 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultErrorTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefIndex.cshtml",
                new CrudeDefaultErrorTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefDetails(System.String defaultErrorTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefDetails.cshtml",
                new CrudeDefaultErrorTypeRefServiceClient().FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefEdit(
            System.String defaultErrorTypeRcd
            ) {

            CrudeDefaultErrorTypeRefContract contract = new CrudeDefaultErrorTypeRefServiceClient().FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorTypeRefEdit([Bind()] CrudeDefaultErrorTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultErrorTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultErrorTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultErrorTypeRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorTypeRefCreate([Bind()] CrudeDefaultErrorTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultErrorTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultErrorTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefDelete(
            System.String defaultErrorTypeRcd
            ) {
            new CrudeDefaultErrorTypeRefServiceClient().Delete(defaultErrorTypeRcd);

            return RedirectToAction("CrudeDefaultErrorTypeRefIndex");
        }
    }
}
