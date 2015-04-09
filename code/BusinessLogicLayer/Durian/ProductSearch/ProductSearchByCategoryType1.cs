using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductSearchByCategoryType1 {
        
        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1FromDal(List<norpim.DataAccessLayer.ProductSearchByCategoryType1> dataList) {
           var list = new List<ProductSearchByCategoryType1Contract>();

           foreach (norpim.DataAccessLayer.ProductSearchByCategoryType1 data in dataList) {
               var contract = new ProductSearchByCategoryType1Contract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductSearchByCategoryType1 dalProductSearchByCategoryType1, ProductSearchByCategoryType1Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType1.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType1.ProductName;
            dataContract.Gtin = dalProductSearchByCategoryType1.Gtin;
            dataContract.Color = dalProductSearchByCategoryType1.Color;
        }
    }
    
    [DataContract()]
    public class ProductSearchByCategoryType1Contract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string Gtin { get; set; } //;
        
        [DataMember()]
        public string Color { get; set; } //;
    }
}
