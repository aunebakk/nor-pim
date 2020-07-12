/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:15 AM
  From Machine: DESKTOP-517I8BU
  Filename: ProductAttribute.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeService")]
    public partial interface ICrudeProductAttributeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeId", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeRcdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByProductAttributeRcd(string productAttributeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeUnitRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeUnitRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/DeleteResponse")]
        void Delete(System.Guid productAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductAttributeServiceChannel : ICrudeProductAttributeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductAttributeServiceClient : System.ServiceModel.ClientBase<ICrudeProductAttributeService>, ICrudeProductAttributeService {
        
        public CrudeProductAttributeServiceClient() {
        }
        
        public CrudeProductAttributeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId) {
            return base.Channel.FetchByProductAttributeId(productAttributeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByProductAttributeRcd(string productAttributeRcd) {
            return base.Channel.FetchByProductAttributeRcd(productAttributeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            return base.Channel.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productAttributeId) {
            base.Channel.Delete(productAttributeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productAttributeId: productAttributeId,
                productId: productId,
                productAttributeRcd: productAttributeRcd,
                productAttributeUnitRcd: productAttributeUnitRcd,
                value: value,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
