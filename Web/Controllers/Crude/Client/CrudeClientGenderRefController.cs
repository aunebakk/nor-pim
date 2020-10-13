/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:40:40 PM
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
    public class CrudeClientGenderRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientGenderRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefIndex.cshtml",
                new CrudeClientGenderRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientGenderRefDetails(System.String clientGenderRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefDetails.cshtml",
                new CrudeClientGenderRefServiceClient().FetchByClientGenderRcd(clientGenderRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientGenderRefEdit(
            System.String clientGenderRcd
            ) {

            CrudeClientGenderRefContract contract = new CrudeClientGenderRefServiceClient().FetchByClientGenderRcd(clientGenderRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientGenderRefEdit([Bind()] CrudeClientGenderRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientGenderRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientGenderRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientGenderRefCreate(System.Guid? userId) {
            var contract = new CrudeClientGenderRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientGenderRefCreate([Bind()] CrudeClientGenderRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientGenderRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientGenderRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientGenderRefDelete(
            System.String clientGenderRcd
            ) {
            new CrudeClientGenderRefServiceClient().Delete(clientGenderRcd);

            return RedirectToAction("CrudeClientGenderRefIndex");
        }
    }
}
