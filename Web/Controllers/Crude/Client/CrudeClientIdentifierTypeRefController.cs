/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 1:12:04 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientIdentifierTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefIndex.cshtml",
                new CrudeClientIdentifierTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefDetails(System.String clientIdentifierTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefDetails.cshtml",
                new CrudeClientIdentifierTypeRefServiceClient().FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefEdit(
            System.String clientIdentifierTypeRcd
            ) {

            CrudeClientIdentifierTypeRefContract contract = new CrudeClientIdentifierTypeRefServiceClient().FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientIdentifierTypeRefEdit([Bind()] CrudeClientIdentifierTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientIdentifierTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientIdentifierTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientIdentifierTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientIdentifierTypeRefCreate([Bind()] CrudeClientIdentifierTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientIdentifierTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientIdentifierTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefDelete(
            System.String clientIdentifierTypeRcd
            ) {
            new CrudeClientIdentifierTypeRefServiceClient().Delete(clientIdentifierTypeRcd);

            return RedirectToAction("CrudeClientIdentifierTypeRefIndex");
        }
    }
}
