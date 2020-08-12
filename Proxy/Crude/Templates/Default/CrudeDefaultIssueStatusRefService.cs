/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:25 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultIssueStatusRef.json
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

    public partial class DefaultIssueStatusRef {
        
        public const string NotAnIssue = "NotAnIssue";
        
        public const string NotReproducible = "NotReproducible";
        
        public const string Resolved = "Resolved";
        
        public const string ToBeResolved = "ToBeResolved";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultIssueStatusRefService")]
    public partial interface ICrudeDefaultIssueStatusRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusRc" +
            "d", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusRc" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultUserIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/DeleteResponse")]
        void Delete(string defaultIssueStatusRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusNa" +
            "me", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusNa" +
            "meResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusName(string defaultIssueStatusName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimitAndOffsetR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultIssueStatusRefServiceChannel : ICrudeDefaultIssueStatusRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultIssueStatusRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultIssueStatusRefService>, ICrudeDefaultIssueStatusRefService {
        
        public CrudeDefaultIssueStatusRefServiceClient() {
        }
        
        public CrudeDefaultIssueStatusRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultIssueStatusRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueStatusRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueStatusRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            return base.Channel.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultIssueStatusRcd) {
            base.Channel.Delete(defaultIssueStatusRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusName(string defaultIssueStatusName) {
            return base.Channel.FetchByDefaultIssueStatusName(defaultIssueStatusName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultIssueStatusRcd: defaultIssueStatusRcd,
                defaultIssueStatusName: defaultIssueStatusName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
