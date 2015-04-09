using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductSearchByCategory {
        
        public List<ProductSearchByCategoryContract> ProductSearchByCategoryFromDal(List<norpim.DataAccessLayer.ProductSearchByCategory> dataList) {
           var list = new List<ProductSearchByCategoryContract>();

           foreach (norpim.DataAccessLayer.ProductSearchByCategory data in dataList) {
               var contract = new ProductSearchByCategoryContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductSearchByCategory dalProductSearchByCategory, ProductSearchByCategoryContract dataContract) {
            dataContract.ProductId = dalProductSearchByCategory.ProductId;
            dataContract.ProductName = dalProductSearchByCategory.ProductName;
            dataContract.Identifier = dalProductSearchByCategory.Identifier;
            dataContract.Value = dalProductSearchByCategory.Value;
            dataContract.ProductInfoValue = dalProductSearchByCategory.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchByCategory.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchByCategory.ProductImageTypeName;
            dataContract.Image = dalProductSearchByCategory.Image;
        }
    }
    
    [DataContract()]
    public class ProductSearchByCategoryContract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string Identifier { get; set; } //;
        
        [DataMember()]
        public string Value { get; set; } //;
        
        [DataMember()]
        public string ProductInfoValue { get; set; } //;
        
        [DataMember()]
        public string ProductImageTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductImageTypeName { get; set; } //;
        
        [DataMember()]
        public byte[] Image { get; set; } //;
    }
}
