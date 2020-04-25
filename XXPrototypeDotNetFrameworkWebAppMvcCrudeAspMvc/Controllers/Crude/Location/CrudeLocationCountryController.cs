/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:24:19 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeLocationCountryController : Controller {

        [HttpGet]
        public ActionResult CrudeLocationCountryIndex() {

            return View(
                "~/Views/Crude/Location/CrudeLocationCountry/CrudeLocationCountryIndex.cshtml",
                new CrudeLocationCountryServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCountryDetails(System.Guid locationCountryId) {

            return View(
                "~/Views/Crude/Location/CrudeLocationCountry/CrudeLocationCountryDetails.cshtml",
                new CrudeLocationCountryServiceClient().FetchByLocationCountryId(locationCountryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCountryEdit(
            System.Guid locationCountryId
            ) {

            CrudeLocationCountryContract contract = new CrudeLocationCountryServiceClient().FetchByLocationCountryId(locationCountryId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Location/CrudeLocationCountry/CrudeLocationCountryEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationCountryEdit([Bind()] CrudeLocationCountryContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeLocationCountryServiceClient().Update(contract);

                return RedirectToAction("CrudeLocationCountryIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationCountry/CrudeLocationCountryEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCountryCreate(System.Guid? userId) {
            var contract = new CrudeLocationCountryContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Location/CrudeLocationCountry/CrudeLocationCountryCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationCountryCreate([Bind()] CrudeLocationCountryContract contract) {
            if (ModelState.IsValid) {

                new CrudeLocationCountryServiceClient().Insert(contract);

                return RedirectToAction("CrudeLocationCountryIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationCountry/CrudeLocationCountryCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCountryDelete(
            System.Guid locationCountryId
            ) {
            new CrudeLocationCountryServiceClient().Delete(locationCountryId);

            return RedirectToAction("CrudeLocationCountryIndex");
        }
    }
}
