﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:56:40 AM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceImageTypeService")]
    public partial interface IProductReferenceImageTypeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceImageTypeService/ProductReferenceImageTypeCom" +
            "pleteGet", ReplyAction="http://tempuri.org/IProductReferenceImageTypeService/ProductReferenceImageTypeCom" +
            "pleteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceImageTypeContract ProductReferenceImageTypeCompleteGet(string productImageTypeRcd, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceImageTypeService/ProductReferenceImageTypeCom" +
            "pleteUpdate", ReplyAction="http://tempuri.org/IProductReferenceImageTypeService/ProductReferenceImageTypeCom" +
            "pleteUpdateResponse")]
        string ProductReferenceImageTypeCompleteUpdate(string productImageTypeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceImageTypeContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceImageTypeServiceChannel : IProductReferenceImageTypeService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceImageTypeServiceClient : System.ServiceModel.ClientBase<IProductReferenceImageTypeService>, IProductReferenceImageTypeService {
        
        public ProductReferenceImageTypeServiceClient() {
        }
        
        public ProductReferenceImageTypeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceImageTypeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceImageTypeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceImageTypeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceImageTypeContract ProductReferenceImageTypeCompleteGet(string productImageTypeRcd, System.Guid userId) {
            return base.Channel.ProductReferenceImageTypeCompleteGet(productImageTypeRcd, userId);
        }
        
        public string ProductReferenceImageTypeCompleteUpdate(string productImageTypeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceImageTypeContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceImageTypeCompleteUpdate(productImageTypeRcd, productContract, userId);
        }
    }
}
