/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:34:30 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultRuleTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefIndex.cshtml",
                new CrudeDefaultRuleTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefDetails(System.String defaultRuleTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefDetails.cshtml",
                new CrudeDefaultRuleTypeRefServiceClient().FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefEdit(
            System.String defaultRuleTypeRcd
            ) {

            CrudeDefaultRuleTypeRefContract contract = new CrudeDefaultRuleTypeRefServiceClient().FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultRuleTypeRefEdit([Bind()] CrudeDefaultRuleTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultRuleTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultRuleTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultRuleTypeRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultRuleTypeRefCreate([Bind()] CrudeDefaultRuleTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultRuleTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultRuleTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefDelete(
            System.String defaultRuleTypeRcd
            ) {
            new CrudeDefaultRuleTypeRefServiceClient().Delete(defaultRuleTypeRcd);

            return RedirectToAction("CrudeDefaultRuleTypeRefIndex");
        }
    }
}
