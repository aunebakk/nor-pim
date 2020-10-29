/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:07:57 PM
  From Machine: DESKTOP-742U247
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
    public class CrudeDefaultRuleController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultRuleIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleIndex.cshtml",
                new CrudeDefaultRuleServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultRuleDetails(System.Guid defaultRuleId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultRule/CrudeDefaultRuleDetails.cshtml",
                new CrudeDefaultRuleServiceClient().FetchByDefaultRuleId(defaultRuleId)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultRuleDelete(
            System.Guid defaultRuleId
            ) {
            new CrudeDefaultRuleServiceClient().Delete(defaultRuleId);

            return RedirectToAction("CrudeDefaultRuleIndex");
        }
    }
}
