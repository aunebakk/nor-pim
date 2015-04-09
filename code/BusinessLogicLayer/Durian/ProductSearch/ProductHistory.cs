using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductHistory {
        
        public List<ProductHistoryContract> ProductHistoryFromDal(List<norpim.DataAccessLayer.ProductHistory> dataList) {
           var list = new List<ProductHistoryContract>();

           foreach (norpim.DataAccessLayer.ProductHistory data in dataList) {
               var contract = new ProductHistoryContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductHistory dalProductHistory, ProductHistoryContract dataContract) {
            dataContract.ProductId = dalProductHistory.ProductId;
            dataContract.ProductName = dalProductHistory.ProductName;
            dataContract.StateName = dalProductHistory.StateName;
            dataContract.DateTime = dalProductHistory.DateTime;
            dataContract.UserName = dalProductHistory.UserName;
            dataContract.ProductBecameId = dalProductHistory.ProductBecameId;
        }
    }
    
    [DataContract()]
    public class ProductHistoryContract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string StateName { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string UserName { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductBecameId { get; set; } //;
    }
}
