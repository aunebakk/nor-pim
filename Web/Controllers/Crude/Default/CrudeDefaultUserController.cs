/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:07:03 AM
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
    public class CrudeDefaultUserController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultUserIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserIndex.cshtml",
                new CrudeDefaultUserServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeDefaultUserByCreatedByDefaultUserIndex(System.Guid createdByDefaultUserId) {
            ViewBag.CreatedByDefaultUserId = createdByDefaultUserId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserIndex.cshtml",
                new CrudeDefaultUserServiceClient().FetchByCreatedByDefaultUserId(createdByDefaultUserId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultUserDetails(System.Guid defaultUserId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserDetails.cshtml",
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(defaultUserId)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultUserDelete(
            System.Guid defaultUserId
            ) {
            new CrudeDefaultUserServiceClient().Delete(defaultUserId);

            return RedirectToAction("CrudeDefaultUserIndex");
        }
    }
}
