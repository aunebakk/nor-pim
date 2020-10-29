/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:05:55 PM
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

    public class ProductSearchByCategoryType1 {
        
        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1FromDal(List<ProductSearchByCategoryType1Data> dataList) {
           var list = new List<ProductSearchByCategoryType1Contract>();

           foreach (ProductSearchByCategoryType1Data data in dataList) {
               var contract = new ProductSearchByCategoryType1Contract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductSearchByCategoryType1Data dalProductSearchByCategoryType1, ProductSearchByCategoryType1Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType1.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType1.ProductName;
            dataContract.Gtin13 = dalProductSearchByCategoryType1.Gtin13;
            dataContract.Color = dalProductSearchByCategoryType1.Color;
        }
    }
}
