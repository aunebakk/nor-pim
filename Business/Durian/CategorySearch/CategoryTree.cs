/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:20 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class CategoryTree {

        public List<CategoryTreeContract> CategoryTreeFromDal(List<CategoryTreeData> dataList) {
            List<CategoryTreeContract> list = new List<CategoryTreeContract>();

            foreach (CategoryTreeData data in dataList) {
                CategoryTreeContract contract = new CategoryTreeContract();
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
