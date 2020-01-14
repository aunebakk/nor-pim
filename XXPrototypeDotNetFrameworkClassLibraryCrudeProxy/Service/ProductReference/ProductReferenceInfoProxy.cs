/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:10:17 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceInfoService")]
    public partial interface IProductReferenceInfoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceInfoService/ProductReferenceInfoCompleteGet", ReplyAction="http://tempuri.org/IProductReferenceInfoService/ProductReferenceInfoCompleteGetRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceInfoContract ProductReferenceInfoCompleteGet(string productInfoRcd, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceInfoService/ProductReferenceInfoCompleteUpdat" +
            "e", ReplyAction="http://tempuri.org/IProductReferenceInfoService/ProductReferenceInfoCompleteUpdat" +
            "eResponse")]
        string ProductReferenceInfoCompleteUpdate(string productInfoRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceInfoContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceInfoServiceChannel : IProductReferenceInfoService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceInfoServiceClient : System.ServiceModel.ClientBase<IProductReferenceInfoService>, IProductReferenceInfoService {
        
        public ProductReferenceInfoServiceClient() {
        }
        
        public ProductReferenceInfoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceInfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceInfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceInfoContract ProductReferenceInfoCompleteGet(string productInfoRcd, System.Guid userId) {
            return base.Channel.ProductReferenceInfoCompleteGet(productInfoRcd, userId);
        }
        
        public string ProductReferenceInfoCompleteUpdate(string productInfoRcd, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceInfoContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceInfoCompleteUpdate(productInfoRcd, productContract, userId);
        }
    }
}
