/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:19:13 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialBankAccountNumberTypeRef.json
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
    
    
    public partial class FinancialBankAccountNumberTypeRef {
        
        public const string InternationalBankAccount = "IBAN";
        
        public const string SocietyWorldwideInterbankFinancialTelecommunication = "SWIFT";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialBankAccountNumberTypeRefService")]
    public partial interface ICrudeFinancialBankAccountNumberTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchByFinancia" +
            "lBankAccountNumberTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchByFinancia" +
            "lBankAccountNumberTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchByUserIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/DeleteResponse")]
        void Delete(string financialBankAccountNumberTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchByFinancia" +
            "lBankAccountNumberTypeName", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchByFinancia" +
            "lBankAccountNumberTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeName(string financialBankAccountNumberTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAllRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAllWithLim" +
            "it", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAllWithLim" +
            "itResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAllWithLim" +
            "itAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAllWithLim" +
            "itAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchAllCountRe" +
            "sponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchWithFilter" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialBankAccountNumberTypeRefService/FetchWithFilter" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchWithFilter(string financialBankAccountNumberTypeRcd, string financialBankAccountNumberTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialBankAccountNumberTypeRefServiceChannel : ICrudeFinancialBankAccountNumberTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialBankAccountNumberTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialBankAccountNumberTypeRefService>, ICrudeFinancialBankAccountNumberTypeRefService {
        
        public CrudeFinancialBankAccountNumberTypeRefServiceClient() {
        }
        
        public CrudeFinancialBankAccountNumberTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialBankAccountNumberTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialBankAccountNumberTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialBankAccountNumberTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd) {
            return base.Channel.FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialBankAccountNumberTypeRcd) {
            base.Channel.Delete(financialBankAccountNumberTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeName(string financialBankAccountNumberTypeName) {
            return base.Channel.FetchByFinancialBankAccountNumberTypeName(financialBankAccountNumberTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialBankAccountNumberTypeRefContract> FetchWithFilter(string financialBankAccountNumberTypeRcd, string financialBankAccountNumberTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialBankAccountNumberTypeRcd: financialBankAccountNumberTypeRcd,
                financialBankAccountNumberTypeName: financialBankAccountNumberTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
