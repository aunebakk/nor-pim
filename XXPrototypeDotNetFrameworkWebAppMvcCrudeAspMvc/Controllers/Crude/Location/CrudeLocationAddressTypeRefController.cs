/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:42:18 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeLocationAddressTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeLocationAddressTypeRefIndex() {

            return View(
                "~/Views/Crude/Location/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefIndex.cshtml",
                new CrudeLocationAddressTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressTypeRefDetails(System.String locationAddressTypeRcd) {

            return View(
                "~/Views/Crude/Location/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefDetails.cshtml",
                new CrudeLocationAddressTypeRefServiceClient().FetchByLocationAddressTypeRcd(locationAddressTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressTypeRefEdit(
            System.String locationAddressTypeRcd
            ) {

            CrudeLocationAddressTypeRefContract contract = new CrudeLocationAddressTypeRefServiceClient().FetchByLocationAddressTypeRcd(locationAddressTypeRcd);

            return View(
                "~/Views/Crude/Location/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationAddressTypeRefEdit([Bind()] CrudeLocationAddressTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeLocationAddressTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeLocationAddressTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeLocationAddressTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Location/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeLocationAddressTypeRefCreate([Bind()] CrudeLocationAddressTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeLocationAddressTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeLocationAddressTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Location/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeLocationAddressTypeRefDelete(
            System.String locationAddressTypeRcd
            ) {
            new CrudeLocationAddressTypeRefServiceClient().Delete(locationAddressTypeRcd);

            return RedirectToAction("CrudeLocationAddressTypeRefIndex");
        }
    }
}
