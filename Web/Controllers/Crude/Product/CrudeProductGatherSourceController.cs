/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:46:12 PM
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
    public class CrudeProductGatherSourceController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductGatherSourceIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceIndex.cshtml",
                new CrudeProductGatherSourceServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductGatherSourceDetails(System.Guid productGatherSourceId) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceDetails.cshtml",
                new CrudeProductGatherSourceServiceClient().FetchByProductGatherSourceId(productGatherSourceId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductGatherSourceEdit(
            System.Guid productGatherSourceId
            ) {

            CrudeProductGatherSourceContract contract = new CrudeProductGatherSourceServiceClient().FetchByProductGatherSourceId(productGatherSourceId);
            ViewBag.ProductGatherSourceTypeRcd =
                new SelectList( new CrudeProductGatherSourceTypeRefServiceClient().FetchAll(),
                                "ProductGatherSourceTypeRcd",
                                "ProductGatherSourceTypeName",
                                contract.ProductGatherSourceTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceEdit([Bind()] CrudeProductGatherSourceContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherSourceServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherSourceIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductGatherSourceCreate(System.Guid? productGatherId, System.Guid? userId) {
            var contract = new CrudeProductGatherSourceContract();
            if (productGatherId != null) contract.ProductGatherId = (System.Guid) productGatherId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductGatherSourceTypeRcd =
                new SelectList( new CrudeProductGatherSourceTypeRefServiceClient().FetchAll(),
                                "ProductGatherSourceTypeRcd",
                                "ProductGatherSourceTypeName",
                                contract.ProductGatherSourceTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceCreate([Bind()] CrudeProductGatherSourceContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherSourceServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherSourceIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductGatherSourceDelete(
            System.Guid productGatherSourceId
            ) {
            new CrudeProductGatherSourceServiceClient().Delete(productGatherSourceId);

            return RedirectToAction("CrudeProductGatherSourceIndex");
        }
    }
}
