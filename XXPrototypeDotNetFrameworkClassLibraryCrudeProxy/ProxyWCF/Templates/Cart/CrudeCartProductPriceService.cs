/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:37:00 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Cart\CartProductPrice.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeCartProductPriceService")]
    public partial interface ICrudeCartProductPriceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByCartProductPriceId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByCartProductPriceIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByFinancialCurrencyIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/Insert", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/Update", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/Delete", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/DeleteResponse")]
        void Delete(System.Guid cartProductPriceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAll", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeCartProductPriceServiceChannel : ICrudeCartProductPriceService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeCartProductPriceServiceClient : System.ServiceModel.ClientBase<ICrudeCartProductPriceService>, ICrudeCartProductPriceService {
        
        public CrudeCartProductPriceServiceClient() {
        }
        
        public CrudeCartProductPriceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeCartProductPriceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductPriceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductPriceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId) {
            return base.Channel.FetchByCartProductPriceId(cartProductPriceId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid cartProductPriceId) {
            base.Channel.Delete(cartProductPriceId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId) {
            return base.Channel.FetchWithFilter(
                cartProductPriceId: cartProductPriceId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime,
                productId: productId
                );
        }
    }
}
