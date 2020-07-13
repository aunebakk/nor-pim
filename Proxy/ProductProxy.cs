/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 11:06:02 AM
  Template: sql2x.svcUtil.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductService")]
    public partial interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductGetCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductGetCompleteByIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductContract ProductGetCompleteById(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductGetCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductGetCompleteByIdResponse")]
        System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductContract> ProductGetCompleteByIdAsync(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductSaveCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductSaveCompleteByIdResponse")]
        System.Guid ProductSaveCompleteById(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductSaveCompleteById", ReplyAction="http://tempuri.org/IProductService/ProductSaveCompleteByIdResponse")]
        System.Threading.Tasks.Task<System.Guid> ProductSaveCompleteByIdAsync(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductAdd", ReplyAction="http://tempuri.org/IProductService/ProductAddResponse")]
        System.Guid ProductAdd(System.Guid productCategoryId, string productName, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductAdd", ReplyAction="http://tempuri.org/IProductService/ProductAddResponse")]
        System.Threading.Tasks.Task<System.Guid> ProductAddAsync(System.Guid productCategoryId, string productName, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductHistory", ReplyAction="http://tempuri.org/IProductService/ProductHistoryResponse")]
        System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract> ProductHistory(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductHistory", ReplyAction="http://tempuri.org/IProductService/ProductHistoryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract>> ProductHistoryAsync(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductChangeAttribute", ReplyAction="http://tempuri.org/IProductService/ProductChangeAttributeResponse")]
        void ProductChangeAttribute(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductChangeAttribute", ReplyAction="http://tempuri.org/IProductService/ProductChangeAttributeResponse")]
        System.Threading.Tasks.Task ProductChangeAttributeAsync(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductChangeEntities", ReplyAction="http://tempuri.org/IProductService/ProductChangeEntitiesResponse")]
        void ProductChangeEntities(System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductChangeEntityContract> productEntities, System.Guid userId);
        
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
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductContract ProductGetCompleteById(System.Guid productId) {
            return base.Channel.ProductGetCompleteById(productId);
        }
        
        public System.Threading.Tasks.Task<SolutionNorSolutionPim.BusinessLogicLayer.ProductContract> ProductGetCompleteByIdAsync(System.Guid productId) {
            return base.Channel.ProductGetCompleteByIdAsync(productId);
        }
        
        public System.Guid ProductSaveCompleteById(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId) {
            return base.Channel.ProductSaveCompleteById(contract, userId);
        }
        
        public System.Threading.Tasks.Task<System.Guid> ProductSaveCompleteByIdAsync(SolutionNorSolutionPim.BusinessLogicLayer.ProductContract contract, System.Guid userId) {
            return base.Channel.ProductSaveCompleteByIdAsync(contract, userId);
        }
        
        public System.Guid ProductAdd(System.Guid productCategoryId, string productName, System.Guid userId) {
            return base.Channel.ProductAdd(productCategoryId, productName, userId);
        }
        
        public System.Threading.Tasks.Task<System.Guid> ProductAddAsync(System.Guid productCategoryId, string productName, System.Guid userId) {
            return base.Channel.ProductAddAsync(productCategoryId, productName, userId);
        }
        
        public System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract> ProductHistory(System.Guid productId) {
            return base.Channel.ProductHistory(productId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductHistoryContract>> ProductHistoryAsync(System.Guid productId) {
            return base.Channel.ProductHistoryAsync(productId);
        }
        
        public void ProductChangeAttribute(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId) {
            base.Channel.ProductChangeAttribute(productIds, productAttributeRcd, newAttributeValue, productIdentifierRcd, newIdentifierValue, userId);
        }
        
        public System.Threading.Tasks.Task ProductChangeAttributeAsync(System.Collections.Generic.List<System.Guid> productIds, string productAttributeRcd, string newAttributeValue, string productIdentifierRcd, string newIdentifierValue, System.Guid userId) {
            return base.Channel.ProductChangeAttributeAsync(productIds, productAttributeRcd, newAttributeValue, productIdentifierRcd, newIdentifierValue, userId);
        }
        
        public void ProductChangeEntities(System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductChangeEntityContract> productEntities, System.Guid userId) {
            base.Channel.ProductChangeEntities(productEntities, userId);
        }
        
        public System.Threading.Tasks.Task ProductChangeEntitiesAsync(System.Collections.Generic.List<SolutionNorSolutionPim.BusinessLogicLayer.ProductChangeEntityContract> productEntities, System.Guid userId) {
            return base.Channel.ProductChangeEntitiesAsync(productEntities, userId);
        }
    }
}
