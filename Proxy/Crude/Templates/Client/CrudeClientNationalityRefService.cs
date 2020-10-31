/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:06:18 AM
  From Machine: DESKTOP-9A2DH39
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
    public partial class ClientNationalityRef {
        
        public const string Africa = "AFA";
        
        public const string Americas = "AMA";
        
        public const string Asia = "ASA";
        
        public const string Europe = "EUA";
        
        public const string Oceania = "OCA";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientNationalityRefService")]
    public partial interface ICrudeClientNationalityRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityRcd", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/DeleteResponse")]
        void Delete(string clientNationalityRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityName" +
            "", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchByClientNationalityName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName);
        
        // fetch all rows from table client_nationality_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientNationalityRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientNationalityRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientNationalityRefServiceChannel : ICrudeClientNationalityRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientNationalityRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientNationalityRefService>, ICrudeClientNationalityRefService {
        
        public CrudeClientNationalityRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
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
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd) {
            return base.Channel.FetchByClientNationalityRcd(clientNationalityRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientNationalityRcd) {
            base.Channel.Delete(clientNationalityRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName) {
            return base.Channel.FetchByClientNationalityName(clientNationalityName);
        }
        
        // fetch all rows from table client_nationality_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
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
