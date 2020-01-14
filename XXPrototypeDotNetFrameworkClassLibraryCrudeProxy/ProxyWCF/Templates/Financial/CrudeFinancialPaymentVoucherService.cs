/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:24:47 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPaymentVoucher.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentVoucherService")]
    public partial interface ICrudeFinancialPaymentVoucherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByFinancialPaymentVo" +
            "ucherId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByFinancialPaymentVo" +
            "ucherIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByFinancialVoucherId" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByFinancialVoucherId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchByFinancialVoucherId(System.Guid financialVoucherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByFinancialCurrencyI" +
            "d", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchByFinancialCurrencyI" +
            "dResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/DeleteResponse")]
        void Delete(System.Guid financialPaymentVoucherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentVoucherService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchWithFilter(System.Guid financialPaymentVoucherId, System.Guid userId, System.DateTime dateTime, System.Guid financialVoucherId, decimal amount, System.Guid financialCurrencyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentVoucherServiceChannel : ICrudeFinancialPaymentVoucherService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentVoucherServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentVoucherService>, ICrudeFinancialPaymentVoucherService {
        
        public CrudeFinancialPaymentVoucherServiceClient() {
        }
        
        public CrudeFinancialPaymentVoucherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentVoucherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentVoucherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentVoucherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            return base.Channel.FetchByFinancialPaymentVoucherId(financialPaymentVoucherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchByFinancialVoucherId(System.Guid financialVoucherId) {
            return base.Channel.FetchByFinancialVoucherId(financialVoucherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialPaymentVoucherId) {
            base.Channel.Delete(financialPaymentVoucherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentVoucherContract> FetchWithFilter(System.Guid financialPaymentVoucherId, System.Guid userId, System.DateTime dateTime, System.Guid financialVoucherId, decimal amount, System.Guid financialCurrencyId) {
            return base.Channel.FetchWithFilter(
                financialPaymentVoucherId: financialPaymentVoucherId,
                userId: userId,
                dateTime: dateTime,
                financialVoucherId: financialVoucherId,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );
        }
    }
}
