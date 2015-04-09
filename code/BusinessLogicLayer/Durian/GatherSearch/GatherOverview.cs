using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class GatherOverview {
        
        public List<GatherOverviewContract> GatherOverviewFromDal(List<norpim.DataAccessLayer.GatherOverview> dataList) {
           var list = new List<GatherOverviewContract>();

           foreach (norpim.DataAccessLayer.GatherOverview data in dataList) {
               var contract = new GatherOverviewContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.GatherOverview dalGatherOverview, GatherOverviewContract dataContract) {
            dataContract.ProductGatherId = dalGatherOverview.ProductGatherId;
            dataContract.StartDateTime = dalGatherOverview.StartDateTime;
            dataContract.FinishDateTime = dalGatherOverview.FinishDateTime;
            dataContract.ProductGatherSourceTypeRcd = dalGatherOverview.ProductGatherSourceTypeRcd;
            dataContract.ProductGatherSourceTypeName = dalGatherOverview.ProductGatherSourceTypeName;
            dataContract.KeyCount = dalGatherOverview.KeyCount;
            dataContract.UserName = dalGatherOverview.UserName;
            dataContract.DateTime = dalGatherOverview.DateTime;
        }
    }
    
    [DataContract()]
    public class GatherOverviewContract {
        
        [DataMember()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [DataMember()]
        public System.DateTime StartDateTime { get; set; } //;
        
        [DataMember()]
        public System.DateTime FinishDateTime { get; set; } //;
        
        [DataMember()]
        public string ProductGatherSourceTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductGatherSourceTypeName { get; set; } //;
        
        [DataMember()]
        public int KeyCount { get; set; } //;
        
        [DataMember()]
        public string UserName { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
