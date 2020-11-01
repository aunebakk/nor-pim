/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:17:24 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultErrorLayerRef.json
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
    public partial class DefaultErrorLayerRef {
        
        public const string BusinessLogicLayer = "BLL";
        
        public const string BusinessLayerEngine = "BLLEngine";
        
        public const string BusinessLogicLayerRest = "BLLRest";
        
        public const string BusinessLogicLayerSoap = "BLLSoap";
        
        public const string ClientEngine = "CEngine";
        
        public const string Database = "DB";
        
        public const string DataAccessLayer = "DLL";
        
        public const string Documentation = "DOC";
        
        public const string ASPModelViewController = "MVC";
        
        public const string ClientProxy = "Proxy";
        
        public const string Sql2Wcf = "S2W";
        
        public const string AutomatedTesting = "Test";
        
        public const string TestFront = "TestF";
        
        public const string WindowsWinforms = "WinForms";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultErrorLayerRefService")]
    public partial interface ICrudeDefaultErrorLayerRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerRcd", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/DeleteResponse")]
        void Delete(string defaultErrorLayerRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerName" +
            "", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName);
        
        // fetch all rows from table default_error_layer_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultErrorLayerRefServiceChannel : ICrudeDefaultErrorLayerRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultErrorLayerRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultErrorLayerRefService>, ICrudeDefaultErrorLayerRefService {
        
        public CrudeDefaultErrorLayerRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultErrorLayerRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultErrorLayerRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorLayerRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorLayerRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            return base.Channel.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultErrorLayerRcd) {
            base.Channel.Delete(defaultErrorLayerRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName) {
            return base.Channel.FetchByDefaultErrorLayerName(defaultErrorLayerName);
        }
        
        // fetch all rows from table default_error_layer_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultErrorLayerRcd: defaultErrorLayerRcd,
                defaultErrorLayerName: defaultErrorLayerName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
