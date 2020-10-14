/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 8:33:28 PM
  From Machine: DESKTOP-742U247
  Filename: DefaultError.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultErrorService")]
    public partial interface ICrudeDefaultErrorService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorId", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByDefaultErrorId(System.Guid defaultErrorId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorLayerRcd", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorLayerRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/DeleteResponse")]
        void Delete(System.Guid defaultErrorId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByMethodName", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByMethodNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByMethodName(string methodName);
        
        // fetch all rows from table default_error into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultErrorServiceChannel : ICrudeDefaultErrorService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultErrorServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultErrorService>, ICrudeDefaultErrorService {
        
        public CrudeDefaultErrorServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultErrorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultErrorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByDefaultErrorId(System.Guid defaultErrorId) {
            return base.Channel.FetchByDefaultErrorId(defaultErrorId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // fetch all rows matching foreign key: DefaultErrorLayerRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            return base.Channel.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);
        }
        
        // fetch all rows matching foreign key: DefaultErrorTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            return base.Channel.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultErrorId) {
            base.Channel.Delete(defaultErrorId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByMethodName(string methodName) {
            return base.Channel.FetchByMethodName(methodName);
        }
        
        // fetch all rows from table default_error into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultErrorId: defaultErrorId,
                defaultErrorLayerRcd: defaultErrorLayerRcd,
                defaultErrorTypeRcd: defaultErrorTypeRcd,
                layerAddress: layerAddress,
                errorMessage: errorMessage,
                stackTrace: stackTrace,
                methodName: methodName,
                domainName: domainName,
                className: className,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
