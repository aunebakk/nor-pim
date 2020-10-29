/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:57:06 PM
  From Machine: DESKTOP-9A2DH39
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

// Client Proxy Layer
// the ClientProxyLayer is where the SOAP services ties into the Client layer
//  this layer is used for, among other technologies, dotNetFramework WinForm,
//  ASP and TypeScript User Interfaces or from one business layer to another
// links:
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
//   https://www.c-sharpcorner.com/UploadFile/8a67c0/proxy-class-for-the-wcf-service/: client Proxy
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientAddressService")]
    public partial interface ICrudeClientAddressService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressId", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId);
        
        // fetch all rows matching foreign key: ClientId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientId(System.Guid clientId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByClientAddressTypeRcdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/Insert", ReplyAction="http://tempuri.org/ICrudeClientAddressService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/Update", ReplyAction="http://tempuri.org/ICrudeClientAddressService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/Delete", ReplyAction="http://tempuri.org/ICrudeClientAddressService/DeleteResponse")]
        void Delete(System.Guid clientAddressId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchByAddressLineOneName", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchByAddressLineOneNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName);
        
        // fetch all rows from table client_address into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientAddressService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
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
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientAddressServiceChannel : ICrudeClientAddressService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientAddressServiceClient : System.ServiceModel.ClientBase<ICrudeClientAddressService>, ICrudeClientAddressService {
        
        public CrudeClientAddressServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
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
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId) {
            return base.Channel.FetchByClientAddressId(clientAddressId);
        }
        
        // fetch all rows matching foreign key: ClientId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ClientAddressTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            return base.Channel.FetchByClientAddressTypeRcd(clientAddressTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientAddressId) {
            base.Channel.Delete(clientAddressId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName) {
            return base.Channel.FetchByAddressLineOneName(addressLineOneName);
        }
        
        // fetch all rows from table client_address into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
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
