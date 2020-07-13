/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:49:34 PM
  From Machine: DESKTOP-517I8BU
  Filename: ProductIdentifierRef.json
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

    public partial class ProductIdentifierRef {
        
        public const string BlockStructure1 = "BS1";
        
        public const string BlockStructure2 = "BS2";
        
        public const string BlockStructure3 = "BS3";
        
        public const string GlobalTradeItemNumber13 = "GTIN13";
        
        public const string GlobalTradeItemNumber14 = "GTIN14";
        
        public const string HN = "HN";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductIdentifierRefService")]
    public partial interface ICrudeProductIdentifierRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByProductIdentifierRcd", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByProductIdentifierRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/DeleteResponse")]
        void Delete(string productIdentifierRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByProductIdentifierName" +
            "", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByProductIdentifierName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract FetchByProductIdentifierName(string productIdentifierName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductIdentifierRefServiceChannel : ICrudeProductIdentifierRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductIdentifierRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductIdentifierRefService>, ICrudeProductIdentifierRefService {
        
        public CrudeProductIdentifierRefServiceClient() {
        }
        
        public CrudeProductIdentifierRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductIdentifierRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return base.Channel.FetchByProductIdentifierRcd(productIdentifierRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productIdentifierRcd) {
            base.Channel.Delete(productIdentifierRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract FetchByProductIdentifierName(string productIdentifierName) {
            return base.Channel.FetchByProductIdentifierName(productIdentifierName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductIdentifierRefContract> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productIdentifierRcd: productIdentifierRcd,
                productIdentifierName: productIdentifierName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
