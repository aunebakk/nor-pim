/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:19:19 AM
  Template: sql2x.svcUtil.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDiagnosticsService")]
    public partial interface IDiagnosticsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/WorkingSet", ReplyAction="http://tempuri.org/IDiagnosticsService/WorkingSetResponse")]
        long WorkingSet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/WorkingSet", ReplyAction="http://tempuri.org/IDiagnosticsService/WorkingSetResponse")]
        System.Threading.Tasks.Task<System.Int64> WorkingSetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/PingTest", ReplyAction="http://tempuri.org/IDiagnosticsService/PingTestResponse")]
        System.DateTime PingTest();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/PingTest", ReplyAction="http://tempuri.org/IDiagnosticsService/PingTestResponse")]
        System.Threading.Tasks.Task<System.DateTime> PingTestAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/Database", ReplyAction="http://tempuri.org/IDiagnosticsService/DatabaseResponse")]
        string Database();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/Database", ReplyAction="http://tempuri.org/IDiagnosticsService/DatabaseResponse")]
        System.Threading.Tasks.Task<System.String> DatabaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiagnosticsService/ComputerName", ReplyAction="http://tempuri.org/IDiagnosticsService/ComputerNameResponse")]
        string ComputerName();
        
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
        
        public long WorkingSet() {
            return base.Channel.WorkingSet();
        }
        
        public System.Threading.Tasks.Task<System.Int64> WorkingSetAsync() {
            return base.Channel.WorkingSetAsync();
        }
        
        public System.DateTime PingTest() {
            return base.Channel.PingTest();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> PingTestAsync() {
            return base.Channel.PingTestAsync();
        }
        
        public string Database() {
            return base.Channel.Database();
        }
        
        public System.Threading.Tasks.Task<System.String> DatabaseAsync() {
            return base.Channel.DatabaseAsync();
        }
        
        public string ComputerName() {
            return base.Channel.ComputerName();
        }
        
        public System.Threading.Tasks.Task<System.String> ComputerNameAsync() {
            return base.Channel.ComputerNameAsync();
        }
    }
}
