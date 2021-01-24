/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:52:41 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/179373dc-6fcc-4fc3-a7aa-e57c35d4d1d4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceAttributeSearchService")]
    public interface IProductReferenceAttributeSearchServiceClient {
        // returns a list of ProductReferenceAttributeSearchWithFilter contracts from ProductReferenceAttributeSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceAttributeSearchService/ProductReferenceAttributeSearchWithFilter", ReplyAction="http://tempuri.org/IProductReferenceAttributeSearchService/ProductReferenceAttributeSearchWithFilterResponse")]
        List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceAttributeSearchServiceChannel : IProductReferenceAttributeSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceAttributeSearchServiceClient : System.ServiceModel.ClientBase<IProductReferenceAttributeSearchServiceClient>, IProductReferenceAttributeSearchServiceClient {
        // returns a list of ProductReferenceAttributeSearchWithFilter contracts from ProductReferenceAttributeSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilter () {
            return base.Channel.ProductReferenceAttributeSearchWithFilter();
        }
        
        public ProductReferenceAttributeSearchServiceClient() {
        }
        
        public ProductReferenceAttributeSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceAttributeSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceAttributeSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
