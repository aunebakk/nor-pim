/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:50 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientAddressTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefIndex.cshtml",
                new CrudeClientAddressTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefDetails(System.String clientAddressTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefDetails.cshtml",
                new CrudeClientAddressTypeRefServiceClient().FetchByClientAddressTypeRcd(clientAddressTypeRcd)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeClientAddressTypeRefDelete(
            System.String clientAddressTypeRcd
            ) {
            new CrudeClientAddressTypeRefServiceClient().Delete(clientAddressTypeRcd);

            return RedirectToAction("CrudeClientAddressTypeRefIndex");
        }
    }
}
