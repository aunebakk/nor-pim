/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 5:09:30 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceAttributeSearchService")]
    public interface IProductReferenceAttributeSearchService {
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductReferenceAttributeSearchService/ProductReferenceAttributeSearchWithFilter", ReplyAction = "http://tempuri.org/IProductReferenceAttributeSearchService/ProductReferenceAttributeSearchWithFilterResponse")]
        List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceAttributeSearchServiceChannel : IProductReferenceAttributeSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceAttributeSearchService : System.ServiceModel.ClientBase<IProductReferenceAttributeSearchService>, IProductReferenceAttributeSearchService {
        
        public ProductReferenceAttributeSearchService() {
        }
        
        public ProductReferenceAttributeSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceAttributeSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter() {
            return base.Channel.ProductReferenceAttributeSearchWithFilter();
        }
    }
}
