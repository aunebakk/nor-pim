/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:40 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultUserController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultUserIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserIndex.cshtml",
                new CrudeDefaultUserServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserByCreatedByDefaultUserIndex(System.Guid createdByDefaultUserId) {
            ViewBag.CreatedByDefaultUserId = createdByDefaultUserId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserIndex.cshtml",
                new CrudeDefaultUserServiceClient().FetchByCreatedByDefaultUserId(createdByDefaultUserId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserDetails(System.Guid defaultUserId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserDetails.cshtml",
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(defaultUserId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserEdit(
            System.Guid defaultUserId
            ) {

            CrudeDefaultUserContract contract = new CrudeDefaultUserServiceClient().FetchByDefaultUserId(defaultUserId);
            ViewBag.DefaultStateRcd =
                new SelectList( new CrudeDefaultStateRefServiceClient().FetchAll(),
                                "DefaultStateRcd",
                                "DefaultStateName",
                                contract.DefaultStateRcd
                                );

            ViewBag.CreatedByDefaultUserId =
                new SelectList( new CrudeDefaultUserServiceClient().FetchAll(),
                                "DefaultUserId",
                                "DefaultUserName",
                                contract.CreatedByDefaultUserId
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserEdit([Bind()] CrudeDefaultUserContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultUserServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultUserIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserCreate(System.Guid? createdByDefaultUserId) {
            var contract = new CrudeDefaultUserContract();
            if (createdByDefaultUserId != null) contract.CreatedByDefaultUserId = (System.Guid) createdByDefaultUserId;

            ViewBag.DefaultStateRcd =
                new SelectList( new CrudeDefaultStateRefServiceClient().FetchAll(),
                                "DefaultStateRcd",
                                "DefaultStateName",
                                contract.DefaultStateRcd
                                );

            ViewBag.CreatedByDefaultUserId =
                new SelectList( new CrudeDefaultUserServiceClient().FetchAll(),
                                "DefaultUserId",
                                "DefaultUserName",
                                contract.CreatedByDefaultUserId
                                );

            contract.DateTime = DateTime.UtcNow;

            contract.LastActivityDateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserCreate([Bind()] CrudeDefaultUserContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultUserServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultUserIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultUserDelete(
            System.Guid defaultUserId
            ) {
            new CrudeDefaultUserServiceClient().Delete(defaultUserId);

            return RedirectToAction("CrudeDefaultUserIndex");
        }
    }
}
