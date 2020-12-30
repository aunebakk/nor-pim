/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:13:42 PM
  From Machine: DESKTOP-LSRVP12
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
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IClientSearchService")]
    public interface IClientSearchService {
        // returns a list of GetClientWithFilter contracts from ClientSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  lastName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  clientTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientSearchService/GetClientWithFilter", ReplyAction="http://tempuri.org/IClientSearchService/GetClientWithFilterResponse")]
        List<GetClientWithFilterContract> GetClientWithFilter (System.String lastName,System.String clientTypeRcd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientSearchServiceChannel : IClientSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ClientSearchService : System.ServiceModel.ClientBase<IClientSearchService>, IClientSearchService {
        // returns a list of GetClientWithFilter contracts from ClientSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  lastName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  clientTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<GetClientWithFilterContract> GetClientWithFilter (System.String lastName,System.String clientTypeRcd) {
            return base.Channel.GetClientWithFilter(lastName, clientTypeRcd);
        }
        
        public ClientSearchService() {
        }
        
        public ClientSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
