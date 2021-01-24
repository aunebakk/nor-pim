﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:55:07 AM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceAttributeService")]
    public partial interface IProductReferenceAttributeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceAttributeService/ProductReferenceAttributeCom" +
            "pleteGet", ReplyAction="http://tempuri.org/IProductReferenceAttributeService/ProductReferenceAttributeCom" +
            "pleteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeContract ProductReferenceAttributeCompleteGet(string productAttributeRcd, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceAttributeService/ProductReferenceAttributeCom" +
            "pleteUpdate", ReplyAction="http://tempuri.org/IProductReferenceAttributeService/ProductReferenceAttributeCom" +
            "pleteUpdateResponse")]
        string ProductReferenceAttributeCompleteUpdate(string productAttributeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceAttributeServiceChannel : IProductReferenceAttributeService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceAttributeServiceClient : System.ServiceModel.ClientBase<IProductReferenceAttributeService>, IProductReferenceAttributeService {
        
        public ProductReferenceAttributeServiceClient() {
        }
        
        public ProductReferenceAttributeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceAttributeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeContract ProductReferenceAttributeCompleteGet(string productAttributeRcd, System.Guid userId) {
            return base.Channel.ProductReferenceAttributeCompleteGet(productAttributeRcd, userId);
        }
        
        public string ProductReferenceAttributeCompleteUpdate(string productAttributeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceAttributeCompleteUpdate(productAttributeRcd, productContract, userId);
        }
    }
}
