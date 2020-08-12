/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:45:49 AM
  From Machine: DESKTOP-00MSEIL
  Filename: ProductImageTypeRef.json
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

    public partial class ProductImageTypeRef {
        
        public const string InternalStockPhoto = "ISP";
        
        public const string ProductImageVariableSize = "PI";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductImageTypeRefService")]
    public partial interface ICrudeProductImageTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByProductImageTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByProductImageTypeRcdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/DeleteResponse")]
        void Delete(string productImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByProductImageTypeName", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByProductImageTypeNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract FetchByProductImageTypeName(string productImageTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductImageTypeRefServiceChannel : ICrudeProductImageTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductImageTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductImageTypeRefService>, ICrudeProductImageTypeRefService {
        
        public CrudeProductImageTypeRefServiceClient() {
        }
        
        public CrudeProductImageTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductImageTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return base.Channel.FetchByProductImageTypeRcd(productImageTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productImageTypeRcd) {
            base.Channel.Delete(productImageTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract FetchByProductImageTypeName(string productImageTypeName) {
            return base.Channel.FetchByProductImageTypeName(productImageTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productImageTypeRcd: productImageTypeRcd,
                productImageTypeName: productImageTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
