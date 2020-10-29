/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:06:55 AM
  From Machine: DESKTOP-9A2DH39
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
    public class CrudeProductDocumentationController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductDocumentationIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationIndex.cshtml",
                new CrudeProductDocumentationServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductDocumentationByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationIndex.cshtml",
                new CrudeProductDocumentationServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductDocumentationDetails(System.Guid productDocumentationId) {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentation/CrudeProductDocumentationDetails.cshtml",
                new CrudeProductDocumentationServiceClient().FetchByProductDocumentationId(productDocumentationId)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductDocumentationDelete(
            System.Guid productDocumentationId
            ) {
            new CrudeProductDocumentationServiceClient().Delete(productDocumentationId);

            return RedirectToAction("CrudeProductDocumentationIndex");
        }
    }
}
