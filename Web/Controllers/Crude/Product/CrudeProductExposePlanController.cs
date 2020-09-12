/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 9/12/2020 3:41:18 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // controller class for mvc
    public class CrudeProductExposePlanController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductExposePlanIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExposePlan/CrudeProductExposePlanIndex.cshtml",
                new CrudeProductExposePlanServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductExposePlanByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductExposePlan/CrudeProductExposePlanIndex.cshtml",
                new CrudeProductExposePlanServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductExposePlanDetails(System.Guid productExposePlanId) {

            return View(
                "~/Views/Crude/Product/CrudeProductExposePlan/CrudeProductExposePlanDetails.cshtml",
                new CrudeProductExposePlanServiceClient().FetchByProductExposePlanId(productExposePlanId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductExposePlanEdit(
            System.Guid productExposePlanId
            ) {

            CrudeProductExposePlanContract contract = new CrudeProductExposePlanServiceClient().FetchByProductExposePlanId(productExposePlanId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductExposeSetTypeRcd =
                new SelectList( new CrudeProductExposeSetTypeRefServiceClient().FetchAll(),
                                "ProductExposeSetTypeRcd",
                                "ProductExposeSetTypeName",
                                contract.ProductExposeSetTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductExposePlan/CrudeProductExposePlanEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposePlanEdit([Bind()] CrudeProductExposePlanContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposePlanServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposePlanIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposePlan/CrudeProductExposePlanEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductExposePlanCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductExposePlanContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

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
                "~/Views/Crude/Product/CrudeProductExposePlan/CrudeProductExposePlanCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposePlanCreate([Bind()] CrudeProductExposePlanContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposePlanServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposePlanIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposePlan/CrudeProductExposePlanCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductExposePlanDelete(
            System.Guid productExposePlanId
            ) {
            new CrudeProductExposePlanServiceClient().Delete(productExposePlanId);

            return RedirectToAction("CrudeProductExposePlanIndex");
        }
    }
}
