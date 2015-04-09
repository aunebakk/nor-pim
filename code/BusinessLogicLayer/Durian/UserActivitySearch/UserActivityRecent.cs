using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class UserActivityRecent {
        
        public List<UserActivityRecentContract> UserActivityRecentFromDal(List<norpim.DataAccessLayer.UserActivityRecent> dataList) {
           var list = new List<UserActivityRecentContract>();

           foreach (norpim.DataAccessLayer.UserActivityRecent data in dataList) {
               var contract = new UserActivityRecentContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.UserActivityRecent dalUserActivityRecent, UserActivityRecentContract dataContract) {
            dataContract.DateTime = dalUserActivityRecent.DateTime;
            dataContract.UserActivityTypeName = dalUserActivityRecent.UserActivityTypeName;
            dataContract.OriginatingAddress = dalUserActivityRecent.OriginatingAddress;
            dataContract.UserActivityNote = dalUserActivityRecent.UserActivityNote;
        }
    }
    
    [DataContract()]
    public class UserActivityRecentContract {
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string UserActivityTypeName { get; set; } //;
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
        
        [DataMember()]
        public string UserActivityNote { get; set; } //;
    }
}
