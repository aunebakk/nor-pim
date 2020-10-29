/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:48:36 PM
  From Machine: DESKTOP-9A2DH39
  Filename: ClientDocument.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientDocumentService")]
    public partial interface ICrudeClientDocumentService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentId", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId);
        
        // fetch all rows matching foreign key: ClientId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientId(System.Guid clientId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByClientDocumentTypeRcdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/Insert", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/Update", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/Delete", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/DeleteResponse")]
        void Delete(System.Guid clientDocumentId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchByDocumentName", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchByDocumentNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByDocumentName(string documentName);
        
        // fetch all rows from table client_document into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientDocumentService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientDocumentService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientDocumentServiceChannel : ICrudeClientDocumentService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientDocumentServiceClient : System.ServiceModel.ClientBase<ICrudeClientDocumentService>, ICrudeClientDocumentService {
        
        public CrudeClientDocumentServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
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
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId) {
            return base.Channel.FetchByClientDocumentId(clientDocumentId);
        }
        
        // fetch all rows matching foreign key: ClientId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ClientDocumentTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            return base.Channel.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientDocumentId) {
            base.Channel.Delete(clientDocumentId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract FetchByDocumentName(string documentName) {
            return base.Channel.FetchByDocumentName(documentName);
        }
        
        // fetch all rows from table client_document into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
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
