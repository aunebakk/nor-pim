/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:54:25 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductMaintenanceImageIndexWithFilter {
        
        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilterFromDal(List<ProductMaintenanceImageIndexWithFilterData> dataList) {
           var list = new List<ProductMaintenanceImageIndexWithFilterContract>();

           foreach (ProductMaintenanceImageIndexWithFilterData data in dataList) {
               var contract = new ProductMaintenanceImageIndexWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductMaintenanceImageIndexWithFilterData dalProductMaintenanceImageIndexWithFilter, ProductMaintenanceImageIndexWithFilterContract dataContract) {
            dataContract.ProductName = dalProductMaintenanceImageIndexWithFilter.ProductName;
            dataContract.StateRcd = dalProductMaintenanceImageIndexWithFilter.StateRcd;
            dataContract.ProductImageTypeName = dalProductMaintenanceImageIndexWithFilter.ProductImageTypeName;
            dataContract.ImageFileName = dalProductMaintenanceImageIndexWithFilter.ImageFileName;
            dataContract.DefaultUserName = dalProductMaintenanceImageIndexWithFilter.DefaultUserName;
            dataContract.ProductId = dalProductMaintenanceImageIndexWithFilter.ProductId;
            dataContract.ProductImageTypeRcd = dalProductMaintenanceImageIndexWithFilter.ProductImageTypeRcd;
            dataContract.Image = dalProductMaintenanceImageIndexWithFilter.Image;
            dataContract.UserId = dalProductMaintenanceImageIndexWithFilter.UserId;
            dataContract.DateTime = dalProductMaintenanceImageIndexWithFilter.DateTime;
            dataContract.ProductImageId = dalProductMaintenanceImageIndexWithFilter.ProductImageId;
        }
    }
}
