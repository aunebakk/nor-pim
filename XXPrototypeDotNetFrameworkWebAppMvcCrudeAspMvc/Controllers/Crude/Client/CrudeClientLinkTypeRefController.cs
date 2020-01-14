/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:44:58 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientLinkTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefIndex.cshtml",
                new CrudeClientLinkTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefDetails(System.String clientLinkTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefDetails.cshtml",
                new CrudeClientLinkTypeRefServiceClient().FetchByClientLinkTypeRcd(clientLinkTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefEdit(
            System.String clientLinkTypeRcd
            ) {

            CrudeClientLinkTypeRefContract contract = new CrudeClientLinkTypeRefServiceClient().FetchByClientLinkTypeRcd(clientLinkTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientLinkTypeRefEdit([Bind()] CrudeClientLinkTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientLinkTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientLinkTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientLinkTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientLinkTypeRefCreate([Bind()] CrudeClientLinkTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientLinkTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientLinkTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientLinkTypeRefDelete(
            System.String clientLinkTypeRcd
            ) {
            new CrudeClientLinkTypeRefServiceClient().Delete(clientLinkTypeRcd);

            return RedirectToAction("CrudeClientLinkTypeRefIndex");
        }
    }
}
