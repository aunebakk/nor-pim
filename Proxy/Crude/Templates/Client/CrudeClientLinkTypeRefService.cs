/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:21 AM
  From Machine: DESKTOP-00MSEIL
  Filename: ClientLinkTypeRef.json
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

    public partial class ClientLinkTypeRef {
        
        public const string WebPage = "WPE";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientLinkTypeRefService")]
    public partial interface ICrudeClientLinkTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchByClientLinkTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchByClientLinkTypeRcdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract FetchByClientLinkTypeRcd(string clientLinkTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/DeleteResponse")]
        void Delete(string clientLinkTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchByClientLinkTypeName", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchByClientLinkTypeNameRespon" +
            "se")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract FetchByClientLinkTypeName(string clientLinkTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientLinkTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientLinkTypeRefServiceChannel : ICrudeClientLinkTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientLinkTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientLinkTypeRefService>, ICrudeClientLinkTypeRefService {
        
        public CrudeClientLinkTypeRefServiceClient() {
        }
        
        public CrudeClientLinkTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientLinkTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientLinkTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientLinkTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            return base.Channel.FetchByClientLinkTypeRcd(clientLinkTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientLinkTypeRcd) {
            base.Channel.Delete(clientLinkTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract FetchByClientLinkTypeName(string clientLinkTypeName) {
            return base.Channel.FetchByClientLinkTypeName(clientLinkTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkTypeRefContract> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientLinkTypeRcd: clientLinkTypeRcd,
                clientLinkTypeName: clientLinkTypeName,
                clientLinkTypeDescription: clientLinkTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
