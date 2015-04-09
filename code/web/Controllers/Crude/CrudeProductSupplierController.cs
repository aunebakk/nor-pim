using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductSupplierController : Controller {

        [HttpGet]
        public ActionResult CrudeProductSupplierIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductSupplier", "CrudeProductSupplierIndex"),
                new CrudeProductSupplierService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductSupplierDetails(System.Guid productSupplierId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductSupplier", "CrudeProductSupplierDetails"),
                new CrudeProductSupplierService().FetchByProductSupplierId(productSupplierId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductSupplierEdit(System.Guid productSupplierId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductSupplier", "CrudeProductSupplierEdit"),
                new CrudeProductSupplierService().FetchByProductSupplierId(productSupplierId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductSupplierEdit([Bind()] CrudeProductSupplierContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductSupplierService().Update(contract);

                return RedirectToAction("CrudeProductSupplierIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductSupplier", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductSupplierCreate() {
            var contract = new CrudeProductSupplierContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductSupplier", "CrudeProductSupplierCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductSupplierCreate([Bind()] CrudeProductSupplierContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductSupplierService().Insert(contract);

                return RedirectToAction("CrudeProductSupplierIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductSupplier", "CrudeProductSupplierCreate"),
                contract
                );
        }
    }
}
