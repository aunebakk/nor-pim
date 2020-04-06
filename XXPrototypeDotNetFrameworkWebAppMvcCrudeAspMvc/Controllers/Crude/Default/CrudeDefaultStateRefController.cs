/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:39:04 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultStateRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultStateRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefIndex.cshtml",
                new CrudeDefaultStateRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultStateRefDetails(System.String defaultStateRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefDetails.cshtml",
                new CrudeDefaultStateRefServiceClient().FetchByDefaultStateRcd(defaultStateRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultStateRefEdit(
            System.String defaultStateRcd
            ) {

            CrudeDefaultStateRefContract contract = new CrudeDefaultStateRefServiceClient().FetchByDefaultStateRcd(defaultStateRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultStateRefEdit([Bind()] CrudeDefaultStateRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultStateRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultStateRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultStateRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultStateRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultStateRefCreate([Bind()] CrudeDefaultStateRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultStateRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultStateRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultStateRefDelete(
            System.String defaultStateRcd
            ) {
            new CrudeDefaultStateRefServiceClient().Delete(defaultStateRcd);

            return RedirectToAction("CrudeDefaultStateRefIndex");
        }
    }
}
