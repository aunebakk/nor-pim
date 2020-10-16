/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:04:52 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System.Collections.Generic;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IProductReferenceAttributeSearchService {

        [OperationContract()]
        List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter();
    }

    public partial class ProductReferenceAttributeSearchService : IProductReferenceAttributeSearchService {

        public virtual List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter() {
            DataAccessLayer.ProductReferenceAttributeSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductReferenceAttributeSearch();
            ProductReferenceAttributeSearchWithFilter businessLogicLayer = new ProductReferenceAttributeSearchWithFilter();
            return businessLogicLayer.ProductReferenceAttributeSearchWithFilterFromDal(dataAccessLayer.ProductReferenceAttributeSearchWithFilter());
        }
    }
}
