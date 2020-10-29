/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:57:35 PM
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
    public class CrudeClientTitleRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientTitleRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefIndex.cshtml",
                new CrudeClientTitleRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientTitleRefDetails(System.String clientTitleRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefDetails.cshtml",
                new CrudeClientTitleRefServiceClient().FetchByClientTitleRcd(clientTitleRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientTitleRefEdit(
            System.String clientTitleRcd
            ) {

            CrudeClientTitleRefContract contract = new CrudeClientTitleRefServiceClient().FetchByClientTitleRcd(clientTitleRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTitleRefEdit([Bind()] CrudeClientTitleRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientTitleRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientTitleRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientTitleRefCreate(System.Guid? userId) {
            var contract = new CrudeClientTitleRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTitleRefCreate([Bind()] CrudeClientTitleRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientTitleRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientTitleRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientTitleRefDelete(
            System.String clientTitleRcd
            ) {
            new CrudeClientTitleRefServiceClient().Delete(clientTitleRcd);

            return RedirectToAction("CrudeClientTitleRefIndex");
        }
    }
}
