/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:39:48 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductAttributeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductAttributeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefIndex.cshtml",
                new CrudeProductAttributeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeRefDetails(System.String productAttributeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefDetails.cshtml",
                new CrudeProductAttributeRefServiceClient().FetchByProductAttributeRcd(productAttributeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeRefEdit(
            System.String productAttributeRcd
            ) {

            CrudeProductAttributeRefContract contract = new CrudeProductAttributeRefServiceClient().FetchByProductAttributeRcd(productAttributeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeRefEdit([Bind()] CrudeProductAttributeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductAttributeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductAttributeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductAttributeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeRefCreate([Bind()] CrudeProductAttributeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductAttributeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductAttributeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeRefDelete(
            System.String productAttributeRcd
            ) {
            new CrudeProductAttributeRefServiceClient().Delete(productAttributeRcd);

            return RedirectToAction("CrudeProductAttributeRefIndex");
        }
    }
}
