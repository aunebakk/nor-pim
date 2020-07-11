/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:49:54 PM
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

    public class ProductSearchByCategory {
        
        public List<ProductSearchByCategoryContract> ProductSearchByCategoryFromDal(List<ProductSearchByCategoryData> dataList) {
           var list = new List<ProductSearchByCategoryContract>();

           foreach (ProductSearchByCategoryData data in dataList) {
               var contract = new ProductSearchByCategoryContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductSearchByCategoryData dalProductSearchByCategory, ProductSearchByCategoryContract dataContract) {
            dataContract.ProductId = dalProductSearchByCategory.ProductId;
            dataContract.ProductName = dalProductSearchByCategory.ProductName;
            dataContract.Identifier = dalProductSearchByCategory.Identifier;
            dataContract.Value = dalProductSearchByCategory.Value;
            dataContract.ProductInfoValue = dalProductSearchByCategory.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchByCategory.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchByCategory.ProductImageTypeName;
            dataContract.Image = dalProductSearchByCategory.Image;
        }
    }
}
