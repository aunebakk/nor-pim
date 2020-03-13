/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:41:36 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductGatherSource.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherSourceService")]
    public partial interface ICrudeProductGatherSourceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceIdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceTyp" +
            "eRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceTyp" +
            "eRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/DeleteResponse")]
        void Delete(System.Guid productGatherSourceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherSourceServiceChannel : ICrudeProductGatherSourceService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherSourceServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherSourceService>, ICrudeProductGatherSourceService {
        
        public CrudeProductGatherSourceServiceClient() {
        }
        
        public CrudeProductGatherSourceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherSourceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            return base.Channel.FetchByProductGatherSourceId(productGatherSourceId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId) {
            return base.Channel.FetchByProductGatherId(productGatherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            return base.Channel.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productGatherSourceId) {
            base.Channel.Delete(productGatherSourceId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherSourceId: productGatherSourceId,
                productGatherId: productGatherId,
                productGatherSourceTypeRcd: productGatherSourceTypeRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
