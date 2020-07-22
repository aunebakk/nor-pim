/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:26 AM
  From Machine: DESKTOP-00MSEIL
  Filename: ProductIdentifier.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductIdentifierService")]
    public partial interface ICrudeProductIdentifierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdentifierId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdentifierIdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdentifierRcd", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdentifierRcdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/Insert", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/Update", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/Delete", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/DeleteResponse")]
        void Delete(System.Guid productIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductIdentifierServiceChannel : ICrudeProductIdentifierService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductIdentifierServiceClient : System.ServiceModel.ClientBase<ICrudeProductIdentifierService>, ICrudeProductIdentifierService {
        
        public CrudeProductIdentifierServiceClient() {
        }
        
        public CrudeProductIdentifierServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductIdentifierServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId) {
            return base.Channel.FetchByProductIdentifierId(productIdentifierId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return base.Channel.FetchByProductIdentifierRcd(productIdentifierRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productIdentifierId) {
            base.Channel.Delete(productIdentifierId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierContract> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productIdentifierId: productIdentifierId,
                productId: productId,
                productIdentifierRcd: productIdentifierRcd,
                identifier: identifier,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
