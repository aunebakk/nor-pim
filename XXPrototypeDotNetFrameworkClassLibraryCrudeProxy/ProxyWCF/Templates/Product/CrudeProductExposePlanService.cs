/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:23:24 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductExposePlan.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposePlanService")]
    public partial interface ICrudeProductExposePlanService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposePlanId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposePlanIdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposeSetTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposeSetTypeRcdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/DeleteResponse")]
        void Delete(System.Guid productExposePlanId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposePlanServiceChannel : ICrudeProductExposePlanService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposePlanServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposePlanService>, ICrudeProductExposePlanService {
        
        public CrudeProductExposePlanServiceClient() {
        }
        
        public CrudeProductExposePlanServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposePlanServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposePlanServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposePlanServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId) {
            return base.Channel.FetchByProductExposePlanId(productExposePlanId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return base.Channel.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposePlanId) {
            base.Channel.Delete(productExposePlanId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposePlanId: productExposePlanId,
                productId: productId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
