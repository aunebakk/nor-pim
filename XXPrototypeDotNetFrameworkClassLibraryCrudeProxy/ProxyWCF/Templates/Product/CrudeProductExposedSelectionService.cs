/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:58:18 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductExposedSelection.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposedSelectionService")]
    public partial interface ICrudeProductExposedSelectionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposedSele" +
            "ctionId", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposedSele" +
            "ctionIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposeId", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposeIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchByProductExposeId(System.Guid productExposeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/DeleteResponse")]
        void Delete(System.Guid productExposedSelectionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposedSelectionServiceChannel : ICrudeProductExposedSelectionService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposedSelectionServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposedSelectionService>, ICrudeProductExposedSelectionService {
        
        public CrudeProductExposedSelectionServiceClient() {
        }
        
        public CrudeProductExposedSelectionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposedSelectionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposedSelectionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposedSelectionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId) {
            return base.Channel.FetchByProductExposedSelectionId(productExposedSelectionId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchByProductExposeId(System.Guid productExposeId) {
            return base.Channel.FetchByProductExposeId(productExposeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposedSelectionId) {
            base.Channel.Delete(productExposedSelectionId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposedSelectionContract> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposedSelectionId: productExposedSelectionId,
                productExposeId: productExposeId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
