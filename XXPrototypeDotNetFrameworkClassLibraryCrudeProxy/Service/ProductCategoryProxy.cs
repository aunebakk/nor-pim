/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:31:51 PM
  Template: sql2x.svcUtil.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductCategoryService")]
    public partial interface IProductCategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/CleanSlate", ReplyAction="http://tempuri.org/IProductCategoryService/CleanSlateResponse")]
        void CleanSlate(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/CleanSlate", ReplyAction="http://tempuri.org/IProductCategoryService/CleanSlateResponse")]
        System.Threading.Tasks.Task CleanSlateAsync(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryAdd", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryAddResponse")]
        System.Guid ProductCategoryAdd(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryAdd", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryAddResponse")]
        System.Threading.Tasks.Task<System.Guid> ProductCategoryAddAsync(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteById", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteByIdResponse" +
            "")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract ProductCategoryGetCompleteById(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteById", ReplyAction="http://tempuri.org/IProductCategoryService/ProductCategoryGetCompleteByIdResponse" +
            "")]
        System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract> ProductCategoryGetCompleteByIdAsync(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/PositionDown", ReplyAction="http://tempuri.org/IProductCategoryService/PositionDownResponse")]
        long PositionDown(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/PositionDown", ReplyAction="http://tempuri.org/IProductCategoryService/PositionDownResponse")]
        System.Threading.Tasks.Task<System.Int64> PositionDownAsync(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductCategoryService/PositionUp", ReplyAction="http://tempuri.org/IProductCategoryService/PositionUpResponse")]
        long PositionUp(System.Guid productCategoryId);
        
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
        
        public void CleanSlate(System.Guid userId) {
            base.Channel.CleanSlate(userId);
        }
        
        public System.Threading.Tasks.Task CleanSlateAsync(System.Guid userId) {
            return base.Channel.CleanSlateAsync(userId);
        }
        
        public System.Guid ProductCategoryAdd(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId) {
            return base.Channel.ProductCategoryAdd(productCategoryCode, productCategoryName, productCategoryParentId, productCategoryPosition, userId);
        }
        
        public System.Threading.Tasks.Task<System.Guid> ProductCategoryAddAsync(string productCategoryCode, string productCategoryName, System.Guid productCategoryParentId, int productCategoryPosition, System.Guid userId) {
            return base.Channel.ProductCategoryAddAsync(productCategoryCode, productCategoryName, productCategoryParentId, productCategoryPosition, userId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract ProductCategoryGetCompleteById(System.Guid productCategoryId) {
            return base.Channel.ProductCategoryGetCompleteById(productCategoryId);
        }
        
        public System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductCategoryContract> ProductCategoryGetCompleteByIdAsync(System.Guid productCategoryId) {
            return base.Channel.ProductCategoryGetCompleteByIdAsync(productCategoryId);
        }
        
        public long PositionDown(System.Guid productCategoryId) {
            return base.Channel.PositionDown(productCategoryId);
        }
        
        public System.Threading.Tasks.Task<System.Int64> PositionDownAsync(System.Guid productCategoryId) {
            return base.Channel.PositionDownAsync(productCategoryId);
        }
        
        public long PositionUp(System.Guid productCategoryId) {
            return base.Channel.PositionUp(productCategoryId);
        }
        
        public System.Threading.Tasks.Task<System.Int64> PositionUpAsync(System.Guid productCategoryId) {
            return base.Channel.PositionUpAsync(productCategoryId);
        }
    }
}
