/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:50:54 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultRule.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultRuleService")]
    public partial interface ICrudeDefaultRuleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleId", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/DeleteResponse")]
        void Delete(System.Guid defaultRuleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultRuleServiceChannel : ICrudeDefaultRuleService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultRuleServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultRuleService>, ICrudeDefaultRuleService {
        
        public CrudeDefaultRuleServiceClient() {
        }
        
        public CrudeDefaultRuleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultRuleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId) {
            return base.Channel.FetchByDefaultRuleId(defaultRuleId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            return base.Channel.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultRuleId) {
            base.Channel.Delete(defaultRuleId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultRuleId: defaultRuleId,
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                address: address,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
