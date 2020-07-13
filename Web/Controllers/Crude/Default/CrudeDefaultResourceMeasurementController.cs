/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:51:36 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultResourceMeasurementController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementIndex.cshtml",
                new CrudeDefaultResourceMeasurementServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementDetails(System.Guid defaultResourceMeasurementId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementDetails.cshtml",
                new CrudeDefaultResourceMeasurementServiceClient().FetchByDefaultResourceMeasurementId(defaultResourceMeasurementId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultResourceMeasurementDelete(
            System.Guid defaultResourceMeasurementId
            ) {
            new CrudeDefaultResourceMeasurementServiceClient().Delete(defaultResourceMeasurementId);

            return RedirectToAction("CrudeDefaultResourceMeasurementIndex");
        }
    }
}
