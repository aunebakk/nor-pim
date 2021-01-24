﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:27:14 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeCartProductPriceController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeCartProductPriceIndex() {

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeCartProductPriceByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeCartProductPriceByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeCartProductPriceDetails(System.Guid cartProductPriceId) {

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceDetails.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByCartProductPriceId(cartProductPriceId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeCartProductPriceEdit(
            System.Guid cartProductPriceId
            ) {

            CrudeCartProductPriceContract contract = new CrudeCartProductPriceServiceClient().FetchByCartProductPriceId(cartProductPriceId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeCartProductPriceEdit([Bind()] CrudeCartProductPriceContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeCartProductPriceServiceClient().Update(contract);

                return RedirectToAction("CrudeCartProductPriceIndex");
            }

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeCartProductPriceCreate(System.Guid? financialCurrencyId, System.Guid? userId, System.Guid? productId) {
            var contract = new CrudeCartProductPriceContract();
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (productId != null) contract.ProductId = (System.Guid) productId;

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );


            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeCartProductPriceCreate([Bind()] CrudeCartProductPriceContract contract) {
            if (ModelState.IsValid) {

                new CrudeCartProductPriceServiceClient().Insert(contract);

                return RedirectToAction("CrudeCartProductPriceIndex");
            }

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeCartProductPriceDelete(
            System.Guid cartProductPriceId
            ) {
            new CrudeCartProductPriceServiceClient().Delete(cartProductPriceId);

            return RedirectToAction("CrudeCartProductPriceIndex");
        }
    }
}
