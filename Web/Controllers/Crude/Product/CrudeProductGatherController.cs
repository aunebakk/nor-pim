/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 9:52:33 PM
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
    public class CrudeProductGatherController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductGatherIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherIndex.cshtml",
                new CrudeProductGatherServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductGatherDetails(System.Guid productGatherId) {

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherDetails.cshtml",
                new CrudeProductGatherServiceClient().FetchByProductGatherId(productGatherId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductGatherEdit(
            System.Guid productGatherId
            ) {

            CrudeProductGatherContract contract = new CrudeProductGatherServiceClient().FetchByProductGatherId(productGatherId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherEdit([Bind()] CrudeProductGatherContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductGatherCreate(System.Guid? userId) {
            var contract = new CrudeProductGatherContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.StartDateTime = DateTime.UtcNow;

            contract.FinishDateTime = DateTime.UtcNow;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherCreate([Bind()] CrudeProductGatherContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductGatherDelete(
            System.Guid productGatherId
            ) {
            new CrudeProductGatherServiceClient().Delete(productGatherId);

            return RedirectToAction("CrudeProductGatherIndex");
        }
    }
}
