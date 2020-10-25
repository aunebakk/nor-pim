using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;
using SolutionNorSolutionPim.BusinessLogicLayer;
using Microsoft.AspNet.Identity;

namespace SolutionNorSolutionPim.mvc.Controllers
{
    public static class MVCHelper
    {

        public static bool IsMobile(HttpRequestBase request) {
            string u = request.ServerVariables["HTTP_USER_AGENT"];
            Regex b = new Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex v = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return ( ( b.IsMatch(u) || v.IsMatch(u.Substring(0, 4)) ) );
        }

        public static string Resolve(HttpRequestBase request, string domain, string module, string action) {
            Logging.ActionLog(request, domain + " " + module + " " + action + " ( ASP MVC WCF )");
            return "~/Views/" + domain + "/" + module + "/" + action + ".cshtml";
        }

        public static string Resolve(HttpRequestBase request, string domain, string action) {
            Logging.ActionLog(request, domain + " " + action + " ( ASP MVC WCF )");
            return "~/Views/" + domain + "/" + action + ".cshtml";
        }
    }

    public static class Logging {
        public static Guid UserId(
            System.Security.Principal.IIdentity UserIdentity,
            dynamic viewBag
            ) {

            // use viewbag userid if present
            try {
                if (viewBag.UserId != null) {
                    return viewBag.UserId;
                }
            } catch { }

            // use Identity Guid if valid
            try {
                if (string.IsNullOrEmpty(UserIdentity.GetUserId())) {

                    return new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                } else if (Guid.Parse(UserIdentity.GetUserId()) != Guid.Empty) {

                    // validate user
                    CrudeDefaultUserContract user =
                        new CrudeDefaultUserServiceClient().FetchByDefaultUserId(Guid.Parse(UserIdentity.GetUserId()));

                    if (user == null || user.DefaultUserId == Guid.Empty) {

                        // create new user from ASP OAuth
                        user = new CrudeDefaultUserContract();
                        user.DefaultUserId = Guid.Parse(UserIdentity.GetUserId());
                        user.DefaultUserCode = UserIdentity.GetUserName().Substring(0, 19);
                        user.DefaultUserName = UserIdentity.GetUserName();
                        user.Password = UserIdentity.GetUserName();
                        user.Email = UserIdentity.GetUserName();
                        user.DefaultStateRcd = DefaultStateRef.Created;
                        user.CreatedByDefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                        user.DateTime = DateTime.UtcNow;
                        new CrudeDefaultUserServiceClient().Insert(user);

                        // create new client from user
                        CrudeClientContract client = new CrudeClientContract {
                            ClientId = user.DefaultUserId,
                            ClientTypeRcd = ClientTypeRef.Business,
                            FirstName = user.DefaultUserName,
                            LastName = user.DefaultUserName,
                            UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}"),
                            DateTime = DateTime.UtcNow
                        };
                        new CrudeClientServiceClient().Insert(client);
                    }

                    // store for next usage of this method
                    viewBag.UserId = user.DefaultUserId;

                    return user.DefaultUserId;
                }
            } catch (Exception ex) {
                throw new Exception("Failed to create user and client", ex);
            }

            // use default use id
            return new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
        }

        //public static Guid UserId(
        //    HttpRequestBase request,
        //    System.String currentUserId
        //    ) {
        //    Guid userId;

        //    try {
        //        // return passed in user id
        //        if ( !string.IsNullOrEmpty(currentUserId) ) {
        //            userId = new Guid(( System.String ) currentUserId.ToString());
        //        } else {
        //            // figure out user id based on remote address
        //            string originatingAddress = request.ServerVariables["REMOTE_ADDR"];

        //            if ( string.IsNullOrEmpty(originatingAddress) )
        //                userId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
        //            else
        //                userId = new DefaultUserActivityServiceClient().Login(originatingAddress);
        //        }
        //    } catch {
        //        userId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
        //    };

        //    return userId;
        //}

        //public static Guid UserId(
        //    HttpRequestBase request,
        //    dynamic viewBag
        //    ) {
        //    Guid userId;

        //    try {
        //        // return passed in user id
        //        if ( viewBag.UserId != null ) {
        //            userId = viewBag.UserId;
        //        } else {
        //            // figure out user id based on remote address
        //            string originatingAddress = request.ServerVariables["REMOTE_ADDR"];

        //            if ( string.IsNullOrEmpty(originatingAddress) )
        //                userId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
        //            else
        //                userId = new DefaultUserActivityServiceClient().Login(originatingAddress);
        //        }

        //        viewBag.UserId = userId;

        //    } catch {
        //        userId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
        //    };

        //    return userId;
        //}

        public static void ActionLog(
            HttpRequestBase request,
            string message,
            dynamic viewBag
            ) {

            try {
                var contract = new CrudeDefaultUserActivityContract();

                contract.DefaultUserActivityId = Guid.NewGuid();
                contract.DefaultUserActivityTypeRcd = DefaultUserActivityTypeRef.WebPageOpened;

                // get referrer
                try {
                    contract.Referrer = request.UrlReferrer != null
                                        && !string.IsNullOrEmpty(request.UrlReferrer.OriginalString)
                                        ? request.UrlReferrer.OriginalString
                                        : "no referrer";
                } catch { }

                contract.UserActivityNote = string.IsNullOrEmpty(message) ? null : message;

                try {
                    contract.OriginatingAddress = request.ServerVariables != null
                                                  && !string.IsNullOrEmpty(request.ServerVariables["REMOTE_ADDR"])
                                                  ? request.ServerVariables["REMOTE_ADDR"]
                                                  : "no originating address";
                } catch { };

                //contract.DefaultUserId = UserId(request, viewBag);
                contract.DateTime = DateTime.UtcNow;

                var activity = new CrudeDefaultUserActivityServiceClient();
                //activity.Insert(contract);
                activity.Close();
            } catch { };
        }

        public static void ActionLog(
            HttpRequestBase request,
            string message1,
            string message2,
            string message3
            ) {
            ActionLog(request, message1 + " " + message2 + " " + message3);
        }

        public static void ActionLog(
            HttpRequestBase request,
            string message
            ) {
            return;
            //try {
            //    var contract = new CrudeDefaultUserActivityContract();

            //    contract.DefaultUserActivityId = Guid.NewGuid();
            //    contract.DefaultUserActivityTypeRcd = DefaultUserActivityTypeRef.WebPageOpened;
            //    contract.UserActivityNote = message;

            //    try {
            //        contract.OriginatingAddress = request.ServerVariables["REMOTE_ADDR"];
            //    } catch { };

            //    //contract.DefaultUserId = UserId(request, string.Empty);
            //    contract.DateTime = DateTime.UtcNow;

            //    var activity = new CrudeDefaultUserActivityServiceClient();
            //    activity.Insert(contract);
            //    activity.Close();
            //} catch { };
        }

        public static Guid ErrorLog(
            string controller,
            string action,
            Exception ex
            ) {

            string message = ex.Message;

            if ( ex.InnerException != null ) {
                message += "\r\n inner " + ex.InnerException;

                if ( ex.InnerException.InnerException != null )
                    message += "\r\n inners inner" + ex.InnerException.InnerException;
            }

            Guid defaultErrorId = 
                Logging.ErrorLog(
                    controller,
                    action,
                    message,
                    ex.StackTrace
                    );

            return defaultErrorId;
        }

        public static Guid ErrorLog(
            string controller,
            string action,
            string message,
            string stackTrace
            ) {

            var contract = new CrudeDefaultErrorContract();

            try {
                contract.DefaultErrorId = Guid.NewGuid();
                contract.DefaultErrorTypeRcd = DefaultErrorTypeRef.UserInitiated;
                contract.DefaultErrorLayerRcd = DefaultErrorLayerRef.ASPModelViewController;
                contract.DomainName = "General";
                contract.ClassName = controller;
                contract.MethodName = action;
                contract.StackTrace = stackTrace;
                contract.ErrorMessage = message;
                contract.DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                contract.DateTime = DateTime.UtcNow;

                var activity = new CrudeDefaultErrorServiceClient();
                activity.Insert(contract);
                activity.Close();
            } catch {
            };

            return contract.DefaultErrorId;
        }
    }

    public class LoggingTime
    {
        public Stopwatch StopWatch;
        Guid UserId;
        //string _sql;

        public string DomainName { get; set; }
        public string LayerName { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }

        public static LoggingTime PerformanceTimeStart(
            string commandName
            ) {

            var log = new LoggingTime();
            log.MethodName = commandName;
            log.StopWatch = new Stopwatch();
            log.StopWatch.Start();

            return log;
        }

        public static LoggingTime PerformanceTimeStart(
            string domainName,
            string layerName,
            string className,
            string methodName,
            Guid? userId = null
            ) {

            var log = new LoggingTime();
            log.DomainName = domainName;
            log.LayerName = layerName;
            log.ClassName = className;
            log.MethodName = methodName;

            if ( userId != null )
                log.UserId = ( Guid ) userId;

            log.StopWatch = new Stopwatch();
            log.StopWatch.Start();

            return log;
        }

        public void PerformanceTimeStop(
            ) {
            PerformanceTimeStop(logIfMoreThanMilliseconds: 100);
        }

        public void PerformanceTimeStop(
            int logIfMoreThanMilliseconds
            ) {
            StopWatch.Stop();
        }
    }
}
