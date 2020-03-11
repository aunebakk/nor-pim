/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:53:01 PM
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public class CategoryTree {
        
        public List<CategoryTreeContract> CategoryTreeFromDal(List<CategoryTreeData> dataList) {
           var list = new List<CategoryTreeContract>();

           foreach (CategoryTreeData data in dataList) {
               var contract = new CategoryTreeContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(CategoryTreeData dalCategoryTree, CategoryTreeContract dataContract) {
            dataContract.ProductCategoryId = dalCategoryTree.ProductCategoryId;
            dataContract.ProductCategoryParentId = dalCategoryTree.ProductCategoryParentId;
            dataContract.ProductCategoryCode = dalCategoryTree.ProductCategoryCode;
            dataContract.ProductCategoryName = dalCategoryTree.ProductCategoryName;
        }
    }
}
