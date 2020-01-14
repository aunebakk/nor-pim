/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:01 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderSourceRef.json
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
    
    
    public partial class FinancialOrderSourceRef {
        
        public const string InternalSystem = "IS";
        
        public const string WEBFront = "WEB";
        
        public const string TestData = "T";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderSourceRefService")]
    public partial interface ICrudeFinancialOrderSourceRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchByFinancialOrderSour" +
            "ceRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchByFinancialOrderSour" +
            "ceRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/DeleteResponse")]
        void Delete(string financialOrderSourceRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchByFinancialOrderSour" +
            "ceName", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchByFinancialOrderSour" +
            "ceNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceName(string financialOrderSourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderSourceRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchWithFilter(string financialOrderSourceRcd, string financialOrderSourceName, string financialOrderSourceCode, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderSourceRefServiceChannel : ICrudeFinancialOrderSourceRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderSourceRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderSourceRefService>, ICrudeFinancialOrderSourceRefService {
        
        public CrudeFinancialOrderSourceRefServiceClient() {
        }
        
        public CrudeFinancialOrderSourceRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderSourceRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderSourceRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderSourceRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            return base.Channel.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialOrderSourceRcd) {
            base.Channel.Delete(financialOrderSourceRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceName(string financialOrderSourceName) {
            return base.Channel.FetchByFinancialOrderSourceName(financialOrderSourceName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderSourceRefContract> FetchWithFilter(string financialOrderSourceRcd, string financialOrderSourceName, string financialOrderSourceCode, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialOrderSourceRcd: financialOrderSourceRcd,
                financialOrderSourceName: financialOrderSourceName,
                financialOrderSourceCode: financialOrderSourceCode,
                sortSequenceNumber: sortSequenceNumber,
                changeFlag: changeFlag,
                statusCode: statusCode,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
