/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 2:55:48 PM
  From Machine: DESKTOP-742U247
  Filename: ClientGenderRef.json
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
    public partial class ClientGenderRef {
        
        public const string Female = "FEA";
        
        public const string Male = "MAA";
        
        public const string Unknown = "UNA";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientGenderRefService")]
    public partial interface ICrudeClientGenderRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderRcd", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/DeleteResponse")]
        void Delete(string clientGenderRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderName", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName);
        
        // fetch all rows from table client_gender_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientGenderRefServiceChannel : ICrudeClientGenderRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientGenderRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientGenderRefService>, ICrudeClientGenderRefService {
        
        public CrudeClientGenderRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeClientGenderRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientGenderRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientGenderRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientGenderRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd) {
            return base.Channel.FetchByClientGenderRcd(clientGenderRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientGenderRcd) {
            base.Channel.Delete(clientGenderRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName) {
            return base.Channel.FetchByClientGenderName(clientGenderName);
        }
        
        // fetch all rows from table client_gender_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientGenderRcd: clientGenderRcd,
                clientGenderName: clientGenderName,
                clientGenderDescription: clientGenderDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
