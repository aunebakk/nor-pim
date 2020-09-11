/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:25 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultChangeLog.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultChangeLogService")]
    public partial interface ICrudeDefaultChangeLogService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogId", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultIssueId", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultIssueIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/DeleteResponse")]
        void Delete(System.Guid defaultChangeLogId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeName", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeNameResponse" +
            "")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultChangeLogServiceChannel : ICrudeDefaultChangeLogService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultChangeLogServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultChangeLogService>, ICrudeDefaultChangeLogService {
        
        public CrudeDefaultChangeLogServiceClient() {
        }
        
        public CrudeDefaultChangeLogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultChangeLogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultChangeLogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultChangeLogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            return base.Channel.FetchByDefaultChangeLogId(defaultChangeLogId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId) {
            return base.Channel.FetchByDefaultIssueId(defaultIssueId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            return base.Channel.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultChangeLogId) {
            base.Channel.Delete(defaultChangeLogId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName) {
            return base.Channel.FetchByDefaultChangeName(defaultChangeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            return base.Channel.FetchWithFilter(
                defaultChangeLogId: defaultChangeLogId,
                defaultChangeName: defaultChangeName,
                defaultChangeDescription: defaultChangeDescription,
                defaultUserId: defaultUserId,
                dateTime: dateTime,
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultIssueId: defaultIssueId
                );
        }
    }
}
