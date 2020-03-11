/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:58:13 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductCategoryDocumentation.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryDocumentationService")]
    public partial interface ICrudeProductCategoryDocumentationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByUserIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/DeleteResponse")]
        void Delete(System.Guid productCategoryDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitAnd" +
            "Offset", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitAnd" +
            "OffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllCountRespons" +
            "e")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchWithFilterRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryDocumentationServiceChannel : ICrudeProductCategoryDocumentationService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryDocumentationServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryDocumentationService>, ICrudeProductCategoryDocumentationService {
        
        public CrudeProductCategoryDocumentationServiceClient() {
        }
        
        public CrudeProductCategoryDocumentationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryDocumentationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            return base.Channel.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return base.Channel.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryDocumentationId) {
            base.Channel.Delete(productCategoryDocumentationId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryDocumentationId: productCategoryDocumentationId,
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryId: productCategoryId,
                documentation: documentation,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
