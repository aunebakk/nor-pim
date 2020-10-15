/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 5:40:56 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductMaintenanceAttributeIndexWithFilter {
        
        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilterFromDal(List<ProductMaintenanceAttributeIndexWithFilterData> dataList) {
           var list = new List<ProductMaintenanceAttributeIndexWithFilterContract>();

           foreach (ProductMaintenanceAttributeIndexWithFilterData data in dataList) {
               var contract = new ProductMaintenanceAttributeIndexWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductMaintenanceAttributeIndexWithFilterData dalProductMaintenanceAttributeIndexWithFilter, ProductMaintenanceAttributeIndexWithFilterContract dataContract) {
            dataContract.ProductName = dalProductMaintenanceAttributeIndexWithFilter.ProductName;
            dataContract.StateRcd = dalProductMaintenanceAttributeIndexWithFilter.StateRcd;
            dataContract.ProductAttributeName = dalProductMaintenanceAttributeIndexWithFilter.ProductAttributeName;
            dataContract.ProductAttributeUnitName = dalProductMaintenanceAttributeIndexWithFilter.ProductAttributeUnitName;
            dataContract.DefaultUserName = dalProductMaintenanceAttributeIndexWithFilter.DefaultUserName;
            dataContract.ProductId = dalProductMaintenanceAttributeIndexWithFilter.ProductId;
            dataContract.ProductAttributeRcd = dalProductMaintenanceAttributeIndexWithFilter.ProductAttributeRcd;
            dataContract.ProductAttributeUnitRcd = dalProductMaintenanceAttributeIndexWithFilter.ProductAttributeUnitRcd;
            dataContract.Value = dalProductMaintenanceAttributeIndexWithFilter.Value;
            dataContract.UserId = dalProductMaintenanceAttributeIndexWithFilter.UserId;
            dataContract.DateTime = dalProductMaintenanceAttributeIndexWithFilter.DateTime;
            dataContract.ProductAttributeId = dalProductMaintenanceAttributeIndexWithFilter.ProductAttributeId;
        }
    }
}
