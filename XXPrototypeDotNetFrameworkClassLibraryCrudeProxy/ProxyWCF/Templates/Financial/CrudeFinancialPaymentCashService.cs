/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:27 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPaymentCash.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentCashService")]
    public partial interface ICrudeFinancialPaymentCashService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchByFinancialPaymentCashI" +
            "d", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchByFinancialPaymentCashI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchByFinancialCurrencyIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/DeleteResponse")]
        void Delete(System.Guid financialPaymentCashId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCashService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchWithFilter(System.Guid financialPaymentCashId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentCashServiceChannel : ICrudeFinancialPaymentCashService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentCashServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentCashService>, ICrudeFinancialPaymentCashService {
        
        public CrudeFinancialPaymentCashServiceClient() {
        }
        
        public CrudeFinancialPaymentCashServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentCashServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentCashServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentCashServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            return base.Channel.FetchByFinancialPaymentCashId(financialPaymentCashId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialPaymentCashId) {
            base.Channel.Delete(financialPaymentCashId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCashContract> FetchWithFilter(System.Guid financialPaymentCashId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            return base.Channel.FetchWithFilter(
                financialPaymentCashId: financialPaymentCashId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );
        }
    }
}
