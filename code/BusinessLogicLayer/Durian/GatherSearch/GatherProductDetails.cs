using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class GatherProductDetails {
        
        public List<GatherProductDetailsContract> GatherProductDetailsFromDal(List<norpim.DataAccessLayer.GatherProductDetails> dataList) {
           var list = new List<GatherProductDetailsContract>();

           foreach (norpim.DataAccessLayer.GatherProductDetails data in dataList) {
               var contract = new GatherProductDetailsContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.GatherProductDetails dalGatherProductDetails, GatherProductDetailsContract dataContract) {
            dataContract.ProductId = dalGatherProductDetails.ProductId;
            dataContract.ProductGatherKeyValue = dalGatherProductDetails.ProductGatherKeyValue;
            dataContract.ProductName = dalGatherProductDetails.ProductName;
            dataContract.ProductCategoryName = dalGatherProductDetails.ProductCategoryName;
            dataContract.ProductUserName = dalGatherProductDetails.ProductUserName;
            dataContract.ProductDateTime = dalGatherProductDetails.ProductDateTime;
            dataContract.ProductStateName = dalGatherProductDetails.ProductStateName;
        }
    }
    
    [DataContract()]
    public class GatherProductDetailsContract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductGatherKeyValue { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryName { get; set; } //;
        
        [DataMember()]
        public string ProductUserName { get; set; } //;
        
        [DataMember()]
        public System.DateTime ProductDateTime { get; set; } //;
        
        [DataMember()]
        public string ProductStateName { get; set; } //;
    }
}
