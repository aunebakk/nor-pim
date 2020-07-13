/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:54:30 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultTestController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultTestIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestIndex.cshtml",
                new CrudeDefaultTestServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestDetails(System.Guid defaultTestId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestDetails.cshtml",
                new CrudeDefaultTestServiceClient().FetchByDefaultTestId(defaultTestId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestEdit(
            System.Guid defaultTestId
            ) {

            CrudeDefaultTestContract contract = new CrudeDefaultTestServiceClient().FetchByDefaultTestId(defaultTestId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestEdit([Bind()] CrudeDefaultTestContract contract) {
            if (ModelState.IsValid) {
                new CrudeDefaultTestServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultTestIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestCreate(System.Guid? userId) {
            var contract = new CrudeDefaultTestContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestCreate([Bind()] CrudeDefaultTestContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultTestServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultTestIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestDelete(
            System.Guid defaultTestId
            ) {
            new CrudeDefaultTestServiceClient().Delete(defaultTestId);

            return RedirectToAction("CrudeDefaultTestIndex");
        }
    }
}
