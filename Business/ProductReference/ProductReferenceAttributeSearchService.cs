/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:12:02 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IProductReferenceAttributeSearchService {
        
        [OperationContract()]
        List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter();
    }
    
    public partial class ProductReferenceAttributeSearchService : IProductReferenceAttributeSearchService {
        
        public virtual List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductReferenceAttributeSearch();
            var businessLogicLayer = new ProductReferenceAttributeSearchWithFilter();
            return businessLogicLayer.ProductReferenceAttributeSearchWithFilterFromDal(dataAccessLayer.ProductReferenceAttributeSearchWithFilter());
        }
    }
}
