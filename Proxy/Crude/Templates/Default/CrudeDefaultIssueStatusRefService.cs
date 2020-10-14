/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 8:33:28 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultIssueStatusRef.json
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
    public partial class DefaultIssueStatusRef {
        
        public const string NotAnIssue = "NotAnIssue";
        
        public const string NotReproducible = "NotReproducible";
        
        public const string Resolved = "Resolved";
        
        public const string ToBeResolved = "ToBeResolved";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultIssueStatusRefService")]
    public partial interface ICrudeDefaultIssueStatusRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusRc" +
            "d", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusRc" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultUserIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/DeleteResponse")]
        void Delete(string defaultIssueStatusRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusNa" +
            "me", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchByDefaultIssueStatusNa" +
            "meResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusName(string defaultIssueStatusName);
        
        // fetch all rows from table default_issue_status_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllWithLimitAndOffsetR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultIssueStatusRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultIssueStatusRefServiceChannel : ICrudeDefaultIssueStatusRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultIssueStatusRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultIssueStatusRefService>, ICrudeDefaultIssueStatusRefService {
        
        public CrudeDefaultIssueStatusRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultIssueStatusRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultIssueStatusRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueStatusRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueStatusRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            return base.Channel.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultIssueStatusRcd) {
            base.Channel.Delete(defaultIssueStatusRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusName(string defaultIssueStatusName) {
            return base.Channel.FetchByDefaultIssueStatusName(defaultIssueStatusName);
        }
        
        // fetch all rows from table default_issue_status_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueStatusRefContract> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultIssueStatusRcd: defaultIssueStatusRcd,
                defaultIssueStatusName: defaultIssueStatusName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
