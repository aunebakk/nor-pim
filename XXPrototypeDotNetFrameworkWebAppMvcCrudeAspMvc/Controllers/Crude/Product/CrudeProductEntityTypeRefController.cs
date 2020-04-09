/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:24:54 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductEntityTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefIndex.cshtml",
                new CrudeProductEntityTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefDetails(System.String productEntityTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefDetails.cshtml",
                new CrudeProductEntityTypeRefServiceClient().FetchByProductEntityTypeRcd(productEntityTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefEdit(
            System.String productEntityTypeRcd
            ) {

            CrudeProductEntityTypeRefContract contract = new CrudeProductEntityTypeRefServiceClient().FetchByProductEntityTypeRcd(productEntityTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductEntityTypeRefEdit([Bind()] CrudeProductEntityTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductEntityTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductEntityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductEntityTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductEntityTypeRefCreate([Bind()] CrudeProductEntityTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductEntityTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductEntityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefDelete(
            System.String productEntityTypeRcd
            ) {
            new CrudeProductEntityTypeRefServiceClient().Delete(productEntityTypeRcd);

            return RedirectToAction("CrudeProductEntityTypeRefIndex");
        }
    }
}
