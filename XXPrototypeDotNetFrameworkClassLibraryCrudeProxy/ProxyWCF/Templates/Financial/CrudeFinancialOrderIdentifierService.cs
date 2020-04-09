/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:44 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderIdentifier.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderIdentifierService")]
    public partial interface ICrudeFinancialOrderIdentifierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByFinancialOrderIde" +
            "ntifierId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByFinancialOrderIde" +
            "ntifierIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract FetchByFinancialOrderIdentifierId(System.Guid financialOrderIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByFinancialOrderId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByFinancialOrderIdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByFinancialOrderIde" +
            "ntifierTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchByFinancialOrderIde" +
            "ntifierTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/DeleteResponse")]
        void Delete(System.Guid financialOrderIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAllWithLimitRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAllWithLimitAndOffs" +
            "et", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAllWithLimitAndOffs" +
            "etResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchWithFilter(System.Guid financialOrderIdentifierId, System.Guid financialOrderId, string financialOrderIdentifierTypeRcd, string financialOrderIdentifierCode, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderIdentifierServiceChannel : ICrudeFinancialOrderIdentifierService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderIdentifierServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderIdentifierService>, ICrudeFinancialOrderIdentifierService {
        
        public CrudeFinancialOrderIdentifierServiceClient() {
        }
        
        public CrudeFinancialOrderIdentifierServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderIdentifierServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderIdentifierServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderIdentifierServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract FetchByFinancialOrderIdentifierId(System.Guid financialOrderIdentifierId) {
            return base.Channel.FetchByFinancialOrderIdentifierId(financialOrderIdentifierId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return base.Channel.FetchByFinancialOrderId(financialOrderId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            return base.Channel.FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialOrderIdentifierId) {
            base.Channel.Delete(financialOrderIdentifierId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierContract> FetchWithFilter(System.Guid financialOrderIdentifierId, System.Guid financialOrderId, string financialOrderIdentifierTypeRcd, string financialOrderIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialOrderIdentifierId: financialOrderIdentifierId,
                financialOrderId: financialOrderId,
                financialOrderIdentifierTypeRcd: financialOrderIdentifierTypeRcd,
                financialOrderIdentifierCode: financialOrderIdentifierCode,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
