/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:40 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductGatherSourceTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefIndex.cshtml",
                new CrudeProductGatherSourceTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefDetails(System.String productGatherSourceTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefDetails.cshtml",
                new CrudeProductGatherSourceTypeRefServiceClient().FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefEdit(
            System.String productGatherSourceTypeRcd
            ) {

            CrudeProductGatherSourceTypeRefContract contract = new CrudeProductGatherSourceTypeRefServiceClient().FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceTypeRefEdit([Bind()] CrudeProductGatherSourceTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherSourceTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductGatherSourceTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceTypeRefCreate([Bind()] CrudeProductGatherSourceTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherSourceTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefDelete(
            System.String productGatherSourceTypeRcd
            ) {
            new CrudeProductGatherSourceTypeRefServiceClient().Delete(productGatherSourceTypeRcd);

            return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
        }
    }
}
