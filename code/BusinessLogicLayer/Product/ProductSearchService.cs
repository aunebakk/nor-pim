using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.BusinessLogicLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public interface IProductSearchService
    {

        [OperationContract()]
        ProductSearchByIdContract ProductSearchById(Guid productId);

        [OperationContract()]
        List<ProductSearchByCategoryContract> ProductSearchByCategory(Guid productCategoryId, bool onParent);

        [OperationContract()]
        List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1(Guid productCategoryId, bool onParent);

        [OperationContract()]
        List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2(Guid productCategoryId, bool onParent);

        [OperationContract()]
        List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3(Guid productCategoryId, bool onParent);

        [OperationContract()]
        List<ProductSearchByNameContract> ProductSearchByName(string productName);

        [OperationContract()]
        List<ProductHistoryContract> ProductHistory(Guid productId);
    }

    public class ProductSearchService : IProductSearchService
    {

        public ProductSearchByIdContract ProductSearchById(Guid productId)
        {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchById();
            return businessLogicLayer.ProductSearchByIdFromDal(dataAccessLayer.ProductSearchById(productId));
        }

        public List<ProductSearchByCategoryContract> ProductSearchByCategory(Guid productCategoryId, bool onParent)
        {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategory();
            return businessLogicLayer.ProductSearchByCategoryFromDal(dataAccessLayer.ProductSearchByCategory(productCategoryId, onParent));
        }

        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1(Guid productCategoryId, bool onParent)
        {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType1();
            return businessLogicLayer.ProductSearchByCategoryType1FromDal(dataAccessLayer.ProductSearchByCategoryType1(productCategoryId, onParent));
        }

        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2(Guid productCategoryId, bool onParent)
        {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType2();
            return businessLogicLayer.ProductSearchByCategoryType2FromDal(dataAccessLayer.ProductSearchByCategoryType2(productCategoryId, onParent));
        }

        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3(Guid productCategoryId, bool onParent)
        {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType3();
            return businessLogicLayer.ProductSearchByCategoryType3FromDal(dataAccessLayer.ProductSearchByCategoryType3(productCategoryId, onParent));
        }

        public List<ProductSearchByNameContract> ProductSearchByName(string productName)
        {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByName();
            return businessLogicLayer.ProductSearchByNameFromDal(dataAccessLayer.ProductSearchByName(productName));
        }

        public List<ProductHistoryContract> ProductHistory(Guid productId) {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductHistory();
            return businessLogicLayer.ProductHistoryFromDal(dataAccessLayer.ProductHistory(productId));
        }
    }
}
