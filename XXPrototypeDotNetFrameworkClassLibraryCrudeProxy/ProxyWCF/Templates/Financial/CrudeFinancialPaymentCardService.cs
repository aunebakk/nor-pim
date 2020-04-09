/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:45 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPaymentCard.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentCardService")]
    public partial interface ICrudeFinancialPaymentCardService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByFinancialPaymentCardI" +
            "d", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByFinancialPaymentCardI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByFinancialCurrencyIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByFinancialCardTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchByFinancialCardTypeRcdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchByFinancialCardTypeRcd(string financialCardTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/DeleteResponse")]
        void Delete(System.Guid financialPaymentCardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCardService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchWithFilter(System.Guid financialPaymentCardId, System.Guid userId, System.DateTime dateTime, string cardNumber, string nameOnCard, int expiryYear, int expiryMonth, string financialCardTypeRcd, int cardVerificationValue, int issuedMonth, int issuedYear, string addressVerificationCode, decimal amount, System.Guid financialCurrencyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentCardServiceChannel : ICrudeFinancialPaymentCardService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentCardServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentCardService>, ICrudeFinancialPaymentCardService {
        
        public CrudeFinancialPaymentCardServiceClient() {
        }
        
        public CrudeFinancialPaymentCardServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentCardServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentCardServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentCardServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            return base.Channel.FetchByFinancialPaymentCardId(financialPaymentCardId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            return base.Channel.FetchByFinancialCardTypeRcd(financialCardTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialPaymentCardId) {
            base.Channel.Delete(financialPaymentCardId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCardContract> FetchWithFilter(System.Guid financialPaymentCardId, System.Guid userId, System.DateTime dateTime, string cardNumber, string nameOnCard, int expiryYear, int expiryMonth, string financialCardTypeRcd, int cardVerificationValue, int issuedMonth, int issuedYear, string addressVerificationCode, decimal amount, System.Guid financialCurrencyId) {
            return base.Channel.FetchWithFilter(
                financialPaymentCardId: financialPaymentCardId,
                userId: userId,
                dateTime: dateTime,
                cardNumber: cardNumber,
                nameOnCard: nameOnCard,
                expiryYear: expiryYear,
                expiryMonth: expiryMonth,
                financialCardTypeRcd: financialCardTypeRcd,
                cardVerificationValue: cardVerificationValue,
                issuedMonth: issuedMonth,
                issuedYear: issuedYear,
                addressVerificationCode: addressVerificationCode,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );
        }
    }
}
