/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 12:54:16 PM
  From Machine: DESKTOP-9A2DH39
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
    public class CrudeProductSupplierController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductSupplierIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductSupplier/CrudeProductSupplierIndex.cshtml",
                new CrudeProductSupplierServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductSupplierByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductSupplier/CrudeProductSupplierIndex.cshtml",
                new CrudeProductSupplierServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductSupplierDetails(System.Guid productSupplierId) {

            return View(
                "~/Views/Crude/Product/CrudeProductSupplier/CrudeProductSupplierDetails.cshtml",
                new CrudeProductSupplierServiceClient().FetchByProductSupplierId(productSupplierId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductSupplierEdit(
            System.Guid productSupplierId
            ) {

            CrudeProductSupplierContract contract = new CrudeProductSupplierServiceClient().FetchByProductSupplierId(productSupplierId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductSupplier/CrudeProductSupplierEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductSupplierEdit([Bind()] CrudeProductSupplierContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductSupplierServiceClient().Update(contract);

                return RedirectToAction("CrudeProductSupplierIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductSupplier/CrudeProductSupplierEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductSupplierCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductSupplierContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
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
                "~/Views/Crude/Product/CrudeProductSupplier/CrudeProductSupplierCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductSupplierCreate([Bind()] CrudeProductSupplierContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductSupplierServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductSupplierIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductSupplier/CrudeProductSupplierCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductSupplierDelete(
            System.Guid productSupplierId
            ) {
            new CrudeProductSupplierServiceClient().Delete(productSupplierId);

            return RedirectToAction("CrudeProductSupplierIndex");
        }
    }
}
