/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:43:08 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialFeeTypeRef.json
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
    
    
    public partial class FinancialFeeTypeRef {
        
        public const string ExpressHandlingFee = "Ex";
        
        public const string PaymentFee = "Payment";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialFeeTypeRefService")]
    public partial interface ICrudeFinancialFeeTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchByFinancialFeeTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchByFinancialFeeTypeRcdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/DeleteResponse")]
        void Delete(string financialFeeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchByFinancialFeeTypeName", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchByFinancialFeeTypeNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeName(string financialFeeTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialFeeTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchWithFilter(string financialFeeTypeRcd, string financialFeeTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialFeeTypeRefServiceChannel : ICrudeFinancialFeeTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialFeeTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialFeeTypeRefService>, ICrudeFinancialFeeTypeRefService {
        
        public CrudeFinancialFeeTypeRefServiceClient() {
        }
        
        public CrudeFinancialFeeTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialFeeTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialFeeTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialFeeTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd) {
            return base.Channel.FetchByFinancialFeeTypeRcd(financialFeeTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialFeeTypeRcd) {
            base.Channel.Delete(financialFeeTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeName(string financialFeeTypeName) {
            return base.Channel.FetchByFinancialFeeTypeName(financialFeeTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeTypeRefContract> FetchWithFilter(string financialFeeTypeRcd, string financialFeeTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialFeeTypeRcd: financialFeeTypeRcd,
                financialFeeTypeName: financialFeeTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
