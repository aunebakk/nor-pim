/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:29:52 PM
  From Machine: DESKTOP-KE5CSN3
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
    public partial interface IProductMaintenanceSearchService {
        [OperationContract()]
        List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter (System.Guid productId);
        [OperationContract()]
        List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter (System.Guid productId);
        [OperationContract()]
        List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter (System.Guid productId);
        [OperationContract()]
        List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter (System.Guid productId);
        [OperationContract()]
        List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter (System.Guid productId);
        [OperationContract()]
        List<ProductMaintenanceIndexContract> ProductMaintenanceIndex ();
    }
    
    public partial class ProductMaintenanceSearchService : IProductMaintenanceSearchService {
        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter (System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceInfoIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceInfoIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceInfoIndexWithFilter(productId));
        }
        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter (System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceImageIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceImageIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceImageIndexWithFilter(productId));
        }
        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter (System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceIdentifierIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceIdentifierIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceIdentifierIndexWithFilter(productId));
        }
        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter (System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceDocumentationIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceDocumentationIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceDocumentationIndexWithFilter(productId));
        }
        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter (System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceAttributeIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceAttributeIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceAttributeIndexWithFilter(productId));
        }
        public List<ProductMaintenanceIndexContract> ProductMaintenanceIndex () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceIndex();
            return businessLogicLayer.ProductMaintenanceIndexFromDal(dataAccessLayer.ProductMaintenanceIndex());
        }
    }
}
