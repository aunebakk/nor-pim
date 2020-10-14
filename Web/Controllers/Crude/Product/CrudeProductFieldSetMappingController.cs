/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:10:46 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // controller class for mvc
    public class CrudeProductFieldSetMappingController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingIndex.cshtml",
                new CrudeProductFieldSetMappingServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingByProductFieldSetIndex(System.Guid productFieldSetId) {
            ViewBag.ProductFieldSetId = productFieldSetId;

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingIndex.cshtml",
                new CrudeProductFieldSetMappingServiceClient().FetchByProductFieldSetId(productFieldSetId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingDetails(System.Guid productFieldSetMappingId) {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingDetails.cshtml",
                new CrudeProductFieldSetMappingServiceClient().FetchByProductFieldSetMappingId(productFieldSetMappingId)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingDelete(
            System.Guid productFieldSetMappingId
            ) {
            new CrudeProductFieldSetMappingServiceClient().Delete(productFieldSetMappingId);

            return RedirectToAction("CrudeProductFieldSetMappingIndex");
        }
    }
}
