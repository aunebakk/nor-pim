using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class UserActivityGroupedByAddress {
        
        public List<UserActivityGroupedByAddressContract> UserActivityGroupedByAddressFromDal(List<norpim.DataAccessLayer.UserActivityGroupedByAddress> dataList) {
           var list = new List<UserActivityGroupedByAddressContract>();

           foreach (norpim.DataAccessLayer.UserActivityGroupedByAddress data in dataList) {
               var contract = new UserActivityGroupedByAddressContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.UserActivityGroupedByAddress dalUserActivityGroupedByAddress, UserActivityGroupedByAddressContract dataContract) {
            dataContract.OriginatingAddress = dalUserActivityGroupedByAddress.OriginatingAddress;
            dataContract.Occurrences = dalUserActivityGroupedByAddress.Occurrences;
        }
    }
    
    [DataContract()]
    public class UserActivityGroupedByAddressContract {
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
        
        [DataMember()]
        public int Occurrences { get; set; } //;
    }
}
