/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:01 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPaymentAccounting.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentAccountingService")]
    public partial interface ICrudeFinancialPaymentAccountingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchByFinancialPaymen" +
            "tAccountingId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchByFinancialPaymen" +
            "tAccountingIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchByFinancialCurren" +
            "cyId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchByFinancialCurren" +
            "cyIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/DeleteResponse")]
        void Delete(System.Guid financialPaymentAccountingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAllWithLimitRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentAccountingService/FetchWithFilterRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchWithFilter(System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentAccountingServiceChannel : ICrudeFinancialPaymentAccountingService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentAccountingServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentAccountingService>, ICrudeFinancialPaymentAccountingService {
        
        public CrudeFinancialPaymentAccountingServiceClient() {
        }
        
        public CrudeFinancialPaymentAccountingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentAccountingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentAccountingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentAccountingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            return base.Channel.FetchByFinancialPaymentAccountingId(financialPaymentAccountingId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialPaymentAccountingId) {
            base.Channel.Delete(financialPaymentAccountingId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentAccountingContract> FetchWithFilter(System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            return base.Channel.FetchWithFilter(
                financialPaymentAccountingId: financialPaymentAccountingId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );
        }
    }
}
