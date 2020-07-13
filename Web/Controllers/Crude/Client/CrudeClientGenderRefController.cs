/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:50:18 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientGenderRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientGenderRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefIndex.cshtml",
                new CrudeClientGenderRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientGenderRefDetails(System.String clientGenderRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefDetails.cshtml",
                new CrudeClientGenderRefServiceClient().FetchByClientGenderRcd(clientGenderRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientGenderRefEdit(
            System.String clientGenderRcd
            ) {

            CrudeClientGenderRefContract contract = new CrudeClientGenderRefServiceClient().FetchByClientGenderRcd(clientGenderRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientGenderRefEdit([Bind()] CrudeClientGenderRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientGenderRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientGenderRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientGenderRefCreate(System.Guid? userId) {
            var contract = new CrudeClientGenderRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientGenderRefCreate([Bind()] CrudeClientGenderRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientGenderRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientGenderRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientGenderRef/CrudeClientGenderRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientGenderRefDelete(
            System.String clientGenderRcd
            ) {
            new CrudeClientGenderRefServiceClient().Delete(clientGenderRcd);

            return RedirectToAction("CrudeClientGenderRefIndex");
        }
    }
}
