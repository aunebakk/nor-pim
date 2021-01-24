/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:50:18 AM
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICategorySearchService")]
    public interface ICategorySearchServiceClient {
        // returns a list of CategoryFind contracts from CategorySearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  findWhat: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategorySearchService/CategoryFind", ReplyAction="http://tempuri.org/ICategorySearchService/CategoryFindResponse")]
        List<CategoryFindContract> CategoryFind (System.String findWhat);
        // returns a list of CategoryTree contracts from CategorySearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategorySearchService/CategoryTree", ReplyAction="http://tempuri.org/ICategorySearchService/CategoryTreeResponse")]
        List<CategoryTreeContract> CategoryTree ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategorySearchServiceChannel : ICategorySearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class CategorySearchServiceClient : System.ServiceModel.ClientBase<ICategorySearchServiceClient>, ICategorySearchServiceClient {
        // returns a list of CategoryFind contracts from CategorySearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  findWhat: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<CategoryFindContract> CategoryFind (System.String findWhat) {
            return base.Channel.CategoryFind(findWhat);
        }
        // returns a list of CategoryTree contracts from CategorySearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<CategoryTreeContract> CategoryTree () {
            return base.Channel.CategoryTree();
        }
        
        public CategorySearchServiceClient() {
        }
        
        public CategorySearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategorySearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategorySearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategorySearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
