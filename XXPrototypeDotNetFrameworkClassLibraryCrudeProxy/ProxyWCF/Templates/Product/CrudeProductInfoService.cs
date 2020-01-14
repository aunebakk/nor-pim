/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:06 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductInfo.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductInfoService")]
    public partial interface ICrudeProductInfoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchByProductInfoId", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchByProductInfoIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchByProductInfoRcd", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchByProductInfoRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchByProductInfoRcd(string productInfoRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/Insert", ReplyAction="http://tempuri.org/ICrudeProductInfoService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/Update", ReplyAction="http://tempuri.org/ICrudeProductInfoService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/Delete", ReplyAction="http://tempuri.org/ICrudeProductInfoService/DeleteResponse")]
        void Delete(System.Guid productInfoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductInfoServiceChannel : ICrudeProductInfoService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductInfoServiceClient : System.ServiceModel.ClientBase<ICrudeProductInfoService>, ICrudeProductInfoService {
        
        public CrudeProductInfoServiceClient() {
        }
        
        public CrudeProductInfoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductInfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId) {
            return base.Channel.FetchByProductInfoId(productInfoId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchByProductInfoRcd(string productInfoRcd) {
            return base.Channel.FetchByProductInfoRcd(productInfoRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productInfoId) {
            base.Channel.Delete(productInfoId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productInfoId: productInfoId,
                productId: productId,
                productInfoRcd: productInfoRcd,
                productInfoValue: productInfoValue,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
