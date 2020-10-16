/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:03:06 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductSearchByCategoryType2 {

        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2FromDal(List<ProductSearchByCategoryType2Data> dataList) {
            List<ProductSearchByCategoryType2Contract> list = new List<ProductSearchByCategoryType2Contract>();

            foreach (ProductSearchByCategoryType2Data data in dataList) {
                ProductSearchByCategoryType2Contract contract = new ProductSearchByCategoryType2Contract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductSearchByCategoryType2Data dalProductSearchByCategoryType2, ProductSearchByCategoryType2Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType2.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType2.ProductName;
            dataContract.Gtin13 = dalProductSearchByCategoryType2.Gtin13;
            dataContract.Hn = dalProductSearchByCategoryType2.Hn;
            dataContract.Color = dalProductSearchByCategoryType2.Color;
        }
    }
}
