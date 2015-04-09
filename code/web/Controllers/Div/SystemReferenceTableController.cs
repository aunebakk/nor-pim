using norpim.BusinessLogicLayer;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class SystemReferenceTableController : Controller {

        [HttpGet]
        public ActionResult Index() {
            var obj = new CrudeSystemReferenceTableService();
            CrudeSystemReferenceTableContract[] refTables = obj.FetchAll();

            foreach (CrudeSystemReferenceTableContract refTable in refTables) {
                refTable.SystemReferenceTableName = Logging.Nice(refTable.SystemReferenceTableName);
            }

            return View(
                MVCHelper.ResolveDiv(Request, "SystemReferenceTable", "Index"), 
                refTables
                );
        }
    }
}