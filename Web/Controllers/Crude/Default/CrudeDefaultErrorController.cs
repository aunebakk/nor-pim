﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:28:18 AM
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
    public class CrudeDefaultErrorController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeDefaultErrorIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorIndex.cshtml",
                new CrudeDefaultErrorServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeDefaultErrorDetails(System.Guid defaultErrorId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorDetails.cshtml",
                new CrudeDefaultErrorServiceClient().FetchByDefaultErrorId(defaultErrorId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeDefaultErrorEdit(
            System.Guid defaultErrorId
            ) {

            CrudeDefaultErrorContract contract = new CrudeDefaultErrorServiceClient().FetchByDefaultErrorId(defaultErrorId);
            ViewBag.DefaultErrorLayerRcd =
                new SelectList( new CrudeDefaultErrorLayerRefServiceClient().FetchAll(),
                                "DefaultErrorLayerRcd",
                                "DefaultErrorLayerName",
                                contract.DefaultErrorLayerRcd
                                );

            ViewBag.DefaultErrorTypeRcd =
                new SelectList( new CrudeDefaultErrorTypeRefServiceClient().FetchAll(),
                                "DefaultErrorTypeRcd",
                                "DefaultErrorTypeName",
                                contract.DefaultErrorTypeRcd
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorEdit([Bind()] CrudeDefaultErrorContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultErrorServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultErrorIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeDefaultErrorCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultErrorContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            ViewBag.DefaultErrorLayerRcd =
                new SelectList( new CrudeDefaultErrorLayerRefServiceClient().FetchAll(),
                                "DefaultErrorLayerRcd",
                                "DefaultErrorLayerName",
                                contract.DefaultErrorLayerRcd
                                );

            ViewBag.DefaultErrorTypeRcd =
                new SelectList( new CrudeDefaultErrorTypeRefServiceClient().FetchAll(),
                                "DefaultErrorTypeRcd",
                                "DefaultErrorTypeName",
                                contract.DefaultErrorTypeRcd
                                );

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorCreate([Bind()] CrudeDefaultErrorContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultErrorServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultErrorIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultError/CrudeDefaultErrorCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeDefaultErrorDelete(
            System.Guid defaultErrorId
            ) {
            new CrudeDefaultErrorServiceClient().Delete(defaultErrorId);

            return RedirectToAction("CrudeDefaultErrorIndex");
        }
    }
}
