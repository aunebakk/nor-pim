using System;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Transactions;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    [ServiceContract()]
    public interface IActivityService {
        /// <summary>
        /// Add an activity
        /// </summary>
        /// <param name="userId">User who triggered the activity</param>
        [OperationContract()]
        void AddActivity(Guid userId, string userActivityTypeRcd, string activityNote);
        
        [OperationContract()]
        void DeleteAll();

        [OperationContract()]
        Guid Login(string userCode);
    }

    /// <domain>User</domain>
    /// <namespace>norpim.BusinessLogicLayer.Other</namespace>
    public class ActivityService : IActivityService {
        public void AddActivity(Guid userId, 
                                string userActivityTypeRcd, 
                                string activityNote
                                ) {
            var contract = new CrudeUserActivityContract();

            contract.UserActivityTypeRcd = userActivityTypeRcd;
            contract.UserActivityNote = activityNote;
            contract.
            contract.UserId = userId;
            contract.DateTime = DateTime.UtcNow;

            var bll = new CrudeUserActivityService();

            bll.Insert(contract);
        }

        public void DeleteAll() {
            var dalActivity = new norpim.DataAccessLayer.UserActivity();

            // delete all activities
            dalActivity.DeleteAllActivities();
        }

        public Guid Login(string userCode) {

            var dalUser = new CrudeUserData();
            dalUser.FetchByUserCode(userCode);

            // insert if not existing
            if (dalUser.UserId == Guid.Empty) { 
                dalUser.UserId = new Guid();
                dalUser.UserCode = userCode;
                dalUser.UserName = userCode;

                dalUser.StateRcd = StateRef.Created;
                dalUser.DateTime = DateTime.UtcNow;
                dalUser.CreatedByUserId = new Guid("FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF");
                dalUser.Insert();
                
                AddActivity(dalUser.UserId,
                            UserActivityTypeRef.Login,
                            "New user: " + dalUser.UserName
                            );

            } else { 
                AddActivity(dalUser.UserId,
                            UserActivityTypeRef.Login,
                            dalUser.UserName
                            );
            }

            return dalUser.UserId;
        }
    }
}
