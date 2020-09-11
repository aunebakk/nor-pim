/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:25 AM
  From Machine: DESKTOP-517I8BU
  Filename: ClientEvent.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientEventService")]
    public partial interface ICrudeClientEventService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchByClientEventId", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchByClientEventIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract FetchByClientEventId(System.Guid clientEventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchByClientEventTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchByClientEventTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchByClientEventTypeRcd(string clientEventTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/Insert", ReplyAction="http://tempuri.org/ICrudeClientEventService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/Update", ReplyAction="http://tempuri.org/ICrudeClientEventService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/Delete", ReplyAction="http://tempuri.org/ICrudeClientEventService/DeleteResponse")]
        void Delete(System.Guid clientEventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientEventService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientEventServiceChannel : ICrudeClientEventService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientEventServiceClient : System.ServiceModel.ClientBase<ICrudeClientEventService>, ICrudeClientEventService {
        
        public CrudeClientEventServiceClient() {
        }
        
        public CrudeClientEventServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientEventServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientEventServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientEventServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract FetchByClientEventId(System.Guid clientEventId) {
            return base.Channel.FetchByClientEventId(clientEventId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            return base.Channel.FetchByClientEventTypeRcd(clientEventTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid clientEventId) {
            base.Channel.Delete(clientEventId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventContract> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientEventId: clientEventId,
                clientId: clientId,
                clientEventTypeRcd: clientEventTypeRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
