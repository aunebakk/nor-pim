/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:32 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Client\ClientDocument.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientDocumentService")]
    public partial interface ICrudeClientDocumentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentId", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentTypeRcdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/Insert", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/Update", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/Delete", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/DeleteResponse")]
        void Delete(System.Guid clientDocumentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByDocumentName", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByDocumentNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByDocumentName(string documentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientDocumentServiceChannel : ICrudeClientDocumentService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientDocumentServiceClient : System.ServiceModel.ClientBase<ICrudeClientDocumentService>, ICrudeClientDocumentService {
        
        public CrudeClientDocumentServiceClient() {
        }
        
        public CrudeClientDocumentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientDocumentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientDocumentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientDocumentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId) {
            return base.Channel.FetchByClientDocumentId(clientDocumentId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            return base.Channel.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid clientDocumentId) {
            base.Channel.Delete(clientDocumentId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByDocumentName(string documentName) {
            return base.Channel.FetchByDocumentName(documentName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientDocumentId: clientDocumentId,
                clientId: clientId,
                clientDocumentTypeRcd: clientDocumentTypeRcd,
                documentName: documentName,
                documentDateTime: documentDateTime,
                expiryDateTime: expiryDateTime,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
