/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:00 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialCurrencyTypeRef.json
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
    
    
    public partial class FinancialCurrencyTypeRef {
        
        public const string Euro = "EUR";
        
        public const string NorwegianKrone = "NOK";
        
        public const string SwedishKrona = "SEK";
        
        public const string ThaiBath = "THB";
        
        public const string UnitedStatesDollar = "USD";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialCurrencyTypeRefService")]
    public partial interface ICrudeFinancialCurrencyTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchByFinancialCurrency" +
            "TypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchByFinancialCurrency" +
            "TypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/DeleteResponse")]
        void Delete(string financialCurrencyTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchByFinancialCurrency" +
            "TypeName", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchByFinancialCurrency" +
            "TypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAllWithLimitRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAllWithLimitAndOffs" +
            "et", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAllWithLimitAndOffs" +
            "etResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchWithFilter(string financialCurrencyTypeRcd, string financialCurrencyTypeName, System.Guid userId, System.DateTime dateTime, int decimalCount, string financialCurrencyTypeCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCurrencyTypeRefServiceChannel : ICrudeFinancialCurrencyTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialCurrencyTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCurrencyTypeRefService>, ICrudeFinancialCurrencyTypeRefService {
        
        public CrudeFinancialCurrencyTypeRefServiceClient() {
        }
        
        public CrudeFinancialCurrencyTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialCurrencyTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCurrencyTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCurrencyTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            return base.Channel.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialCurrencyTypeRcd) {
            base.Channel.Delete(financialCurrencyTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            return base.Channel.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyTypeRefContract> FetchWithFilter(string financialCurrencyTypeRcd, string financialCurrencyTypeName, System.Guid userId, System.DateTime dateTime, int decimalCount, string financialCurrencyTypeCode) {
            return base.Channel.FetchWithFilter(
                financialCurrencyTypeRcd: financialCurrencyTypeRcd,
                financialCurrencyTypeName: financialCurrencyTypeName,
                userId: userId,
                dateTime: dateTime,
                decimalCount: decimalCount,
                financialCurrencyTypeCode: financialCurrencyTypeCode
                );
        }
    }
}
