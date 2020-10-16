/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:26 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class CategoryFind {

        public List<CategoryFindContract> CategoryFindFromDal(List<CategoryFindData> dataList) {
            List<CategoryFindContract> list = new List<CategoryFindContract>();

            foreach (CategoryFindData data in dataList) {
                CategoryFindContract contract = new CategoryFindContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(CategoryFindData dalCategoryFind, CategoryFindContract dataContract) {
            dataContract.ProductCategoryCode = dalCategoryFind.ProductCategoryCode;
            dataContract.ProductName = dalCategoryFind.ProductName;
            dataContract.ProductCategoryId = dalCategoryFind.ProductCategoryId;
            dataContract.ProductId = dalCategoryFind.ProductId;
        }
    }
}
