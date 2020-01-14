/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:43:07 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialAdjustmentTypeRef.json
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
    
    
    public partial class FinancialAdjustmentTypeRef {
        
        public const string RoundingRule = "RR";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialAdjustmentTypeRefService")]
    public partial interface ICrudeFinancialAdjustmentTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchByFinancialAdjust" +
            "mentTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchByFinancialAdjust" +
            "mentTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/DeleteResponse")]
        void Delete(string financialAdjustmentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchByFinancialAdjust" +
            "mentTypeName", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchByFinancialAdjust" +
            "mentTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeName(string financialAdjustmentTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAllWithLimitRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentTypeRefService/FetchWithFilterRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchWithFilter(string financialAdjustmentTypeRcd, string financialAdjustmentTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialAdjustmentTypeRefServiceChannel : ICrudeFinancialAdjustmentTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialAdjustmentTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialAdjustmentTypeRefService>, ICrudeFinancialAdjustmentTypeRefService {
        
        public CrudeFinancialAdjustmentTypeRefServiceClient() {
        }
        
        public CrudeFinancialAdjustmentTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialAdjustmentTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialAdjustmentTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialAdjustmentTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd) {
            return base.Channel.FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialAdjustmentTypeRcd) {
            base.Channel.Delete(financialAdjustmentTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeName(string financialAdjustmentTypeName) {
            return base.Channel.FetchByFinancialAdjustmentTypeName(financialAdjustmentTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentTypeRefContract> FetchWithFilter(string financialAdjustmentTypeRcd, string financialAdjustmentTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialAdjustmentTypeRcd: financialAdjustmentTypeRcd,
                financialAdjustmentTypeName: financialAdjustmentTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
