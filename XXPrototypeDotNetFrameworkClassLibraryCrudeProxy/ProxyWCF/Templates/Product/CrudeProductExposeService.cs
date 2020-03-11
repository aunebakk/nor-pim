/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:58:17 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductExpose.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeService")]
    public partial interface ICrudeProductExposeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByExposeProductId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByExposeProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByExposeBasedOnProductId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByExposeBasedOnProductIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeSetId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeSetIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeService/DeleteResponse")]
        void Delete(System.Guid productExposeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposeServiceChannel : ICrudeProductExposeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposeServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposeService>, ICrudeProductExposeService {
        
        public CrudeProductExposeServiceClient() {
        }
        
        public CrudeProductExposeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId) {
            return base.Channel.FetchByProductExposeId(productExposeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId) {
            return base.Channel.FetchByExposeProductId(exposeProductId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId) {
            return base.Channel.FetchByExposeBasedOnProductId(exposeBasedOnProductId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return base.Channel.FetchByProductExposeSetId(productExposeSetId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposeId) {
            base.Channel.Delete(productExposeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposeId: productExposeId,
                exposeProductId: exposeProductId,
                exposeBasedOnProductId: exposeBasedOnProductId,
                productExposeSetId: productExposeSetId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
