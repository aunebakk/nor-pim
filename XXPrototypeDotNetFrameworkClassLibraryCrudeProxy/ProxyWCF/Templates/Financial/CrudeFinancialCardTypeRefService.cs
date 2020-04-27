/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:27 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialCardTypeRef.json
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
    
    
    public partial class FinancialCardTypeRef {
        
        public const string AmericanExpress = "AmEx";
        
        public const string MasterCard = "Master";
        
        public const string Visa = "Visa";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialCardTypeRefService")]
    public partial interface ICrudeFinancialCardTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchByFinancialCardTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchByFinancialCardTypeRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeRcd(string financialCardTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/DeleteResponse")]
        void Delete(string financialCardTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchByFinancialCardTypeName" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchByFinancialCardTypeName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeName(string financialCardTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialCardTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchWithFilter(string financialCardTypeRcd, string financialCardTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCardTypeRefServiceChannel : ICrudeFinancialCardTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialCardTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCardTypeRefService>, ICrudeFinancialCardTypeRefService {
        
        public CrudeFinancialCardTypeRefServiceClient() {
        }
        
        public CrudeFinancialCardTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialCardTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCardTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCardTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            return base.Channel.FetchByFinancialCardTypeRcd(financialCardTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialCardTypeRcd) {
            base.Channel.Delete(financialCardTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeName(string financialCardTypeName) {
            return base.Channel.FetchByFinancialCardTypeName(financialCardTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCardTypeRefContract> FetchWithFilter(string financialCardTypeRcd, string financialCardTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialCardTypeRcd: financialCardTypeRcd,
                financialCardTypeName: financialCardTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
