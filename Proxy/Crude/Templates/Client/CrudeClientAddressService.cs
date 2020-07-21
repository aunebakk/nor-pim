/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:21 AM
  From Machine: DESKTOP-00MSEIL
  Filename: ClientAddress.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientAddressService")]
    public partial interface ICrudeClientAddressService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressId", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientId(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressTypeRcdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/Insert", ReplyAction="http://tempuri.org/ICrudeClientAddressService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/Update", ReplyAction="http://tempuri.org/ICrudeClientAddressService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/Delete", ReplyAction="http://tempuri.org/ICrudeClientAddressService/DeleteResponse")]
        void Delete(System.Guid clientAddressId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByAddressLineOneName", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByAddressLineOneNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchWithFilter(
                    System.Guid clientAddressId, 
                    System.Guid clientId, 
                    string clientAddressTypeRcd, 
                    string addressLineOneName, 
                    string addressLineTwoName, 
                    string addressLineThreeName, 
                    string cityName, 
                    string streetName, 
                    string stateName, 
                    string districtName, 
                    string provinceName, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientAddressServiceChannel : ICrudeClientAddressService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientAddressServiceClient : System.ServiceModel.ClientBase<ICrudeClientAddressService>, ICrudeClientAddressService {
        
        public CrudeClientAddressServiceClient() {
        }
        
        public CrudeClientAddressServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientAddressServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientAddressServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientAddressServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId) {
            return base.Channel.FetchByClientAddressId(clientAddressId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            return base.Channel.FetchByClientAddressTypeRcd(clientAddressTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid clientAddressId) {
            base.Channel.Delete(clientAddressId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName) {
            return base.Channel.FetchByAddressLineOneName(addressLineOneName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchWithFilter(
                    System.Guid clientAddressId, 
                    System.Guid clientId, 
                    string clientAddressTypeRcd, 
                    string addressLineOneName, 
                    string addressLineTwoName, 
                    string addressLineThreeName, 
                    string cityName, 
                    string streetName, 
                    string stateName, 
                    string districtName, 
                    string provinceName, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientAddressId: clientAddressId,
                clientId: clientId,
                clientAddressTypeRcd: clientAddressTypeRcd,
                addressLineOneName: addressLineOneName,
                addressLineTwoName: addressLineTwoName,
                addressLineThreeName: addressLineThreeName,
                cityName: cityName,
                streetName: streetName,
                stateName: stateName,
                districtName: districtName,
                provinceName: provinceName,
                zipCode: zipCode,
                poBox: poBox,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
