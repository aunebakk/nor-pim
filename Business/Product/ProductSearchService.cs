/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:33:08 AM
  From Machine: DESKTOP-00MSEIL
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
        List<ProductHistoryContract> ProductHistory(System.Guid productId);
        [OperationContract()]
        List<ProductSearchByNameContract> ProductSearchByName(string productName);
        [OperationContract()]
        ProductSearchByIdContract ProductSearchById(Guid productId);
        [OperationContract()]
        List<ProductSearchByCategoryContract> ProductSearchByCategory(Guid productCategoryId, bool onParent);
        [OperationContract()]
        List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode(string productCategoryCode, bool onParent);
        [OperationContract()]
        List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1(Guid productCategoryId, bool onParent);
        [OperationContract()]
        List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2(Guid productCategoryId, bool onParent);
        [OperationContract()]
        List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3(Guid productCategoryId, bool onParent);
        [OperationContract()]
        List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4(Guid productCategoryId, bool onParent);
    }

    public partial class ProductSearchService : IProductSearchService {
        
        public virtual List<ProductHistoryContract> ProductHistory(System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductHistory();
            return businessLogicLayer.ProductHistoryFromDal(dataAccessLayer.ProductHistory(productId));
        }

        public List<ProductSearchByNameContract> ProductSearchByName(string productName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByName();
            return businessLogicLayer.ProductSearchByNameFromDal(dataAccessLayer.ProductSearchByName(productName));
        }

        public ProductSearchByIdContract ProductSearchById(Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchById();
            return businessLogicLayer.ProductSearchByIdFromDal(dataAccessLayer.ProductSearchById(productId));
        }

        public List<ProductSearchByCategoryContract> ProductSearchByCategory(Guid productCategoryId, bool onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategory();
            return businessLogicLayer.ProductSearchByCategoryFromDal(dataAccessLayer.ProductSearchByCategory(productCategoryId, onParent));
        }

        public List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode(string productCategoryCode, bool onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryCode();
            return businessLogicLayer.ProductSearchByCategoryCodeFromDal(dataAccessLayer.ProductSearchByCategoryCode(productCategoryCode, onParent));
        }

        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1(Guid productCategoryId, bool onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType1();
            return businessLogicLayer.ProductSearchByCategoryType1FromDal(dataAccessLayer.ProductSearchByCategoryType1(productCategoryId, onParent));
        }

        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2(Guid productCategoryId, bool onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType2();
            return businessLogicLayer.ProductSearchByCategoryType2FromDal(dataAccessLayer.ProductSearchByCategoryType2(productCategoryId, onParent));
        }

        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3(Guid productCategoryId, bool onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType3();
            return businessLogicLayer.ProductSearchByCategoryType3FromDal(dataAccessLayer.ProductSearchByCategoryType3(productCategoryId, onParent));
        }

        public List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4(Guid productCategoryId, bool onParent) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType4();
            return businessLogicLayer.ProductSearchByCategoryType4FromDal(dataAccessLayer.ProductSearchByCategoryType4(productCategoryId, onParent));
        }
    }
}
