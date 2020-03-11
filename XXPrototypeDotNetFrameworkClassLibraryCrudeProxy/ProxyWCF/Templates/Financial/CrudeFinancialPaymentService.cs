/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:58:03 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPayment.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentService")]
    public partial interface ICrudeFinancialPaymentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract FetchByFinancialPaymentId(System.Guid financialPaymentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentAccountin" +
            "gId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentAccountin" +
            "gIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentBankId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentBankIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentVoucherId" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentVoucherId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCardId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCardIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCashId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCashIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCouponId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCouponIdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/DeleteResponse")]
        void Delete(System.Guid financialPaymentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentServiceChannel : ICrudeFinancialPaymentService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentService>, ICrudeFinancialPaymentService {
        
        public CrudeFinancialPaymentServiceClient() {
        }
        
        public CrudeFinancialPaymentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            return base.Channel.FetchByFinancialPaymentId(financialPaymentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            return base.Channel.FetchByFinancialPaymentAccountingId(financialPaymentAccountingId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            return base.Channel.FetchByFinancialPaymentBankId(financialPaymentBankId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            return base.Channel.FetchByFinancialPaymentVoucherId(financialPaymentVoucherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            return base.Channel.FetchByFinancialPaymentCardId(financialPaymentCardId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            return base.Channel.FetchByFinancialPaymentCashId(financialPaymentCashId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            return base.Channel.FetchByFinancialPaymentCouponId(financialPaymentCouponId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            return base.Channel.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialPaymentId) {
            base.Channel.Delete(financialPaymentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId) {
            return base.Channel.FetchWithFilter(
                financialPaymentId: financialPaymentId,
                financialPaymentTypeRcd: financialPaymentTypeRcd,
                userId: userId,
                dateTime: dateTime,
                financialPaymentAccountingId: financialPaymentAccountingId,
                financialPaymentBankId: financialPaymentBankId,
                financialPaymentVoucherId: financialPaymentVoucherId,
                financialPaymentCardId: financialPaymentCardId,
                financialPaymentCashId: financialPaymentCashId,
                financialPaymentCouponId: financialPaymentCouponId
                );
        }
    }
}
