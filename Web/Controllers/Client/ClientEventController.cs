using System;
using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.mvc.Controllers
{
    public class ClientEventController : Controller
    {

        [HttpGet]
        public ActionResult ClientEventByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;
            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEvent", "ClientEventIndex"),
                new CrudeClientEventServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult ClientEventDetails(System.Guid clientEventId) {
            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEvent", "ClientEventDetails"),
                new CrudeClientEventServiceClient().FetchByClientEventId(clientEventId)
                );
        }

        [HttpGet]
        public ActionResult ClientEventEdit(System.Guid clientEventId) {
            CrudeClientEventContract contract = new CrudeClientEventServiceClient().FetchByClientEventId(clientEventId);

            ViewBag.ClientEventTypeRcd =
                new SelectList(new CrudeClientEventTypeRefServiceClient().FetchAll(),
                                "ClientEventTypeRcd",
                                "ClientEventTypeName",
                                contract.ClientEventTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEvent", "ClientEventEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientEventEdit([Bind()] CrudeClientEventContract contract) {
            if ( ModelState.IsValid ) {
                new CrudeClientEventServiceClient().Update(contract);

                return RedirectToAction("ClientEventByClientIndex", new { clientId = contract.ClientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEvent", "ClientEventEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ClientEventCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientEventContract();
            if ( clientId != null )
                contract.ClientId = ( System.Guid ) clientId;
            if ( userId != null )
                contract.UserId = ( System.Guid ) userId;

            ViewBag.ClientEventTypeRcd =
                new SelectList(new CrudeClientEventTypeRefServiceClient().FetchAll(),
                                "ClientEventTypeRcd",
                                "ClientEventTypeName",
                                contract.ClientEventTypeRcd
                                );

            if ( userId == null )
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEvent", "ClientEventCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientEventCreate([Bind()] CrudeClientEventContract contract) {
            if ( ModelState.IsValid ) {

                new CrudeClientEventServiceClient().Insert(contract);

                return RedirectToAction("ClientEventByClientIndex", new { clientId = contract.ClientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEvent", "ClientEventCreate"),
                contract
                );
        }
    }
}
