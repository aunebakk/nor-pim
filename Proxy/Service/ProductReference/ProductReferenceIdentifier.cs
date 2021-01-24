﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:56:14 AM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceIdentifierService")]
    public partial interface IProductReferenceIdentifierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceIdentifierService/ProductReferenceIdentifierC" +
            "ompleteGet", ReplyAction="http://tempuri.org/IProductReferenceIdentifierService/ProductReferenceIdentifierC" +
            "ompleteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceIdentifierContract ProductReferenceIdentifierCompleteGet(System.Guid productIdentifierId, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceIdentifierService/ProductReferenceIdentifierC" +
            "ompleteUpdate", ReplyAction="http://tempuri.org/IProductReferenceIdentifierService/ProductReferenceIdentifierC" +
            "ompleteUpdateResponse")]
        System.Guid ProductReferenceIdentifierCompleteUpdate(System.Guid productIdentifierId, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceIdentifierContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceIdentifierServiceChannel : IProductReferenceIdentifierService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceIdentifierServiceClient : System.ServiceModel.ClientBase<IProductReferenceIdentifierService>, IProductReferenceIdentifierService {
        
        public ProductReferenceIdentifierServiceClient() {
        }
        
        public ProductReferenceIdentifierServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceIdentifierServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceIdentifierServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceIdentifierServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceIdentifierContract ProductReferenceIdentifierCompleteGet(System.Guid productIdentifierId, System.Guid userId) {
            return base.Channel.ProductReferenceIdentifierCompleteGet(productIdentifierId, userId);
        }
        
        public System.Guid ProductReferenceIdentifierCompleteUpdate(System.Guid productIdentifierId, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceIdentifierContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceIdentifierCompleteUpdate(productIdentifierId, productContract, userId);
        }
    }
}
