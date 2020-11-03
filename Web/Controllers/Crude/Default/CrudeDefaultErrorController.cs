/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 1:26:10 PM
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
    public class CrudeDefaultErrorController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultErrorIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorIndex.cshtml",
                new CrudeDefaultErrorServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultErrorDetails(System.Guid defaultErrorId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorDetails.cshtml",
                new CrudeDefaultErrorServiceClient().FetchByDefaultErrorId(defaultErrorId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultErrorEdit(
            System.Guid defaultErrorId
            ) {

            CrudeDefaultErrorContract contract = new CrudeDefaultErrorServiceClient().FetchByDefaultErrorId(defaultErrorId);
            ViewBag.DefaultErrorLayerRcd =
                new SelectList( new CrudeDefaultErrorLayerRefServiceClient().FetchAll(),
                                "DefaultErrorLayerRcd",
                                "DefaultErrorLayerName",
                                contract.DefaultErrorLayerRcd
                                );

            ViewBag.DefaultErrorTypeRcd =
                new SelectList( new CrudeDefaultErrorTypeRefServiceClient().FetchAll(),
                                "DefaultErrorTypeRcd",
                                "DefaultErrorTypeName",
                                contract.DefaultErrorTypeRcd
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorEdit([Bind()] CrudeDefaultErrorContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultErrorServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultErrorIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultErrorCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultErrorContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            ViewBag.DefaultErrorLayerRcd =
                new SelectList( new CrudeDefaultErrorLayerRefServiceClient().FetchAll(),
                                "DefaultErrorLayerRcd",
                                "DefaultErrorLayerName",
                                contract.DefaultErrorLayerRcd
                                );

            ViewBag.DefaultErrorTypeRcd =
                new SelectList( new CrudeDefaultErrorTypeRefServiceClient().FetchAll(),
                                "DefaultErrorTypeRcd",
                                "DefaultErrorTypeName",
                                contract.DefaultErrorTypeRcd
                                );

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorCreate([Bind()] CrudeDefaultErrorContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultErrorServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultErrorIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultErrorDelete(
            System.Guid defaultErrorId
            ) {
            new CrudeDefaultErrorServiceClient().Delete(defaultErrorId);

            return RedirectToAction("CrudeDefaultErrorIndex");
        }
    }
}
