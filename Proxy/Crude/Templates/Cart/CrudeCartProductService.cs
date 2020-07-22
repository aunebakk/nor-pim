/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:26 AM
  From Machine: DESKTOP-00MSEIL
  Filename: CartProduct.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeCartProductService")]
    public partial interface ICrudeCartProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByCartProductId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByCartProductIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByFinancialCurrencyIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchBySessionId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchBySessionIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchBySessionId(System.Guid sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByAspId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByAspIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByAspId(System.Guid aspId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByStateRcd(string stateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/Insert", ReplyAction="http://tempuri.org/ICrudeCartProductService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/Update", ReplyAction="http://tempuri.org/ICrudeCartProductService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/Delete", ReplyAction="http://tempuri.org/ICrudeCartProductService/DeleteResponse")]
        void Delete(System.Guid cartProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAll", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, System.Guid sessionId, string sessionIdentificator, System.Guid aspId, string stateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeCartProductServiceChannel : ICrudeCartProductService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeCartProductServiceClient : System.ServiceModel.ClientBase<ICrudeCartProductService>, ICrudeCartProductService {
        
        public CrudeCartProductServiceClient() {
        }
        
        public CrudeCartProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeCartProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId) {
            return base.Channel.FetchByCartProductId(cartProductId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchBySessionId(System.Guid sessionId) {
            return base.Channel.FetchBySessionId(sessionId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByAspId(System.Guid aspId) {
            return base.Channel.FetchByAspId(aspId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid cartProductId) {
            base.Channel.Delete(cartProductId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, System.Guid sessionId, string sessionIdentificator, System.Guid aspId, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                cartProductId: cartProductId,
                clientId: clientId,
                productId: productId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                sessionId: sessionId,
                sessionIdentificator: sessionIdentificator,
                aspId: aspId,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
