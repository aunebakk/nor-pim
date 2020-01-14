/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:21:39 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductFieldSetController : Controller {

        [HttpGet]
        public ActionResult CrudeProductFieldSetIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetIndex.cshtml",
                new CrudeProductFieldSetServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetDetails(System.Guid productFieldSetId) {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetDetails.cshtml",
                new CrudeProductFieldSetServiceClient().FetchByProductFieldSetId(productFieldSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetEdit(
            System.Guid productFieldSetId
            ) {

            CrudeProductFieldSetContract contract = new CrudeProductFieldSetServiceClient().FetchByProductFieldSetId(productFieldSetId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetEdit([Bind()] CrudeProductFieldSetContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductFieldSetServiceClient().Update(contract);

                return RedirectToAction("CrudeProductFieldSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetCreate(System.Guid? userId) {
            var contract = new CrudeProductFieldSetContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetCreate([Bind()] CrudeProductFieldSetContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductFieldSetServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductFieldSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetDelete(
            System.Guid productFieldSetId
            ) {
            new CrudeProductFieldSetServiceClient().Delete(productFieldSetId);

            return RedirectToAction("CrudeProductFieldSetIndex");
        }
    }
}
