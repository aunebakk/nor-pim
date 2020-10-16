/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:50 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductSearchByCategory {

        public List<ProductSearchByCategoryContract> ProductSearchByCategoryFromDal(List<ProductSearchByCategoryData> dataList) {
            List<ProductSearchByCategoryContract> list = new List<ProductSearchByCategoryContract>();

            foreach (ProductSearchByCategoryData data in dataList) {
                ProductSearchByCategoryContract contract = new ProductSearchByCategoryContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductSearchByCategoryData dalProductSearchByCategory, ProductSearchByCategoryContract dataContract) {
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
}
