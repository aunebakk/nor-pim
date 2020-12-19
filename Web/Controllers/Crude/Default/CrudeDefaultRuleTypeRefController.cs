/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:22:33 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // controller class for mvc
    public class CrudeDefaultRuleTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefIndex.cshtml",
                new CrudeDefaultRuleTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefDetails(System.String defaultRuleTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefDetails.cshtml",
                new CrudeDefaultRuleTypeRefServiceClient().FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultRuleTypeRefDelete(
            System.String defaultRuleTypeRcd
            ) {
            new CrudeDefaultRuleTypeRefServiceClient().Delete(defaultRuleTypeRcd);

            return RedirectToAction("CrudeDefaultRuleTypeRefIndex");
        }
    }
}
