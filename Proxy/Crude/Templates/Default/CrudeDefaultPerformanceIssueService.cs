/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:50:54 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultPerformanceIssue.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultPerformanceIssueService")]
    public partial interface ICrudeDefaultPerformanceIssueService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultPerformance" +
            "IssueId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultPerformance" +
            "IssueIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultUserIdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/DeleteResponse")]
        void Delete(System.Guid defaultPerformanceIssueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByCommandName", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByCommandNameRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultPerformanceIssueServiceChannel : ICrudeDefaultPerformanceIssueService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultPerformanceIssueServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultPerformanceIssueService>, ICrudeDefaultPerformanceIssueService {
        
        public CrudeDefaultPerformanceIssueServiceClient() {
        }
        
        public CrudeDefaultPerformanceIssueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultPerformanceIssueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceIssueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceIssueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            return base.Channel.FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultPerformanceIssueId) {
            base.Channel.Delete(defaultPerformanceIssueId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName) {
            return base.Channel.FetchByCommandName(commandName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultPerformanceIssueId: defaultPerformanceIssueId,
                commandName: commandName,
                commandText: commandText,
                milliseconds: milliseconds,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
