using System;
using norpim.BusinessLogicLayer;
using System.Text.RegularExpressions;
using System.Web;

namespace norpim.mvc.Controllers {
    public static class MVCHelper {

        public static string ResolveCrude(HttpRequestBase request, string module, string action) {
            Logging.ActionLog(request, module + " " + action + " ( ASP MVC WCF )" );
            return "~/Views/Crude/" + module + "/" + action + ".cshtml";
        }

        public static string ResolveDurian(HttpRequestBase request, string className, string method, string action) {
            Logging.ActionLog(  request, className + " " + method + " " + action + " ( ASP MVC WCF )" );
            return "~/Views/Durian/" + className + "/" + method + "/" + action + ".cshtml";
        }

        public static string ResolveDiv(HttpRequestBase request, string module, string action) {
            Logging.ActionLog(  request, module + " " + action + " ( ASP MVC WCF )" );
            return "~/Views/Div/" + module + "/" + action + ".cshtml";
        }

        public static string Resolve(HttpRequestBase request, string domain, string module, string action) {
            Logging.ActionLog(  request, module + " " + action + " ( ASP MVC WCF )" );
            return "~/Views/" + domain + "/" + module + "/" + action + ".cshtml";
        }
    }

    public static class Logging {
        public static void ActionLog(   HttpRequestBase request, 
                                        string message
            ) {

            try { 
                var contract = new CrudeUserActivityContract();
            
                contract.UserActivityId = Guid.NewGuid();
                contract.UserActivityTypeRcd = UserActivityTypeRef.WebPageOpened;
                contract.UserActivityNote = message;
                
                try { 
                    contract.OriginatingAddress = request.ServerVariables["REMOTE_ADDR"]; 
                } catch {};

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                contract.DateTime = DateTime.UtcNow;

                var activity = new CrudeUserActivityService();
                activity.Insert(contract);
                activity.Close();
            } catch {};
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

            if (toReadable.Length == 0)
                return "<<empty<<";

            // TODO Rewrite
            // Replace illegal characters with underscore
            foreach (char character in toReadable)
                if (legalchars.IndexOf(character) == -1)
                    toReadable = toReadable.Replace(character, '_');

            // Insert 'A' if string starts with a number
            if (numbers.IndexOf(toReadable.Substring(0, 1)) != -1) {
                toReadable = "A" + toReadable;
            }

            readable = Regex.Replace(toReadable, pattern,
                                 delegate(Match match) {
                                     return " " + match.Groups[1].Value.ToUpper();
                                 });

            // Remove last underscore, if any
            if (readable.EndsWith("_"))
                readable = readable.Substring(0, readable.Length - 1);

            // Remove first space, if any
            if (readable.StartsWith(" "))
                readable = readable.Substring(1);

            readable = readable.Replace(" ", "");

            return readable;
        }
    }
}