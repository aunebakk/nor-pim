/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:39:31 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductCategoryDocumentationTypeRef.json
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
    
    
    public partial class ProductCategoryDocumentationTypeRef {
        
        public const string BottomText = "BT";
        
        public const string TopText = "TT";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryDocumentationTypeRefService")]
    public partial interface ICrudeProductCategoryDocumentationTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByUserId" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByUserId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/InsertRespons" +
            "e")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/UpdateRespons" +
            "e")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/DeleteRespons" +
            "e")]
        void Delete(string productCategoryDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeName", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imit", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllCount" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllCount" +
            "Response")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchWithFilt" +
            "er", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchWithFilt" +
            "erResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryDocumentationTypeRefServiceChannel : ICrudeProductCategoryDocumentationTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryDocumentationTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryDocumentationTypeRefService>, ICrudeProductCategoryDocumentationTypeRefService {
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient() {
        }
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return base.Channel.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productCategoryDocumentationTypeRcd) {
            base.Channel.Delete(productCategoryDocumentationTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName) {
            return base.Channel.FetchByProductCategoryDocumentationTypeName(productCategoryDocumentationTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryDocumentationTypeName: productCategoryDocumentationTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
