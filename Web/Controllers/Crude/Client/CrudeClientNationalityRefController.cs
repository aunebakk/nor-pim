/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:37 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientNationalityRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientNationalityRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefIndex.cshtml",
                new CrudeClientNationalityRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientNationalityRefDetails(System.String clientNationalityRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefDetails.cshtml",
                new CrudeClientNationalityRefServiceClient().FetchByClientNationalityRcd(clientNationalityRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientNationalityRefEdit(
            System.String clientNationalityRcd
            ) {

            CrudeClientNationalityRefContract contract = new CrudeClientNationalityRefServiceClient().FetchByClientNationalityRcd(clientNationalityRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientNationalityRefEdit([Bind()] CrudeClientNationalityRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientNationalityRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientNationalityRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientNationalityRefCreate(System.Guid? userId) {
            var contract = new CrudeClientNationalityRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientNationalityRefCreate([Bind()] CrudeClientNationalityRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientNationalityRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientNationalityRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientNationalityRef/CrudeClientNationalityRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientNationalityRefDelete(
            System.String clientNationalityRcd
            ) {
            new CrudeClientNationalityRefServiceClient().Delete(clientNationalityRcd);

            return RedirectToAction("CrudeClientNationalityRefIndex");
        }
    }
}
