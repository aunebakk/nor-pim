/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:34:43 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductGatherSourceController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherSourceIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceIndex.cshtml",
                new CrudeProductGatherSourceServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceDetails(System.Guid productGatherSourceId) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceDetails.cshtml",
                new CrudeProductGatherSourceServiceClient().FetchByProductGatherSourceId(productGatherSourceId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceEdit(
            System.Guid productGatherSourceId
            ) {

            CrudeProductGatherSourceContract contract = new CrudeProductGatherSourceServiceClient().FetchByProductGatherSourceId(productGatherSourceId);
            ViewBag.ProductGatherSourceTypeRcd =
                new SelectList( new CrudeProductGatherSourceTypeRefServiceClient().FetchAll(),
                                "ProductGatherSourceTypeRcd",
                                "ProductGatherSourceTypeName",
                                contract.ProductGatherSourceTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceEdit([Bind()] CrudeProductGatherSourceContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherSourceServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherSourceIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceCreate(System.Guid? productGatherId, System.Guid? userId) {
            var contract = new CrudeProductGatherSourceContract();
            if (productGatherId != null) contract.ProductGatherId = (System.Guid) productGatherId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductGatherSourceTypeRcd =
                new SelectList( new CrudeProductGatherSourceTypeRefServiceClient().FetchAll(),
                                "ProductGatherSourceTypeRcd",
                                "ProductGatherSourceTypeName",
                                contract.ProductGatherSourceTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceCreate([Bind()] CrudeProductGatherSourceContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherSourceServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherSourceIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSource/CrudeProductGatherSourceCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceDelete(
            System.Guid productGatherSourceId
            ) {
            new CrudeProductGatherSourceServiceClient().Delete(productGatherSourceId);

            return RedirectToAction("CrudeProductGatherSourceIndex");
        }
    }
}
