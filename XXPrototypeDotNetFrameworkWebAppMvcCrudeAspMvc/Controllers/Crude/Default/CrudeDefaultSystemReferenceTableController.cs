/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:21:15 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultSystemReferenceTableController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableIndex.cshtml",
                new CrudeDefaultSystemReferenceTableServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableDetails(System.Guid defaultSystemReferenceTableId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableDetails.cshtml",
                new CrudeDefaultSystemReferenceTableServiceClient().FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableEdit(
            System.Guid defaultSystemReferenceTableId
            ) {

            CrudeDefaultSystemReferenceTableContract contract = new CrudeDefaultSystemReferenceTableServiceClient().FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemReferenceTableEdit([Bind()] CrudeDefaultSystemReferenceTableContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultSystemReferenceTableServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultSystemReferenceTableIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultSystemReferenceTableContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemReferenceTableCreate([Bind()] CrudeDefaultSystemReferenceTableContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultSystemReferenceTableServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultSystemReferenceTableIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableDelete(
            System.Guid defaultSystemReferenceTableId
            ) {
            new CrudeDefaultSystemReferenceTableServiceClient().Delete(defaultSystemReferenceTableId);

            return RedirectToAction("CrudeDefaultSystemReferenceTableIndex");
        }
    }
}
