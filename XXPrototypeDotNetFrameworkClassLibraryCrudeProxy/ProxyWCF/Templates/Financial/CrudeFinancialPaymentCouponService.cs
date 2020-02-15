/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:39:28 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPaymentCoupon.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentCouponService")]
    public partial interface ICrudeFinancialPaymentCouponService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByFinancialPaymentCou" +
            "ponId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByFinancialPaymentCou" +
            "ponIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByFinancialCouponId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByFinancialCouponIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchByFinancialCouponId(System.Guid financialCouponId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByFinancialCurrencyId" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchByFinancialCurrencyId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/DeleteResponse")]
        void Delete(System.Guid financialPaymentCouponId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentCouponService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchWithFilter(System.Guid financialPaymentCouponId, System.Guid financialCouponId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentCouponServiceChannel : ICrudeFinancialPaymentCouponService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentCouponServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentCouponService>, ICrudeFinancialPaymentCouponService {
        
        public CrudeFinancialPaymentCouponServiceClient() {
        }
        
        public CrudeFinancialPaymentCouponServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentCouponServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentCouponServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentCouponServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            return base.Channel.FetchByFinancialPaymentCouponId(financialPaymentCouponId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchByFinancialCouponId(System.Guid financialCouponId) {
            return base.Channel.FetchByFinancialCouponId(financialCouponId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialPaymentCouponId) {
            base.Channel.Delete(financialPaymentCouponId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentCouponContract> FetchWithFilter(System.Guid financialPaymentCouponId, System.Guid financialCouponId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            return base.Channel.FetchWithFilter(
                financialPaymentCouponId: financialPaymentCouponId,
                financialCouponId: financialCouponId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );
        }
    }
}
