/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:47:58 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductMaintenanceSearchService")]
    public interface IProductMaintenanceSearchService {
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIndex", ReplyAction = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIndexResponse")]
        List<ProductMaintenanceIndexContract> ProductMaintenanceIndex();
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceAttributeIndexWithFilter", ReplyAction = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceAttributeIndexWithFilterResponse")]
        List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter(System.Guid productId);
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceDocumentationIndexWithFilter", ReplyAction = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceDocumentationIndexWithFilterResponse")]
        List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter(System.Guid productId);
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIdentifierIndexWithFilter", ReplyAction = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIdentifierIndexWithFilterResponse")]
        List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter(System.Guid productId);
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceImageIndexWithFilter", ReplyAction = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceImageIndexWithFilterResponse")]
        List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter(System.Guid productId);
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceInfoIndexWithFilter", ReplyAction = "http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceInfoIndexWithFilterResponse")]
        List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter(System.Guid productId);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductMaintenanceSearchServiceChannel : IProductMaintenanceSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductMaintenanceSearchService : System.ServiceModel.ClientBase<IProductMaintenanceSearchService>, IProductMaintenanceSearchService {
        
        public ProductMaintenanceSearchService() {
        }
        
        public ProductMaintenanceSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductMaintenanceSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductMaintenanceSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductMaintenanceSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public List<ProductMaintenanceIndexContract> ProductMaintenanceIndex() {
            return base.Channel.ProductMaintenanceIndex();
        }

        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter(System.Guid productId) {
            return base.Channel.ProductMaintenanceAttributeIndexWithFilter(productId);
        }

        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter(System.Guid productId) {
            return base.Channel.ProductMaintenanceDocumentationIndexWithFilter(productId);
        }

        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter(System.Guid productId) {
            return base.Channel.ProductMaintenanceIdentifierIndexWithFilter(productId);
        }

        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter(System.Guid productId) {
            return base.Channel.ProductMaintenanceImageIndexWithFilter(productId);
        }

        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter(System.Guid productId) {
            return base.Channel.ProductMaintenanceInfoIndexWithFilter(productId);
        }
    }
}
