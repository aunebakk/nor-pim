/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:55:55 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductExposeController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposeIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeIndex.cshtml",
                new CrudeProductExposeServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeByExposeProductIndex(System.Guid exposeProductId) {
            ViewBag.ExposeProductId = exposeProductId;

            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeIndex.cshtml",
                new CrudeProductExposeServiceClient().FetchByExposeProductId(exposeProductId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeByExposeBasedOnProductIndex(System.Guid exposeBasedOnProductId) {
            ViewBag.ExposeBasedOnProductId = exposeBasedOnProductId;

            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeIndex.cshtml",
                new CrudeProductExposeServiceClient().FetchByExposeBasedOnProductId(exposeBasedOnProductId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeByProductExposeSetIndex(System.Guid productExposeSetId) {
            ViewBag.ProductExposeSetId = productExposeSetId;

            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeIndex.cshtml",
                new CrudeProductExposeServiceClient().FetchByProductExposeSetId(productExposeSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeDetails(System.Guid productExposeId) {

            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeDetails.cshtml",
                new CrudeProductExposeServiceClient().FetchByProductExposeId(productExposeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeEdit(
            System.Guid productExposeId
            ) {

            CrudeProductExposeContract contract = new CrudeProductExposeServiceClient().FetchByProductExposeId(productExposeId);
            ViewBag.ExposeProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ExposeProductId
                                );

            ViewBag.ExposeBasedOnProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ExposeBasedOnProductId
                                );

            ViewBag.ProductExposeSetId =
                new SelectList( new CrudeProductExposeSetServiceClient().FetchAll(),
                                "ProductExposeSetId",
                                "ProductExposeSetName",
                                contract.ProductExposeSetId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeEdit([Bind()] CrudeProductExposeContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposeServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposeIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeCreate(System.Guid? exposeProductId, System.Guid? exposeBasedOnProductId, System.Guid? productExposeSetId, System.Guid? userId) {
            var contract = new CrudeProductExposeContract();
            if (exposeProductId != null) contract.ExposeProductId = (System.Guid) exposeProductId;
            if (exposeBasedOnProductId != null) contract.ExposeBasedOnProductId = (System.Guid) exposeBasedOnProductId;
            if (productExposeSetId != null) contract.ProductExposeSetId = (System.Guid) productExposeSetId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ExposeProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ExposeProductId
                                );

            ViewBag.ExposeBasedOnProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ExposeBasedOnProductId
                                );

            ViewBag.ProductExposeSetId =
                new SelectList( new CrudeProductExposeSetServiceClient().FetchAll(),
                                "ProductExposeSetId",
                                "ProductExposeSetName",
                                contract.ProductExposeSetId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeCreate([Bind()] CrudeProductExposeContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposeServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposeIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExpose/CrudeProductExposeCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeDelete(
            System.Guid productExposeId
            ) {
            new CrudeProductExposeServiceClient().Delete(productExposeId);

            return RedirectToAction("CrudeProductExposeIndex");
        }
    }
}
