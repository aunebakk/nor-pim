/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:43:29 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultTestRunResultRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefIndex.cshtml",
                new CrudeDefaultTestRunResultRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefDetails(System.String defaultTestRunResultRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefDetails.cshtml",
                new CrudeDefaultTestRunResultRefServiceClient().FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefEdit(
            System.String defaultTestRunResultRcd
            ) {

            CrudeDefaultTestRunResultRefContract contract = new CrudeDefaultTestRunResultRefServiceClient().FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestRunResultRefEdit([Bind()] CrudeDefaultTestRunResultRefContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultTestRunResultRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultTestRunResultRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefCreate(System.Guid? userId) {
            var contract = new CrudeDefaultTestRunResultRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestRunResultRefCreate([Bind()] CrudeDefaultTestRunResultRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultTestRunResultRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultTestRunResultRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefDelete(
            System.String defaultTestRunResultRcd
            ) {
            new CrudeDefaultTestRunResultRefServiceClient().Delete(defaultTestRunResultRcd);

            return RedirectToAction("CrudeDefaultTestRunResultRefIndex");
        }
    }
}
