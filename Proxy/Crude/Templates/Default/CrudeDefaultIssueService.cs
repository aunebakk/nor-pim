/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 1:31:26 PM
  From Machine: DESKTOP-9A2DH39
  Filename: DefaultIssue.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultIssueService")]
    public partial interface ICrudeDefaultIssueService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByDefaultIssueId(System.Guid defaultIssueId);
        
        // fetch all rows matching foreign key: DefaultErrorId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultErrorId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultErrorIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultErrorId(System.Guid defaultErrorId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueStatusRcd", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByDefaultIssueStatusRcdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/DeleteResponse")]
        void Delete(System.Guid defaultIssueId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchByIssueName", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchByIssueNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByIssueName(string issueName);
        
        // fetch all rows from table default_issue into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultIssueService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultIssueServiceChannel : ICrudeDefaultIssueService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultIssueServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultIssueService>, ICrudeDefaultIssueService {
        
        public CrudeDefaultIssueServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultIssueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultIssueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByDefaultIssueId(System.Guid defaultIssueId) {
            return base.Channel.FetchByDefaultIssueId(defaultIssueId);
        }
        
        // fetch all rows matching foreign key: DefaultErrorId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultErrorId(System.Guid defaultErrorId) {
            return base.Channel.FetchByDefaultErrorId(defaultErrorId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // fetch all rows matching foreign key: DefaultIssueTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            return base.Channel.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
        }
        
        // fetch all rows matching foreign key: DefaultIssueStatusRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            return base.Channel.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultIssueId) {
            base.Channel.Delete(defaultIssueId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract FetchByIssueName(string issueName) {
            return base.Channel.FetchByIssueName(issueName);
        }
        
        // fetch all rows from table default_issue into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueContract> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote) {
            return base.Channel.FetchWithFilter(
                defaultIssueId: defaultIssueId,
                defaultIssueTypeRcd: defaultIssueTypeRcd,
                defaultIssueStatusRcd: defaultIssueStatusRcd,
                defaultErrorId: defaultErrorId,
                issueName: issueName,
                issueDescription: issueDescription,
                stepsToReproduce: stepsToReproduce,
                link: link,
                defaultUserId: defaultUserId,
                dateTime: dateTime,
                fixedNote: fixedNote
                );
        }
    }
}
