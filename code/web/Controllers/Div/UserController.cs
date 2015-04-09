using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class UserController : Controller {

        [HttpGet]
        public ActionResult Index() {
            return View(    
                MVCHelper.ResolveDiv(Request, "User", "Index"), 
                new CrudeUserService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult Details(Guid userId) {
            return View(    
                MVCHelper.ResolveDiv(Request, "User", "Details"), 
                new CrudeUserService().FetchByUserId(userId)
                );
        }

        [HttpGet]
        public ActionResult Edit(Guid userId) {
            return View(    
                MVCHelper.ResolveDiv(Request, "User", "Edit"), 
                new CrudeUserService().FetchByUserId(userId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind()] CrudeUserContract contract) {
            if (ModelState.IsValid) {
                new CrudeUserService().Update(contract);

                return RedirectToAction("Index");
            }

            return View(    
                MVCHelper.ResolveDiv(Request, "User", "Edit"), 
                contract
                );
        }

        [HttpGet]
        public ActionResult Create() {
            var contract = new CrudeUserContract();
            
            contract.DateTime = DateTime.UtcNow;

            return View(    
                MVCHelper.ResolveDiv(Request, "User", "Create"), 
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind()] CrudeUserContract contract) {
            if (ModelState.IsValid) {
                
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                
                new CrudeUserService().Insert(contract);

                return RedirectToAction("Index");
            }

            return View(    
                MVCHelper.ResolveDiv(Request, "User", "Create"), 
                contract
                );
        }
    }
}