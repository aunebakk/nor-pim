/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:12:31 AM
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

    public class ProductSearchByName {
        
        public List<ProductSearchByNameContract> ProductSearchByNameFromDal(List<ProductSearchByNameData> dataList) {
           var list = new List<ProductSearchByNameContract>();

           foreach (ProductSearchByNameData data in dataList) {
               var contract = new ProductSearchByNameContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductSearchByNameData dalProductSearchByName, ProductSearchByNameContract dataContract) {
            dataContract.ProductId = dalProductSearchByName.ProductId;
            dataContract.ProductName = dalProductSearchByName.ProductName;
            dataContract.Identifier = dalProductSearchByName.Identifier;
            dataContract.Value = dalProductSearchByName.Value;
            dataContract.ProductInfoValue = dalProductSearchByName.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchByName.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchByName.ProductImageTypeName;
            dataContract.Image = dalProductSearchByName.Image;
        }
    }
}
