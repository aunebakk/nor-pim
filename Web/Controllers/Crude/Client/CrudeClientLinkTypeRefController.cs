/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/3/2020 3:48:50 PM
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
    public class CrudeClientLinkTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefIndex.cshtml",
                new CrudeClientLinkTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefDetails(System.String clientLinkTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefDetails.cshtml",
                new CrudeClientLinkTypeRefServiceClient().FetchByClientLinkTypeRcd(clientLinkTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefEdit(
            System.String clientLinkTypeRcd
            ) {

            CrudeClientLinkTypeRefContract contract = new CrudeClientLinkTypeRefServiceClient().FetchByClientLinkTypeRcd(clientLinkTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientLinkTypeRefEdit([Bind()] CrudeClientLinkTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientLinkTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientLinkTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientLinkTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientLinkTypeRefCreate([Bind()] CrudeClientLinkTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientLinkTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientLinkTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefDelete(
            System.String clientLinkTypeRcd
            ) {
            new CrudeClientLinkTypeRefServiceClient().Delete(clientLinkTypeRcd);

            return RedirectToAction("CrudeClientLinkTypeRefIndex");
        }
    }
}
