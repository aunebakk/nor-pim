/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:02:12 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ClientIdentifierTypeRef.json
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

    // this class is used to expose reference codes from the database
    // links:
    //   https://norsolutionsql2xcore.azurewebsites.net/sql2xIndex#documentation: sql2x.org
    public partial class ClientIdentifierTypeRef {
        
        public const string EmployeeNumber = "ENR";
        
        public const string PassportNumber = "PNR";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientIdentifierTypeRefService")]
    public partial interface ICrudeClientIdentifierTypeRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peRcd", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/DeleteResponse")]
        void Delete(string clientIdentifierTypeRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peName", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeName(string clientIdentifierTypeName);
        
        // fetch all rows from table client_identifier_type_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchWithFilter(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientIdentifierTypeRefServiceChannel : ICrudeClientIdentifierTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientIdentifierTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientIdentifierTypeRefService>, ICrudeClientIdentifierTypeRefService {
        
        public CrudeClientIdentifierTypeRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeClientIdentifierTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientIdentifierTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientIdentifierTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientIdentifierTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            return base.Channel.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientIdentifierTypeRcd) {
            base.Channel.Delete(clientIdentifierTypeRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeName(string clientIdentifierTypeName) {
            return base.Channel.FetchByClientIdentifierTypeName(clientIdentifierTypeName);
        }
        
        // fetch all rows from table client_identifier_type_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchWithFilter(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientIdentifierTypeRcd: clientIdentifierTypeRcd,
                clientIdentifierTypeName: clientIdentifierTypeName,
                clientIdentifierTypeDescription: clientIdentifierTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
