/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:01:03 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductGatherAttributeController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttribute/CrudeProductGatherAttributeIndex.cshtml",
                new CrudeProductGatherAttributeServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeDetails(System.Guid productGatherAttributeId) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttribute/CrudeProductGatherAttributeDetails.cshtml",
                new CrudeProductGatherAttributeServiceClient().FetchByProductGatherAttributeId(productGatherAttributeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeEdit(
            System.Guid productGatherAttributeId
            ) {

            CrudeProductGatherAttributeContract contract = new CrudeProductGatherAttributeServiceClient().FetchByProductGatherAttributeId(productGatherAttributeId);
            ViewBag.ProductGatherAttributeTypeRcd =
                new SelectList( new CrudeProductGatherAttributeTypeRefServiceClient().FetchAll(),
                                "ProductGatherAttributeTypeRcd",
                                "ProductGatherAttributeTypeName",
                                contract.ProductGatherAttributeTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttribute/CrudeProductGatherAttributeEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeEdit([Bind()] CrudeProductGatherAttributeContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherAttributeServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherAttributeIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttribute/CrudeProductGatherAttributeEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeCreate(System.Guid? productGatherKeyId, System.Guid? userId) {
            var contract = new CrudeProductGatherAttributeContract();
            if (productGatherKeyId != null) contract.ProductGatherKeyId = (System.Guid) productGatherKeyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductGatherAttributeTypeRcd =
                new SelectList( new CrudeProductGatherAttributeTypeRefServiceClient().FetchAll(),
                                "ProductGatherAttributeTypeRcd",
                                "ProductGatherAttributeTypeName",
                                contract.ProductGatherAttributeTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttribute/CrudeProductGatherAttributeCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeCreate([Bind()] CrudeProductGatherAttributeContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherAttributeServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherAttributeIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttribute/CrudeProductGatherAttributeCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeDelete(
            System.Guid productGatherAttributeId
            ) {
            new CrudeProductGatherAttributeServiceClient().Delete(productGatherAttributeId);

            return RedirectToAction("CrudeProductGatherAttributeIndex");
        }
    }
}
