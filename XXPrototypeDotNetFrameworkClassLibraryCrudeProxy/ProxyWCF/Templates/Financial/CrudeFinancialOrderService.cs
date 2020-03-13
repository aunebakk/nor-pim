/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:41:29 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrder.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderService")]
    public partial interface ICrudeFinancialOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchByFinancialOrderId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchByFinancialOrderIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchByLocationAddressId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchByLocationAddressIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByLocationAddressId(System.Guid locationAddressId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchByFinancialCurrencyIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchByFinancialOrderSourceRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchByFinancialOrderSourceRcdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/DeleteResponse")]
        void Delete(System.Guid financialOrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderServiceChannel : ICrudeFinancialOrderService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderService>, ICrudeFinancialOrderService {
        
        public CrudeFinancialOrderServiceClient() {
        }
        
        public CrudeFinancialOrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract FetchByFinancialOrderId(System.Guid financialOrderId) {
            return base.Channel.FetchByFinancialOrderId(financialOrderId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByLocationAddressId(System.Guid locationAddressId) {
            return base.Channel.FetchByLocationAddressId(locationAddressId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            return base.Channel.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialOrderId) {
            base.Channel.Delete(financialOrderId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderContract> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId) {
            return base.Channel.FetchWithFilter(
                financialOrderId: financialOrderId,
                userId: userId,
                dateTime: dateTime,
                comment: comment,
                locationAddressId: locationAddressId,
                financialCurrencyId: financialCurrencyId,
                financialOrderSourceRcd: financialOrderSourceRcd,
                clientId: clientId
                );
        }
    }
}
