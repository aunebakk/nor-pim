/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:19:17 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductCategory.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryService")]
    public partial interface ICrudeProductCategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryBecameId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryBecameIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryParentId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryParentIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryParentId(System.Guid productCategoryParentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByStateRcd(string stateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/DeleteResponse")]
        void Delete(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryName", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryNameRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryName(string productCategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryServiceChannel : ICrudeProductCategoryService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryService>, ICrudeProductCategoryService {
        
        public CrudeProductCategoryServiceClient() {
        }
        
        public CrudeProductCategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId) {
            return base.Channel.FetchByProductCategoryBecameId(productCategoryBecameId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryParentId(System.Guid productCategoryParentId) {
            return base.Channel.FetchByProductCategoryParentId(productCategoryParentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryId) {
            base.Channel.Delete(productCategoryId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryName(string productCategoryName) {
            return base.Channel.FetchByProductCategoryName(productCategoryName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryId: productCategoryId,
                productCategoryBecameId: productCategoryBecameId,
                productCategoryParentId: productCategoryParentId,
                productCategoryCode: productCategoryCode,
                productCategoryName: productCategoryName,
                productCategoryPosition: productCategoryPosition,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
