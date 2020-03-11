/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:34:53 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductInfoRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductInfoRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefIndex.cshtml",
                new CrudeProductInfoRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoRefDetails(System.String productInfoRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefDetails.cshtml",
                new CrudeProductInfoRefServiceClient().FetchByProductInfoRcd(productInfoRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoRefEdit(
            System.String productInfoRcd
            ) {

            CrudeProductInfoRefContract contract = new CrudeProductInfoRefServiceClient().FetchByProductInfoRcd(productInfoRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoRefEdit([Bind()] CrudeProductInfoRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductInfoRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductInfoRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoRefCreate(System.Guid? userId) {
            var contract = new CrudeProductInfoRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoRefCreate([Bind()] CrudeProductInfoRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductInfoRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductInfoRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoRefDelete(
            System.String productInfoRcd
            ) {
            new CrudeProductInfoRefServiceClient().Delete(productInfoRcd);

            return RedirectToAction("CrudeProductInfoRefIndex");
        }
    }
}
