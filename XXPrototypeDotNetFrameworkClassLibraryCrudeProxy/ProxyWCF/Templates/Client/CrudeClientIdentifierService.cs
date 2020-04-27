/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:27 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Client\ClientIdentifier.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientIdentifierService")]
    public partial interface ICrudeClientIdentifierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchByClientIdentifierId", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchByClientIdentifierIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract FetchByClientIdentifierId(System.Guid clientIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchByClientIdentifierTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchByClientIdentifierTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/Insert", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/Update", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/Delete", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/DeleteResponse")]
        void Delete(System.Guid clientIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientIdentifierService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientIdentifierServiceChannel : ICrudeClientIdentifierService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientIdentifierServiceClient : System.ServiceModel.ClientBase<ICrudeClientIdentifierService>, ICrudeClientIdentifierService {
        
        public CrudeClientIdentifierServiceClient() {
        }
        
        public CrudeClientIdentifierServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientIdentifierServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientIdentifierServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientIdentifierServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract FetchByClientIdentifierId(System.Guid clientIdentifierId) {
            return base.Channel.FetchByClientIdentifierId(clientIdentifierId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            return base.Channel.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid clientIdentifierId) {
            base.Channel.Delete(clientIdentifierId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierContract> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientIdentifierId: clientIdentifierId,
                clientId: clientId,
                clientIdentifierTypeRcd: clientIdentifierTypeRcd,
                clientIdentifierCode: clientIdentifierCode,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
