/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:35:24 PM
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
    public partial interface IProductSearchService {
        [OperationContract()]
        List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent);
        [OperationContract()]
        List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent);
        [OperationContract()]
        List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent);
        [OperationContract()]
        List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent);
        [OperationContract()]
        List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent);
        [OperationContract()]
        List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent);
        [OperationContract()]
        ProductSearchByIdContract ProductSearchById (System.Guid productId);
        [OperationContract()]
        List<ProductSearchByNameContract> ProductSearchByName (System.String productName);
        
        [OperationContract()]
        List<ProductHistoryContract> ProductHistory(System.Guid productId);
    }
    
    public partial class ProductSearchService : IProductSearchService {
        public List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType4();
            return businessLogicLayer.ProductSearchByCategoryType4FromDal(dataAccessLayer.ProductSearchByCategoryType4(productCategoryId, onParent));
        }
        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType3();
            return businessLogicLayer.ProductSearchByCategoryType3FromDal(dataAccessLayer.ProductSearchByCategoryType3(productCategoryId, onParent));
        }
        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType2();
            return businessLogicLayer.ProductSearchByCategoryType2FromDal(dataAccessLayer.ProductSearchByCategoryType2(productCategoryId, onParent));
        }
        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType1();
            return businessLogicLayer.ProductSearchByCategoryType1FromDal(dataAccessLayer.ProductSearchByCategoryType1(productCategoryId, onParent));
        }
        public List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryCode();
            return businessLogicLayer.ProductSearchByCategoryCodeFromDal(dataAccessLayer.ProductSearchByCategoryCode(productCategoryCode, onParent));
        }
        public List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategory();
            return businessLogicLayer.ProductSearchByCategoryFromDal(dataAccessLayer.ProductSearchByCategory(productCategoryId, onParent));
        }
        public ProductSearchByIdContract ProductSearchById (System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchById();
            return businessLogicLayer.ProductSearchByIdFromDal(dataAccessLayer.ProductSearchById(productId));
        }
        public List<ProductSearchByNameContract> ProductSearchByName (System.String productName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByName();
            return businessLogicLayer.ProductSearchByNameFromDal(dataAccessLayer.ProductSearchByName(productName));
        }
        
        public virtual List<ProductHistoryContract> ProductHistory(System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductHistory();
            return businessLogicLayer.ProductHistoryFromDal(dataAccessLayer.ProductHistory(productId));
        }
    }
}
