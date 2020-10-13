/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:34:08 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultPerformanceTimeRollup.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultPerformanceTimeRollupService")]
    public partial interface ICrudeDefaultPerformanceTimeRollupService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultPerfor" +
            "manceTimeRollupId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultPerfor" +
            "manceTimeRollupIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultUserId" +
            "", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByDefaultUserId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/DeleteResponse")]
        void Delete(System.Guid defaultPerformanceTimeRollupId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByCommandName", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchByCommandNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName);
        
        // fetch all rows from table default_performance_time_rollup into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimitRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimitAnd" +
            "Offset", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllWithLimitAnd" +
            "OffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchAllCountRespons" +
            "e")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeRollupService/FetchWithFilterRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultPerformanceTimeRollupServiceChannel : ICrudeDefaultPerformanceTimeRollupService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultPerformanceTimeRollupServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultPerformanceTimeRollupService>, ICrudeDefaultPerformanceTimeRollupService {
        
        public CrudeDefaultPerformanceTimeRollupServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultPerformanceTimeRollupServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultPerformanceTimeRollupServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceTimeRollupServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceTimeRollupServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId) {
            return base.Channel.FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultPerformanceTimeRollupId) {
            base.Channel.Delete(defaultPerformanceTimeRollupId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName) {
            return base.Channel.FetchByCommandName(commandName);
        }
        
        // fetch all rows from table default_performance_time_rollup into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultPerformanceTimeRollupId: defaultPerformanceTimeRollupId,
                commandName: commandName,
                milliseconds: milliseconds,
                hits: hits,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
