/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:55 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductInfoRef.json
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
    
    
    public partial class ProductInfoRef {
        
        public const string FDVInfo = "FDV";
        
        public const string HMSInfo = "HMS";
        
        public const string HTMLInfo = "HTML";
        
        public const string ProductInfo = "PI";
        
        public const string UserManual = "UM";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductInfoRefService")]
    public partial interface ICrudeProductInfoRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoRcd", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/DeleteResponse")]
        void Delete(string productInfoRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoName", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductInfoRefServiceChannel : ICrudeProductInfoRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductInfoRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductInfoRefService>, ICrudeProductInfoRefService {
        
        public CrudeProductInfoRefServiceClient() {
        }
        
        public CrudeProductInfoRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductInfoRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd) {
            return base.Channel.FetchByProductInfoRcd(productInfoRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productInfoRcd) {
            base.Channel.Delete(productInfoRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName) {
            return base.Channel.FetchByProductInfoName(productInfoName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productInfoRcd: productInfoRcd,
                productInfoName: productInfoName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
