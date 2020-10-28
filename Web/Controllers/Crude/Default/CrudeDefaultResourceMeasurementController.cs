/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 9:23:44 PM
  From Machine: DESKTOP-9A2DH39
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
    public class CrudeDefaultResourceMeasurementController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementIndex.cshtml",
                new CrudeDefaultResourceMeasurementServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementDetails(System.Guid defaultResourceMeasurementId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementDetails.cshtml",
                new CrudeDefaultResourceMeasurementServiceClient().FetchByDefaultResourceMeasurementId(defaultResourceMeasurementId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementEdit(
            System.Guid defaultResourceMeasurementId
            ) {

            CrudeDefaultResourceMeasurementContract contract = new CrudeDefaultResourceMeasurementServiceClient().FetchByDefaultResourceMeasurementId(defaultResourceMeasurementId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultResourceMeasurementEdit([Bind()] CrudeDefaultResourceMeasurementContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultResourceMeasurementServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultResourceMeasurementIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultResourceMeasurementContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultResourceMeasurementCreate([Bind()] CrudeDefaultResourceMeasurementContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultResourceMeasurementServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultResourceMeasurementIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementDelete(
            System.Guid defaultResourceMeasurementId
            ) {
            new CrudeDefaultResourceMeasurementServiceClient().Delete(defaultResourceMeasurementId);

            return RedirectToAction("CrudeDefaultResourceMeasurementIndex");
        }
    }
}
