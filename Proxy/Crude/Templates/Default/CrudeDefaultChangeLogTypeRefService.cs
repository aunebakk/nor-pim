/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:11 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultChangeLogTypeRef.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: CrudeProxy
  Documentation:
    WCF Client Proxy layer for accessing Azure Storage Tables through
      CIFUDE ( Create Insert Fetch Update Delete and Extra Operations )
      Works for dotNetFramework
*/
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
    public partial class DefaultChangeLogTypeRef {

        public const string ChangedFeature = "Change";

        public const string Issue = "Issue";

        public const string NewFeature = "New";

        public const string RemovedFeature = "Removed";
    }

    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ICrudeDefaultChangeLogTypeRefService")]
    public partial interface ICrudeDefaultChangeLogTypeRefService {

        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peRcd", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);

        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultUserId", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultUserIdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);

        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/Insert", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract);

        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/Update", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract);

        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/Delete", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/DeleteResponse")]
        void Delete(string defaultChangeLogTypeRcd);

        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peName", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName);

        // fetch all rows from table default_change_log_type_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAll", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAll();

        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimit", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit);

        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);

        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllCount", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();

        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchWithFilter", ReplyAction = "http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }

    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultChangeLogTypeRefServiceChannel : ICrudeDefaultChangeLogTypeRefService, System.ServiceModel.IClientChannel {
    }

    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultChangeLogTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultChangeLogTypeRefService>, ICrudeDefaultChangeLogTypeRefService {

        public CrudeDefaultChangeLogTypeRefServiceClient() {
        }

        // constructors for end point address, binding and contracts
        public CrudeDefaultChangeLogTypeRefServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        public CrudeDefaultChangeLogTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public CrudeDefaultChangeLogTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public CrudeDefaultChangeLogTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            return base.Channel.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
        }

        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }

        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract) {
            base.Channel.Insert(contract);
        }

        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract) {
            base.Channel.Update(contract);
        }

        // delete a row in table based on primary key
        public void Delete(string defaultChangeLogTypeRcd) {
            base.Channel.Delete(defaultChangeLogTypeRcd);
        }

        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName) {
            return base.Channel.FetchByDefaultChangeLogTypeName(defaultChangeLogTypeName);
        }

        // fetch all rows from table default_change_log_type_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }

        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }

        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit, offset);
        }

        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }

        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultChangeLogTypeName: defaultChangeLogTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
