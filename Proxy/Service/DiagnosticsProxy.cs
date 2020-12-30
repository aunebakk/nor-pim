/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:18:15 PM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of Diagnostics's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDiagnosticsService")]
    public partial interface IDiagnosticsService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/WorkingSet", ReplyAction="http://tempuri.org/IDiagnosticsService/WorkingSetResponse")]
        long WorkingSet();
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/WorkingSet", ReplyAction="http://tempuri.org/IDiagnosticsService/WorkingSetResponse")]
        System.Threading.Tasks.Task<System.Int64> WorkingSetAsync();
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/PingTest", ReplyAction="http://tempuri.org/IDiagnosticsService/PingTestResponse")]
        System.DateTime PingTest();
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/PingTest", ReplyAction="http://tempuri.org/IDiagnosticsService/PingTestResponse")]
        System.Threading.Tasks.Task<System.DateTime> PingTestAsync();
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/Database", ReplyAction="http://tempuri.org/IDiagnosticsService/DatabaseResponse")]
        string Database();
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/Database", ReplyAction="http://tempuri.org/IDiagnosticsService/DatabaseResponse")]
        System.Threading.Tasks.Task<System.String> DatabaseAsync();
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/ComputerName", ReplyAction="http://tempuri.org/IDiagnosticsService/ComputerNameResponse")]
        string ComputerName();
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/ComputerName", ReplyAction="http://tempuri.org/IDiagnosticsService/ComputerNameResponse")]
        System.Threading.Tasks.Task<System.String> ComputerNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDiagnosticsServiceChannel : IDiagnosticsService, System.ServiceModel.IClientChannel {
    }
    
    public class DiagnosticsServiceClient : System.ServiceModel.ClientBase<IDiagnosticsService>, IDiagnosticsService {
        
        public DiagnosticsServiceClient() {
        }
        
        public DiagnosticsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DiagnosticsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DiagnosticsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DiagnosticsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public long WorkingSet() {
            return base.Channel.WorkingSet();
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Int64> WorkingSetAsync() {
            return base.Channel.WorkingSetAsync();
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.DateTime PingTest() {
            return base.Channel.PingTest();
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.DateTime> PingTestAsync() {
            return base.Channel.PingTestAsync();
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public string Database() {
            return base.Channel.Database();
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.String> DatabaseAsync() {
            return base.Channel.DatabaseAsync();
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public string ComputerName() {
            return base.Channel.ComputerName();
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.String> ComputerNameAsync() {
            return base.Channel.ComputerNameAsync();
        }
    }
}
