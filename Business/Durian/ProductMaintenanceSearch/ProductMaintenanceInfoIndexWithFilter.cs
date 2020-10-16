/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:04:44 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductMaintenanceInfoIndexWithFilter {

        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilterFromDal(List<ProductMaintenanceInfoIndexWithFilterData> dataList) {
            List<ProductMaintenanceInfoIndexWithFilterContract> list = new List<ProductMaintenanceInfoIndexWithFilterContract>();

            foreach (ProductMaintenanceInfoIndexWithFilterData data in dataList) {
                ProductMaintenanceInfoIndexWithFilterContract contract = new ProductMaintenanceInfoIndexWithFilterContract();
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
