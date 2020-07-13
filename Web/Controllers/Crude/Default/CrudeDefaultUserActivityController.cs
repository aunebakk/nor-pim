/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:55:41 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultUserActivityController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityIndex.cshtml",
                new CrudeDefaultUserActivityServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityDetails(System.Guid defaultUserActivityId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivity/CrudeDefaultUserActivityDetails.cshtml",
                new CrudeDefaultUserActivityServiceClient().FetchByDefaultUserActivityId(defaultUserActivityId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultUserActivityDelete(
            System.Guid defaultUserActivityId
            ) {
            new CrudeDefaultUserActivityServiceClient().Delete(defaultUserActivityId);

            return RedirectToAction("CrudeDefaultUserActivityIndex");
        }
    }
}
