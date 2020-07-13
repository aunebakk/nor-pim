/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 5:02:48 PM
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

    public class ProductSearchByCategoryType4 {
        
        public List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4FromDal(List<ProductSearchByCategoryType4Data> dataList) {
           var list = new List<ProductSearchByCategoryType4Contract>();

           foreach (ProductSearchByCategoryType4Data data in dataList) {
               var contract = new ProductSearchByCategoryType4Contract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductSearchByCategoryType4Data dalProductSearchByCategoryType4, ProductSearchByCategoryType4Contract dataContract) {
            dataContract.Hn = dalProductSearchByCategoryType4.Hn;
            dataContract.ProductName = dalProductSearchByCategoryType4.ProductName;
            dataContract.Gtin13 = dalProductSearchByCategoryType4.Gtin13;
            dataContract.SupplierName = dalProductSearchByCategoryType4.SupplierName;
            dataContract.ProductId = dalProductSearchByCategoryType4.ProductId;
        }
    }
}
