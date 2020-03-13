/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:44:11 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductChangeSetController : Controller {

        [HttpGet]
        public ActionResult CrudeProductChangeSetIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetIndex.cshtml",
                new CrudeProductChangeSetServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetIndex.cshtml",
                new CrudeProductChangeSetServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetDetails(System.Guid productChangeSetId) {

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetDetails.cshtml",
                new CrudeProductChangeSetServiceClient().FetchByProductChangeSetId(productChangeSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetEdit(
            System.Guid productChangeSetId
            ) {

            CrudeProductChangeSetContract contract = new CrudeProductChangeSetServiceClient().FetchByProductChangeSetId(productChangeSetId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductChangeSetEdit([Bind()] CrudeProductChangeSetContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductChangeSetServiceClient().Update(contract);

                return RedirectToAction("CrudeProductChangeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetCreate(System.Guid? productId, System.Guid? productGatherKeyId, System.Guid? userId) {
            var contract = new CrudeProductChangeSetContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (productGatherKeyId != null) contract.ProductGatherKeyId = (System.Guid) productGatherKeyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductChangeSetCreate([Bind()] CrudeProductChangeSetContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductChangeSetServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductChangeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetDelete(
            System.Guid productChangeSetId
            ) {
            new CrudeProductChangeSetServiceClient().Delete(productChangeSetId);

            return RedirectToAction("CrudeProductChangeSetIndex");
        }
    }
}
