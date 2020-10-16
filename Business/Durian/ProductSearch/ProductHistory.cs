/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:31 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductHistory {

        public List<ProductHistoryContract> ProductHistoryFromDal(List<ProductHistoryData> dataList) {
            List<ProductHistoryContract> list = new List<ProductHistoryContract>();

            foreach (ProductHistoryData data in dataList) {
                ProductHistoryContract contract = new ProductHistoryContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductHistoryData dalProductHistory, ProductHistoryContract dataContract) {
            dataContract.ProductId = dalProductHistory.ProductId;
            dataContract.ProductName = dalProductHistory.ProductName;
            dataContract.StateName = dalProductHistory.StateName;
            dataContract.DateTime = dalProductHistory.DateTime;
            dataContract.UserName = dalProductHistory.UserName;
            dataContract.ProductBecameId = dalProductHistory.ProductBecameId;
        }
    }
}
