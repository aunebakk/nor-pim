/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:39:17 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialCostcentreController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialCostcentreIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCostcentre/CrudeFinancialCostcentreIndex.cshtml",
                new CrudeFinancialCostcentreServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCostcentreByFinancialCompanyIndex(System.Guid financialCompanyId) {
            ViewBag.FinancialCompanyId = financialCompanyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCostcentre/CrudeFinancialCostcentreIndex.cshtml",
                new CrudeFinancialCostcentreServiceClient().FetchByFinancialCompanyId(financialCompanyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCostcentreDetails(System.Guid financialCostcentreId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCostcentre/CrudeFinancialCostcentreDetails.cshtml",
                new CrudeFinancialCostcentreServiceClient().FetchByFinancialCostcentreId(financialCostcentreId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCostcentreEdit(
            System.Guid financialCostcentreId
            ) {

            CrudeFinancialCostcentreContract contract = new CrudeFinancialCostcentreServiceClient().FetchByFinancialCostcentreId(financialCostcentreId);
            ViewBag.FinancialCompanyId =
                new SelectList( new CrudeFinancialCompanyServiceClient().FetchAll(),
                                "FinancialCompanyId",
                                "FinancialCompanyName",
                                contract.FinancialCompanyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCostcentre/CrudeFinancialCostcentreEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCostcentreEdit([Bind()] CrudeFinancialCostcentreContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCostcentreServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCostcentreIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCostcentre/CrudeFinancialCostcentreEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCostcentreCreate(System.Guid? financialCompanyId, System.Guid? userId) {
            var contract = new CrudeFinancialCostcentreContract();
            if (financialCompanyId != null) contract.FinancialCompanyId = (System.Guid) financialCompanyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.FinancialCompanyId =
                new SelectList( new CrudeFinancialCompanyServiceClient().FetchAll(),
                                "FinancialCompanyId",
                                "FinancialCompanyName",
                                contract.FinancialCompanyId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCostcentre/CrudeFinancialCostcentreCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCostcentreCreate([Bind()] CrudeFinancialCostcentreContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCostcentreServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCostcentreIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCostcentre/CrudeFinancialCostcentreCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCostcentreDelete(
            System.Guid financialCostcentreId
            ) {
            new CrudeFinancialCostcentreServiceClient().Delete(financialCostcentreId);

            return RedirectToAction("CrudeFinancialCostcentreIndex");
        }
    }
}
