/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:27 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductGatherSourceTypeRef.json
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
    
    
    public partial class ProductGatherSourceTypeRef {
        
        public const string TSQLScript = "tsql";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherSourceTypeRefService")]
    public partial interface ICrudeProductGatherSourceTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByProductGatherSo" +
            "urceTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByProductGatherSo" +
            "urceTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/DeleteResponse")]
        void Delete(string productGatherSourceTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByProductGatherSo" +
            "urceTypeName", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByProductGatherSo" +
            "urceTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeName(string productGatherSourceTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimitRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchWithFilterRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherSourceTypeRefServiceChannel : ICrudeProductGatherSourceTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherSourceTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherSourceTypeRefService>, ICrudeProductGatherSourceTypeRefService {
        
        public CrudeProductGatherSourceTypeRefServiceClient() {
        }
        
        public CrudeProductGatherSourceTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherSourceTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            return base.Channel.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productGatherSourceTypeRcd) {
            base.Channel.Delete(productGatherSourceTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeName(string productGatherSourceTypeName) {
            return base.Channel.FetchByProductGatherSourceTypeName(productGatherSourceTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherSourceTypeRcd: productGatherSourceTypeRcd,
                productGatherSourceTypeName: productGatherSourceTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
