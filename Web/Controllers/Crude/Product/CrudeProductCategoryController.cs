/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:17:41 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductCategoryController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategory/CrudeProductCategoryIndex.cshtml",
                new CrudeProductCategoryServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDetails(System.Guid productCategoryId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategory/CrudeProductCategoryDetails.cshtml",
                new CrudeProductCategoryServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryEdit(
            System.Guid productCategoryId
            ) {

            CrudeProductCategoryContract contract = new CrudeProductCategoryServiceClient().FetchByProductCategoryId(productCategoryId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategory/CrudeProductCategoryEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryEdit([Bind()] CrudeProductCategoryContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategory/CrudeProductCategoryEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryCreate(System.Guid? productCategoryBecameId, System.Guid? productCategoryParentId, System.Guid? userId) {
            var contract = new CrudeProductCategoryContract();
            if (productCategoryBecameId != null) contract.ProductCategoryBecameId = (System.Guid) productCategoryBecameId;
            if (productCategoryParentId != null) contract.ProductCategoryParentId = (System.Guid) productCategoryParentId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategory/CrudeProductCategoryCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryCreate([Bind()] CrudeProductCategoryContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategory/CrudeProductCategoryCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDelete(
            System.Guid productCategoryId
            ) {
            new CrudeProductCategoryServiceClient().Delete(productCategoryId);

            return RedirectToAction("CrudeProductCategoryIndex");
        }
    }
}
