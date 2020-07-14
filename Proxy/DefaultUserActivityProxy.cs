/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 7:10:27 AM
  Template: sql2x.svcUtil.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultUserActivityService")]
    public partial interface IDefaultUserActivityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4", ReplyAction="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4Response")]
        string ResolveNetnameFromIpV4(string ipAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4", ReplyAction="http://tempuri.org/IDefaultUserActivityService/ResolveNetnameFromIpV4Response")]
        System.Threading.Tasks.Task<System.String> ResolveNetnameFromIpV4Async(string ipAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/AddActivity", ReplyAction="http://tempuri.org/IDefaultUserActivityService/AddActivityResponse")]
        void AddActivity(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/AddActivity", ReplyAction="http://tempuri.org/IDefaultUserActivityService/AddActivityResponse")]
        System.Threading.Tasks.Task AddActivityAsync(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/Login", ReplyAction="http://tempuri.org/IDefaultUserActivityService/LoginResponse")]
        System.Guid Login(string userCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/Login", ReplyAction="http://tempuri.org/IDefaultUserActivityService/LoginResponse")]
        System.Threading.Tasks.Task<System.Guid> LoginAsync(string userCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultUserActivityService/LoginOverrideUserName", ReplyAction="http://tempuri.org/IDefaultUserActivityService/LoginOverrideUserNameResponse")]
        System.Guid LoginOverrideUserName(string userCode);
        
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
        
        public string ResolveNetnameFromIpV4(string ipAddress) {
            return base.Channel.ResolveNetnameFromIpV4(ipAddress);
        }
        
        public System.Threading.Tasks.Task<System.String> ResolveNetnameFromIpV4Async(string ipAddress) {
            return base.Channel.ResolveNetnameFromIpV4Async(ipAddress);
        }
        
        public void AddActivity(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress) {
            base.Channel.AddActivity(userId, userActivityTypeRcd, activityNote, originatingAddress);
        }
        
        public System.Threading.Tasks.Task AddActivityAsync(System.Guid userId, string userActivityTypeRcd, string activityNote, string originatingAddress) {
            return base.Channel.AddActivityAsync(userId, userActivityTypeRcd, activityNote, originatingAddress);
        }
        
        public System.Guid Login(string userCode) {
            return base.Channel.Login(userCode);
        }
        
        public System.Threading.Tasks.Task<System.Guid> LoginAsync(string userCode) {
            return base.Channel.LoginAsync(userCode);
        }
        
        public System.Guid LoginOverrideUserName(string userCode) {
            return base.Channel.LoginOverrideUserName(userCode);
        }
        
        public System.Threading.Tasks.Task<System.Guid> LoginOverrideUserNameAsync(string userCode) {
            return base.Channel.LoginOverrideUserNameAsync(userCode);
        }
    }
}
