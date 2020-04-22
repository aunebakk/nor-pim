/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:51:52 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Client\ClientContactMethod.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientContactMethodService")]
    public partial interface ICrudeClientContactMethodService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodIdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodRcd" +
            "", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/Insert", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/Update", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/Delete", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/DeleteResponse")]
        void Delete(System.Guid clientContactMethodId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientContactMethodServiceChannel : ICrudeClientContactMethodService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientContactMethodServiceClient : System.ServiceModel.ClientBase<ICrudeClientContactMethodService>, ICrudeClientContactMethodService {
        
        public CrudeClientContactMethodServiceClient() {
        }
        
        public CrudeClientContactMethodServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientContactMethodServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId) {
            return base.Channel.FetchByClientContactMethodId(clientContactMethodId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            return base.Channel.FetchByClientContactMethodRcd(clientContactMethodRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid clientContactMethodId) {
            base.Channel.Delete(clientContactMethodId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientContactMethodId: clientContactMethodId,
                clientId: clientId,
                clientContactMethodRcd: clientContactMethodRcd,
                contactMethodWay: contactMethodWay,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
