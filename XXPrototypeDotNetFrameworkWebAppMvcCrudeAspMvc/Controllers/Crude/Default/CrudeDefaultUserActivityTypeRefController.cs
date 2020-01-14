/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:44:14 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultUserActivityTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefIndex.cshtml",
                new CrudeDefaultUserActivityTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefDetails(System.String defaultUserActivityTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefDetails.cshtml",
                new CrudeDefaultUserActivityTypeRefServiceClient().FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefEdit(
            System.String defaultUserActivityTypeRcd
            ) {

            CrudeDefaultUserActivityTypeRefContract contract = new CrudeDefaultUserActivityTypeRefServiceClient().FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserActivityTypeRefEdit([Bind()] CrudeDefaultUserActivityTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultUserActivityTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultUserActivityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultUserActivityTypeRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserActivityTypeRefCreate([Bind()] CrudeDefaultUserActivityTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultUserActivityTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultUserActivityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefDelete(
            System.String defaultUserActivityTypeRcd
            ) {
            new CrudeDefaultUserActivityTypeRefServiceClient().Delete(defaultUserActivityTypeRcd);

            return RedirectToAction("CrudeDefaultUserActivityTypeRefIndex");
        }
    }
}
