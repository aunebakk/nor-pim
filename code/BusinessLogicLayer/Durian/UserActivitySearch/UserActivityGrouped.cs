using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class UserActivityGrouped {
        
        public List<UserActivityGroupedContract> UserActivityGroupedFromDal(List<norpim.DataAccessLayer.UserActivityGrouped> dataList) {
           var list = new List<UserActivityGroupedContract>();

           foreach (norpim.DataAccessLayer.UserActivityGrouped data in dataList) {
               var contract = new UserActivityGroupedContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.UserActivityGrouped dalUserActivityGrouped, UserActivityGroupedContract dataContract) {
            dataContract.OriginatingAddress = dalUserActivityGrouped.OriginatingAddress;
            dataContract.UserActivityTypeName = dalUserActivityGrouped.UserActivityTypeName;
            dataContract.UserActivityNote = dalUserActivityGrouped.UserActivityNote;
            dataContract.Occurrences = dalUserActivityGrouped.Occurrences;
        }
    }
    
    [DataContract()]
    public class UserActivityGroupedContract {
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
        
        [DataMember()]
        public string UserActivityTypeName { get; set; } //;
        
        [DataMember()]
        public string UserActivityNote { get; set; } //;
        
        [DataMember()]
        public int Occurrences { get; set; } //;
    }
}
