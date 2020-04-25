/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:20:35 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultRuleController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultRuleIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleIndex.cshtml",
                new CrudeDefaultRuleServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleDetails(System.Guid defaultRuleId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleDetails.cshtml",
                new CrudeDefaultRuleServiceClient().FetchByDefaultRuleId(defaultRuleId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleEdit(
            System.Guid defaultRuleId
            ) {

            CrudeDefaultRuleContract contract = new CrudeDefaultRuleServiceClient().FetchByDefaultRuleId(defaultRuleId);
            ViewBag.DefaultRuleTypeRcd =
                new SelectList( new CrudeDefaultRuleTypeRefServiceClient().FetchAll(),
                                "DefaultRuleTypeRcd",
                                "DefaultRuleTypeName",
                                contract.DefaultRuleTypeRcd
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultRuleEdit([Bind()] CrudeDefaultRuleContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultRuleServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultRuleIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultRuleContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            ViewBag.DefaultRuleTypeRcd =
                new SelectList( new CrudeDefaultRuleTypeRefServiceClient().FetchAll(),
                                "DefaultRuleTypeRcd",
                                "DefaultRuleTypeName",
                                contract.DefaultRuleTypeRcd
                                );

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultRuleCreate([Bind()] CrudeDefaultRuleContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultRuleServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultRuleIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultRuleDelete(
            System.Guid defaultRuleId
            ) {
            new CrudeDefaultRuleServiceClient().Delete(defaultRuleId);

            return RedirectToAction("CrudeDefaultRuleIndex");
        }
    }
}
