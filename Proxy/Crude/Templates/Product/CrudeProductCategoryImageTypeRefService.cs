/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:28 AM
  From Machine: DESKTOP-517I8BU
  Filename: ProductCategoryImageTypeRef.json
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

    public partial class ProductCategoryImageTypeRef {
        
        public const string LargeSize = "LS";
        
        public const string SmallSize = "SS";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryImageTypeRefService")]
    public partial interface ICrudeProductCategoryImageTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/DeleteResponse")]
        void Delete(string productCategoryImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeName", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchWithFilterRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryImageTypeRefServiceChannel : ICrudeProductCategoryImageTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryImageTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryImageTypeRefService>, ICrudeProductCategoryImageTypeRefService {
        
        public CrudeProductCategoryImageTypeRefServiceClient() {
        }
        
        public CrudeProductCategoryImageTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryImageTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return base.Channel.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productCategoryImageTypeRcd) {
            base.Channel.Delete(productCategoryImageTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName) {
            return base.Channel.FetchByProductCategoryImageTypeName(productCategoryImageTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                productCategoryImageTypeName: productCategoryImageTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
