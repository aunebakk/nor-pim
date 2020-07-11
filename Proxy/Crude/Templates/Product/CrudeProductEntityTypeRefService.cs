/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:25:58 AM
  From Machine: DESKTOP-517I8BU
  Filename: ProductEntityTypeRef.json
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

    public partial class ProductEntityTypeRef {
        
        public const string Product = "P";
        
        public const string ProductAttribute = "PA";
        
        public const string ProductCategory = "PC";
        
        public const string ProductDescription = "PD";
        
        public const string ProductIdentifier = "PID";
        
        public const string ProductInfo = "PI";
        
        public const string ProductSupplier = "PS";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductEntityTypeRefService")]
    public partial interface ICrudeProductEntityTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchByProductEntityTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchByProductEntityTypeRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract FetchByProductEntityTypeRcd(string productEntityTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/DeleteResponse")]
        void Delete(string productEntityTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchByProductEntityTypeName" +
            "", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchByProductEntityTypeName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract FetchByProductEntityTypeName(string productEntityTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductEntityTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductEntityTypeRefServiceChannel : ICrudeProductEntityTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductEntityTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductEntityTypeRefService>, ICrudeProductEntityTypeRefService {
        
        public CrudeProductEntityTypeRefServiceClient() {
        }
        
        public CrudeProductEntityTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductEntityTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductEntityTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductEntityTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract FetchByProductEntityTypeRcd(string productEntityTypeRcd) {
            return base.Channel.FetchByProductEntityTypeRcd(productEntityTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productEntityTypeRcd) {
            base.Channel.Delete(productEntityTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract FetchByProductEntityTypeName(string productEntityTypeName) {
            return base.Channel.FetchByProductEntityTypeName(productEntityTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductEntityTypeRefContract> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productEntityTypeRcd: productEntityTypeRcd,
                productEntityTypeName: productEntityTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
