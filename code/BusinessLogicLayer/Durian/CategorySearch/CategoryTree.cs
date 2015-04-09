using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class CategoryTree {
        
        public List<CategoryTreeContract> CategoryTreeFromDal(List<norpim.DataAccessLayer.CategoryTree> dataList) {
           var list = new List<CategoryTreeContract>();

           foreach (norpim.DataAccessLayer.CategoryTree data in dataList) {
               var contract = new CategoryTreeContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.CategoryTree dalCategoryTree, CategoryTreeContract dataContract) {
            dataContract.ProductCategoryId = dalCategoryTree.ProductCategoryId;
            dataContract.ProductCategoryParentId = dalCategoryTree.ProductCategoryParentId;
            dataContract.ProductCategoryCode = dalCategoryTree.ProductCategoryCode;
            dataContract.ProductCategoryName = dalCategoryTree.ProductCategoryName;
        }
    }
    
    [DataContract()]
    public class CategoryTreeContract {
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryParentId { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryCode { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryName { get; set; } //;
    }
}
