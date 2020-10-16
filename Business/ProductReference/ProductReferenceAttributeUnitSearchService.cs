/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:05:00 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System.Collections.Generic;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IProductReferenceAttributeUnitSearchService {

        [OperationContract()]
        List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilter();
    }

    public partial class ProductReferenceAttributeUnitSearchService : IProductReferenceAttributeUnitSearchService {

        public virtual List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilter() {
            DataAccessLayer.ProductReferenceAttributeUnitSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductReferenceAttributeUnitSearch();
            ProductReferenceAttributeUnitSearchWithFilter businessLogicLayer = new ProductReferenceAttributeUnitSearchWithFilter();
            return businessLogicLayer.ProductReferenceAttributeUnitSearchWithFilterFromDal(dataAccessLayer.ProductReferenceAttributeUnitSearchWithFilter());
        }
    }
}
