/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:14 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductGatherAttribute.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherAttributeService")]
    public partial interface ICrudeProductGatherAttributeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherKeyIdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/DeleteResponse")]
        void Delete(System.Guid productGatherAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherAttributeServiceChannel : ICrudeProductGatherAttributeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherAttributeServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherAttributeService>, ICrudeProductGatherAttributeService {
        
        public CrudeProductGatherAttributeServiceClient() {
        }
        
        public CrudeProductGatherAttributeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherAttributeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            return base.Channel.FetchByProductGatherAttributeId(productGatherAttributeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return base.Channel.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productGatherAttributeId) {
            base.Channel.Delete(productGatherAttributeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherAttributeId: productGatherAttributeId,
                productGatherAttributeValue: productGatherAttributeValue,
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
