/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:23:16 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPaymentBank.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentBankService")]
    public partial interface ICrudeFinancialPaymentBankService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByFinancialPaymentBankI" +
            "d", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByFinancialPaymentBankI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByFinancialCurrencyIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByFinancialBankAccountN" +
            "umberTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByFinancialBankAccountN" +
            "umberTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/DeleteResponse")]
        void Delete(System.Guid financialPaymentBankId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByBankName", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchByBankNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract FetchByBankName(string bankName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentBankService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchWithFilter(System.Guid financialPaymentBankId, System.Guid userId, System.DateTime dateTime, string bankName, string bankAccount, string bankNumber, string financialBankAccountNumberTypeRcd, decimal amount, System.Guid financialCurrencyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentBankServiceChannel : ICrudeFinancialPaymentBankService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentBankServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentBankService>, ICrudeFinancialPaymentBankService {
        
        public CrudeFinancialPaymentBankServiceClient() {
        }
        
        public CrudeFinancialPaymentBankServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentBankServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentBankServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentBankServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            return base.Channel.FetchByFinancialPaymentBankId(financialPaymentBankId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd) {
            return base.Channel.FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialPaymentBankId) {
            base.Channel.Delete(financialPaymentBankId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract FetchByBankName(string bankName) {
            return base.Channel.FetchByBankName(bankName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentBankContract> FetchWithFilter(System.Guid financialPaymentBankId, System.Guid userId, System.DateTime dateTime, string bankName, string bankAccount, string bankNumber, string financialBankAccountNumberTypeRcd, decimal amount, System.Guid financialCurrencyId) {
            return base.Channel.FetchWithFilter(
                financialPaymentBankId: financialPaymentBankId,
                userId: userId,
                dateTime: dateTime,
                bankName: bankName,
                bankAccount: bankAccount,
                bankNumber: bankNumber,
                financialBankAccountNumberTypeRcd: financialBankAccountNumberTypeRcd,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );
        }
    }
}
