/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:21 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialCouponTypeRef.json
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
    
    
    public partial class FinancialCouponTypeRef {
        
        public const string LoungeCoupon = "LC";
        
        public const string MealCoupon = "MC";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialCouponTypeRefService")]
    public partial interface ICrudeFinancialCouponTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchByFinancialCouponType" +
            "Rcd", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchByFinancialCouponType" +
            "RcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/DeleteResponse")]
        void Delete(string financialCouponTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchByFinancialCouponType" +
            "Name", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchByFinancialCouponType" +
            "NameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeName(string financialCouponTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialCouponTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchWithFilter(string financialCouponTypeRcd, string financialCouponTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCouponTypeRefServiceChannel : ICrudeFinancialCouponTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialCouponTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCouponTypeRefService>, ICrudeFinancialCouponTypeRefService {
        
        public CrudeFinancialCouponTypeRefServiceClient() {
        }
        
        public CrudeFinancialCouponTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialCouponTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCouponTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCouponTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            return base.Channel.FetchByFinancialCouponTypeRcd(financialCouponTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialCouponTypeRcd) {
            base.Channel.Delete(financialCouponTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeName(string financialCouponTypeName) {
            return base.Channel.FetchByFinancialCouponTypeName(financialCouponTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCouponTypeRefContract> FetchWithFilter(string financialCouponTypeRcd, string financialCouponTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialCouponTypeRcd: financialCouponTypeRcd,
                financialCouponTypeName: financialCouponTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
