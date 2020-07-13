/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:54:58 PM
  From Machine: DESKTOP-00MSEIL
  Filename: ClientNationalityRef.json
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

    public partial class ClientNationalityRef {
        
        public const string Africa = "AFA";
        
        public const string Americas = "AMA";
        
        public const string Asia = "ASA";
        
        public const string Europe = "EUA";
        
        public const string Oceania = "OCA";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientNationalityRefService")]
    public partial interface ICrudeClientNationalityRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityRcd", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/DeleteResponse")]
        void Delete(string clientNationalityRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityName" +
            "", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientNationalityRefServiceChannel : ICrudeClientNationalityRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientNationalityRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientNationalityRefService>, ICrudeClientNationalityRefService {
        
        public CrudeClientNationalityRefServiceClient() {
        }
        
        public CrudeClientNationalityRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientNationalityRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientNationalityRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientNationalityRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd) {
            return base.Channel.FetchByClientNationalityRcd(clientNationalityRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientNationalityRcd) {
            base.Channel.Delete(clientNationalityRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName) {
            return base.Channel.FetchByClientNationalityName(clientNationalityName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientNationalityRcd: clientNationalityRcd,
                clientNationalityName: clientNationalityName,
                clientNationalityDescription: clientNationalityDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
