/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:48:36 PM
  From Machine: DESKTOP-9A2DH39
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientService")]
    public partial interface ICrudeClientService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByClientId(System.Guid clientId);
        
        // fetch all rows matching foreign key: ClientAddressId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientAddressId", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientAddressIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientNationalityRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientNationalityRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientGenderRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientGenderRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByClientTitleRcd", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByClientTitleRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/Insert", ReplyAction="http://tempuri.org/ICrudeClientService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/Update", ReplyAction="http://tempuri.org/ICrudeClientService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/Delete", ReplyAction="http://tempuri.org/ICrudeClientService/DeleteResponse")]
        void Delete(System.Guid clientId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchByFirstName", ReplyAction="http://tempuri.org/ICrudeClientService/FetchByFirstNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByFirstName(string firstName);
        
        // fetch all rows from table client into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientServiceChannel : ICrudeClientService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientServiceClient : System.ServiceModel.ClientBase<ICrudeClientService>, ICrudeClientService {
        
        public CrudeClientServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
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
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        // fetch all rows matching foreign key: ClientAddressId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId) {
            return base.Channel.FetchByClientAddressId(clientAddressId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ClientTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd) {
            return base.Channel.FetchByClientTypeRcd(clientTypeRcd);
        }
        
        // fetch all rows matching foreign key: ClientNationalityRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd) {
            return base.Channel.FetchByClientNationalityRcd(clientNationalityRcd);
        }
        
        // fetch all rows matching foreign key: ClientGenderRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd) {
            return base.Channel.FetchByClientGenderRcd(clientGenderRcd);
        }
        
        // fetch all rows matching foreign key: ClientTitleRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd) {
            return base.Channel.FetchByClientTitleRcd(clientTitleRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientId) {
            base.Channel.Delete(clientId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract FetchByFirstName(string firstName) {
            return base.Channel.FetchByFirstName(firstName);
        }
        
        // fetch all rows from table client into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
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
