/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 1:31:26 PM
  From Machine: DESKTOP-9A2DH39
  Filename: DefaultUserActivityTypeRef.json
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
    public partial class DefaultUserActivityTypeRef {
        
        public const string BusinessLogicMethodInvoked = "blmi";
        
        public const string FormOpened = "fo";
        
        public const string Login = "li";
        
        public const string Logout = "lo";
        
        public const string ScheduledEvent = "se";
        
        public const string WebPageOpened = "wpo";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultUserActivityTypeRefService")]
    public partial interface ICrudeDefaultUserActivityTypeRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/DeleteResponse")]
        void Delete(string defaultUserActivityTypeRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeName", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName);
        
        // fetch all rows from table default_user_activity_type_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimitRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchWithFilterRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultUserActivityTypeRefServiceChannel : ICrudeDefaultUserActivityTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultUserActivityTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultUserActivityTypeRefService>, ICrudeDefaultUserActivityTypeRefService {
        
        public CrudeDefaultUserActivityTypeRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultUserActivityTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultUserActivityTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserActivityTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserActivityTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            return base.Channel.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultUserActivityTypeRcd) {
            base.Channel.Delete(defaultUserActivityTypeRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName) {
            return base.Channel.FetchByDefaultUserActivityTypeName(defaultUserActivityTypeName);
        }
        
        // fetch all rows from table default_user_activity_type_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultUserActivityTypeRcd: defaultUserActivityTypeRcd,
                defaultUserActivityTypeName: defaultUserActivityTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
