/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:36:54 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductExposedSelectionController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionIndex.cshtml",
                new CrudeProductExposedSelectionServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionDetails(System.Guid productExposedSelectionId) {

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionDetails.cshtml",
                new CrudeProductExposedSelectionServiceClient().FetchByProductExposedSelectionId(productExposedSelectionId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionEdit(
            System.Guid productExposedSelectionId
            ) {

            CrudeProductExposedSelectionContract contract = new CrudeProductExposedSelectionServiceClient().FetchByProductExposedSelectionId(productExposedSelectionId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposedSelectionEdit([Bind()] CrudeProductExposedSelectionContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposedSelectionServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposedSelectionIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionCreate(System.Guid? productExposeId, System.Guid? userId) {
            var contract = new CrudeProductExposedSelectionContract();
            if (productExposeId != null) contract.ProductExposeId = (System.Guid) productExposeId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposedSelectionCreate([Bind()] CrudeProductExposedSelectionContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposedSelectionServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposedSelectionIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionDelete(
            System.Guid productExposedSelectionId
            ) {
            new CrudeProductExposedSelectionServiceClient().Delete(productExposedSelectionId);

            return RedirectToAction("CrudeProductExposedSelectionIndex");
        }
    }
}
