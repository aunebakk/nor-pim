/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:55 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductSearchByCategoryCode {

        public List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCodeFromDal(List<ProductSearchByCategoryCodeData> dataList) {
            List<ProductSearchByCategoryCodeContract> list = new List<ProductSearchByCategoryCodeContract>();

            foreach (ProductSearchByCategoryCodeData data in dataList) {
                ProductSearchByCategoryCodeContract contract = new ProductSearchByCategoryCodeContract();
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
