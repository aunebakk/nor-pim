/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:13 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductDocumentationTypeRef.json
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
    
    
    public partial class ProductDocumentationTypeRef {
        
        public const string Headline = "HD";
        
        public const string LongDescription = "LD";
        
        public const string ShortDescription = "SD";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductDocumentationTypeRefService")]
    public partial interface ICrudeProductDocumentationTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByProductDocumen" +
            "tationTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByProductDocumen" +
            "tationTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/DeleteResponse")]
        void Delete(string productDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByProductDocumen" +
            "tationTypeName", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByProductDocumen" +
            "tationTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeName(string productDocumentationTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimitResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchWithFilterRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductDocumentationTypeRefServiceChannel : ICrudeProductDocumentationTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductDocumentationTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductDocumentationTypeRefService>, ICrudeProductDocumentationTypeRefService {
        
        public CrudeProductDocumentationTypeRefServiceClient() {
        }
        
        public CrudeProductDocumentationTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductDocumentationTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return base.Channel.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productDocumentationTypeRcd) {
            base.Channel.Delete(productDocumentationTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeName(string productDocumentationTypeName) {
            return base.Channel.FetchByProductDocumentationTypeName(productDocumentationTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                productDocumentationTypeName: productDocumentationTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
