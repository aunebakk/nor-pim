/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:40 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientEventTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientEventTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefIndex.cshtml",
                new CrudeClientEventTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventTypeRefDetails(System.String clientEventTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefDetails.cshtml",
                new CrudeClientEventTypeRefServiceClient().FetchByClientEventTypeRcd(clientEventTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventTypeRefEdit(
            System.String clientEventTypeRcd
            ) {

            CrudeClientEventTypeRefContract contract = new CrudeClientEventTypeRefServiceClient().FetchByClientEventTypeRcd(clientEventTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEventTypeRefEdit([Bind()] CrudeClientEventTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientEventTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientEventTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientEventTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEventTypeRefCreate([Bind()] CrudeClientEventTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientEventTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientEventTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventTypeRefDelete(
            System.String clientEventTypeRcd
            ) {
            new CrudeClientEventTypeRefServiceClient().Delete(clientEventTypeRcd);

            return RedirectToAction("CrudeClientEventTypeRefIndex");
        }
    }
}
