/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:44:02 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultErrorLayerRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefIndex.cshtml",
                new CrudeDefaultErrorLayerRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefDetails(System.String defaultErrorLayerRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefDetails.cshtml",
                new CrudeDefaultErrorLayerRefServiceClient().FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefEdit(
            System.String defaultErrorLayerRcd
            ) {

            CrudeDefaultErrorLayerRefContract contract = new CrudeDefaultErrorLayerRefServiceClient().FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorLayerRefEdit([Bind()] CrudeDefaultErrorLayerRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultErrorLayerRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultErrorLayerRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultErrorLayerRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorLayerRefCreate([Bind()] CrudeDefaultErrorLayerRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultErrorLayerRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultErrorLayerRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefDelete(
            System.String defaultErrorLayerRcd
            ) {
            new CrudeDefaultErrorLayerRefServiceClient().Delete(defaultErrorLayerRcd);

            return RedirectToAction("CrudeDefaultErrorLayerRefIndex");
        }
    }
}
