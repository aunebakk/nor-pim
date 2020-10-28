/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 10:09:35 PM
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
    public class CrudeClientContactMethodRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientContactMethodRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefIndex.cshtml",
                new CrudeClientContactMethodRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientContactMethodRefDetails(System.String clientContactMethodRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefDetails.cshtml",
                new CrudeClientContactMethodRefServiceClient().FetchByClientContactMethodRcd(clientContactMethodRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientContactMethodRefEdit(
            System.String clientContactMethodRcd
            ) {

            CrudeClientContactMethodRefContract contract = new CrudeClientContactMethodRefServiceClient().FetchByClientContactMethodRcd(clientContactMethodRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodRefEdit([Bind()] CrudeClientContactMethodRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientContactMethodRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientContactMethodRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientContactMethodRefCreate(System.Guid? userId) {
            var contract = new CrudeClientContactMethodRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodRefCreate([Bind()] CrudeClientContactMethodRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientContactMethodRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientContactMethodRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientContactMethodRefDelete(
            System.String clientContactMethodRcd
            ) {
            new CrudeClientContactMethodRefServiceClient().Delete(clientContactMethodRcd);

            return RedirectToAction("CrudeClientContactMethodRefIndex");
        }
    }
}
