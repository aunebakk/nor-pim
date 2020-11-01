/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:17:24 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultSystemReferenceTable.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultSystemReferenceTableService")]
    public partial interface ICrudeDefaultSystemReferenceTableService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultUserIdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/DeleteResponse")]
        void Delete(System.Guid defaultSystemReferenceTableId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableName", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName);
        
        // fetch all rows from table default_system_reference_table into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimitResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchWithFilterRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultSystemReferenceTableServiceChannel : ICrudeDefaultSystemReferenceTableService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultSystemReferenceTableServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultSystemReferenceTableService>, ICrudeDefaultSystemReferenceTableService {
        
        public CrudeDefaultSystemReferenceTableServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultSystemReferenceTableServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultSystemReferenceTableServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemReferenceTableServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemReferenceTableServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            return base.Channel.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultSystemReferenceTableId) {
            base.Channel.Delete(defaultSystemReferenceTableId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName) {
            return base.Channel.FetchByDefaultSystemReferenceTableName(defaultSystemReferenceTableName);
        }
        
        // fetch all rows from table default_system_reference_table into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultSystemReferenceTableId: defaultSystemReferenceTableId,
                defaultSystemReferenceTableName: defaultSystemReferenceTableName,
                defaultSystemReferenceDisplayName: defaultSystemReferenceDisplayName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
