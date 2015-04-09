using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductSearchByName {
        
        public List<ProductSearchByNameContract> ProductSearchByNameFromDal(List<norpim.DataAccessLayer.ProductSearchByName> dataList) {
           var list = new List<ProductSearchByNameContract>();

           foreach (norpim.DataAccessLayer.ProductSearchByName data in dataList) {
               var contract = new ProductSearchByNameContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductSearchByName dalProductSearchByName, ProductSearchByNameContract dataContract) {
            dataContract.ProductId = dalProductSearchByName.ProductId;
            dataContract.ProductName = dalProductSearchByName.ProductName;
            dataContract.Identifier = dalProductSearchByName.Identifier;
            dataContract.Value = dalProductSearchByName.Value;
            dataContract.ProductInfoValue = dalProductSearchByName.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchByName.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchByName.ProductImageTypeName;
            dataContract.Image = dalProductSearchByName.Image;
        }
    }
    
    [DataContract()]
    public class ProductSearchByNameContract {
        
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
