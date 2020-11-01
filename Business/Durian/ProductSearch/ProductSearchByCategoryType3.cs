/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:11:06 AM
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

    public class ProductSearchByCategoryType3 {
        
        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3FromDal(List<ProductSearchByCategoryType3Data> dataList) {
           var list = new List<ProductSearchByCategoryType3Contract>();

           foreach (ProductSearchByCategoryType3Data data in dataList) {
               var contract = new ProductSearchByCategoryType3Contract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductSearchByCategoryType3Data dalProductSearchByCategoryType3, ProductSearchByCategoryType3Contract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryType3.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryType3.ProductName;
            dataContract.Gtin13 = dalProductSearchByCategoryType3.Gtin13;
            dataContract.Hn = dalProductSearchByCategoryType3.Hn;
            dataContract.Color = dalProductSearchByCategoryType3.Color;
        }
    }
}
