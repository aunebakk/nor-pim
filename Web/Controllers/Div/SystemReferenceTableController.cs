using SolutionNorSolutionPim.BusinessLogicLayer;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.mvc.Controllers {
    public class SystemReferenceTableController : Controller {

        [HttpGet]
        public ActionResult Index() {
            CrudeDefaultSystemReferenceTableServiceClient obj = new CrudeDefaultSystemReferenceTableServiceClient();
            List<CrudeDefaultSystemReferenceTableContract> refTables = obj.FetchAll();

            foreach (CrudeDefaultSystemReferenceTableContract refTable in refTables) {
                refTable.DefaultSystemReferenceTableName = Nice(refTable.DefaultSystemReferenceTableName);
            }

            Logging.ActionLog(Request, "SystemReferenceTable" + " " + "Index" + " ( ASP MVC WCF )");

            return View(
                "~/Views/Div/" + "SystemReferenceTable" + "/" + "Index" + ".cshtml",
                refTables
                );
        }

        /// <summary>
        /// Takes a string ( database column ? ) in format 'low_case' and makes it into 'LowCase'
        /// </summary>
        /// <param name="toReadable">Low with underscore column name</param>
        /// <returns>Human readable each word capitalized string</returns>
        public static string Nice(string toReadable) {
            string pattern = "(?:^|_)(.)";
            string numbers = "1234567890";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string legalchars = alphabet + numbers;
            string readable;

            if (toReadable.Length == 0) {
                return "<<empty<<";
            }

            // TODO Rewrite
            // Replace illegal characters with underscore
            foreach (char character in toReadable) {
                if (legalchars.IndexOf(character) == -1) {
                    toReadable = toReadable.Replace(character, '_');
                }
            }

            // Insert 'A' if string starts with a number
            if (numbers.IndexOf(toReadable.Substring(0, 1)) != -1) {
                toReadable = "A" + toReadable;
            }

            readable = Regex.Replace(toReadable, pattern,
                                 delegate (Match match) {
                                     return " " + match.Groups[1].Value.ToUpper();
                                 });

            // Remove last underscore, if any
            if (readable.EndsWith("_")) {
                readable = readable.Substring(0, readable.Length - 1);
            }

            // Remove first space, if any
            if (readable.StartsWith(" ")) {
                readable = readable.Substring(1);
            }

            readable = readable.Replace(" ", "");

            return readable;
        }
    }
}
