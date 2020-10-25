using SolutionNorSolutionPim.DataAccessLayer;
using System;
using System.IO;
using System.Net;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public interface IDefaultUserActivityService {
        [OperationContract()]
        string ResolveNetnameFromIpV4(
            string ipAddress
            );

        [OperationContract()]
        void AddActivity(
            Guid userId,
            string userActivityTypeRcd,
            string activityNote,
            string originatingAddress
            );

        [OperationContract()]
        Guid Login(
            string userCode
            );

        [OperationContract()]
        Guid LoginOverrideUserName(
            string userCode
            );
    }

    /// <domain>User</domain>
    /// <namespace>SolutionNorSolutionPim.BusinessLogicLayer</namespace>
    public class DefaultUserActivityService : IDefaultUserActivityService {

        /// <summary>
        /// get netname from whois based on ipv4 address
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns>netname</returns>
        public string ResolveNetnameFromIpV4(
            string ipAddress
            ) {

            Stream stream = null;
            StreamReader reader = null;
            string netname = string.Empty;
            const string lookFor = "netname:";

            try {
                string url = "http://www.whois.com/whois/" + ipAddress;
                WebRequest webRequest = WebRequest.Create(url);
                stream = webRequest.GetResponse().GetResponseStream();
                reader = new StreamReader(stream);

                string line = string.Empty;
                while (line != null) {
                    line = reader.ReadLine();
                    if (line != null && line.ToLower().StartsWith(lookFor)) {
                        netname = line.Substring(lookFor.Length + 1).Trim();
                    }
                }

            } catch (Exception ex) {
                // todo, what happens with WCF here?
                throw new Exception("ResolveNetnameFromIpV4 failed", ex);
            } finally {
                reader.Close();
                stream.Close();
            }

            return netname;
        }

        /// <summary>
        /// Add an activity
        /// </summary>
        /// <param name="userId">User who triggered the activity</param>
        public void AddActivity(
            Guid userId,
            string userActivityTypeRcd,
            string activityNote,
            string originatingAddress
            ) {

            CrudeDefaultUserActivityData defaultUserActivity = new CrudeDefaultUserActivityData {
                DefaultUserActivityId = Guid.NewGuid(),
                DefaultUserActivityTypeRcd = userActivityTypeRcd,
                UserActivityNote = activityNote,
                OriginatingAddress = originatingAddress,
                DefaultUserId = userId,
                DateTime = DateTime.UtcNow
            };
            defaultUserActivity.Insert();

            CrudeDefaultUserData defaultUser = new CrudeDefaultUserData();
            defaultUser.FetchByDefaultUserId(userId);
            defaultUser.LastActivityDateTime = DateTime.UtcNow;
            defaultUser.Update(); // todo, possible to only update LastActivityDateTime?
        }

        /// <summary>
        /// Login a user and log the activity
        /// </summary>
        /// <param name="userCode">IP address will be resolved to whois netname, valid usercode stays</param>
        /// <returns>Internal user id</returns>
        public Guid Login(
            string userCode
            ) {
            return Login(
                userCode: userCode,
                overrideUserName: false
                );
        }

        /// <summary>
        /// Login a user and log the activity
        /// </summary>
        /// <param name="userCode">IP address will be resolved to whois netname, valid usercode stays</param>
        /// <returns>Internal user id</returns>
        public Guid LoginOverrideUserName(
            string userCode
            ) {
            return Login(
                userCode: userCode,
                overrideUserName: true
                );
        }

        /// <summary>
        /// Login a user and log the activity
        /// </summary>
        /// <param name="userCode">IP address will be resolved to whois netname, valid usercode stays</param>
        /// <returns>Internal user id</returns>
        public Guid Login(
            string userCode,
            bool overrideUserName
            ) {

            CrudeDefaultUserData defaultUser = new CrudeDefaultUserData();

            try {
                defaultUser.FetchByDefaultUserName(userCode);

                // insert if not existing
                if (defaultUser.DefaultUserId == Guid.Empty) {
                    defaultUser.DefaultUserId = new Guid();
                    defaultUser.DefaultUserCode = userCode;

                    // resolve net-name if user code appears to be an ip address
                    IPAddress ipAddress;
                    if (IPAddress.TryParse(userCode, out ipAddress)) {
                        defaultUser.DefaultUserName = ResolveNetnameFromIpV4(userCode);

                        // use ip user code if no net-name found
                        if (string.IsNullOrEmpty(defaultUser.DefaultUserName)) {
                            defaultUser.DefaultUserName = userCode;
                        }
                    } else {
                        // not an ip address, username is usercode
                        defaultUser.DefaultUserName = userCode;
                    }

                    defaultUser.DefaultStateRcd = DefaultStateRef.Created;
                    defaultUser.DateTime = DateTime.UtcNow;
                    defaultUser.CreatedByDefaultUserId = new Guid("FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF");
                    defaultUser.Insert();

                    AddActivity(
                        defaultUser.DefaultUserId,
                        DefaultUserActivityTypeRef.Login,
                        "New user: " + defaultUser.DefaultUserName,
                        "Internal"
                        );

                } else {
                    // resolve net-name if user name appears to be an ip address
                    // or an averride is asked for
                    IPAddress ipAddress;
                    if (IPAddress.TryParse(defaultUser.DefaultUserName, out ipAddress)
                        || overrideUserName
                        ) {
                        string netName = ResolveNetnameFromIpV4(userCode);

                        // use new net-name if found
                        if (!string.IsNullOrEmpty(netName)) {

                            // a new net name was found, use that instead of ip address
                            defaultUser.DefaultUserName = netName;
                            defaultUser.DefaultStateRcd = DefaultStateRef.Updated;
                            defaultUser.DateTime = DateTime.UtcNow;
                            defaultUser.Update();

                            AddActivity(
                                defaultUser.DefaultUserId,
                                DefaultUserActivityTypeRef.Login,
                                "Resolved user name: "
                                    + defaultUser.DefaultUserName
                                    + " from IP address: "
                                    + userCode,
                                "Internal"
                                );

                        }
                    }
                }

                AddActivity(
                    defaultUser.DefaultUserId,
                    DefaultUserActivityTypeRef.Login,
                    defaultUser.DefaultUserName,
                    "Internal"
                    );

            } catch (Exception ex) {
                // todo, what happens with WCF here?
                throw new Exception("Login failed", ex);
            }

            return defaultUser.DefaultUserId;
        }
    }
}
