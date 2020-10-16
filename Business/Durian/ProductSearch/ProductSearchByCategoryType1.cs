/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:03:00 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductSearchByCategoryType1 {

        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1FromDal(List<ProductSearchByCategoryType1Data> dataList) {
            List<ProductSearchByCategoryType1Contract> list = new List<ProductSearchByCategoryType1Contract>();

            foreach (ProductSearchByCategoryType1Data data in dataList) {
                ProductSearchByCategoryType1Contract contract = new ProductSearchByCategoryType1Contract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductSearchByCategoryType1Data dalProductSearchByCategoryType1, ProductSearchByCategoryType1Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType1.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType1.ProductName;
            dataContract.Gtin13 = dalProductSearchByCategoryType1.Gtin13;
            dataContract.Color = dalProductSearchByCategoryType1.Color;
        }
    }
}
