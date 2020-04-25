/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:15 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductChangeSet.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductChangeSetService")]
    public partial interface ICrudeProductChangeSetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductChangeSetId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductChangeSetIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductGatherKeyIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/DeleteResponse")]
        void Delete(System.Guid productChangeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductChangeSetServiceChannel : ICrudeProductChangeSetService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductChangeSetServiceClient : System.ServiceModel.ClientBase<ICrudeProductChangeSetService>, ICrudeProductChangeSetService {
        
        public CrudeProductChangeSetServiceClient() {
        }
        
        public CrudeProductChangeSetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductChangeSetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductChangeSetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductChangeSetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId) {
            return base.Channel.FetchByProductChangeSetId(productChangeSetId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productChangeSetId) {
            base.Channel.Delete(productChangeSetId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productChangeSetId: productChangeSetId,
                productId: productId,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
