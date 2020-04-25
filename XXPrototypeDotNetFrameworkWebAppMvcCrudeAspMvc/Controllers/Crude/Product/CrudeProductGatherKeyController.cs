/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:24:19 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductGatherKeyController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherKeyIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyIndex.cshtml",
                new CrudeProductGatherKeyServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherKeyDetails(System.Guid productGatherKeyId) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyDetails.cshtml",
                new CrudeProductGatherKeyServiceClient().FetchByProductGatherKeyId(productGatherKeyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherKeyEdit(
            System.Guid productGatherKeyId
            ) {

            CrudeProductGatherKeyContract contract = new CrudeProductGatherKeyServiceClient().FetchByProductGatherKeyId(productGatherKeyId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherKeyEdit([Bind()] CrudeProductGatherKeyContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherKeyServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherKeyIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherKeyCreate(System.Guid? productGatherId, System.Guid? userId) {
            var contract = new CrudeProductGatherKeyContract();
            if (productGatherId != null) contract.ProductGatherId = (System.Guid) productGatherId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherKeyCreate([Bind()] CrudeProductGatherKeyContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherKeyServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherKeyIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherKeyDelete(
            System.Guid productGatherKeyId
            ) {
            new CrudeProductGatherKeyServiceClient().Delete(productGatherKeyId);

            return RedirectToAction("CrudeProductGatherKeyIndex");
        }
    }
}
