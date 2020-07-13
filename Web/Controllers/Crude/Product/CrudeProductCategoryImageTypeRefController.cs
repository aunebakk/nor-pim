/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:51:56 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductCategoryImageTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefIndex.cshtml",
                new CrudeProductCategoryImageTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefDetails(System.String productCategoryImageTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefDetails.cshtml",
                new CrudeProductCategoryImageTypeRefServiceClient().FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefEdit(
            System.String productCategoryImageTypeRcd
            ) {

            CrudeProductCategoryImageTypeRefContract contract = new CrudeProductCategoryImageTypeRefServiceClient().FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageTypeRefEdit([Bind()] CrudeProductCategoryImageTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryImageTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductCategoryImageTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageTypeRefCreate([Bind()] CrudeProductCategoryImageTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryImageTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefDelete(
            System.String productCategoryImageTypeRcd
            ) {
            new CrudeProductCategoryImageTypeRefServiceClient().Delete(productCategoryImageTypeRcd);

            return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
        }
    }
}
