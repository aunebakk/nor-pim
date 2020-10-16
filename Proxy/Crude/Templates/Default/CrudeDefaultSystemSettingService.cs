/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 2:55:24 PM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultSystemSetting.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultSystemSettingService")]
    public partial interface ICrudeDefaultSystemSettingService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingI" +
            "d", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId);
        
        // fetch all rows matching foreign key: DefaultUserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingR" +
            "cd", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingR" +
            "cdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/DeleteResponse")]
        void Delete(System.Guid defaultSystemSettingId);
        
        // fetch all rows from table default_system_setting into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultSystemSettingServiceChannel : ICrudeDefaultSystemSettingService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultSystemSettingServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultSystemSettingService>, ICrudeDefaultSystemSettingService {
        
        public CrudeDefaultSystemSettingServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultSystemSettingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultSystemSettingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            return base.Channel.FetchByDefaultSystemSettingId(defaultSystemSettingId);
        }
        
        // fetch all rows matching foreign key: DefaultUserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        // fetch all rows matching foreign key: DefaultSystemSettingRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            return base.Channel.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultSystemSettingId) {
            base.Channel.Delete(defaultSystemSettingId);
        }
        
        // fetch all rows from table default_system_setting into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultSystemSettingId: defaultSystemSettingId,
                defaultSystemSettingRcd: defaultSystemSettingRcd,
                defaultSystemSettingValue: defaultSystemSettingValue,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
