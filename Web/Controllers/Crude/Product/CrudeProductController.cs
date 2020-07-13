/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:50:35 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductController : Controller {

        [HttpGet]
        public ActionResult CrudeProductIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProduct/CrudeProductIndex.cshtml",
                new CrudeProductServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDetails(System.Guid productId) {

            return View(
                "~/Views/Crude/Product/CrudeProduct/CrudeProductDetails.cshtml",
                new CrudeProductServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductEdit(
            System.Guid productId
            ) {

            CrudeProductContract contract = new CrudeProductServiceClient().FetchByProductId(productId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProduct/CrudeProductEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductEdit([Bind()] CrudeProductContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductServiceClient().Update(contract);

                return RedirectToAction("CrudeProductIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProduct/CrudeProductEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCreate(System.Guid? productBecameId, System.Guid? userId) {
            var contract = new CrudeProductContract();
            if (productBecameId != null) contract.ProductBecameId = (System.Guid) productBecameId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProduct/CrudeProductCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCreate([Bind()] CrudeProductContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProduct/CrudeProductCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDelete(
            System.Guid productId
            ) {
            new CrudeProductServiceClient().Delete(productId);

            return RedirectToAction("CrudeProductIndex");
        }
    }
}
