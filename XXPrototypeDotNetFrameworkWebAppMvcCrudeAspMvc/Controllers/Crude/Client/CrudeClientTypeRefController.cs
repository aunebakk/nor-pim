/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:41:56 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefIndex.cshtml",
                new CrudeClientTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTypeRefDetails(System.String clientTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefDetails.cshtml",
                new CrudeClientTypeRefServiceClient().FetchByClientTypeRcd(clientTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTypeRefEdit(
            System.String clientTypeRcd
            ) {

            CrudeClientTypeRefContract contract = new CrudeClientTypeRefServiceClient().FetchByClientTypeRcd(clientTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTypeRefEdit([Bind()] CrudeClientTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTypeRefCreate([Bind()] CrudeClientTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTypeRefDelete(
            System.String clientTypeRcd
            ) {
            new CrudeClientTypeRefServiceClient().Delete(clientTypeRcd);

            return RedirectToAction("CrudeClientTypeRefIndex");
        }
    }
}
