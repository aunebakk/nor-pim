/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:17:55 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductExposeSetController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposeSetIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetIndex.cshtml",
                new CrudeProductExposeSetServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetDetails(System.Guid productExposeSetId) {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetDetails.cshtml",
                new CrudeProductExposeSetServiceClient().FetchByProductExposeSetId(productExposeSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetEdit(
            System.Guid productExposeSetId
            ) {

            CrudeProductExposeSetContract contract = new CrudeProductExposeSetServiceClient().FetchByProductExposeSetId(productExposeSetId);
            ViewBag.ProductExposeSetTypeRcd =
                new SelectList( new CrudeProductExposeSetTypeRefServiceClient().FetchAll(),
                                "ProductExposeSetTypeRcd",
                                "ProductExposeSetTypeName",
                                contract.ProductExposeSetTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetEdit([Bind()] CrudeProductExposeSetContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposeSetServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetCreate(System.Guid? userId) {
            var contract = new CrudeProductExposeSetContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductExposeSetTypeRcd =
                new SelectList( new CrudeProductExposeSetTypeRefServiceClient().FetchAll(),
                                "ProductExposeSetTypeRcd",
                                "ProductExposeSetTypeName",
                                contract.ProductExposeSetTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetCreate([Bind()] CrudeProductExposeSetContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposeSetServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetDelete(
            System.Guid productExposeSetId
            ) {
            new CrudeProductExposeSetServiceClient().Delete(productExposeSetId);

            return RedirectToAction("CrudeProductExposeSetIndex");
        }
    }
}
