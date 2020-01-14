/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:44:51 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductCategoryDocumentationTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefIndex.cshtml",
                new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefDetails(System.String productCategoryDocumentationTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefDetails.cshtml",
                new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefEdit(
            System.String productCategoryDocumentationTypeRcd
            ) {

            CrudeProductCategoryDocumentationTypeRefContract contract = new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationTypeRefEdit([Bind()] CrudeProductCategoryDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryDocumentationTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationTypeRefCreate([Bind()] CrudeProductCategoryDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryDocumentationTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefDelete(
            System.String productCategoryDocumentationTypeRcd
            ) {
            new CrudeProductCategoryDocumentationTypeRefServiceClient().Delete(productCategoryDocumentationTypeRcd);

            return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
        }
    }
}
