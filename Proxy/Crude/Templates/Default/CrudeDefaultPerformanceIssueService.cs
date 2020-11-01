/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 12:52:58 PM
  From Machine: DESKTOP-9A2DH39
  Filename: DefaultPerformanceIssue.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultPerformanceIssueService")]
    public partial interface ICrudeDefaultPerformanceIssueService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultPerformance" +
            "IssueId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultPerformance" +
            "IssueIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByDefaultUserIdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/DeleteResponse")]
        void Delete(System.Guid defaultPerformanceIssueId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByCommandName", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchByCommandNameRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName);
        
        // fetch all rows from table default_performance_issue into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceIssueService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultPerformanceIssueServiceChannel : ICrudeDefaultPerformanceIssueService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultPerformanceIssueServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultPerformanceIssueService>, ICrudeDefaultPerformanceIssueService {
        
        public CrudeDefaultPerformanceIssueServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultPerformanceIssueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultPerformanceIssueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceIssueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceIssueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            return base.Channel.FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultPerformanceIssueId) {
            base.Channel.Delete(defaultPerformanceIssueId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName) {
            return base.Channel.FetchByCommandName(commandName);
        }
        
        // fetch all rows from table default_performance_issue into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultPerformanceIssueId: defaultPerformanceIssueId,
                commandName: commandName,
                commandText: commandText,
                milliseconds: milliseconds,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
