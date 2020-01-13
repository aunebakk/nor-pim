using System;
using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.mvc.Controllers;

namespace SolutionNorSolutionPim.Controllers.Default
{
    public class DefaultIssueController : Controller
    {
        [HttpGet]
        public ActionResult DefaultIssueIndex()
        {
            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueIndex");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueIndex.cshtml",
                new CrudeDefaultIssueServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult DefaultIssueByDefaultErrorIndex(Guid defaultErrorId)
        {
            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueIndex");

            ViewBag.DefaultErrorId = defaultErrorId;
            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueIndex.cshtml",
                new CrudeDefaultIssueServiceClient().FetchByDefaultErrorId(defaultErrorId)
                );
        }

        [HttpGet]
        public ActionResult DefaultIssueDetails(Guid defaultIssueId)
        {
            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueDetails");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueDetails.cshtml",
                new CrudeDefaultIssueServiceClient().FetchByDefaultIssueId(defaultIssueId)
                );
        }

        [HttpGet]
        public ActionResult DefaultIssueEdit(Guid defaultIssueId)
        {
            var contract = new CrudeDefaultIssueServiceClient().FetchByDefaultIssueId(defaultIssueId);
            ViewBag.DefaultIssueTypeRcd =
                new SelectList(new CrudeDefaultIssueTypeRefServiceClient().FetchAll(),
                    "DefaultIssueTypeRcd",
                    "DefaultIssueTypeName",
                    contract.DefaultIssueTypeRcd
                    );

            ViewBag.DefaultIssueStatusRcd =
                new SelectList(new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                    "DefaultIssueStatusRcd",
                    "DefaultIssueStatusName",
                    contract.DefaultIssueStatusRcd
                    );

            if (contract.DefaultErrorId != Guid.Empty)
            {
                ViewBag.DefaultErrorId =
                    new SelectList(new CrudeDefaultErrorServiceClient().FetchAll(),
                        "DefaultErrorId",
                        "MethodName",
                        contract.DefaultErrorId
                        );
            }

            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueEdit");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultIssueEdit(
            [Bind] CrudeDefaultIssueContract contract
            )
        {
            if (ModelState.IsValid)
            {
                contract.DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultIssueServiceClient().Update(contract);

                return RedirectToAction("DefaultIssueWithFilterLiveIndex", "DefaultIssueWithFilterLive");
            }

            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueEdit");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult DefaultIssueCreateWithUrl(
            string fromUrl,
            Guid? defaultUserId
            )
        {
            var contract = new CrudeDefaultIssueContract();
            if (defaultUserId != null)
                contract.DefaultUserId = (Guid) defaultUserId;

            contract.Link = fromUrl;

            contract.DefaultIssueTypeRcd = DefaultIssueTypeRef.IncorrectBehavior;
            ViewBag.DefaultIssueTypeRcd =
                new SelectList(new CrudeDefaultIssueTypeRefServiceClient().FetchAll(),
                    "DefaultIssueTypeRcd",
                    "DefaultIssueTypeName",
                    contract.DefaultIssueTypeRcd
                    );

            contract.DefaultIssueStatusRcd = DefaultIssueStatusRef.ToBeResolved;
            ViewBag.DefaultIssueStatusRcd =
                new SelectList(new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                    "DefaultIssueStatusRcd",
                    "DefaultIssueStatusName",
                    contract.DefaultIssueStatusRcd
                    );

            if (defaultUserId == null)
                contract.DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;

            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueCreate");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultIssueCreateWithUrl(
            [Bind] CrudeDefaultIssueContract contract
            )
        {
            if (ModelState.IsValid)
            {
                new CrudeDefaultIssueServiceClient().Insert(contract);

                return RedirectToAction("DefaultIssueWithFilterLiveIndex", "DefaultIssueWithFilterLive");
            }

            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueCreate");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult DefaultIssueCreate(
            Guid? defaultErrorId,
            Guid? defaultUserId
            )
        {
            var contract = new CrudeDefaultIssueContract();
            contract.DefaultIssueTypeRcd = DefaultIssueTypeRef.IncorrectBehavior;
            contract.DefaultIssueStatusRcd = DefaultIssueStatusRef.ToBeResolved;
            if (defaultErrorId != null)
                contract.DefaultErrorId = (Guid) defaultErrorId;
            if (defaultUserId != null)
                contract.DefaultUserId = (Guid) defaultUserId;

            ViewBag.DefaultIssueTypeRcd =
                new SelectList(new CrudeDefaultIssueTypeRefServiceClient().FetchAll(),
                    "DefaultIssueTypeRcd",
                    "DefaultIssueTypeName",
                    contract.DefaultIssueTypeRcd
                    );

            ViewBag.DefaultIssueStatusRcd =
                new SelectList(new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                    "DefaultIssueStatusRcd",
                    "DefaultIssueStatusName",
                    contract.DefaultIssueStatusRcd
                    );

            if (defaultUserId != null)
            {
                ViewBag.DefaultErrorId =
                    new SelectList(new CrudeDefaultErrorServiceClient().FetchAll(),
                        "DefaultErrorId",
                        "MethodName",
                        contract.DefaultErrorId
                        );
            }

            if (defaultUserId == null)
                contract.DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;

            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueCreate");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultIssueCreate(
            [Bind] CrudeDefaultIssueContract contract
            ) {
            if (ModelState.IsValid) {
                if (contract.IssueName == null) {
                    ViewBag.DefaultIssueTypeRcd =
                        new SelectList(new CrudeDefaultIssueTypeRefServiceClient().FetchAll(),
                            "DefaultIssueTypeRcd",
                            "DefaultIssueTypeName",
                            contract.DefaultIssueTypeRcd
                            );

                    ViewBag.DefaultIssueStatusRcd =
                        new SelectList(new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                            "DefaultIssueStatusRcd",
                            "DefaultIssueStatusName",
                            contract.DefaultIssueStatusRcd
                            );

                    return View(
                        "~/Views/Default/DefaultIssue/DefaultIssueCreate.cshtml",
                        contract
                        );
                }

                new CrudeDefaultIssueServiceClient().Insert(contract);

                return RedirectToAction("DefaultIssueWithFilterLiveIndex", "DefaultIssueWithFilterLive");
            }

            MVCHelper.Resolve(Request, "Default", "DefaultIssue", "DefaultIssueCreate");

            return View(
                "~/Views/Default/DefaultIssue/DefaultIssueCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult DefaultIssueSetStatus(
            Guid defaultIssueId,
            string defaultIssueStatusRcd
            )
        {
            var contract =
                new CrudeDefaultIssueServiceClient().FetchByDefaultIssueId(
                    defaultIssueId
                    );

            contract.DefaultIssueStatusRcd = defaultIssueStatusRcd;

            new CrudeDefaultIssueServiceClient().Update(contract);

            MVCHelper.Resolve(Request, "Default", "DefaultIssueWithFilterLive", "DefaultIssueWithFilterLiveCreate");

            return RedirectToAction("DefaultIssueWithFilterLiveIndex", "DefaultIssueWithFilterLive");
        }
    }
}
