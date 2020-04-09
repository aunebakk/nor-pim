/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:47 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Location\LocationAddress.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeLocationAddressService")]
    public partial interface ICrudeLocationAddressService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchByLocationAddressId", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchByLocationAddressIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract FetchByLocationAddressId(System.Guid locationAddressId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchByLocationCountryId", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchByLocationCountryIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchByLocationCountryId(System.Guid locationCountryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchByLocationAddressTypeRcd", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchByLocationAddressTypeRcdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchByLocationAddressTypeRcd(string locationAddressTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/Insert", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/Update", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/Delete", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/DeleteResponse")]
        void Delete(System.Guid locationAddressId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchAll", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeLocationAddressService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchWithFilter(
                    System.Guid locationAddressId, 
                    string locationAddressTypeRcd, 
                    System.Guid locationCountryId, 
                    string addressOne, 
                    string addressTwo, 
                    string addressThree, 
                    string city, 
                    string street, 
                    string state, 
                    string district, 
                    string province, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeLocationAddressServiceChannel : ICrudeLocationAddressService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeLocationAddressServiceClient : System.ServiceModel.ClientBase<ICrudeLocationAddressService>, ICrudeLocationAddressService {
        
        public CrudeLocationAddressServiceClient() {
        }
        
        public CrudeLocationAddressServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeLocationAddressServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationAddressServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationAddressServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract FetchByLocationAddressId(System.Guid locationAddressId) {
            return base.Channel.FetchByLocationAddressId(locationAddressId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchByLocationCountryId(System.Guid locationCountryId) {
            return base.Channel.FetchByLocationCountryId(locationCountryId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            return base.Channel.FetchByLocationAddressTypeRcd(locationAddressTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid locationAddressId) {
            base.Channel.Delete(locationAddressId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressContract> FetchWithFilter(
                    System.Guid locationAddressId, 
                    string locationAddressTypeRcd, 
                    System.Guid locationCountryId, 
                    string addressOne, 
                    string addressTwo, 
                    string addressThree, 
                    string city, 
                    string street, 
                    string state, 
                    string district, 
                    string province, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                locationAddressId: locationAddressId,
                locationAddressTypeRcd: locationAddressTypeRcd,
                locationCountryId: locationCountryId,
                addressOne: addressOne,
                addressTwo: addressTwo,
                addressThree: addressThree,
                city: city,
                street: street,
                state: state,
                district: district,
                province: province,
                zipCode: zipCode,
                poBox: poBox,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
