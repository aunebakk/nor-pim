/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:58:28 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductDocumentationController : Controller {

        [HttpGet]
        public ActionResult CrudeProductDocumentationIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationIndex.cshtml",
                new CrudeProductDocumentationServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationIndex.cshtml",
                new CrudeProductDocumentationServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationDetails(System.Guid productDocumentationId) {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationDetails.cshtml",
                new CrudeProductDocumentationServiceClient().FetchByProductDocumentationId(productDocumentationId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationEdit(
            System.Guid productDocumentationId
            ) {

            CrudeProductDocumentationContract contract = new CrudeProductDocumentationServiceClient().FetchByProductDocumentationId(productDocumentationId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductDocumentationTypeRcd =
                new SelectList( new CrudeProductDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductDocumentationTypeRcd",
                                "ProductDocumentationTypeName",
                                contract.ProductDocumentationTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationEdit([Bind()] CrudeProductDocumentationContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductDocumentationServiceClient().Update(contract);

                return RedirectToAction("CrudeProductDocumentationIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductDocumentationContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductDocumentationTypeRcd =
                new SelectList( new CrudeProductDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductDocumentationTypeRcd",
                                "ProductDocumentationTypeName",
                                contract.ProductDocumentationTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationCreate([Bind()] CrudeProductDocumentationContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductDocumentationServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductDocumentationIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationDelete(
            System.Guid productDocumentationId
            ) {
            new CrudeProductDocumentationServiceClient().Delete(productDocumentationId);

            return RedirectToAction("CrudeProductDocumentationIndex");
        }
    }
}
