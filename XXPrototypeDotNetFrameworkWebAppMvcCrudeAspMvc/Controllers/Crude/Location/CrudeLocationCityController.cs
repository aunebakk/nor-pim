/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:30:22 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeLocationCityController : Controller {

        [HttpGet]
        public ActionResult CrudeLocationCityIndex() {

            return View(
                "~/Views/Crude/Location/CrudeLocationCity/CrudeLocationCityIndex.cshtml",
                new CrudeLocationCityServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCityByLocationCountryIndex(System.Guid locationCountryId) {
            ViewBag.LocationCountryId = locationCountryId;

            return View(
                "~/Views/Crude/Location/CrudeLocationCity/CrudeLocationCityIndex.cshtml",
                new CrudeLocationCityServiceClient().FetchByLocationCountryId(locationCountryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCityDetails(System.Guid locationCityId) {

            return View(
                "~/Views/Crude/Location/CrudeLocationCity/CrudeLocationCityDetails.cshtml",
                new CrudeLocationCityServiceClient().FetchByLocationCityId(locationCityId)
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCityEdit(
            System.Guid locationCityId
            ) {

            CrudeLocationCityContract contract = new CrudeLocationCityServiceClient().FetchByLocationCityId(locationCityId);
            ViewBag.LocationCountryId =
                new SelectList( new CrudeLocationCountryServiceClient().FetchAll(),
                                "LocationCountryId",
                                "LocationCountryName",
                                contract.LocationCountryId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Location/CrudeLocationCity/CrudeLocationCityEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationCityEdit([Bind()] CrudeLocationCityContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeLocationCityServiceClient().Update(contract);

                return RedirectToAction("CrudeLocationCityIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationCity/CrudeLocationCityEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCityCreate(System.Guid? locationCountryId, System.Guid? userId) {
            var contract = new CrudeLocationCityContract();
            if (locationCountryId != null) contract.LocationCountryId = (System.Guid) locationCountryId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.LocationCountryId =
                new SelectList( new CrudeLocationCountryServiceClient().FetchAll(),
                                "LocationCountryId",
                                "LocationCountryName",
                                contract.LocationCountryId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Location/CrudeLocationCity/CrudeLocationCityCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationCityCreate([Bind()] CrudeLocationCityContract contract) {
            if (ModelState.IsValid) {

                new CrudeLocationCityServiceClient().Insert(contract);

                return RedirectToAction("CrudeLocationCityIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationCity/CrudeLocationCityCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationCityDelete(
            System.Guid locationCityId
            ) {
            new CrudeLocationCityServiceClient().Delete(locationCityId);

            return RedirectToAction("CrudeLocationCityIndex");
        }
    }
}
