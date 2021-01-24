/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:50:43 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/c8b78807-5be0-4da9-89f2-2d7f8dac1c12
    [ServiceContract()]
    public partial interface IProductSearchService {
        // returns a list of ProductSearchByCategoryType4 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryType3 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryType2 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryType1 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryCode contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productCategoryCode: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent);
        // returns a list of ProductSearchByCategory contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchById contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        ProductSearchByIdContract ProductSearchById (System.Guid productId);
        // returns a list of ProductSearchByName contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductSearchByNameContract> ProductSearchByName (System.String productName);
        
        // returns a list of ProductHistory contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductHistoryContract> ProductHistory(System.Guid productId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class ProductSearchService : IProductSearchService {
        // returns a list of ProductSearchByCategoryType4 contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent) {
            // transfer all ProductSearchByCategoryType4 serialized objects from ProductSearch as ProductSearchByCategoryType4 contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType4();
            return businessLogicLayer.ProductSearchByCategoryType4FromDal(dataAccessLayer.ProductSearchByCategoryType4(productCategoryId, onParent));
        }
        // returns a list of ProductSearchByCategoryType3 contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent) {
            // transfer all ProductSearchByCategoryType3 serialized objects from ProductSearch as ProductSearchByCategoryType3 contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType3();
            return businessLogicLayer.ProductSearchByCategoryType3FromDal(dataAccessLayer.ProductSearchByCategoryType3(productCategoryId, onParent));
        }
        // returns a list of ProductSearchByCategoryType2 contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent) {
            // transfer all ProductSearchByCategoryType2 serialized objects from ProductSearch as ProductSearchByCategoryType2 contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType2();
            return businessLogicLayer.ProductSearchByCategoryType2FromDal(dataAccessLayer.ProductSearchByCategoryType2(productCategoryId, onParent));
        }
        // returns a list of ProductSearchByCategoryType1 contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent) {
            // transfer all ProductSearchByCategoryType1 serialized objects from ProductSearch as ProductSearchByCategoryType1 contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryType1();
            return businessLogicLayer.ProductSearchByCategoryType1FromDal(dataAccessLayer.ProductSearchByCategoryType1(productCategoryId, onParent));
        }
        // returns a list of ProductSearchByCategoryCode contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productCategoryCode: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent) {
            // transfer all ProductSearchByCategoryCode serialized objects from ProductSearch as ProductSearchByCategoryCode contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategoryCode();
            return businessLogicLayer.ProductSearchByCategoryCodeFromDal(dataAccessLayer.ProductSearchByCategoryCode(productCategoryCode, onParent));
        }
        // returns a list of ProductSearchByCategory contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent) {
            // transfer all ProductSearchByCategory serialized objects from ProductSearch as ProductSearchByCategory contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByCategory();
            return businessLogicLayer.ProductSearchByCategoryFromDal(dataAccessLayer.ProductSearchByCategory(productCategoryId, onParent));
        }
        // returns a list of ProductSearchById contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public ProductSearchByIdContract ProductSearchById (System.Guid productId) {
            // transfer all ProductSearchById serialized objects from ProductSearch as ProductSearchById contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchById();
            return businessLogicLayer.ProductSearchByIdFromDal(dataAccessLayer.ProductSearchById(productId));
        }
        // returns a list of ProductSearchByName contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByNameContract> ProductSearchByName (System.String productName) {
            // transfer all ProductSearchByName serialized objects from ProductSearch as ProductSearchByName contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductSearchByName();
            return businessLogicLayer.ProductSearchByNameFromDal(dataAccessLayer.ProductSearchByName(productName));
        }
        
        // returns a list of ProductHistory contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public virtual List<ProductHistoryContract> ProductHistory(System.Guid productId) {
            // transfer all ProductHistory serialized objects from ProductSearch as ProductHistory contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            var businessLogicLayer = new ProductHistory();
            return businessLogicLayer.ProductHistoryFromDal(dataAccessLayer.ProductHistory(productId));
        }
    }
}
