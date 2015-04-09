using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductSearchByCategoryType3 {
        
        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3FromDal(List<norpim.DataAccessLayer.ProductSearchByCategoryType3> dataList) {
           var list = new List<ProductSearchByCategoryType3Contract>();

           foreach (norpim.DataAccessLayer.ProductSearchByCategoryType3 data in dataList) {
               var contract = new ProductSearchByCategoryType3Contract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductSearchByCategoryType3 dalProductSearchByCategoryType3, ProductSearchByCategoryType3Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType3.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType3.ProductName;
            dataContract.Gtin = dalProductSearchByCategoryType3.Gtin;
            dataContract.Hn = dalProductSearchByCategoryType3.Hn;
            dataContract.Color = dalProductSearchByCategoryType3.Color;
        }
    }
    
    [DataContract()]
    public class ProductSearchByCategoryType3Contract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string Gtin { get; set; } //;
        
        [DataMember()]
        public string Hn { get; set; } //;
        
        [DataMember()]
        public string Color { get; set; } //;
    }
}
