/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:03:12 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductSearchByCategoryType3 {

        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3FromDal(List<ProductSearchByCategoryType3Data> dataList) {
            List<ProductSearchByCategoryType3Contract> list = new List<ProductSearchByCategoryType3Contract>();

            foreach (ProductSearchByCategoryType3Data data in dataList) {
                ProductSearchByCategoryType3Contract contract = new ProductSearchByCategoryType3Contract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductSearchByCategoryType3Data dalProductSearchByCategoryType3, ProductSearchByCategoryType3Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType3.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType3.ProductName;
            dataContract.Gtin13 = dalProductSearchByCategoryType3.Gtin13;
            dataContract.Hn = dalProductSearchByCategoryType3.Hn;
            dataContract.Color = dalProductSearchByCategoryType3.Color;
        }
    }
}
