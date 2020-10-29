/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 1:31:26 PM
  From Machine: DESKTOP-9A2DH39
  Filename: DefaultChangeLog.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultChangeLogService")]
    public partial interface ICrudeDefaultChangeLogService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogId", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // fetch all rows matching foreign key: DefaultIssueId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultIssueId", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultIssueIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeLogTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/DeleteResponse")]
        void Delete(System.Guid defaultChangeLogId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeName", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchByDefaultChangeNameResponse" +
            "")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName);
        
        // fetch all rows from table default_change_log into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultChangeLogServiceChannel : ICrudeDefaultChangeLogService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultChangeLogServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultChangeLogService>, ICrudeDefaultChangeLogService {
        
        public CrudeDefaultChangeLogServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultChangeLogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultChangeLogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultChangeLogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultChangeLogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            return base.Channel.FetchByDefaultChangeLogId(defaultChangeLogId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // fetch all rows matching foreign key: DefaultIssueId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId) {
            return base.Channel.FetchByDefaultIssueId(defaultIssueId);
        }
        
        // fetch all rows matching foreign key: DefaultChangeLogTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            return base.Channel.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultChangeLogId) {
            base.Channel.Delete(defaultChangeLogId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName) {
            return base.Channel.FetchByDefaultChangeName(defaultChangeName);
        }
        
        // fetch all rows from table default_change_log into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            return base.Channel.FetchWithFilter(
                defaultChangeLogId: defaultChangeLogId,
                defaultChangeName: defaultChangeName,
                defaultChangeDescription: defaultChangeDescription,
                defaultUserId: defaultUserId,
                dateTime: dateTime,
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultIssueId: defaultIssueId
                );
        }
    }
}
