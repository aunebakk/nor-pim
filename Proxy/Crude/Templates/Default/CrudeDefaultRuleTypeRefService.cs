/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:34:08 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultRuleTypeRef.json
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
    public partial class DefaultRuleTypeRef {
        
        public const string HideLayerAddress = "Hide";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultRuleTypeRefService")]
    public partial interface ICrudeDefaultRuleTypeRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeRcdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/DeleteResponse")]
        void Delete(string defaultRuleTypeRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeName", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchByDefaultRuleTypeNameResp" +
            "onse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName);
        
        // fetch all rows from table default_rule_type_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllWithLimitAndOffsetResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultRuleTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultRuleTypeRefServiceChannel : ICrudeDefaultRuleTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultRuleTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultRuleTypeRefService>, ICrudeDefaultRuleTypeRefService {
        
        public CrudeDefaultRuleTypeRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultRuleTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultRuleTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultRuleTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            return base.Channel.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultRuleTypeRcd) {
            base.Channel.Delete(defaultRuleTypeRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName) {
            return base.Channel.FetchByDefaultRuleTypeName(defaultRuleTypeName);
        }
        
        // fetch all rows from table default_rule_type_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                defaultRuleTypeName: defaultRuleTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
