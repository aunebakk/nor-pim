/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 9:03:23 AM
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
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of ProductCategory's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductCategoryService")]
    public partial interface IProductCategoryService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/CleanSlate", ReplyAction="http://tempuri.org/IProductCategoryService/CleanSlateResponse")]
        void CleanSlate(System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/CleanSlate", ReplyAction="http://tempuri.org/IProductCategoryService/CleanSlateResponse")]
        System.Threading.Tasks.Task CleanSlateAsync(System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryAdd", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryAddResponse")]
        System.Guid ProductCategoryAdd(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryAdd", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryAddResponse")]
        System.Threading.Tasks.Task<System.Guid> ProductCategoryAddAsync(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteById", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteByIdResponse" +
            "")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract ProductCategoryGetCompleteById(System.Guid productCategoryId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteById", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteByIdResponse" +
            "")]
        System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract> ProductCategoryGetCompleteByIdAsync(System.Guid productCategoryId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/PositionDown", ReplyAction="http://tempuri.org/IProductCategoryService/PositionDownResponse")]
        long PositionDown(System.Guid productCategoryId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/PositionDown", ReplyAction="http://tempuri.org/IProductCategoryService/PositionDownResponse")]
        System.Threading.Tasks.Task<System.Int64> PositionDownAsync(System.Guid productCategoryId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/PositionUp", ReplyAction="http://tempuri.org/IProductCategoryService/PositionUpResponse")]
        long PositionUp(System.Guid productCategoryId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/PositionUp", ReplyAction="http://tempuri.org/IProductCategoryService/PositionUpResponse")]
        System.Threading.Tasks.Task<System.Int64> PositionUpAsync(System.Guid productCategoryId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductCategoryServiceChannel : IProductCategoryService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductCategoryServiceClient : System.ServiceModel.ClientBase<IProductCategoryService>, IProductCategoryService {
        
        public ProductCategoryServiceClient() {
        }
        
        public ProductCategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductCategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductCategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductCategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void CleanSlate(System.Guid userId) {
            base.Channel.CleanSlate(userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task CleanSlateAsync(System.Guid userId) {
            return base.Channel.CleanSlateAsync(userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid ProductCategoryAdd(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId) {
            return base.Channel.ProductCategoryAdd(productCategoryCode, productCategoryName, productCategoryParentId, productCategoryPosition, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> ProductCategoryAddAsync(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId) {
            return base.Channel.ProductCategoryAddAsync(productCategoryCode, productCategoryName, productCategoryParentId, productCategoryPosition, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract ProductCategoryGetCompleteById(System.Guid productCategoryId) {
            return base.Channel.ProductCategoryGetCompleteById(productCategoryId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract> ProductCategoryGetCompleteByIdAsync(System.Guid productCategoryId) {
            return base.Channel.ProductCategoryGetCompleteByIdAsync(productCategoryId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public long PositionDown(System.Guid productCategoryId) {
            return base.Channel.PositionDown(productCategoryId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Int64> PositionDownAsync(System.Guid productCategoryId) {
            return base.Channel.PositionDownAsync(productCategoryId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public long PositionUp(System.Guid productCategoryId) {
            return base.Channel.PositionUp(productCategoryId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Int64> PositionUpAsync(System.Guid productCategoryId) {
            return base.Channel.PositionUpAsync(productCategoryId);
        }
    }
}
