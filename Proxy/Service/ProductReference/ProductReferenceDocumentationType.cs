﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:56:01 AM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceDocumentationTypeService")]
    public partial interface IProductReferenceDocumentationTypeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceDocumentationTypeService/ProductReferenceDocu" +
            "mentationTypeCompleteGet", ReplyAction="http://tempuri.org/IProductReferenceDocumentationTypeService/ProductReferenceDocu" +
            "mentationTypeCompleteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceDocumentationTypeContract ProductReferenceDocumentationTypeCompleteGet(string productDocumentationTypeRcd, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceDocumentationTypeService/ProductReferenceDocu" +
            "mentationTypeCompleteUpdate", ReplyAction="http://tempuri.org/IProductReferenceDocumentationTypeService/ProductReferenceDocu" +
            "mentationTypeCompleteUpdateResponse")]
        string ProductReferenceDocumentationTypeCompleteUpdate(string productDocumentationTypeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceDocumentationTypeContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceDocumentationTypeServiceChannel : IProductReferenceDocumentationTypeService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceDocumentationTypeServiceClient : System.ServiceModel.ClientBase<IProductReferenceDocumentationTypeService>, IProductReferenceDocumentationTypeService {
        
        public ProductReferenceDocumentationTypeServiceClient() {
        }
        
        public ProductReferenceDocumentationTypeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceDocumentationTypeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceDocumentationTypeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceDocumentationTypeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceDocumentationTypeContract ProductReferenceDocumentationTypeCompleteGet(string productDocumentationTypeRcd, System.Guid userId) {
            return base.Channel.ProductReferenceDocumentationTypeCompleteGet(productDocumentationTypeRcd, userId);
        }
        
        public string ProductReferenceDocumentationTypeCompleteUpdate(string productDocumentationTypeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceDocumentationTypeContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceDocumentationTypeCompleteUpdate(productDocumentationTypeRcd, productContract, userId);
        }
    }
}
