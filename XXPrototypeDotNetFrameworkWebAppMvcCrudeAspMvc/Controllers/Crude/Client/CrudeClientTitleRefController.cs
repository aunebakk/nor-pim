/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:20:35 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientTitleRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientTitleRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefIndex.cshtml",
                new CrudeClientTitleRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTitleRefDetails(System.String clientTitleRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefDetails.cshtml",
                new CrudeClientTitleRefServiceClient().FetchByClientTitleRcd(clientTitleRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTitleRefEdit(
            System.String clientTitleRcd
            ) {

            CrudeClientTitleRefContract contract = new CrudeClientTitleRefServiceClient().FetchByClientTitleRcd(clientTitleRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTitleRefEdit([Bind()] CrudeClientTitleRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientTitleRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientTitleRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTitleRefCreate(System.Guid? userId) {
            var contract = new CrudeClientTitleRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTitleRefCreate([Bind()] CrudeClientTitleRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientTitleRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientTitleRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTitleRef/CrudeClientTitleRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientTitleRefDelete(
            System.String clientTitleRcd
            ) {
            new CrudeClientTitleRefServiceClient().Delete(clientTitleRcd);

            return RedirectToAction("CrudeClientTitleRefIndex");
        }
    }
}
