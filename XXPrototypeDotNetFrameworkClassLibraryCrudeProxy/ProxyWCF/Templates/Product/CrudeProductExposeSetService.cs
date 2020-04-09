/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:51 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductExposeSet.json
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeSetService")]
    public partial interface ICrudeProductExposeSetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/DeleteResponse")]
        void Delete(System.Guid productExposeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetName", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetNameRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposeSetServiceChannel : ICrudeProductExposeSetService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposeSetServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposeSetService>, ICrudeProductExposeSetService {
        
        public CrudeProductExposeSetServiceClient() {
        }
        
        public CrudeProductExposeSetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeSetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return base.Channel.FetchByProductExposeSetId(productExposeSetId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return base.Channel.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposeSetId) {
            base.Channel.Delete(productExposeSetId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName) {
            return base.Channel.FetchByProductExposeSetName(productExposeSetName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposeSetId: productExposeSetId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetName: productExposeSetName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
