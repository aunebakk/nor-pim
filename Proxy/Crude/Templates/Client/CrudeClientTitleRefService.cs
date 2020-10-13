/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 2:15:13 PM
  From Machine: DESKTOP-742U247
  Filename: ClientTitleRef.json
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
    public partial class ClientTitleRef {
        
        public const string Child = "CHA";
        
        public const string Infant = "INA";
        
        public const string Mr = "MR";
        
        public const string Mrs = "MRS";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientTitleRefService")]
    public partial interface ICrudeClientTitleRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleRcd", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/DeleteResponse")]
        void Delete(string clientTitleRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleName", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName);
        
        // fetch all rows from table client_title_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientTitleRefServiceChannel : ICrudeClientTitleRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientTitleRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientTitleRefService>, ICrudeClientTitleRefService {
        
        public CrudeClientTitleRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeClientTitleRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientTitleRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientTitleRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientTitleRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd) {
            return base.Channel.FetchByClientTitleRcd(clientTitleRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientTitleRcd) {
            base.Channel.Delete(clientTitleRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName) {
            return base.Channel.FetchByClientTitleName(clientTitleName);
        }
        
        // fetch all rows from table client_title_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientTitleRcd: clientTitleRcd,
                clientTitleName: clientTitleName,
                clientTitleDescription: clientTitleDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
