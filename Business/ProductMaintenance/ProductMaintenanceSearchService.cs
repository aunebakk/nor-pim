/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:43:47 AM
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
    public partial interface IProductMaintenanceSearchService {
        // returns a list of ProductMaintenanceInfoIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceImageIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceIdentifierIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceDocumentationIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceAttributeIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceIndex contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<ProductMaintenanceIndexContract> ProductMaintenanceIndex ();
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class ProductMaintenanceSearchService : IProductMaintenanceSearchService {
        // returns a list of ProductMaintenanceInfoIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter (System.Guid productId) {
            // transfer all ProductMaintenanceInfoIndexWithFilter serialized objects from ProductMaintenanceSearch as ProductMaintenanceInfoIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceInfoIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceInfoIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceInfoIndexWithFilter(productId));
        }
        // returns a list of ProductMaintenanceImageIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter (System.Guid productId) {
            // transfer all ProductMaintenanceImageIndexWithFilter serialized objects from ProductMaintenanceSearch as ProductMaintenanceImageIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceImageIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceImageIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceImageIndexWithFilter(productId));
        }
        // returns a list of ProductMaintenanceIdentifierIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter (System.Guid productId) {
            // transfer all ProductMaintenanceIdentifierIndexWithFilter serialized objects from ProductMaintenanceSearch as ProductMaintenanceIdentifierIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceIdentifierIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceIdentifierIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceIdentifierIndexWithFilter(productId));
        }
        // returns a list of ProductMaintenanceDocumentationIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter (System.Guid productId) {
            // transfer all ProductMaintenanceDocumentationIndexWithFilter serialized objects from ProductMaintenanceSearch as ProductMaintenanceDocumentationIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceDocumentationIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceDocumentationIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceDocumentationIndexWithFilter(productId));
        }
        // returns a list of ProductMaintenanceAttributeIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter (System.Guid productId) {
            // transfer all ProductMaintenanceAttributeIndexWithFilter serialized objects from ProductMaintenanceSearch as ProductMaintenanceAttributeIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceAttributeIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceAttributeIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceAttributeIndexWithFilter(productId));
        }
        // returns a list of ProductMaintenanceIndex contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<ProductMaintenanceIndexContract> ProductMaintenanceIndex () {
            // transfer all ProductMaintenanceIndex serialized objects from ProductMaintenanceSearch as ProductMaintenanceIndex contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceIndex();
            return businessLogicLayer.ProductMaintenanceIndexFromDal(dataAccessLayer.ProductMaintenanceIndex());
        }
    }
}
