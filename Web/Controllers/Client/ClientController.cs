using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.mvc.Controllers {
    public class ClientController : Controller {

        [HttpGet]
        public ActionResult ClientIndex() {
            return View(
                MVCHelper.Resolve(
                    Request,
                    "Client",
                    "ClientIndex"),
                new ClientSearchService().GetClientWithFilter(string.Empty, string.Empty)
                );
        }

        [HttpGet]
        public ActionResult ClientEdit(System.Guid clientId) {
            ViewBag.ClientId = clientId;
            CrudeClientContract contract = new CrudeClientServiceClient().FetchByClientId(clientId);
            ViewBag.ClientTypeRcd =
                new SelectList(new CrudeClientTypeRefServiceClient().FetchAll(),
                                "ClientTypeRcd",
                                "ClientTypeName",
                                contract.ClientTypeRcd
                                );

            ViewBag.ClientNationalityRcd =
                new SelectList(new CrudeClientNationalityRefServiceClient().FetchAll(),
                                "ClientNationalityRcd",
                                "ClientNationalityName",
                                contract.ClientNationalityRcd
                                );

            ViewBag.ClientGenderRcd =
                new SelectList(new CrudeClientGenderRefServiceClient().FetchAll(),
                                "ClientGenderRcd",
                                "ClientGenderName",
                                contract.ClientGenderRcd
                                );

            ViewBag.ClientTitleRcd =
                new SelectList(new CrudeClientTitleRefServiceClient().FetchAll(),
                                "ClientTitleRcd",
                                "ClientTitleName",
                                contract.ClientTitleRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientEdit([Bind()] CrudeClientContract contract) {
            if (ModelState.IsValid) {
                new CrudeClientServiceClient().Update(contract);

                return RedirectToAction("ClientIndex");
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ClientCreate(System.Guid? addressId, System.Guid? defaultUserId, System.Guid? userId) {
            CrudeClientContract contract = new CrudeClientContract();
            if (addressId != null) {
                contract.ClientAddressId = (System.Guid)addressId;
            }

            if (defaultUserId != null) {
                contract.UserId = (System.Guid)defaultUserId;
            }

            if (userId != null) {
                contract.UserId = (System.Guid)userId;
            }

            ViewBag.ClientTypeRcd =
                new SelectList(new CrudeClientTypeRefServiceClient().FetchAll(),
                                "ClientTypeRcd",
                                "ClientTypeName",
                                contract.ClientTypeRcd
                                );

            ViewBag.ClientNationalityRcd =
                new SelectList(new CrudeClientNationalityRefServiceClient().FetchAll(),
                                "ClientNationalityRcd",
                                "ClientNationalityName",
                                contract.ClientNationalityRcd
                                );

            ViewBag.ClientGenderRcd =
                new SelectList(new CrudeClientGenderRefServiceClient().FetchAll(),
                                "ClientGenderRcd",
                                "ClientGenderName",
                                contract.ClientGenderRcd
                                );

            ViewBag.ClientTitleRcd =
                new SelectList(new CrudeClientTitleRefServiceClient().FetchAll(),
                                "ClientTitleRcd",
                                "ClientTitleName",
                                contract.ClientTitleRcd
                                );

            ViewBag.ClientTypeRcd =
                new SelectList(new CrudeClientTypeRefServiceClient().FetchAll(),
                                "ClientTypeRcd",
                                "ClientTypeName",
                                contract.ClientTypeRcd
                                );

            if (userId == null) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            }

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientCreate([Bind()] CrudeClientContract contract) {
            if (ModelState.IsValid) {
                contract.ClientId = Guid.NewGuid();
                new CrudeClientServiceClient().Insert(contract);

                return RedirectToAction("ClientEdit", new { clientId = contract.ClientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientCreate"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ClientAddressEdit(
            System.Guid clientId
            ) {
            ViewBag.ClientId = clientId;
            CrudeClientContract clientContract = new CrudeClientServiceClient().FetchByClientId(clientId);

            CrudeClientAddressContract addressContract;
            if (clientContract.ClientAddressId != Guid.Empty) {
                addressContract = new CrudeClientAddressServiceClient().FetchByClientAddressId(clientContract.ClientAddressId);
            } else {
                addressContract = new CrudeClientAddressContract();
            }

            ViewBag.ClientAddressTypeRcd =
                new SelectList(new CrudeClientAddressTypeRefServiceClient().FetchAll(),
                                "ClientAddressTypeRcd",
                                "ClientAddressTypeName",
                                addressContract.ClientAddressTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(addressContract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientAddress", "ClientAddressEdit"),
                addressContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientAddressEdit(
            [Bind()] CrudeClientAddressContract contract,
            System.Guid clientId
            ) {
            ViewBag.ClientId = clientId;

            if (ModelState.IsValid) {
                if (contract.ClientAddressId == Guid.Empty) {
                    // new address
                    contract.ClientAddressId = Guid.NewGuid();
                    contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                    contract.DateTime = DateTime.UtcNow;

                    new CrudeClientAddressServiceClient().Insert(contract);

                    // update client
                    CrudeClientContract clientContract = new CrudeClientServiceClient().FetchByClientId(clientId);
                    clientContract.ClientAddressId = contract.ClientAddressId;
                    new CrudeClientServiceClient().Update(clientContract);
                } else {
                    new CrudeClientAddressServiceClient().Update(contract);
                }

                return RedirectToAction("ClientAddressEdit", new { clientId = clientId });
            }

            return View(
                MVCHelper.Resolve(Request, "Client", "ClientAddress", "ClientAddressEdit"),
                contract
                );
        }
    }
}
