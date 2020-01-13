/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:35:38 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Client\ClientLink.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientLinkService")]
    public partial interface ICrudeClientLinkService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkId", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/Insert", ReplyAction="http://tempuri.org/ICrudeClientLinkService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/Update", ReplyAction="http://tempuri.org/ICrudeClientLinkService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/Delete", ReplyAction="http://tempuri.org/ICrudeClientLinkService/DeleteResponse")]
        void Delete(System.Guid clientLinkId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByLinkName", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByLinkNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByLinkName(string linkName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientLinkServiceChannel : ICrudeClientLinkService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientLinkServiceClient : System.ServiceModel.ClientBase<ICrudeClientLinkService>, ICrudeClientLinkService {
        
        public CrudeClientLinkServiceClient() {
        }
        
        public CrudeClientLinkServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientLinkServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientLinkServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientLinkServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId) {
            return base.Channel.FetchByClientLinkId(clientLinkId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            return base.Channel.FetchByClientLinkTypeRcd(clientLinkTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid clientLinkId) {
            base.Channel.Delete(clientLinkId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByLinkName(string linkName) {
            return base.Channel.FetchByLinkName(linkName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientLinkId: clientLinkId,
                clientId: clientId,
                clientLinkTypeRcd: clientLinkTypeRcd,
                linkName: linkName,
                link: link,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
