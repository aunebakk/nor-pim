/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:41:47 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeProductFieldSetMappingController : Controller {

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingIndex.cshtml",
                new CrudeProductFieldSetMappingServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingByProductFieldSetIndex(System.Guid productFieldSetId) {
            ViewBag.ProductFieldSetId = productFieldSetId;

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingIndex.cshtml",
                new CrudeProductFieldSetMappingServiceClient().FetchByProductFieldSetId(productFieldSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingDetails(System.Guid productFieldSetMappingId) {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingDetails.cshtml",
                new CrudeProductFieldSetMappingServiceClient().FetchByProductFieldSetMappingId(productFieldSetMappingId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingEdit(
            System.Guid productFieldSetMappingId
            ) {

            CrudeProductFieldSetMappingContract contract = new CrudeProductFieldSetMappingServiceClient().FetchByProductFieldSetMappingId(productFieldSetMappingId);
            ViewBag.ProductFieldSetId =
                new SelectList( new CrudeProductFieldSetServiceClient().FetchAll(),
                                "ProductFieldSetId",
                                "ProductFieldSetName",
                                contract.ProductFieldSetId
                                );

            ViewBag.ProductIdentifierRcd =
                new SelectList( new CrudeProductIdentifierRefServiceClient().FetchAll(),
                                "ProductIdentifierRcd",
                                "ProductIdentifierName",
                                contract.ProductIdentifierRcd
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                contract.ProductAttributeRcd
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                contract.ProductInfoRcd
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                contract.ProductImageTypeRcd
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
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetMappingEdit([Bind()] CrudeProductFieldSetMappingContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductFieldSetMappingServiceClient().Update(contract);

                return RedirectToAction("CrudeProductFieldSetMappingIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingCreate(System.Guid? productFieldSetId, System.Guid? userId) {
            var contract = new CrudeProductFieldSetMappingContract();
            if (productFieldSetId != null) contract.ProductFieldSetId = (System.Guid) productFieldSetId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductFieldSetId =
                new SelectList( new CrudeProductFieldSetServiceClient().FetchAll(),
                                "ProductFieldSetId",
                                "ProductFieldSetName",
                                contract.ProductFieldSetId
                                );

            ViewBag.ProductIdentifierRcd =
                new SelectList( new CrudeProductIdentifierRefServiceClient().FetchAll(),
                                "ProductIdentifierRcd",
                                "ProductIdentifierName",
                                contract.ProductIdentifierRcd
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                contract.ProductAttributeRcd
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                contract.ProductInfoRcd
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                contract.ProductImageTypeRcd
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
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetMappingCreate([Bind()] CrudeProductFieldSetMappingContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductFieldSetMappingServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductFieldSetMappingIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingDelete(
            System.Guid productFieldSetMappingId
            ) {
            new CrudeProductFieldSetMappingServiceClient().Delete(productFieldSetMappingId);

            return RedirectToAction("CrudeProductFieldSetMappingIndex");
        }
    }
}
