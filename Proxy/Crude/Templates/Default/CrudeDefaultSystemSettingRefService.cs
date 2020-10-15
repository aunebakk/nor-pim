/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 8:58:37 AM
  From Machine: DESKTOP-742U247
  Filename: DefaultSystemSettingRef.json
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
    public partial class DefaultSystemSettingRef {
        
        public const string EAN13WebLink = "EANLINK";
        
        public const string TheGlobalLanguageOfBusiness = "GS1LINK";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultSystemSettingRefService")]
    public partial interface ICrudeDefaultSystemSettingRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngRcd", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultUserIdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/DeleteResponse")]
        void Delete(string defaultSystemSettingRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngName", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName);
        
        // fetch all rows from table default_system_setting_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultSystemSettingRefServiceChannel : ICrudeDefaultSystemSettingRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultSystemSettingRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultSystemSettingRefService>, ICrudeDefaultSystemSettingRefService {
        
        public CrudeDefaultSystemSettingRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultSystemSettingRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultSystemSettingRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            return base.Channel.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultSystemSettingRcd) {
            base.Channel.Delete(defaultSystemSettingRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName) {
            return base.Channel.FetchByDefaultSystemSettingName(defaultSystemSettingName);
        }
        
        // fetch all rows from table default_system_setting_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultSystemSettingRcd: defaultSystemSettingRcd,
                defaultSystemSettingName: defaultSystemSettingName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
