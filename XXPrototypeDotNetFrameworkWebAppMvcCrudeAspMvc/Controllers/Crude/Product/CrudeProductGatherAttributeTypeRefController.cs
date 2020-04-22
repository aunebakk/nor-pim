/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:56:01 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductGatherAttributeTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefIndex.cshtml",
                new CrudeProductGatherAttributeTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefDetails(System.String productGatherAttributeTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefDetails.cshtml",
                new CrudeProductGatherAttributeTypeRefServiceClient().FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefEdit(
            System.String productGatherAttributeTypeRcd
            ) {

            CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefServiceClient().FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeTypeRefEdit([Bind()] CrudeProductGatherAttributeTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherAttributeTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductGatherAttributeTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeTypeRefCreate([Bind()] CrudeProductGatherAttributeTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherAttributeTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefDelete(
            System.String productGatherAttributeTypeRcd
            ) {
            new CrudeProductGatherAttributeTypeRefServiceClient().Delete(productGatherAttributeTypeRcd);

            return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
        }
    }
}
