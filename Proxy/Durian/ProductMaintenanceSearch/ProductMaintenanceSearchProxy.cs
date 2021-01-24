/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:43:49 AM
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductMaintenanceSearchService")]
    public interface IProductMaintenanceSearchServiceClient {
        // returns a list of ProductMaintenanceInfoIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceInfoIndexWithFilter", ReplyAction="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceInfoIndexWithFilterResponse")]
        List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceImageIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceImageIndexWithFilter", ReplyAction="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceImageIndexWithFilterResponse")]
        List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceIdentifierIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIdentifierIndexWithFilter", ReplyAction="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIdentifierIndexWithFilterResponse")]
        List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceDocumentationIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceDocumentationIndexWithFilter", ReplyAction="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceDocumentationIndexWithFilterResponse")]
        List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceAttributeIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceAttributeIndexWithFilter", ReplyAction="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceAttributeIndexWithFilterResponse")]
        List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter (System.Guid productId);
        // returns a list of ProductMaintenanceIndex contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIndex", ReplyAction="http://tempuri.org/IProductMaintenanceSearchService/ProductMaintenanceIndexResponse")]
        List<ProductMaintenanceIndexContract> ProductMaintenanceIndex ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductMaintenanceSearchServiceChannel : IProductMaintenanceSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class ProductMaintenanceSearchServiceClient : System.ServiceModel.ClientBase<IProductMaintenanceSearchServiceClient>, IProductMaintenanceSearchServiceClient {
        // returns a list of ProductMaintenanceInfoIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter (System.Guid productId) {
            return base.Channel.ProductMaintenanceInfoIndexWithFilter(productId);
        }
        // returns a list of ProductMaintenanceImageIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter (System.Guid productId) {
            return base.Channel.ProductMaintenanceImageIndexWithFilter(productId);
        }
        // returns a list of ProductMaintenanceIdentifierIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter (System.Guid productId) {
            return base.Channel.ProductMaintenanceIdentifierIndexWithFilter(productId);
        }
        // returns a list of ProductMaintenanceDocumentationIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter (System.Guid productId) {
            return base.Channel.ProductMaintenanceDocumentationIndexWithFilter(productId);
        }
        // returns a list of ProductMaintenanceAttributeIndexWithFilter contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter (System.Guid productId) {
            return base.Channel.ProductMaintenanceAttributeIndexWithFilter(productId);
        }
        // returns a list of ProductMaintenanceIndex contracts from ProductMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<ProductMaintenanceIndexContract> ProductMaintenanceIndex () {
            return base.Channel.ProductMaintenanceIndex();
        }
        
        public ProductMaintenanceSearchServiceClient() {
        }
        
        public ProductMaintenanceSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductMaintenanceSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductMaintenanceSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductMaintenanceSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
