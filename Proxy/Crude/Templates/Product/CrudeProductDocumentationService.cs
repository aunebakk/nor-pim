/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:49:34 PM
  From Machine: DESKTOP-517I8BU
  Filename: ProductDocumentation.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductDocumentationService")]
    public partial interface ICrudeProductDocumentationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationI" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationT" +
            "ypeRcd", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationT" +
            "ypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Insert", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Update", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Delete", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/DeleteResponse")]
        void Delete(System.Guid productDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductDocumentationServiceChannel : ICrudeProductDocumentationService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductDocumentationServiceClient : System.ServiceModel.ClientBase<ICrudeProductDocumentationService>, ICrudeProductDocumentationService {
        
        public CrudeProductDocumentationServiceClient() {
        }
        
        public CrudeProductDocumentationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductDocumentationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId) {
            return base.Channel.FetchByProductDocumentationId(productDocumentationId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return base.Channel.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productDocumentationId) {
            base.Channel.Delete(productDocumentationId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productDocumentationId: productDocumentationId,
                productId: productId,
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                documentation: documentation,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
