/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:20:06 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductGatherAttributeTypeRef.json
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
    
    
    public partial class ProductGatherAttributeTypeRef {
        
        public const string Color = "color";
        
        public const string Name = "name";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherAttributeTypeRefService")]
    public partial interface ICrudeProductGatherAttributeTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByUserIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/DeleteResponse")]
        void Delete(string productGatherAttributeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeName", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitAn" +
            "dOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitAn" +
            "dOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllCountRespon" +
            "se")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchWithFilterResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherAttributeTypeRefServiceChannel : ICrudeProductGatherAttributeTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherAttributeTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherAttributeTypeRefService>, ICrudeProductGatherAttributeTypeRefService {
        
        public CrudeProductGatherAttributeTypeRefServiceClient() {
        }
        
        public CrudeProductGatherAttributeTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherAttributeTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return base.Channel.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productGatherAttributeTypeRcd) {
            base.Channel.Delete(productGatherAttributeTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName) {
            return base.Channel.FetchByProductGatherAttributeTypeName(productGatherAttributeTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherAttributeTypeName: productGatherAttributeTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
