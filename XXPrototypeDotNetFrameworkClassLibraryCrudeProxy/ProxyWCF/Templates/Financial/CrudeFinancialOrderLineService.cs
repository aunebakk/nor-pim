/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:21 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderLine.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderLineService")]
    public partial interface ICrudeFinancialOrderLineService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialOrderLineId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialOrderLineIdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract FetchByFinancialOrderLineId(System.Guid financialOrderLineId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialOrderId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialOrderIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialCurrencyIdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialUnitOfMeasurem" +
            "entRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchByFinancialUnitOfMeasurem" +
            "entRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/DeleteResponse")]
        void Delete(System.Guid financialOrderLineId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAllWithLimitAndOffsetResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderLineService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderLineService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchWithFilter(System.Guid financialOrderLineId, System.Guid financialOrderId, System.Guid productId, System.Guid userId, System.DateTime dateTime, string comment, int lineNumber, string financialUnitOfMeasurementRcd, int quantityNumber, System.Guid financialCurrencyId, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderLineServiceChannel : ICrudeFinancialOrderLineService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderLineServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderLineService>, ICrudeFinancialOrderLineService {
        
        public CrudeFinancialOrderLineServiceClient() {
        }
        
        public CrudeFinancialOrderLineServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderLineServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderLineServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderLineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract FetchByFinancialOrderLineId(System.Guid financialOrderLineId) {
            return base.Channel.FetchByFinancialOrderLineId(financialOrderLineId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return base.Channel.FetchByFinancialOrderId(financialOrderId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            return base.Channel.FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialOrderLineId) {
            base.Channel.Delete(financialOrderLineId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderLineContract> FetchWithFilter(System.Guid financialOrderLineId, System.Guid financialOrderId, System.Guid productId, System.Guid userId, System.DateTime dateTime, string comment, int lineNumber, string financialUnitOfMeasurementRcd, int quantityNumber, System.Guid financialCurrencyId, decimal amount) {
            return base.Channel.FetchWithFilter(
                financialOrderLineId: financialOrderLineId,
                financialOrderId: financialOrderId,
                productId: productId,
                userId: userId,
                dateTime: dateTime,
                comment: comment,
                lineNumber: lineNumber,
                financialUnitOfMeasurementRcd: financialUnitOfMeasurementRcd,
                quantityNumber: quantityNumber,
                financialCurrencyId: financialCurrencyId,
                amount: amount
                );
        }
    }
}
