/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:44:04 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderIdentifierTypeRef.json
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
    
    
    public partial class FinancialOrderIdentifierTypeRef {
        
        public const string InternalOrderNumber = "ION";
        
        public const string ExternalOrderNumber = "EON";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderIdentifierTypeRefService")]
    public partial interface ICrudeFinancialOrderIdentifierTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchByFinancialO" +
            "rderIdentifierTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchByFinancialO" +
            "rderIdentifierTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchByUserIdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/DeleteResponse")]
        void Delete(string financialOrderIdentifierTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchByFinancialO" +
            "rderIdentifierTypeName", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchByFinancialO" +
            "rderIdentifierTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeName(string financialOrderIdentifierTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAllWithLimit" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAllWithLimit" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAllWithLimit" +
            "AndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAllWithLimit" +
            "AndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchAllCountResp" +
            "onse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderIdentifierTypeRefService/FetchWithFilterRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchWithFilter(string financialOrderIdentifierTypeRcd, string financialOrderIdentifierTypeCode, string financialOrderIdentifierTypeName, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderIdentifierTypeRefServiceChannel : ICrudeFinancialOrderIdentifierTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderIdentifierTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderIdentifierTypeRefService>, ICrudeFinancialOrderIdentifierTypeRefService {
        
        public CrudeFinancialOrderIdentifierTypeRefServiceClient() {
        }
        
        public CrudeFinancialOrderIdentifierTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderIdentifierTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderIdentifierTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderIdentifierTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            return base.Channel.FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialOrderIdentifierTypeRcd) {
            base.Channel.Delete(financialOrderIdentifierTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeName(string financialOrderIdentifierTypeName) {
            return base.Channel.FetchByFinancialOrderIdentifierTypeName(financialOrderIdentifierTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderIdentifierTypeRefContract> FetchWithFilter(string financialOrderIdentifierTypeRcd, string financialOrderIdentifierTypeCode, string financialOrderIdentifierTypeName, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialOrderIdentifierTypeRcd: financialOrderIdentifierTypeRcd,
                financialOrderIdentifierTypeCode: financialOrderIdentifierTypeCode,
                financialOrderIdentifierTypeName: financialOrderIdentifierTypeName,
                sortSequenceNumber: sortSequenceNumber,
                changeFlag: changeFlag,
                statusCode: statusCode,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
