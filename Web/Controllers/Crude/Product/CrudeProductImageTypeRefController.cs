/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 1:12:49 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductImageTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefIndex.cshtml",
                new CrudeProductImageTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefDetails(System.String productImageTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefDetails.cshtml",
                new CrudeProductImageTypeRefServiceClient().FetchByProductImageTypeRcd(productImageTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefEdit(
            System.String productImageTypeRcd
            ) {

            CrudeProductImageTypeRefContract contract = new CrudeProductImageTypeRefServiceClient().FetchByProductImageTypeRcd(productImageTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageTypeRefEdit([Bind()] CrudeProductImageTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductImageTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductImageTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageTypeRefCreate([Bind()] CrudeProductImageTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductImageTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefDelete(
            System.String productImageTypeRcd
            ) {
            new CrudeProductImageTypeRefServiceClient().Delete(productImageTypeRcd);

            return RedirectToAction("CrudeProductImageTypeRefIndex");
        }
    }
}
