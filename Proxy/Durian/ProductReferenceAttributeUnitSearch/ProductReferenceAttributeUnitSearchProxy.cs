/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 5:40:11 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceAttributeUnitSearchService")]
    public interface IProductReferenceAttributeUnitSearchService
    {
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IProductReferenceAttributeUnitSearchService/ProductReferenceAttributeUnitSearchWithFilter", ReplyAction = "http://tempuri.org/IProductReferenceAttributeUnitSearchService/ProductReferenceAttributeUnitSearchWithFilterResponse")]
        List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilter();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceAttributeUnitSearchServiceChannel : IProductReferenceAttributeUnitSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceAttributeUnitSearchService : System.ServiceModel.ClientBase<IProductReferenceAttributeUnitSearchService>, IProductReferenceAttributeUnitSearchService {
        
        public ProductReferenceAttributeUnitSearchService() {
        }
        
        public ProductReferenceAttributeUnitSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceAttributeUnitSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeUnitSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeUnitSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilter()
        {
            return base.Channel.ProductReferenceAttributeUnitSearchWithFilter();
        }
    }
}
