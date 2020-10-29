/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:50:58 PM
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
    public partial interface IProductMaintenanceSearchService {
        [OperationContract()]
        List<ProductMaintenanceIndexContract> ProductMaintenanceIndex();
        [OperationContract()]
        List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter(Guid productId);
        [OperationContract()]
        List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter(Guid productId);
        [OperationContract()]
        List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter(Guid productId);
        [OperationContract()]
        List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter(Guid productId);
        [OperationContract()]
        List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter(Guid productId);
    }

    public partial class ProductMaintenanceSearchService : IProductMaintenanceSearchService {

        public List<ProductMaintenanceIndexContract> ProductMaintenanceIndex() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceIndex();
            return businessLogicLayer.ProductMaintenanceIndexFromDal(dataAccessLayer.ProductMaintenanceIndex());
        }

        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter(Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceAttributeIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceAttributeIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceAttributeIndexWithFilter(productId));
        }

        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter(Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceDocumentationIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceDocumentationIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceDocumentationIndexWithFilter(productId));
        }

        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter(Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceIdentifierIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceIdentifierIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceIdentifierIndexWithFilter(productId));
        }

        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter(Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceImageIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceImageIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceImageIndexWithFilter(productId));
        }

        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter(Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceInfoIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceInfoIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceInfoIndexWithFilter(productId));
        }
    }
}
