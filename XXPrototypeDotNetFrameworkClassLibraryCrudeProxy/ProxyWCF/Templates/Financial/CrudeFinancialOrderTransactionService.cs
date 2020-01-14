/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:01 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderTransaction.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderTransactionService")]
    public partial interface ICrudeFinancialOrderTransactionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialBooking" +
            "TransactionId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialBooking" +
            "TransactionIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialFeeId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialFeeIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialFeeId(System.Guid financialFeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialTaxId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialTaxIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialTaxId(System.Guid financialTaxId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialPayment" +
            "Id", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialPayment" +
            "IdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialPaymentId(System.Guid financialPaymentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialCurrenc" +
            "yId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialCurrenc" +
            "yIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialCostcen" +
            "treId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialCostcen" +
            "treIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialCostcentreId(System.Guid financialCostcentreId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialAdjustm" +
            "entId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialAdjustm" +
            "entIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialOrderId" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialOrderId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialOrderTr" +
            "ansactionTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchByFinancialOrderTr" +
            "ansactionTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/DeleteResponse")]
        void Delete(System.Guid financialBookingTransactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAllWithLimitRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAllWithLimitAndOff" +
            "set", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAllWithLimitAndOff" +
            "setResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionService/FetchWithFilterResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, int transactionNumber, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, string financialOrderTransactionTypeRcd, System.Guid financialOrderId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderTransactionServiceChannel : ICrudeFinancialOrderTransactionService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderTransactionServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderTransactionService>, ICrudeFinancialOrderTransactionService {
        
        public CrudeFinancialOrderTransactionServiceClient() {
        }
        
        public CrudeFinancialOrderTransactionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderTransactionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderTransactionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderTransactionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId) {
            return base.Channel.FetchByFinancialBookingTransactionId(financialBookingTransactionId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialFeeId(System.Guid financialFeeId) {
            return base.Channel.FetchByFinancialFeeId(financialFeeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialTaxId(System.Guid financialTaxId) {
            return base.Channel.FetchByFinancialTaxId(financialTaxId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            return base.Channel.FetchByFinancialPaymentId(financialPaymentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            return base.Channel.FetchByFinancialCostcentreId(financialCostcentreId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            return base.Channel.FetchByFinancialAdjustmentId(financialAdjustmentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return base.Channel.FetchByFinancialOrderId(financialOrderId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd) {
            return base.Channel.FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialBookingTransactionId) {
            base.Channel.Delete(financialBookingTransactionId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionContract> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, int transactionNumber, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, string financialOrderTransactionTypeRcd, System.Guid financialOrderId) {
            return base.Channel.FetchWithFilter(
                financialBookingTransactionId: financialBookingTransactionId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialFeeId: financialFeeId,
                financialTaxId: financialTaxId,
                financialPaymentId: financialPaymentId,
                financialCurrencyId: financialCurrencyId,
                transactionNumber: transactionNumber,
                financialCostcentreId: financialCostcentreId,
                financialAdjustmentId: financialAdjustmentId,
                financialOrderTransactionTypeRcd: financialOrderTransactionTypeRcd,
                financialOrderId: financialOrderId
                );
        }
    }
}
