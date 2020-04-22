/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:21 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialTaxTypeRef.json
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
    
    
    public partial class FinancialTaxTypeRef {
        
        public const string OrderTax = "Order";
        
        public const string PaymentTax = "Payment";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialTaxTypeRefService")]
    public partial interface ICrudeFinancialTaxTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchByFinancialTaxTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchByFinancialTaxTypeRcdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/DeleteResponse")]
        void Delete(string financialTaxTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchByFinancialTaxTypeName", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchByFinancialTaxTypeNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeName(string financialTaxTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialTaxTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchWithFilter(string financialTaxTypeName, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialTaxTypeRefServiceChannel : ICrudeFinancialTaxTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialTaxTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialTaxTypeRefService>, ICrudeFinancialTaxTypeRefService {
        
        public CrudeFinancialTaxTypeRefServiceClient() {
        }
        
        public CrudeFinancialTaxTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialTaxTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialTaxTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialTaxTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            return base.Channel.FetchByFinancialTaxTypeRcd(financialTaxTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialTaxTypeRcd) {
            base.Channel.Delete(financialTaxTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeName(string financialTaxTypeName) {
            return base.Channel.FetchByFinancialTaxTypeName(financialTaxTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxTypeRefContract> FetchWithFilter(string financialTaxTypeName, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialTaxTypeName: financialTaxTypeName,
                financialTaxTypeRcd: financialTaxTypeRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
