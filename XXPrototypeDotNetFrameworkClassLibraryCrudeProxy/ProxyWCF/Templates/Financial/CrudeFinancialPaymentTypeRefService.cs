/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:46 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialPaymentTypeRef.json
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
    
    
    public partial class FinancialPaymentTypeRef {
        
        public const string Accounting = "ACC";
        
        public const string Bank = "BANK";
        
        public const string Card = "CARD";
        
        public const string Cash = "CASH";
        
        public const string Coupon = "COUPON";
        
        public const string StandardPayment = "STD";
        
        public const string Voucher = "VOU";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentTypeRefService")]
    public partial interface ICrudeFinancialPaymentTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchByFinancialPaymentTy" +
            "peRcd", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchByFinancialPaymentTy" +
            "peRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/DeleteResponse")]
        void Delete(string financialPaymentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchByFinancialPaymentTy" +
            "peName", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchByFinancialPaymentTy" +
            "peNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeName(string financialPaymentTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchWithFilter(string financialPaymentTypeRcd, string financialPaymentTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentTypeRefServiceChannel : ICrudeFinancialPaymentTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialPaymentTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentTypeRefService>, ICrudeFinancialPaymentTypeRefService {
        
        public CrudeFinancialPaymentTypeRefServiceClient() {
        }
        
        public CrudeFinancialPaymentTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            return base.Channel.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialPaymentTypeRcd) {
            base.Channel.Delete(financialPaymentTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeName(string financialPaymentTypeName) {
            return base.Channel.FetchByFinancialPaymentTypeName(financialPaymentTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialPaymentTypeRefContract> FetchWithFilter(string financialPaymentTypeRcd, string financialPaymentTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialPaymentTypeRcd: financialPaymentTypeRcd,
                financialPaymentTypeName: financialPaymentTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
