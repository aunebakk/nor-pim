/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:00:54 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductDocumentationTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefIndex.cshtml",
                new CrudeProductDocumentationTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefDetails(System.String productDocumentationTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefDetails.cshtml",
                new CrudeProductDocumentationTypeRefServiceClient().FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefEdit(
            System.String productDocumentationTypeRcd
            ) {

            CrudeProductDocumentationTypeRefContract contract = new CrudeProductDocumentationTypeRefServiceClient().FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationTypeRefEdit([Bind()] CrudeProductDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductDocumentationTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductDocumentationTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationTypeRefCreate([Bind()] CrudeProductDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductDocumentationTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefDelete(
            System.String productDocumentationTypeRcd
            ) {
            new CrudeProductDocumentationTypeRefServiceClient().Delete(productDocumentationTypeRcd);

            return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
        }
    }
}
