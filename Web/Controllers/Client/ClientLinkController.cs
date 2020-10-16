using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.mvc.Controllers {
    public class ClientLinkController : Controller {

        [HttpGet]
        public ActionResult ClientLinkByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;
            return View(
                MVCHelper.Resolve(Request, "Client", "ClientLink", "ClientLinkIndex"),
                new CrudeClientLinkServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult ClientLinkDetails(System.Guid clientLinkId) {
            return View(
                MVCHelper.Resolve(Request, "Client", "ClientLink", "ClientLinkDetails"),
                new CrudeClientLinkServiceClient().FetchByClientLinkId(clientLinkId)
                );
        }

        [HttpGet]
        public ActionResult ClientLinkEdit(System.Guid clientLinkId) {
            CrudeClientLinkContract contract = new CrudeClientLinkServiceClient().FetchByClientLinkId(clientLinkId);

            ViewBag.ClientLinkTypeRcd =
                new SelectList(new CrudeClientLinkTypeRefServiceClient().FetchAll(),
                                "ClientLinkTypeRcd",
                                "ClientLinkTypeName",
                                contract.ClientLinkTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientLink", "ClientLinkEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientLinkEdit([Bind()] CrudeClientLinkContract contract) {
            if (ModelState.IsValid) {
                new CrudeClientLinkServiceClient().Update(contract);

                return RedirectToAction("ClientLinkByClientIndex", new { clientId = contract.ClientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientLink", "ClientLinkEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ClientLinkCreate(System.Guid? clientId, System.Guid? userId) {
            CrudeClientLinkContract contract = new CrudeClientLinkContract();
            if (clientId != null) {
                contract.ClientId = (System.Guid)clientId;
            }

            if (userId != null) {
                contract.UserId = (System.Guid)userId;
            }

            ViewBag.ClientLinkTypeRcd =
                new SelectList(new CrudeClientLinkTypeRefServiceClient().FetchAll(),
                                "ClientLinkTypeRcd",
                                "ClientLinkTypeName",
                                contract.ClientLinkTypeRcd
                                );

            if (userId == null) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            }

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientLink", "ClientLinkCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientLinkCreate([Bind()] CrudeClientLinkContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientLinkServiceClient().Insert(contract);

                return RedirectToAction("ClientLinkByClientIndex", new { clientId = contract.ClientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientLink", "ClientLinkCreate"),
                contract
                );
        }
    }
}
