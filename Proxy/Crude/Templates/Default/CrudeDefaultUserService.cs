/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:40:13 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultUser.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultUserService")]
    public partial interface ICrudeDefaultUserService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId);
        
        // fetch all rows matching foreign key: CreatedByDefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByCreatedByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByCreatedByDefaultUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultStateRcd", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/DeleteResponse")]
        void Delete(System.Guid defaultUserId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserName", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName);
        
        // fetch all rows from table default_user into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultUserServiceChannel : ICrudeDefaultUserService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultUserServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultUserService>, ICrudeDefaultUserService {
        
        public CrudeDefaultUserServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultUserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultUserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // fetch all rows matching foreign key: CreatedByDefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId) {
            return base.Channel.FetchByCreatedByDefaultUserId(createdByDefaultUserId);
        }
        
        // fetch all rows matching foreign key: DefaultStateRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd) {
            return base.Channel.FetchByDefaultStateRcd(defaultStateRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultUserId) {
            base.Channel.Delete(defaultUserId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName) {
            return base.Channel.FetchByDefaultUserName(defaultUserName);
        }
        
        // fetch all rows from table default_user into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            return base.Channel.FetchWithFilter(
                defaultUserId: defaultUserId,
                defaultUserCode: defaultUserCode,
                defaultUserName: defaultUserName,
                email: email,
                password: password,
                defaultStateRcd: defaultStateRcd,
                createdByDefaultUserId: createdByDefaultUserId,
                dateTime: dateTime,
                lastActivityDateTime: lastActivityDateTime
                );
        }
    }
}
