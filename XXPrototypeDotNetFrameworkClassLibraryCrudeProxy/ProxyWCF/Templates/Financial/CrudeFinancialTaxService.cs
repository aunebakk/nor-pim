/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:11 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialTax.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialTaxService")]
    public partial interface ICrudeFinancialTaxService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchByFinancialTaxId", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchByFinancialTaxIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract FetchByFinancialTaxId(System.Guid financialTaxId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchByFinancialCurrencyIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchByFinancialTaxTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchByFinancialTaxTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/DeleteResponse")]
        void Delete(System.Guid financialTaxId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialTaxService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialTaxService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchWithFilter(System.Guid financialTaxId, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialCurrencyId, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialTaxServiceChannel : ICrudeFinancialTaxService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialTaxServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialTaxService>, ICrudeFinancialTaxService {
        
        public CrudeFinancialTaxServiceClient() {
        }
        
        public CrudeFinancialTaxServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialTaxServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialTaxServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialTaxServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract FetchByFinancialTaxId(System.Guid financialTaxId) {
            return base.Channel.FetchByFinancialTaxId(financialTaxId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            return base.Channel.FetchByFinancialTaxTypeRcd(financialTaxTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialTaxId) {
            base.Channel.Delete(financialTaxId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialTaxContract> FetchWithFilter(System.Guid financialTaxId, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialCurrencyId, decimal amount) {
            return base.Channel.FetchWithFilter(
                financialTaxId: financialTaxId,
                financialTaxTypeRcd: financialTaxTypeRcd,
                userId: userId,
                dateTime: dateTime,
                financialCurrencyId: financialCurrencyId,
                amount: amount
                );
        }
    }
}
