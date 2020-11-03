/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:56:43 AM
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
    public partial interface IProductReferenceAttributeUnitSearchService {
        
        [OperationContract()]
        List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilter();
    }
    
    public partial class ProductReferenceAttributeUnitSearchService : IProductReferenceAttributeUnitSearchService {
        
        public virtual List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilter() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductReferenceAttributeUnitSearch();
            var businessLogicLayer = new ProductReferenceAttributeUnitSearchWithFilter();
            return businessLogicLayer.ProductReferenceAttributeUnitSearchWithFilterFromDal(dataAccessLayer.ProductReferenceAttributeUnitSearchWithFilter());
        }
    }
}
