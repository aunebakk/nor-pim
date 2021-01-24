﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:55:22 AM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceAttributeUnitService")]
    public partial interface IProductReferenceAttributeUnitService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceAttributeUnitService/ProductReferenceAttribut" +
            "eUnitCompleteGet", ReplyAction="http://tempuri.org/IProductReferenceAttributeUnitService/ProductReferenceAttribut" +
            "eUnitCompleteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeUnitContract ProductReferenceAttributeUnitCompleteGet(string productAttributeUnitRcd, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceAttributeUnitService/ProductReferenceAttribut" +
            "eUnitCompleteUpdate", ReplyAction="http://tempuri.org/IProductReferenceAttributeUnitService/ProductReferenceAttribut" +
            "eUnitCompleteUpdateResponse")]
        string ProductReferenceAttributeUnitCompleteUpdate(string productAttributeUnitRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeUnitContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceAttributeUnitServiceChannel : IProductReferenceAttributeUnitService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceAttributeUnitServiceClient : System.ServiceModel.ClientBase<IProductReferenceAttributeUnitService>, IProductReferenceAttributeUnitService {
        
        public ProductReferenceAttributeUnitServiceClient() {
        }
        
        public ProductReferenceAttributeUnitServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceAttributeUnitServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeUnitServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeUnitServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeUnitContract ProductReferenceAttributeUnitCompleteGet(string productAttributeUnitRcd, System.Guid userId) {
            return base.Channel.ProductReferenceAttributeUnitCompleteGet(productAttributeUnitRcd, userId);
        }
        
        public string ProductReferenceAttributeUnitCompleteUpdate(string productAttributeUnitRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceAttributeUnitContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceAttributeUnitCompleteUpdate(productAttributeUnitRcd, productContract, userId);
        }
    }
}
