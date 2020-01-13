/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:36:09 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductExposeSetTypeRef.json
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
    
    
    public partial class ProductExposeSetTypeRef {
        
        public const string Customer = "Customer";
        
        public const string Export = "Export";
        
        public const string Print = "Print";
        
        public const string Web = "Web";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeSetTypeRefService")]
    public partial interface ICrudeProductExposeSetTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByProductExposeSetTy" +
            "peRcd", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByProductExposeSetTy" +
            "peRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/DeleteResponse")]
        void Delete(string productExposeSetTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByProductExposeSetTy" +
            "peName", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByProductExposeSetTy" +
            "peNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposeSetTypeRefServiceChannel : ICrudeProductExposeSetTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposeSetTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposeSetTypeRefService>, ICrudeProductExposeSetTypeRefService {
        
        public CrudeProductExposeSetTypeRefServiceClient() {
        }
        
        public CrudeProductExposeSetTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeSetTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return base.Channel.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productExposeSetTypeRcd) {
            base.Channel.Delete(productExposeSetTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName) {
            return base.Channel.FetchByProductExposeSetTypeName(productExposeSetTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetTypeName: productExposeSetTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
