/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/12/2020 5:03:30 AM
  From Machine: DESKTOP-LSRVP12
  Filename: ClientLink.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: DotNetFrameworkCrudeProxy
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientLinkService")]
    public partial interface ICrudeClientLinkService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkId", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId);
        
        // fetch all rows matching foreign key: ClientId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientId(System.Guid clientId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByClientLinkTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/Insert", ReplyAction="http://tempuri.org/ICrudeClientLinkService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/Update", ReplyAction="http://tempuri.org/ICrudeClientLinkService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/Delete", ReplyAction="http://tempuri.org/ICrudeClientLinkService/DeleteResponse")]
        void Delete(System.Guid clientLinkId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchByLinkName", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchByLinkNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByLinkName(string linkName);
        
        // fetch all rows from table client_link into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientLinkService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientLinkService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientLinkServiceChannel : ICrudeClientLinkService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientLinkServiceClient : System.ServiceModel.ClientBase<ICrudeClientLinkService>, ICrudeClientLinkService {
        
        public CrudeClientLinkServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeClientLinkServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientLinkServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientLinkServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientLinkServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId) {
            return base.Channel.FetchByClientLinkId(clientLinkId);
        }
        
        // fetch all rows matching foreign key: ClientId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ClientLinkTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            return base.Channel.FetchByClientLinkTypeRcd(clientLinkTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientLinkId) {
            base.Channel.Delete(clientLinkId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract FetchByLinkName(string linkName) {
            return base.Channel.FetchByLinkName(linkName);
        }
        
        // fetch all rows from table client_link into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientLinkId: clientLinkId,
                clientId: clientId,
                clientLinkTypeRcd: clientLinkTypeRcd,
                linkName: linkName,
                link: link,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
