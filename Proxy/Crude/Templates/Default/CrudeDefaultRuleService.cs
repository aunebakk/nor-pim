/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 12:52:58 PM
  From Machine: DESKTOP-9A2DH39
  Filename: DefaultRule.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultRuleService")]
    public partial interface ICrudeDefaultRuleService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleId", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchByDefaultRuleTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/DeleteResponse")]
        void Delete(System.Guid defaultRuleId);
        
        // fetch all rows from table default_rule into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultRuleService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultRuleServiceChannel : ICrudeDefaultRuleService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultRuleServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultRuleService>, ICrudeDefaultRuleService {
        
        public CrudeDefaultRuleServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultRuleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultRuleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId) {
            return base.Channel.FetchByDefaultRuleId(defaultRuleId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // fetch all rows matching foreign key: DefaultRuleTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            return base.Channel.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultRuleId) {
            base.Channel.Delete(defaultRuleId);
        }
        
        // fetch all rows from table default_rule into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultRuleId: defaultRuleId,
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                address: address,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
