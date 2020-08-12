/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:25 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultIssue.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultIssueService")]
    public partial interface ICrudeDefaultIssueService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByDefaultIssueId(System.Guid defaultIssueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultErrorId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultErrorIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultErrorId(System.Guid defaultErrorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueStatusRcd", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueStatusRcdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/DeleteResponse")]
        void Delete(System.Guid defaultIssueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByIssueName", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByIssueNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByIssueName(string issueName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultIssueServiceChannel : ICrudeDefaultIssueService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultIssueServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultIssueService>, ICrudeDefaultIssueService {
        
        public CrudeDefaultIssueServiceClient() {
        }
        
        public CrudeDefaultIssueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultIssueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByDefaultIssueId(System.Guid defaultIssueId) {
            return base.Channel.FetchByDefaultIssueId(defaultIssueId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultErrorId(System.Guid defaultErrorId) {
            return base.Channel.FetchByDefaultErrorId(defaultErrorId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            return base.Channel.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            return base.Channel.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultIssueId) {
            base.Channel.Delete(defaultIssueId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByIssueName(string issueName) {
            return base.Channel.FetchByIssueName(issueName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote) {
            return base.Channel.FetchWithFilter(
                defaultIssueId: defaultIssueId,
                defaultIssueTypeRcd: defaultIssueTypeRcd,
                defaultIssueStatusRcd: defaultIssueStatusRcd,
                defaultErrorId: defaultErrorId,
                issueName: issueName,
                issueDescription: issueDescription,
                stepsToReproduce: stepsToReproduce,
                link: link,
                defaultUserId: defaultUserId,
                dateTime: dateTime,
                fixedNote: fixedNote
                );
        }
    }
}
