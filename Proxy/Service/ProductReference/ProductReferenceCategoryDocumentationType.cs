﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:55:48 AM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceCategoryDocumentationTypeService")]
    public partial interface IProductReferenceCategoryDocumentationTypeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceCategoryDocumentationTypeService/ProductRefer" +
            "enceCategoryDocumentationTypeCompleteGet", ReplyAction="http://tempuri.org/IProductReferenceCategoryDocumentationTypeService/ProductRefer" +
            "enceCategoryDocumentationTypeCompleteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryDocumentationTypeContract ProductReferenceCategoryDocumentationTypeCompleteGet(string productCategoryDocumentationTypeRcd, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceCategoryDocumentationTypeService/ProductRefer" +
            "enceCategoryDocumentationTypeCompleteUpdate", ReplyAction="http://tempuri.org/IProductReferenceCategoryDocumentationTypeService/ProductRefer" +
            "enceCategoryDocumentationTypeCompleteUpdateResponse")]
        string ProductReferenceCategoryDocumentationTypeCompleteUpdate(string productCategoryDocumentationTypeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryDocumentationTypeContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceCategoryDocumentationTypeServiceChannel : IProductReferenceCategoryDocumentationTypeService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceCategoryDocumentationTypeServiceClient : System.ServiceModel.ClientBase<IProductReferenceCategoryDocumentationTypeService>, IProductReferenceCategoryDocumentationTypeService {
        
        public ProductReferenceCategoryDocumentationTypeServiceClient() {
        }
        
        public ProductReferenceCategoryDocumentationTypeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceCategoryDocumentationTypeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceCategoryDocumentationTypeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceCategoryDocumentationTypeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryDocumentationTypeContract ProductReferenceCategoryDocumentationTypeCompleteGet(string productCategoryDocumentationTypeRcd, System.Guid userId) {
            return base.Channel.ProductReferenceCategoryDocumentationTypeCompleteGet(productCategoryDocumentationTypeRcd, userId);
        }
        
        public string ProductReferenceCategoryDocumentationTypeCompleteUpdate(string productCategoryDocumentationTypeRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryDocumentationTypeContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceCategoryDocumentationTypeCompleteUpdate(productCategoryDocumentationTypeRcd, productContract, userId);
        }
    }
}
