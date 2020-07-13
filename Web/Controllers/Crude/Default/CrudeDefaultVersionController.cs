/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:56 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultVersionController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultVersionIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionIndex.cshtml",
                new CrudeDefaultVersionServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultVersionDetails(System.Guid defaultVersionId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionDetails.cshtml",
                new CrudeDefaultVersionServiceClient().FetchByDefaultVersionId(defaultVersionId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultVersionEdit(
            System.Guid defaultVersionId
            ) {

            CrudeDefaultVersionContract contract = new CrudeDefaultVersionServiceClient().FetchByDefaultVersionId(defaultVersionId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultVersionEdit([Bind()] CrudeDefaultVersionContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultVersionServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultVersionIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultVersionCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultVersionContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultVersionCreate([Bind()] CrudeDefaultVersionContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultVersionServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultVersionIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultVersionDelete(
            System.Guid defaultVersionId
            ) {
            new CrudeDefaultVersionServiceClient().Delete(defaultVersionId);

            return RedirectToAction("CrudeDefaultVersionIndex");
        }
    }
}
