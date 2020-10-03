/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/3/2020 3:49:08 PM
  From Machine: DESKTOP-517I8BU
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
    public class CrudeDefaultUserActivityController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityIndex.cshtml",
                new CrudeDefaultUserActivityServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityDetails(System.Guid defaultUserActivityId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityDetails.cshtml",
                new CrudeDefaultUserActivityServiceClient().FetchByDefaultUserActivityId(defaultUserActivityId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityEdit(
            System.Guid defaultUserActivityId
            ) {

            CrudeDefaultUserActivityContract contract = new CrudeDefaultUserActivityServiceClient().FetchByDefaultUserActivityId(defaultUserActivityId);
            ViewBag.DefaultUserActivityTypeRcd =
                new SelectList( new CrudeDefaultUserActivityTypeRefServiceClient().FetchAll(),
                                "DefaultUserActivityTypeRcd",
                                "DefaultUserActivityTypeName",
                                contract.DefaultUserActivityTypeRcd
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserActivityEdit([Bind()] CrudeDefaultUserActivityContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultUserActivityServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultUserActivityIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultUserActivityContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            ViewBag.DefaultUserActivityTypeRcd =
                new SelectList( new CrudeDefaultUserActivityTypeRefServiceClient().FetchAll(),
                                "DefaultUserActivityTypeRcd",
                                "DefaultUserActivityTypeName",
                                contract.DefaultUserActivityTypeRcd
                                );

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserActivityCreate([Bind()] CrudeDefaultUserActivityContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultUserActivityServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultUserActivityIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityDelete(
            System.Guid defaultUserActivityId
            ) {
            new CrudeDefaultUserActivityServiceClient().Delete(defaultUserActivityId);

            return RedirectToAction("CrudeDefaultUserActivityIndex");
        }
    }
}
