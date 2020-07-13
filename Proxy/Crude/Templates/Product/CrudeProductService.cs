/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:50:54 AM
  From Machine: DESKTOP-517I8BU
  Filename: Product.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductService")]
    public partial interface ICrudeProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByProductIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByProductBecameId", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByProductBecameIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchByProductBecameId(System.Guid productBecameId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchByStateRcd(string stateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/Insert", ReplyAction="http://tempuri.org/ICrudeProductService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/Update", ReplyAction="http://tempuri.org/ICrudeProductService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/Delete", ReplyAction="http://tempuri.org/ICrudeProductService/DeleteResponse")]
        void Delete(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByProductName", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByProductNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract FetchByProductName(string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductServiceChannel : ICrudeProductService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductServiceClient : System.ServiceModel.ClientBase<ICrudeProductService>, ICrudeProductService {
        
        public CrudeProductServiceClient() {
        }
        
        public CrudeProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchByProductBecameId(System.Guid productBecameId) {
            return base.Channel.FetchByProductBecameId(productBecameId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productId) {
            base.Channel.Delete(productId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract FetchByProductName(string productName) {
            return base.Channel.FetchByProductName(productName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductContract> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productId: productId,
                productBecameId: productBecameId,
                productName: productName,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
