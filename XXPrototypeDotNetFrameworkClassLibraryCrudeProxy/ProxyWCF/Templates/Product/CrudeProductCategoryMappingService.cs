/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:41:34 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductCategoryMapping.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryMappingService")]
    public partial interface ICrudeProductCategoryMappingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryMapp" +
            "ingId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryMapp" +
            "ingIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/DeleteResponse")]
        void Delete(System.Guid productCategoryMappingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryMappingServiceChannel : ICrudeProductCategoryMappingService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryMappingServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryMappingService>, ICrudeProductCategoryMappingService {
        
        public CrudeProductCategoryMappingServiceClient() {
        }
        
        public CrudeProductCategoryMappingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryMappingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryMappingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryMappingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId) {
            return base.Channel.FetchByProductCategoryMappingId(productCategoryMappingId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryMappingId) {
            base.Channel.Delete(productCategoryMappingId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryMappingContract> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryMappingId: productCategoryMappingId,
                productCategoryId: productCategoryId,
                productId: productId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
