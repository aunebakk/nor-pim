/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:39:27 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderTransactionTypeRef.json
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
    
    
    public partial class FinancialOrderTransactionTypeRef {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderTransactionTypeRefService")]
    public partial interface ICrudeFinancialOrderTransactionTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchByFinancial" +
            "OrderTransactionTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchByFinancial" +
            "OrderTransactionTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchByUserIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/DeleteResponse")]
        void Delete(string financialOrderTransactionTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchByFinancial" +
            "OrderTransactionTypeName", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchByFinancial" +
            "OrderTransactionTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeName(string financialOrderTransactionTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAllResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAllWithLimi" +
            "t", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAllWithLimi" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAllWithLimi" +
            "tAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAllWithLimi" +
            "tAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchAllCountRes" +
            "ponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderTransactionTypeRefService/FetchWithFilterR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchWithFilter(string financialOrderTransactionTypeRcd, string financialOrderTransactionTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderTransactionTypeRefServiceChannel : ICrudeFinancialOrderTransactionTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderTransactionTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderTransactionTypeRefService>, ICrudeFinancialOrderTransactionTypeRefService {
        
        public CrudeFinancialOrderTransactionTypeRefServiceClient() {
        }
        
        public CrudeFinancialOrderTransactionTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderTransactionTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderTransactionTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderTransactionTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd) {
            return base.Channel.FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialOrderTransactionTypeRcd) {
            base.Channel.Delete(financialOrderTransactionTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeName(string financialOrderTransactionTypeName) {
            return base.Channel.FetchByFinancialOrderTransactionTypeName(financialOrderTransactionTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderTransactionTypeRefContract> FetchWithFilter(string financialOrderTransactionTypeRcd, string financialOrderTransactionTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialOrderTransactionTypeRcd: financialOrderTransactionTypeRcd,
                financialOrderTransactionTypeName: financialOrderTransactionTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
