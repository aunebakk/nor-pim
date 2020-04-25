/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:37:34 AM
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public class ProductSearchByCategoryCode {
        
        public List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCodeFromDal(List<ProductSearchByCategoryCodeData> dataList) {
           var list = new List<ProductSearchByCategoryCodeContract>();

           foreach (ProductSearchByCategoryCodeData data in dataList) {
               var contract = new ProductSearchByCategoryCodeContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductSearchByCategoryCodeData dalProductSearchByCategoryCode, ProductSearchByCategoryCodeContract dataContract) {
            dataContract.ProductId = dalProductSearchByCategoryCode.ProductId;
            dataContract.ProductName = dalProductSearchByCategoryCode.ProductName;
            dataContract.Identifier = dalProductSearchByCategoryCode.Identifier;
            dataContract.Value = dalProductSearchByCategoryCode.Value;
            dataContract.ProductInfoValue = dalProductSearchByCategoryCode.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchByCategoryCode.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchByCategoryCode.ProductImageTypeName;
            dataContract.Image = dalProductSearchByCategoryCode.Image;
        }
    }
}
