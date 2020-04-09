/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:37:13 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeLocationAddressController : Controller {

        [HttpGet]
        public ActionResult CrudeLocationAddressIndex() {

            return View(
                "~/Views/Crude/Location/CrudeLocationAddress/CrudeLocationAddressIndex.cshtml",
                new CrudeLocationAddressServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressByLocationCountryIndex(System.Guid locationCountryId) {
            ViewBag.LocationCountryId = locationCountryId;

            return View(
                "~/Views/Crude/Location/CrudeLocationAddress/CrudeLocationAddressIndex.cshtml",
                new CrudeLocationAddressServiceClient().FetchByLocationCountryId(locationCountryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressDetails(System.Guid locationAddressId) {

            return View(
                "~/Views/Crude/Location/CrudeLocationAddress/CrudeLocationAddressDetails.cshtml",
                new CrudeLocationAddressServiceClient().FetchByLocationAddressId(locationAddressId)
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressEdit(
            System.Guid locationAddressId
            ) {

            CrudeLocationAddressContract contract = new CrudeLocationAddressServiceClient().FetchByLocationAddressId(locationAddressId);
            ViewBag.LocationAddressTypeRcd =
                new SelectList( new CrudeLocationAddressTypeRefServiceClient().FetchAll(),
                                "LocationAddressTypeRcd",
                                "LocationAddressTypeName",
                                contract.LocationAddressTypeRcd
                                );

            ViewBag.LocationCountryId =
                new SelectList( new CrudeLocationCountryServiceClient().FetchAll(),
                                "LocationCountryId",
                                "LocationCountryName",
                                contract.LocationCountryId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Location/CrudeLocationAddress/CrudeLocationAddressEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationAddressEdit([Bind()] CrudeLocationAddressContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeLocationAddressServiceClient().Update(contract);

                return RedirectToAction("CrudeLocationAddressIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationAddress/CrudeLocationAddressEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressCreate(System.Guid? locationCountryId, System.Guid? userId) {
            var contract = new CrudeLocationAddressContract();
            if (locationCountryId != null) contract.LocationCountryId = (System.Guid) locationCountryId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.LocationAddressTypeRcd =
                new SelectList( new CrudeLocationAddressTypeRefServiceClient().FetchAll(),
                                "LocationAddressTypeRcd",
                                "LocationAddressTypeName",
                                contract.LocationAddressTypeRcd
                                );

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
                "~/Views/Crude/Location/CrudeLocationAddress/CrudeLocationAddressCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationAddressCreate([Bind()] CrudeLocationAddressContract contract) {
            if (ModelState.IsValid) {

                new CrudeLocationAddressServiceClient().Insert(contract);

                return RedirectToAction("CrudeLocationAddressIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationAddress/CrudeLocationAddressCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressDelete(
            System.Guid locationAddressId
            ) {
            new CrudeLocationAddressServiceClient().Delete(locationAddressId);

            return RedirectToAction("CrudeLocationAddressIndex");
        }
    }
}
