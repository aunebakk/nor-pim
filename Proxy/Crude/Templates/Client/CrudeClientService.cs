/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:21 AM
  From Machine: DESKTOP-00MSEIL
  Filename: Client.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientService")]
    public partial interface ICrudeClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientAddressId", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientAddressIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientNationalityRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientNationalityRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientGenderRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientGenderRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientTitleRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientTitleRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/Insert", ReplyAction="http://tempuri.org/ICrudeClientService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/Update", ReplyAction="http://tempuri.org/ICrudeClientService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/Delete", ReplyAction="http://tempuri.org/ICrudeClientService/DeleteResponse")]
        void Delete(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByFirstName", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByFirstNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByFirstName(string firstName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientServiceChannel : ICrudeClientService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientServiceClient : System.ServiceModel.ClientBase<ICrudeClientService>, ICrudeClientService {
        
        public CrudeClientServiceClient() {
        }
        
        public CrudeClientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId) {
            return base.Channel.FetchByClientAddressId(clientAddressId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd) {
            return base.Channel.FetchByClientTypeRcd(clientTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd) {
            return base.Channel.FetchByClientNationalityRcd(clientNationalityRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd) {
            return base.Channel.FetchByClientGenderRcd(clientGenderRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd) {
            return base.Channel.FetchByClientTitleRcd(clientTitleRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid clientId) {
            base.Channel.Delete(clientId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByFirstName(string firstName) {
            return base.Channel.FetchByFirstName(firstName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientId: clientId,
                clientTypeRcd: clientTypeRcd,
                clientNationalityRcd: clientNationalityRcd,
                clientGenderRcd: clientGenderRcd,
                clientTitleRcd: clientTitleRcd,
                clientAddressId: clientAddressId,
                firstName: firstName,
                middleName: middleName,
                lastName: lastName,
                image: image,
                imageBlobFilename: imageBlobFilename,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
