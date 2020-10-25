using System;
using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.mvc.Controllers
{
    public class ClientContactMethodController : Controller
    {

        [HttpGet]
        public ActionResult ClientContactMethodByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;
            return View(
                MVCHelper.Resolve(Request, "Client", "ClientContactMethod", "ClientContactMethodIndex"),
                new CrudeClientContactMethodServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult ClientContactMethodDetails(System.Guid clientContactMethodId) {
            return View(
                MVCHelper.Resolve(Request, "Client", "ClientContactMethod", "ClientContactMethodDetails"),
                new CrudeClientContactMethodServiceClient().FetchByClientContactMethodId(clientContactMethodId)
                );
        }

        [HttpGet]
        public ActionResult ClientContactMethodEdit(System.Guid clientContactMethodId) {
            CrudeClientContactMethodContract contract = new CrudeClientContactMethodServiceClient().FetchByClientContactMethodId(clientContactMethodId);

            ViewBag.ClientContactMethodRcd =
                new SelectList(new CrudeClientContactMethodRefServiceClient().FetchAll(),
                                "ClientContactMethodRcd",
                                "ClientContactMethodName",
                                contract.ClientContactMethodRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientContactMethod", "ClientContactMethodEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientContactMethodEdit([Bind()] CrudeClientContactMethodContract contract) {
            if ( ModelState.IsValid ) {
                new CrudeClientContactMethodServiceClient().Update(contract);

                return RedirectToAction("ClientContactMethodByClientIndex", new { clientId = contract.ClientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientContactMethod", "ClientContactMethodEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ClientContactMethodCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientContactMethodContract();
            if ( clientId != null )
                contract.ClientId = ( System.Guid ) clientId;
            if ( userId != null )
                contract.UserId = ( System.Guid ) userId;

            ViewBag.ClientContactMethodRcd =
                new SelectList(new CrudeClientContactMethodRefServiceClient().FetchAll(),
                                "ClientContactMethodRcd",
                                "ClientContactMethodName",
                                contract.ClientContactMethodRcd
                                );

            if ( userId == null )
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientContactMethod", "ClientContactMethodCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientContactMethodCreate([Bind()] CrudeClientContactMethodContract contract) {
            if ( ModelState.IsValid ) {

                new CrudeClientContactMethodServiceClient().Insert(contract);

                return RedirectToAction("ClientContactMethodByClientIndex", new { clientId = contract.ClientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientContactMethod", "ClientContactMethodCreate"),
                contract
                );
        }
    }
}
