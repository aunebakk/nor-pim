/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:14:51 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductHistory {
        
        public List<ProductHistoryContract> ProductHistoryFromDal(List<ProductHistoryData> dataList) {
           var list = new List<ProductHistoryContract>();

           foreach (ProductHistoryData data in dataList) {
               var contract = new ProductHistoryContract();
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
