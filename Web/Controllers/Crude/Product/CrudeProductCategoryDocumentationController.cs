/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:55:48 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductCategoryDocumentationController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationIndex.cshtml",
                new CrudeProductCategoryDocumentationServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationByProductCategoryIndex(System.Guid productCategoryId) {
            ViewBag.ProductCategoryId = productCategoryId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationIndex.cshtml",
                new CrudeProductCategoryDocumentationServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationDetails(System.Guid productCategoryDocumentationId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationDetails.cshtml",
                new CrudeProductCategoryDocumentationServiceClient().FetchByProductCategoryDocumentationId(productCategoryDocumentationId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationEdit(
            System.Guid productCategoryDocumentationId
            ) {

            CrudeProductCategoryDocumentationContract contract = new CrudeProductCategoryDocumentationServiceClient().FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
            ViewBag.ProductCategoryDocumentationTypeRcd =
                new SelectList( new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductCategoryDocumentationTypeRcd",
                                "ProductCategoryDocumentationTypeName",
                                contract.ProductCategoryDocumentationTypeRcd
                                );

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationEdit([Bind()] CrudeProductCategoryDocumentationContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryDocumentationServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationCreate(System.Guid? productCategoryId, System.Guid? userId) {
            var contract = new CrudeProductCategoryDocumentationContract();
            if (productCategoryId != null) contract.ProductCategoryId = (System.Guid) productCategoryId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductCategoryDocumentationTypeRcd =
                new SelectList( new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductCategoryDocumentationTypeRcd",
                                "ProductCategoryDocumentationTypeName",
                                contract.ProductCategoryDocumentationTypeRcd
                                );

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationCreate([Bind()] CrudeProductCategoryDocumentationContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryDocumentationServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationDelete(
            System.Guid productCategoryDocumentationId
            ) {
            new CrudeProductCategoryDocumentationServiceClient().Delete(productCategoryDocumentationId);

            return RedirectToAction("CrudeProductCategoryDocumentationIndex");
        }
    }
}
