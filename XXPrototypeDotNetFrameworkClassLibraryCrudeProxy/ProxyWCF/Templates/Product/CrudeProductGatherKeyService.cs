/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:44:04 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductGatherKey.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherKeyService")]
    public partial interface ICrudeProductGatherKeyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherKeyIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/DeleteResponse")]
        void Delete(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherKeyServiceChannel : ICrudeProductGatherKeyService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherKeyServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherKeyService>, ICrudeProductGatherKeyService {
        
        public CrudeProductGatherKeyServiceClient() {
        }
        
        public CrudeProductGatherKeyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherKeyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherKeyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherKeyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId) {
            return base.Channel.FetchByProductGatherId(productGatherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productGatherKeyId) {
            base.Channel.Delete(productGatherKeyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherKeyId: productGatherKeyId,
                productGatherKeyValue: productGatherKeyValue,
                productGatherId: productGatherId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
