/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:04:12 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductMaintenanceIndex {

        public List<ProductMaintenanceIndexContract> ProductMaintenanceIndexFromDal(List<ProductMaintenanceIndexData> dataList) {
            List<ProductMaintenanceIndexContract> list = new List<ProductMaintenanceIndexContract>();

            foreach (ProductMaintenanceIndexData data in dataList) {
                ProductMaintenanceIndexContract contract = new ProductMaintenanceIndexContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductMaintenanceIndexData dalProductMaintenanceIndex, ProductMaintenanceIndexContract dataContract) {
            dataContract.ProductName = dalProductMaintenanceIndex.ProductName;
            dataContract.StateRcd = dalProductMaintenanceIndex.StateRcd;
            dataContract.UserId = dalProductMaintenanceIndex.UserId;
            dataContract.DateTime = dalProductMaintenanceIndex.DateTime;
            dataContract.ProductId = dalProductMaintenanceIndex.ProductId;
            dataContract.DefaultUserName = dalProductMaintenanceIndex.DefaultUserName;
        }
    }
}
