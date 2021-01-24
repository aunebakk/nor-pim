/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 9:03:25 AM
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
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of DefaultUserActivity's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultUserActivityService")]
    public partial interface IDefaultUserActivityService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4", ReplyAction="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4Response")]
        string ResolveNetnameFromIpV4(string ipAddress);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4", ReplyAction="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4Response")]
        System.Threading.Tasks.Task<System.String> ResolveNetnameFromIpV4Async(string ipAddress);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/AddActivity", ReplyAction="http://tempuri.org/IDefaultUserActivityService/AddActivityResponse")]
        void AddActivity(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/AddActivity", ReplyAction="http://tempuri.org/IDefaultUserActivityService/AddActivityResponse")]
        System.Threading.Tasks.Task AddActivityAsync(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/Login", ReplyAction="http://tempuri.org/IDefaultUserActivityService/LoginResponse")]
        System.Guid Login(string userCode);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/Login", ReplyAction="http://tempuri.org/IDefaultUserActivityService/LoginResponse")]
        System.Threading.Tasks.Task<System.Guid> LoginAsync(string userCode);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/LoginOverrideUserName", ReplyAction="http://tempuri.org/IDefaultUserActivityService/LoginOverrideUserNameResponse")]
        System.Guid LoginOverrideUserName(string userCode);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/LoginOverrideUserName", ReplyAction="http://tempuri.org/IDefaultUserActivityService/LoginOverrideUserNameResponse")]
        System.Threading.Tasks.Task<System.Guid> LoginOverrideUserNameAsync(string userCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDefaultUserActivityServiceChannel : IDefaultUserActivityService, System.ServiceModel.IClientChannel {
    }
    
    public class DefaultUserActivityServiceClient : System.ServiceModel.ClientBase<IDefaultUserActivityService>, IDefaultUserActivityService {
        
        public DefaultUserActivityServiceClient() {
        }
        
        public DefaultUserActivityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultUserActivityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultUserActivityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultUserActivityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public string ResolveNetnameFromIpV4(string ipAddress) {
            return base.Channel.ResolveNetnameFromIpV4(ipAddress);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.String> ResolveNetnameFromIpV4Async(string ipAddress) {
            return base.Channel.ResolveNetnameFromIpV4Async(ipAddress);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void AddActivity(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress) {
            base.Channel.AddActivity(userId, userActivityTypeRcd, activityNote, originatingAddress);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task AddActivityAsync(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress) {
            return base.Channel.AddActivityAsync(userId, userActivityTypeRcd, activityNote, originatingAddress);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid Login(string userCode) {
            return base.Channel.Login(userCode);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> LoginAsync(string userCode) {
            return base.Channel.LoginAsync(userCode);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid LoginOverrideUserName(string userCode) {
            return base.Channel.LoginOverrideUserName(userCode);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> LoginOverrideUserNameAsync(string userCode) {
            return base.Channel.LoginOverrideUserNameAsync(userCode);
        }
    }
}
