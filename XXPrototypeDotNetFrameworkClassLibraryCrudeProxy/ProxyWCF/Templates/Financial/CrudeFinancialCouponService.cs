/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:23:13 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialCoupon.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialCouponService")]
    public partial interface ICrudeFinancialCouponService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchByFinancialCouponId", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchByFinancialCouponIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract FetchByFinancialCouponId(System.Guid financialCouponId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchByFinancialCurrencyIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchByFinancialCouponTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchByFinancialCouponTypeRcdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/DeleteResponse")]
        void Delete(System.Guid financialCouponId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialCouponService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchWithFilter(System.Guid financialCouponId, int couponNumber, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, string couponDescription, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialCouponTypeRcd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCouponServiceChannel : ICrudeFinancialCouponService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialCouponServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCouponService>, ICrudeFinancialCouponService {
        
        public CrudeFinancialCouponServiceClient() {
        }
        
        public CrudeFinancialCouponServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialCouponServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCouponServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCouponServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract FetchByFinancialCouponId(System.Guid financialCouponId) {
            return base.Channel.FetchByFinancialCouponId(financialCouponId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            return base.Channel.FetchByFinancialCouponTypeRcd(financialCouponTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialCouponId) {
            base.Channel.Delete(financialCouponId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponContract> FetchWithFilter(System.Guid financialCouponId, int couponNumber, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, string couponDescription, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialCouponTypeRcd) {
            return base.Channel.FetchWithFilter(
                financialCouponId: financialCouponId,
                couponNumber: couponNumber,
                valueAmount: valueAmount,
                validFromDateTime: validFromDateTime,
                validUntilDateTime: validUntilDateTime,
                couponDescription: couponDescription,
                financialCurrencyId: financialCurrencyId,
                userId: userId,
                dateTime: dateTime,
                financialCouponTypeRcd: financialCouponTypeRcd
                );
        }
    }
}
