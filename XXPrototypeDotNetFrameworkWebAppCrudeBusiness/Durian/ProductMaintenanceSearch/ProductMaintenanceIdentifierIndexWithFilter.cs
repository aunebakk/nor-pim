/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:53:45 AM
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public class ProductMaintenanceIdentifierIndexWithFilter {
        
        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilterFromDal(List<ProductMaintenanceIdentifierIndexWithFilterData> dataList) {
           var list = new List<ProductMaintenanceIdentifierIndexWithFilterContract>();

           foreach (ProductMaintenanceIdentifierIndexWithFilterData data in dataList) {
               var contract = new ProductMaintenanceIdentifierIndexWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductMaintenanceIdentifierIndexWithFilterData dalProductMaintenanceIdentifierIndexWithFilter, ProductMaintenanceIdentifierIndexWithFilterContract dataContract) {
            dataContract.ProductName = dalProductMaintenanceIdentifierIndexWithFilter.ProductName;
            dataContract.StateRcd = dalProductMaintenanceIdentifierIndexWithFilter.StateRcd;
            dataContract.ProductIdentifierName = dalProductMaintenanceIdentifierIndexWithFilter.ProductIdentifierName;
            dataContract.DefaultUserName = dalProductMaintenanceIdentifierIndexWithFilter.DefaultUserName;
            dataContract.ProductId = dalProductMaintenanceIdentifierIndexWithFilter.ProductId;
            dataContract.ProductIdentifierRcd = dalProductMaintenanceIdentifierIndexWithFilter.ProductIdentifierRcd;
            dataContract.Identifier = dalProductMaintenanceIdentifierIndexWithFilter.Identifier;
            dataContract.UserId = dalProductMaintenanceIdentifierIndexWithFilter.UserId;
            dataContract.DateTime = dalProductMaintenanceIdentifierIndexWithFilter.DateTime;
            dataContract.ProductIdentifierId = dalProductMaintenanceIdentifierIndexWithFilter.ProductIdentifierId;
        }
    }
}
