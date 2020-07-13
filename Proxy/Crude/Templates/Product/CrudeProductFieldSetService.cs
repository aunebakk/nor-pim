/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:53:23 AM
  From Machine: DESKTOP-517I8BU
  Filename: ProductFieldSet.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductFieldSetService")]
    public partial interface ICrudeProductFieldSetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchByProductFieldSetId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchByProductFieldSetIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/DeleteResponse")]
        void Delete(System.Guid productFieldSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchByProductFieldSetName", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchByProductFieldSetNameRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract FetchByProductFieldSetName(string productFieldSetName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductFieldSetServiceChannel : ICrudeProductFieldSetService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductFieldSetServiceClient : System.ServiceModel.ClientBase<ICrudeProductFieldSetService>, ICrudeProductFieldSetService {
        
        public CrudeProductFieldSetServiceClient() {
        }
        
        public CrudeProductFieldSetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductFieldSetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return base.Channel.FetchByProductFieldSetId(productFieldSetId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productFieldSetId) {
            base.Channel.Delete(productFieldSetId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract FetchByProductFieldSetName(string productFieldSetName) {
            return base.Channel.FetchByProductFieldSetName(productFieldSetName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productFieldSetId: productFieldSetId,
                productFieldSetName: productFieldSetName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
