/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 1:12:39 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductExposeSetTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefIndex.cshtml",
                new CrudeProductExposeSetTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefDetails(System.String productExposeSetTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefDetails.cshtml",
                new CrudeProductExposeSetTypeRefServiceClient().FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefEdit(
            System.String productExposeSetTypeRcd
            ) {

            CrudeProductExposeSetTypeRefContract contract = new CrudeProductExposeSetTypeRefServiceClient().FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetTypeRefEdit([Bind()] CrudeProductExposeSetTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposeSetTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductExposeSetTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetTypeRefCreate([Bind()] CrudeProductExposeSetTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposeSetTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefDelete(
            System.String productExposeSetTypeRcd
            ) {
            new CrudeProductExposeSetTypeRefServiceClient().Delete(productExposeSetTypeRcd);

            return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
        }
    }
}
