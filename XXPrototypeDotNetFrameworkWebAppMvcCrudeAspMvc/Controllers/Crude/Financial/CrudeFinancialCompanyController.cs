/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:45:26 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialCompanyController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialCompanyIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCompany/CrudeFinancialCompanyIndex.cshtml",
                new CrudeFinancialCompanyServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCompanyDetails(System.Guid financialCompanyId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCompany/CrudeFinancialCompanyDetails.cshtml",
                new CrudeFinancialCompanyServiceClient().FetchByFinancialCompanyId(financialCompanyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCompanyEdit(
            System.Guid financialCompanyId
            ) {

            CrudeFinancialCompanyContract contract = new CrudeFinancialCompanyServiceClient().FetchByFinancialCompanyId(financialCompanyId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCompany/CrudeFinancialCompanyEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCompanyEdit([Bind()] CrudeFinancialCompanyContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCompanyServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCompanyIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCompany/CrudeFinancialCompanyEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCompanyCreate(System.Guid? userId) {
            var contract = new CrudeFinancialCompanyContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCompany/CrudeFinancialCompanyCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCompanyCreate([Bind()] CrudeFinancialCompanyContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCompanyServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCompanyIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCompany/CrudeFinancialCompanyCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCompanyDelete(
            System.Guid financialCompanyId
            ) {
            new CrudeFinancialCompanyServiceClient().Delete(financialCompanyId);

            return RedirectToAction("CrudeFinancialCompanyIndex");
        }
    }
}
