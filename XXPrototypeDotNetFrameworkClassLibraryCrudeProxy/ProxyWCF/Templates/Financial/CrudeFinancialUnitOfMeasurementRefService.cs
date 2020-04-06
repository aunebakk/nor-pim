/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:23:18 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialUnitOfMeasurementRef.json
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
    
    
    public partial class FinancialUnitOfMeasurementRef {
        
        public const string Pieces = "P";
        
        public const string Meter = "M";
        
        public const string Centimeter = "C";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialUnitOfMeasurementRefService")]
    public partial interface ICrudeFinancialUnitOfMeasurementRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchByFinancialUni" +
            "tOfMeasurementRcd", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchByFinancialUni" +
            "tOfMeasurementRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchByUserIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/DeleteResponse")]
        void Delete(string financialUnitOfMeasurementRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchByFinancialUni" +
            "tOfMeasurementName", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchByFinancialUni" +
            "tOfMeasurementNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementName(string financialUnitOfMeasurementName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAllWithLimitRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAllWithLimitAn" +
            "dOffset", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAllWithLimitAn" +
            "dOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchAllCountRespon" +
            "se")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialUnitOfMeasurementRefService/FetchWithFilterResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchWithFilter(string financialUnitOfMeasurementRcd, int sortSequenceNumber, bool changeFlag, string statusCode, string financialUnitOfMeasurementName, string financialUnitOfMeasurementCode, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialUnitOfMeasurementRefServiceChannel : ICrudeFinancialUnitOfMeasurementRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialUnitOfMeasurementRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialUnitOfMeasurementRefService>, ICrudeFinancialUnitOfMeasurementRefService {
        
        public CrudeFinancialUnitOfMeasurementRefServiceClient() {
        }
        
        public CrudeFinancialUnitOfMeasurementRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialUnitOfMeasurementRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialUnitOfMeasurementRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialUnitOfMeasurementRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            return base.Channel.FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialUnitOfMeasurementRcd) {
            base.Channel.Delete(financialUnitOfMeasurementRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementName(string financialUnitOfMeasurementName) {
            return base.Channel.FetchByFinancialUnitOfMeasurementName(financialUnitOfMeasurementName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialUnitOfMeasurementRefContract> FetchWithFilter(string financialUnitOfMeasurementRcd, int sortSequenceNumber, bool changeFlag, string statusCode, string financialUnitOfMeasurementName, string financialUnitOfMeasurementCode, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialUnitOfMeasurementRcd: financialUnitOfMeasurementRcd,
                sortSequenceNumber: sortSequenceNumber,
                changeFlag: changeFlag,
                statusCode: statusCode,
                financialUnitOfMeasurementName: financialUnitOfMeasurementName,
                financialUnitOfMeasurementCode: financialUnitOfMeasurementCode,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
