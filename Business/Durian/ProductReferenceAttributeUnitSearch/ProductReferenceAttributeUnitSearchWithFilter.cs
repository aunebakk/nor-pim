/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:05:00 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductReferenceAttributeUnitSearchWithFilter {

        public List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilterFromDal(List<ProductReferenceAttributeUnitSearchWithFilterData> dataList) {
            List<ProductReferenceAttributeUnitSearchWithFilterContract> list = new List<ProductReferenceAttributeUnitSearchWithFilterContract>();

            foreach (ProductReferenceAttributeUnitSearchWithFilterData data in dataList) {
                ProductReferenceAttributeUnitSearchWithFilterContract contract = new ProductReferenceAttributeUnitSearchWithFilterContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(ProductReferenceAttributeUnitSearchWithFilterData dalProductReferenceAttributeUnitSearchWithFilter, ProductReferenceAttributeUnitSearchWithFilterContract dataContract) {
            dataContract.ProductAttributeUnitName = dalProductReferenceAttributeUnitSearchWithFilter.ProductAttributeUnitName;
            dataContract.ProductAttributeUnitRcd = dalProductReferenceAttributeUnitSearchWithFilter.ProductAttributeUnitRcd;
            dataContract.DateTime = dalProductReferenceAttributeUnitSearchWithFilter.DateTime;
        }
    }
}
