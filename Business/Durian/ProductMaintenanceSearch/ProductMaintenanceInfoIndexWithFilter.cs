/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:22:32 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductMaintenanceInfoIndexWithFilter {
        
        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilterFromDal(List<ProductMaintenanceInfoIndexWithFilterData> dataList) {
           var list = new List<ProductMaintenanceInfoIndexWithFilterContract>();

           foreach (ProductMaintenanceInfoIndexWithFilterData data in dataList) {
               var contract = new ProductMaintenanceInfoIndexWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductMaintenanceInfoIndexWithFilterData dalProductMaintenanceInfoIndexWithFilter, ProductMaintenanceInfoIndexWithFilterContract dataContract) {
            dataContract.ProductName = dalProductMaintenanceInfoIndexWithFilter.ProductName;
            dataContract.StateRcd = dalProductMaintenanceInfoIndexWithFilter.StateRcd;
            dataContract.ProductInfoName = dalProductMaintenanceInfoIndexWithFilter.ProductInfoName;
            dataContract.DefaultUserName = dalProductMaintenanceInfoIndexWithFilter.DefaultUserName;
            dataContract.ProductId = dalProductMaintenanceInfoIndexWithFilter.ProductId;
            dataContract.ProductInfoRcd = dalProductMaintenanceInfoIndexWithFilter.ProductInfoRcd;
            dataContract.ProductInfoValue = dalProductMaintenanceInfoIndexWithFilter.ProductInfoValue;
            dataContract.UserId = dalProductMaintenanceInfoIndexWithFilter.UserId;
            dataContract.DateTime = dalProductMaintenanceInfoIndexWithFilter.DateTime;
            dataContract.ProductInfoId = dalProductMaintenanceInfoIndexWithFilter.ProductInfoId;
        }
    }
}
