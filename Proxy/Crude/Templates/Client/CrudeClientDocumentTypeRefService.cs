/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:21 AM
  From Machine: DESKTOP-00MSEIL
  Filename: ClientDocumentTypeRef.json
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

    public partial class ClientDocumentTypeRef {
        
        public const string PassportFirstPage = "PFP";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientDocumentTypeRefService")]
    public partial interface ICrudeClientDocumentTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchByClientDocumentTypeRc" +
            "d", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchByClientDocumentTypeRc" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/DeleteResponse")]
        void Delete(string clientDocumentTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchByClientDocumentTypeNa" +
            "me", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchByClientDocumentTypeNa" +
            "meResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeName(string clientDocumentTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAllWithLimitAndOffsetR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientDocumentTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchWithFilter(string clientDocumentTypeRcd, string clientDocumentTypeName, string clientDocumentTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientDocumentTypeRefServiceChannel : ICrudeClientDocumentTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientDocumentTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientDocumentTypeRefService>, ICrudeClientDocumentTypeRefService {
        
        public CrudeClientDocumentTypeRefServiceClient() {
        }
        
        public CrudeClientDocumentTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientDocumentTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientDocumentTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientDocumentTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            return base.Channel.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientDocumentTypeRcd) {
            base.Channel.Delete(clientDocumentTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeName(string clientDocumentTypeName) {
            return base.Channel.FetchByClientDocumentTypeName(clientDocumentTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentTypeRefContract> FetchWithFilter(string clientDocumentTypeRcd, string clientDocumentTypeName, string clientDocumentTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientDocumentTypeRcd: clientDocumentTypeRcd,
                clientDocumentTypeName: clientDocumentTypeName,
                clientDocumentTypeDescription: clientDocumentTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
