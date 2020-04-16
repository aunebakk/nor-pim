/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:04 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderEvent.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderEventService")]
    public partial interface ICrudeFinancialOrderEventService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByFiancialOrderEventId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByFiancialOrderEventIdRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract FetchByFiancialOrderEventId(System.Guid fiancialOrderEventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByFinancialOrderId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByFinancialOrderIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByFinancialOrderEventTyp" +
            "eRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchByFinancialOrderEventTyp" +
            "eRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/DeleteResponse")]
        void Delete(System.Guid fiancialOrderEventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchWithFilter(System.Guid fiancialOrderEventId, System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, string financialOrderEventTypeRcd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderEventServiceChannel : ICrudeFinancialOrderEventService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderEventServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderEventService>, ICrudeFinancialOrderEventService {
        
        public CrudeFinancialOrderEventServiceClient() {
        }
        
        public CrudeFinancialOrderEventServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderEventServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderEventServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderEventServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract FetchByFiancialOrderEventId(System.Guid fiancialOrderEventId) {
            return base.Channel.FetchByFiancialOrderEventId(fiancialOrderEventId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return base.Channel.FetchByFinancialOrderId(financialOrderId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd) {
            return base.Channel.FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid fiancialOrderEventId) {
            base.Channel.Delete(fiancialOrderEventId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventContract> FetchWithFilter(System.Guid fiancialOrderEventId, System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, string financialOrderEventTypeRcd) {
            return base.Channel.FetchWithFilter(
                fiancialOrderEventId: fiancialOrderEventId,
                financialOrderId: financialOrderId,
                userId: userId,
                dateTime: dateTime,
                comment: comment,
                financialOrderEventTypeRcd: financialOrderEventTypeRcd
                );
        }
    }
}
