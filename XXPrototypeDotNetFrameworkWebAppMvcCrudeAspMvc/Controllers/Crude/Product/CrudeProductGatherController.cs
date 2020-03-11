/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:34:37 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductGatherController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherIndex.cshtml",
                new CrudeProductGatherServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherDetails(System.Guid productGatherId) {

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherDetails.cshtml",
                new CrudeProductGatherServiceClient().FetchByProductGatherId(productGatherId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherEdit(
            System.Guid productGatherId
            ) {

            CrudeProductGatherContract contract = new CrudeProductGatherServiceClient().FetchByProductGatherId(productGatherId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherEdit([Bind()] CrudeProductGatherContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherCreate(System.Guid? userId) {
            var contract = new CrudeProductGatherContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.StartDateTime = DateTime.UtcNow;

            contract.FinishDateTime = DateTime.UtcNow;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherCreate([Bind()] CrudeProductGatherContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGather/CrudeProductGatherCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherDelete(
            System.Guid productGatherId
            ) {
            new CrudeProductGatherServiceClient().Delete(productGatherId);

            return RedirectToAction("CrudeProductGatherIndex");
        }
    }
}
