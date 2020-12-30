/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:05:17 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  MVC ( Model View Controller): https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
    //  REST ( REpresentational State Transfer ): https://en.wikipedia.org/wiki/REST
    //  JSON ( JavaScript Object Notation ): https://en.wikipedia.org/wiki/JSON
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeDefaultTestController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeDefaultTestIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestIndex.cshtml",
                new CrudeDefaultTestServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeDefaultTestDetails(System.Guid defaultTestId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestDetails.cshtml",
                new CrudeDefaultTestServiceClient().FetchByDefaultTestId(defaultTestId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeDefaultTestEdit(
            System.Guid defaultTestId
            ) {

            CrudeDefaultTestContract contract = new CrudeDefaultTestServiceClient().FetchByDefaultTestId(defaultTestId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestEdit([Bind()] CrudeDefaultTestContract contract) {
            if (ModelState.IsValid) {
                new CrudeDefaultTestServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultTestIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeDefaultTestCreate(System.Guid? userId) {
            var contract = new CrudeDefaultTestContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestCreate([Bind()] CrudeDefaultTestContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultTestServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultTestIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeDefaultTestDelete(
            System.Guid defaultTestId
            ) {
            new CrudeDefaultTestServiceClient().Delete(defaultTestId);

            return RedirectToAction("CrudeDefaultTestIndex");
        }
    }
}
