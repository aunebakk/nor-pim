using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ExposeProductDetails {
        
        public List<ExposeProductDetailsContract> ExposeProductDetailsFromDal(List<norpim.DataAccessLayer.ExposeProductDetails> dataList) {
           var list = new List<ExposeProductDetailsContract>();

           foreach (norpim.DataAccessLayer.ExposeProductDetails data in dataList) {
               var contract = new ExposeProductDetailsContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ExposeProductDetails dalExposeProductDetails, ExposeProductDetailsContract dataContract) {
            dataContract.ExposeProductId = dalExposeProductDetails.ExposeProductId;
            dataContract.ProductName = dalExposeProductDetails.ProductName;
            dataContract.ProductCategoryName = dalExposeProductDetails.ProductCategoryName;
            dataContract.ProductUserName = dalExposeProductDetails.ProductUserName;
            dataContract.ProductDateTime = dalExposeProductDetails.ProductDateTime;
            dataContract.ProductStateName = dalExposeProductDetails.ProductStateName;
        }
    }
    
    [DataContract()]
    public class ExposeProductDetailsContract {
        
        [DataMember()]
        public System.Guid ExposeProductId { get; set; } //;
        
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
