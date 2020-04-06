/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:30:31 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductAttributeUnitRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefIndex.cshtml",
                new CrudeProductAttributeUnitRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefDetails(System.String productAttributeUnitRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefDetails.cshtml",
                new CrudeProductAttributeUnitRefServiceClient().FetchByProductAttributeUnitRcd(productAttributeUnitRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefEdit(
            System.String productAttributeUnitRcd
            ) {

            CrudeProductAttributeUnitRefContract contract = new CrudeProductAttributeUnitRefServiceClient().FetchByProductAttributeUnitRcd(productAttributeUnitRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeUnitRefEdit([Bind()] CrudeProductAttributeUnitRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductAttributeUnitRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductAttributeUnitRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefCreate(System.Guid? userId) {
            var contract = new CrudeProductAttributeUnitRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeUnitRefCreate([Bind()] CrudeProductAttributeUnitRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductAttributeUnitRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductAttributeUnitRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefDelete(
            System.String productAttributeUnitRcd
            ) {
            new CrudeProductAttributeUnitRefServiceClient().Delete(productAttributeUnitRcd);

            return RedirectToAction("CrudeProductAttributeUnitRefIndex");
        }
    }
}
