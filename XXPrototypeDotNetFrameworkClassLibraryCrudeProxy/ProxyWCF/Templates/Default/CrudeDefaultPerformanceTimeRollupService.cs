/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:24 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultPerformanceTimeRollup.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: CrudeProxy
  Documentation:
    WCF Client Proxy layer for accessing Azure Storage Tables through
      CIFUDE ( Create Insert Fetch Update Delete and Extra Operations )
      Works for dotNetFramework
*/
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultPerformanceTimeRollupService")]
    public partial interface ICrudeDefaultPerformanceTimeRollupService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultPerfor" +
            "manceTimeRollupId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultPerfor" +
            "manceTimeRollupIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultUserId" +
            "", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultUserId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/DeleteResponse")]
        void Delete(System.Guid defaultPerformanceTimeRollupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByCommandName", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByCommandNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimitRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimitAnd" +
            "Offset", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimitAnd" +
            "OffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllCountRespons" +
            "e")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchWithFilterRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultPerformanceTimeRollupServiceChannel : ICrudeDefaultPerformanceTimeRollupService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultPerformanceTimeRollupServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultPerformanceTimeRollupService>, ICrudeDefaultPerformanceTimeRollupService {
        
        public CrudeDefaultPerformanceTimeRollupServiceClient() {
        }
        
        public CrudeDefaultPerformanceTimeRollupServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultPerformanceTimeRollupServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceTimeRollupServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceTimeRollupServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId) {
            return base.Channel.FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultPerformanceTimeRollupId) {
            base.Channel.Delete(defaultPerformanceTimeRollupId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName) {
            return base.Channel.FetchByCommandName(commandName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultPerformanceTimeRollupId: defaultPerformanceTimeRollupId,
                commandName: commandName,
                milliseconds: milliseconds,
                hits: hits,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
