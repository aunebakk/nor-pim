using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductSearchByCategoryType2 {
        
        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2FromDal(List<norpim.DataAccessLayer.ProductSearchByCategoryType2> dataList) {
           var list = new List<ProductSearchByCategoryType2Contract>();

           foreach (norpim.DataAccessLayer.ProductSearchByCategoryType2 data in dataList) {
               var contract = new ProductSearchByCategoryType2Contract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductSearchByCategoryType2 dalProductSearchByCategoryType2, ProductSearchByCategoryType2Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType2.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType2.ProductName;
            dataContract.Gtin = dalProductSearchByCategoryType2.Gtin;
            dataContract.Hn = dalProductSearchByCategoryType2.Hn;
            dataContract.Color = dalProductSearchByCategoryType2.Color;
        }
    }
    
    [DataContract()]
    public class ProductSearchByCategoryType2Contract {
        
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
