using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.BusinessLogicLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public interface IUserActivitySearchService {
        [OperationContract()]
        List<UserActivityRecentContract> UserActivityRecent();

        [OperationContract()]
        List<UserActivityGroupedContract> UserActivityGrouped();

        [OperationContract()]
        List<UserActivityGroupedByAddressContract> UserActivityGroupedByAddress();
    }
    
    public class UserActivitySearchService : IUserActivitySearchService {
        public List<UserActivityRecentContract> UserActivityRecent() {
            var dataAccessLayer = new norpim.DataAccessLayer.UserActivitySearch();
            var businessLogicLayer = new UserActivityRecent();
            return businessLogicLayer.UserActivityRecentFromDal(dataAccessLayer.UserActivityRecent());
        }

        public List<UserActivityGroupedContract> UserActivityGrouped() {
            var dataAccessLayer = new norpim.DataAccessLayer.UserActivitySearch();
            var businessLogicLayer = new UserActivityGrouped();
            return businessLogicLayer.UserActivityGroupedFromDal(dataAccessLayer.UserActivityGrouped());
        }

        public List<UserActivityGroupedByAddressContract> UserActivityGroupedByAddress() {
            var dataAccessLayer = new norpim.DataAccessLayer.UserActivitySearch();
            var businessLogicLayer = new UserActivityGroupedByAddress();
            return businessLogicLayer.UserActivityGroupedByAddressFromDal(dataAccessLayer.UserActivityGroupedByAddress());
        }
    }
}
