/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:59:48 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;

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
            DataAccessLayer.ProductMaintenanceSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            ProductMaintenanceIndex businessLogicLayer = new ProductMaintenanceIndex();
            return businessLogicLayer.ProductMaintenanceIndexFromDal(dataAccessLayer.ProductMaintenanceIndex());
        }

        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter(Guid productId) {
            DataAccessLayer.ProductMaintenanceSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            ProductMaintenanceAttributeIndexWithFilter businessLogicLayer = new ProductMaintenanceAttributeIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceAttributeIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceAttributeIndexWithFilter(productId));
        }

        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter(Guid productId) {
            DataAccessLayer.ProductMaintenanceSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            ProductMaintenanceDocumentationIndexWithFilter businessLogicLayer = new ProductMaintenanceDocumentationIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceDocumentationIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceDocumentationIndexWithFilter(productId));
        }

        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter(Guid productId) {
            DataAccessLayer.ProductMaintenanceSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            ProductMaintenanceIdentifierIndexWithFilter businessLogicLayer = new ProductMaintenanceIdentifierIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceIdentifierIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceIdentifierIndexWithFilter(productId));
        }

        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter(Guid productId) {
            DataAccessLayer.ProductMaintenanceSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            ProductMaintenanceImageIndexWithFilter businessLogicLayer = new ProductMaintenanceImageIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceImageIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceImageIndexWithFilter(productId));
        }

        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter(Guid productId) {
            DataAccessLayer.ProductMaintenanceSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            ProductMaintenanceInfoIndexWithFilter businessLogicLayer = new ProductMaintenanceInfoIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceInfoIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceInfoIndexWithFilter(productId));
        }
    }
}
