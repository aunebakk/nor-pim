/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:46:24 PM
  From Machine: DESKTOP-742U247
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
    public class CrudeClientNationalityRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientNationalityRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefIndex.cshtml",
                new CrudeClientNationalityRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientNationalityRefDetails(System.String clientNationalityRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefDetails.cshtml",
                new CrudeClientNationalityRefServiceClient().FetchByClientNationalityRcd(clientNationalityRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientNationalityRefEdit(
            System.String clientNationalityRcd
            ) {

            CrudeClientNationalityRefContract contract = new CrudeClientNationalityRefServiceClient().FetchByClientNationalityRcd(clientNationalityRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientNationalityRefEdit([Bind()] CrudeClientNationalityRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientNationalityRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientNationalityRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientNationalityRefCreate(System.Guid? userId) {
            var contract = new CrudeClientNationalityRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientNationalityRefCreate([Bind()] CrudeClientNationalityRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientNationalityRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientNationalityRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientNationalityRefDelete(
            System.String clientNationalityRcd
            ) {
            new CrudeClientNationalityRefServiceClient().Delete(clientNationalityRcd);

            return RedirectToAction("CrudeClientNationalityRefIndex");
        }
    }
}
