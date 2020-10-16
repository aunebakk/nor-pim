/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:39 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductSearchByName {

        public List<ProductSearchByNameContract> ProductSearchByNameFromDal(List<ProductSearchByNameData> dataList) {
            List<ProductSearchByNameContract> list = new List<ProductSearchByNameContract>();

            foreach (ProductSearchByNameData data in dataList) {
                ProductSearchByNameContract contract = new ProductSearchByNameContract();
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
