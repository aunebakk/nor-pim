/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:11 PM
  From Machine: DESKTOP-517I8BU
  Filename: ProductAttributeUnitRef.json
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

    public partial class ProductAttributeUnitRef {
        
        public const string Grams = "G";
        
        public const string Meters = "METER";
        
        public const string MilliMeters = "MM";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeUnitRefService")]
    public partial interface ICrudeProductAttributeUnitRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/DeleteResponse")]
        void Delete(string productAttributeUnitRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itName", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductAttributeUnitRefServiceChannel : ICrudeProductAttributeUnitRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductAttributeUnitRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductAttributeUnitRefService>, ICrudeProductAttributeUnitRefService {
        
        public CrudeProductAttributeUnitRefServiceClient() {
        }
        
        public CrudeProductAttributeUnitRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeUnitRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeUnitRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeUnitRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            return base.Channel.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productAttributeUnitRcd) {
            base.Channel.Delete(productAttributeUnitRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName) {
            return base.Channel.FetchByProductAttributeUnitName(productAttributeUnitName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productAttributeUnitRcd: productAttributeUnitRcd,
                productAttributeUnitName: productAttributeUnitName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
