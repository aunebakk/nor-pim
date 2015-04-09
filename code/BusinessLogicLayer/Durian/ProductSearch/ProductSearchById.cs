using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductSearchById {
        
        public ProductSearchByIdContract ProductSearchByIdFromDal(norpim.DataAccessLayer.ProductSearchById data) {
            var contract = new ProductSearchByIdContract();
            CopyDalToContract(data, contract);

            return contract;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductSearchById dalProductSearchById, ProductSearchByIdContract dataContract) {
            dataContract.ProductName = dalProductSearchById.ProductName;
            dataContract.Identifier = dalProductSearchById.Identifier;
            dataContract.Value = dalProductSearchById.Value;
            dataContract.ProductInfoValue = dalProductSearchById.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchById.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchById.ProductImageTypeName;
            dataContract.Image = dalProductSearchById.Image;
        }
    }
    
    [DataContract()]
    public class ProductSearchByIdContract {
        
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
