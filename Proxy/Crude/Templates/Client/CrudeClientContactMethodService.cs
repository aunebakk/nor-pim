/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:47:52 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ClientContactMethod.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientContactMethodService")]
    public partial interface ICrudeClientContactMethodService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodIdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId);
        
        // fetch all rows matching foreign key: ClientId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodRcd" +
            "", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchByClientContactMethodRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/Insert", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/Update", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/Delete", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/DeleteResponse")]
        void Delete(System.Guid clientContactMethodId);
        
        // fetch all rows from table client_contact_method into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientContactMethodService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientContactMethodServiceChannel : ICrudeClientContactMethodService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientContactMethodServiceClient : System.ServiceModel.ClientBase<ICrudeClientContactMethodService>, ICrudeClientContactMethodService {
        
        public CrudeClientContactMethodServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeClientContactMethodServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientContactMethodServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId) {
            return base.Channel.FetchByClientContactMethodId(clientContactMethodId);
        }
        
        // fetch all rows matching foreign key: ClientId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ClientContactMethodRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            return base.Channel.FetchByClientContactMethodRcd(clientContactMethodRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientContactMethodId) {
            base.Channel.Delete(clientContactMethodId);
        }
        
        // fetch all rows from table client_contact_method into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientContactMethodId: clientContactMethodId,
                clientId: clientId,
                clientContactMethodRcd: clientContactMethodRcd,
                contactMethodWay: contactMethodWay,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
