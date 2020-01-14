/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:08 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialAdjustment.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialAdjustmentService")]
    public partial interface ICrudeFinancialAdjustmentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByFinancialAdjustmentId", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByFinancialAdjustmentIdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByFinancialCurrencyIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByFinancialAdjustmentTyp" +
            "eRcd", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchByFinancialAdjustmentTyp" +
            "eRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/DeleteResponse")]
        void Delete(System.Guid financialAdjustmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialAdjustmentService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchWithFilter(System.Guid financialAdjustmentId, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialAdjustmentTypeRcd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialAdjustmentServiceChannel : ICrudeFinancialAdjustmentService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialAdjustmentServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialAdjustmentService>, ICrudeFinancialAdjustmentService {
        
        public CrudeFinancialAdjustmentServiceClient() {
        }
        
        public CrudeFinancialAdjustmentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialAdjustmentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialAdjustmentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialAdjustmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            return base.Channel.FetchByFinancialAdjustmentId(financialAdjustmentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd) {
            return base.Channel.FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialAdjustmentId) {
            base.Channel.Delete(financialAdjustmentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialAdjustmentContract> FetchWithFilter(System.Guid financialAdjustmentId, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialAdjustmentTypeRcd) {
            return base.Channel.FetchWithFilter(
                financialAdjustmentId: financialAdjustmentId,
                amount: amount,
                financialCurrencyId: financialCurrencyId,
                userId: userId,
                dateTime: dateTime,
                financialAdjustmentTypeRcd: financialAdjustmentTypeRcd
                );
        }
    }
}
