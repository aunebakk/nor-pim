/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:04:09 PM
  From Machine: DESKTOP-LSRVP12
  Filename: DefaultTestRun.json
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
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// client Proxy: https://www.c-sharpcorner.com/UploadFile/8a67c0/proxy-class-for-the-wcf-service/
//  docLink: http://sql2x.org/documentationLink/a58883c6-e6e2-4265-98ad-0268dbbdb1b1
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultTestRunService")]
    public partial interface ICrudeDefaultTestRunService {
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/70a1f934-1d8a-43a0-8896-3ec370944938
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId);
        
        // fetch all rows matching foreign key: DefaultTestId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId);
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunResultRcd", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunResultRcdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd);
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/54a1998f-1667-4680-ae80-cb0c31dd5872
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract);
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/c1ccee6d-504c-4fe8-bf7c-57624012598a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract);
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d2e5c69-6801-43a2-9daf-0ff04fa6c996
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/DeleteResponse")]
        void Delete(System.Guid defaultTestRunId);
        
        // fetch all rows from table default_test_run into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/4ac8b1d2-0562-43e9-b63f-8973ca381a0a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/7e45d3c9-f66e-4ad7-8620-df8a4eae6177
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/886cf296-7b9c-4a1a-8b40-8150e605ba11
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/dd08755c-f264-4c12-8d69-18c190b13a6e
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/754c25f9-c499-45f3-9fdb-03850db5c79d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime);
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultTestRunServiceChannel : ICrudeDefaultTestRunService, System.ServiceModel.IClientChannel {
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    public class CrudeDefaultTestRunServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultTestRunService>, ICrudeDefaultTestRunService {
        
        public CrudeDefaultTestRunServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9b6c163a-8411-40ba-bb08-e390673c9ab3
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/0bf226bb-0d8e-4930-90b9-d0e53a1f9c2a
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId) {
            return base.Channel.FetchByDefaultTestRunId(defaultTestRunId);
        }
        
        // fetch all rows matching foreign key: DefaultTestId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId) {
            return base.Channel.FetchByDefaultTestId(defaultTestId);
        }
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: DefaultTestRunResultRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            return base.Channel.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/606647e9-2bdb-4b55-9541-449812c123d2
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/cda8cbb1-dc3e-461a-8c98-5c277efe7e86
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/8513f38a-4552-4020-95b2-78c872a82ffe
        public void Delete(System.Guid defaultTestRunId) {
            base.Channel.Delete(defaultTestRunId);
        }
        
        // fetch all rows from table default_test_run into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/168c348a-8e3d-463e-8e60-727047f10afc
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/05a908ff-897b-49a5-a5e4-fd57e1ddca0d
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9ac77a1-e367-4bbd-89ed-c65f56d14f3c
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b5f68e2-e3e0-4f82-8f99-f3ce860dc8fe
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/c10bac90-d91e-47a6-bd52-f537c96471cd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultTestRunId: defaultTestRunId,
                defaultTestId: defaultTestId,
                defaultTestRunResultRcd: defaultTestRunResultRcd,
                result: result,
                startDateTime: startDateTime,
                endDateTime: endDateTime,
                elapsedMilliseconds: elapsedMilliseconds,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
