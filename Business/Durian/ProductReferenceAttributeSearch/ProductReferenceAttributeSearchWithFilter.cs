/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:04:52 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductReferenceAttributeSearchWithFilter {

        public List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilterFromDal(List<ProductReferenceAttributeSearchWithFilterData> dataList) {
            List<ProductReferenceAttributeSearchWithFilterContract> list = new List<ProductReferenceAttributeSearchWithFilterContract>();

            foreach (ProductReferenceAttributeSearchWithFilterData data in dataList) {
                ProductReferenceAttributeSearchWithFilterContract contract = new ProductReferenceAttributeSearchWithFilterContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductReferenceAttributeSearchWithFilterData dalProductReferenceAttributeSearchWithFilter, ProductReferenceAttributeSearchWithFilterContract dataContract) {
            dataContract.ProductAttributeName = dalProductReferenceAttributeSearchWithFilter.ProductAttributeName;
            dataContract.ProductAttributeRcd = dalProductReferenceAttributeSearchWithFilter.ProductAttributeRcd;
            dataContract.DateTime = dalProductReferenceAttributeSearchWithFilter.DateTime;
        }
    }
}
