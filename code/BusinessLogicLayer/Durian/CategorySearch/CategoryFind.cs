using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class CategoryFind {
        
        public List<CategoryFindContract> CategoryFindFromDal(List<norpim.DataAccessLayer.CategoryFind> dataList) {
           var list = new List<CategoryFindContract>();

           foreach (norpim.DataAccessLayer.CategoryFind data in dataList) {
               var contract = new CategoryFindContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.CategoryFind dalCategoryFind, CategoryFindContract dataContract) {
            dataContract.ProductCategoryCode = dalCategoryFind.ProductCategoryCode;
            dataContract.ProductName = dalCategoryFind.ProductName;
            dataContract.ProductCategoryId = dalCategoryFind.ProductCategoryId;
            dataContract.ProductId = dalCategoryFind.ProductId;
        }
    }
    
    [DataContract()]
    public class CategoryFindContract {
        
        [DataMember()]
        public string ProductCategoryCode { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
    }
}
