/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:04:12 PM
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
    public class CrudeClientAddressTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefIndex.cshtml",
                new CrudeClientAddressTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefDetails(System.String clientAddressTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefDetails.cshtml",
                new CrudeClientAddressTypeRefServiceClient().FetchByClientAddressTypeRcd(clientAddressTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefEdit(
            System.String clientAddressTypeRcd
            ) {

            CrudeClientAddressTypeRefContract contract = new CrudeClientAddressTypeRefServiceClient().FetchByClientAddressTypeRcd(clientAddressTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientAddressTypeRefEdit([Bind()] CrudeClientAddressTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientAddressTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientAddressTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientAddressTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientAddressTypeRefCreate([Bind()] CrudeClientAddressTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientAddressTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientAddressTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefDelete(
            System.String clientAddressTypeRcd
            ) {
            new CrudeClientAddressTypeRefServiceClient().Delete(clientAddressTypeRcd);

            return RedirectToAction("CrudeClientAddressTypeRefIndex");
        }
    }
}
