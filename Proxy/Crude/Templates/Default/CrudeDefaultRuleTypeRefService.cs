/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:25 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultRuleTypeRef.json
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

    public partial class DefaultRuleTypeRef {
        
        public const string HideLayerAddress = "Hide";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultRuleTypeRefService")]
    public partial interface ICrudeDefaultRuleTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeRcdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/DeleteResponse")]
        void Delete(string defaultRuleTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeName", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeNameResp" +
            "onse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimitAndOffsetResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultRuleTypeRefServiceChannel : ICrudeDefaultRuleTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultRuleTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultRuleTypeRefService>, ICrudeDefaultRuleTypeRefService {
        
        public CrudeDefaultRuleTypeRefServiceClient() {
        }
        
        public CrudeDefaultRuleTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultRuleTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            return base.Channel.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultRuleTypeRcd) {
            base.Channel.Delete(defaultRuleTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName) {
            return base.Channel.FetchByDefaultRuleTypeName(defaultRuleTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                defaultRuleTypeName: defaultRuleTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
