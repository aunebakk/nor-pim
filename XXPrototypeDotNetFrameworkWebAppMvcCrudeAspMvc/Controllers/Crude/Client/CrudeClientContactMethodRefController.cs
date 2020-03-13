/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:43:05 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientContactMethodRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientContactMethodRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefIndex.cshtml",
                new CrudeClientContactMethodRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientContactMethodRefDetails(System.String clientContactMethodRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefDetails.cshtml",
                new CrudeClientContactMethodRefServiceClient().FetchByClientContactMethodRcd(clientContactMethodRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientContactMethodRefEdit(
            System.String clientContactMethodRcd
            ) {

            CrudeClientContactMethodRefContract contract = new CrudeClientContactMethodRefServiceClient().FetchByClientContactMethodRcd(clientContactMethodRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodRefEdit([Bind()] CrudeClientContactMethodRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientContactMethodRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientContactMethodRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientContactMethodRefCreate(System.Guid? userId) {
            var contract = new CrudeClientContactMethodRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodRefCreate([Bind()] CrudeClientContactMethodRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientContactMethodRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientContactMethodRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethodRef/CrudeClientContactMethodRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientContactMethodRefDelete(
            System.String clientContactMethodRcd
            ) {
            new CrudeClientContactMethodRefServiceClient().Delete(clientContactMethodRcd);

            return RedirectToAction("CrudeClientContactMethodRefIndex");
        }
    }
}
