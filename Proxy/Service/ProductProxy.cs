/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:18:14 PM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of Product's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductService")]
    public partial interface IProductService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductGetCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductGetCompleteByIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductContract ProductGetCompleteById(System.Guid productId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductGetCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductGetCompleteByIdResponse")]
        System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductContract> ProductGetCompleteByIdAsync(System.Guid productId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductSaveCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductSaveCompleteByIdResponse")]
        System.Guid ProductSaveCompleteById(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductSaveCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductSaveCompleteByIdResponse")]
        System.Threading.Tasks.Task<System.Guid> ProductSaveCompleteByIdAsync(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductAdd", ReplyAction="http://tempuri.org/IProductService/ProductAddResponse")]
        System.Guid ProductAdd(System.Guid productCategoryId, string productName, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductAdd", ReplyAction="http://tempuri.org/IProductService/ProductAddResponse")]
        System.Threading.Tasks.Task<System.Guid> ProductAddAsync(System.Guid productCategoryId, string productName, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductHistory", ReplyAction="http://tempuri.org/IProductService/ProductHistoryResponse")]
        System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract> ProductHistory(System.Guid productId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductHistory", ReplyAction="http://tempuri.org/IProductService/ProductHistoryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract>> ProductHistoryAsync(System.Guid productId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductChangeAttribute", ReplyAction="http://tempuri.org/IProductService/ProductChangeAttributeResponse")]
        void ProductChangeAttribute(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductChangeAttribute", ReplyAction="http://tempuri.org/IProductService/ProductChangeAttributeResponse")]
        System.Threading.Tasks.Task ProductChangeAttributeAsync(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductChangeEntities", ReplyAction="http://tempuri.org/IProductService/ProductChangeEntitiesResponse")]
        void ProductChangeEntities(System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductChangeEntityContract> productEntities, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductChangeEntities", ReplyAction="http://tempuri.org/IProductService/ProductChangeEntitiesResponse")]
        System.Threading.Tasks.Task ProductChangeEntitiesAsync(System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductChangeEntityContract> productEntities, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : IProductService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductServiceClient : System.ServiceModel.ClientBase<IProductService>, IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductContract ProductGetCompleteById(System.Guid productId) {
            return base.Channel.ProductGetCompleteById(productId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductContract> ProductGetCompleteByIdAsync(System.Guid productId) {
            return base.Channel.ProductGetCompleteByIdAsync(productId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid ProductSaveCompleteById(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId) {
            return base.Channel.ProductSaveCompleteById(contract, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> ProductSaveCompleteByIdAsync(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId) {
            return base.Channel.ProductSaveCompleteByIdAsync(contract, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid ProductAdd(System.Guid productCategoryId, string productName, System.Guid userId) {
            return base.Channel.ProductAdd(productCategoryId, productName, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> ProductAddAsync(System.Guid productCategoryId, string productName, System.Guid userId) {
            return base.Channel.ProductAddAsync(productCategoryId, productName, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract> ProductHistory(System.Guid productId) {
            return base.Channel.ProductHistory(productId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract>> ProductHistoryAsync(System.Guid productId) {
            return base.Channel.ProductHistoryAsync(productId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void ProductChangeAttribute(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId) {
            base.Channel.ProductChangeAttribute(productIds, productAttributeRcd, newAttributeValue, productIdentifierRcd, newIdentifierValue, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task ProductChangeAttributeAsync(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId) {
            return base.Channel.ProductChangeAttributeAsync(productIds, productAttributeRcd, newAttributeValue, productIdentifierRcd, newIdentifierValue, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void ProductChangeEntities(System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductChangeEntityContract> productEntities, System.Guid userId) {
            base.Channel.ProductChangeEntities(productEntities, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task ProductChangeEntitiesAsync(System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductChangeEntityContract> productEntities, System.Guid userId) {
            return base.Channel.ProductChangeEntitiesAsync(productEntities, userId);
        }
    }
}
