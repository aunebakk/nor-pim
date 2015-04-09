using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class SystemSettingController : Controller {

        [HttpGet]
        public ActionResult Index() {
            return View(    
                MVCHelper.ResolveDiv(Request, "SystemSetting", "Index"), 
                new CrudeSystemSettingService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult Details(Guid systemSettingId) {
            return View(    
                MVCHelper.ResolveDiv(Request, "SystemSetting", "Details"), 
                new CrudeSystemSettingService().FetchBySystemSettingId(systemSettingId)
                );
        }

        [HttpGet]
        public ActionResult Edit(Guid systemSettingId) {
            return View(    
                MVCHelper.ResolveDiv(Request, "SystemSetting", "Edit"), 
                new CrudeSystemSettingService().FetchBySystemSettingId(systemSettingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind()] CrudeSystemSettingContract contract) {
            if (ModelState.IsValid) {
                new CrudeSystemSettingService().Update(contract);

                return RedirectToAction("Index");
            }

            return View(    
                MVCHelper.ResolveDiv(Request, "SystemSetting", "Edit"), 
                contract
                );
        }

        [HttpGet]
        public ActionResult Create() {
            var contract = new CrudeSystemSettingContract();
            
            contract.DateTime = DateTime.UtcNow;

            return View(    
                MVCHelper.ResolveDiv(Request, "SystemSetting", "Create"), 
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind()] CrudeSystemSettingContract contract) {
            if (ModelState.IsValid) {
                
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                
                new CrudeSystemSettingService().Insert(contract);

                return RedirectToAction("Index");
            }

            return View(    
                MVCHelper.ResolveDiv(Request, "SystemSetting", "Create"), 
                contract
                );
        }
    }
}