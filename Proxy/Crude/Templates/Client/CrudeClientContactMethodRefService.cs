/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:02:12 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ClientContactMethodRef.json
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
    public partial class ClientContactMethodRef {
        
        public const string BusinessPhone = "BPE";
        
        public const string EMail = "EMA";
        
        public const string Fax = "FAX";
        
        public const string HomePhone = "HPE";
        
        public const string InternationalPhone = "IPE";
        
        public const string LocalPhone = "LPE";
        
        public const string MMSMobile = "MME";
        
        public const string Mobile = "MOA";
        
        public const string SMSMobile = "SME";
        
        public const string Telephone = "TEA";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientContactMethodRefService")]
    public partial interface ICrudeClientContactMethodRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "Rcd", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "RcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/DeleteResponse")]
        void Delete(string clientContactMethodRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "Name", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "NameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName);
        
        // fetch all rows from table client_contact_method_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientContactMethodRefServiceChannel : ICrudeClientContactMethodRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeClientContactMethodRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientContactMethodRefService>, ICrudeClientContactMethodRefService {
        
        public CrudeClientContactMethodRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeClientContactMethodRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientContactMethodRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            return base.Channel.FetchByClientContactMethodRcd(clientContactMethodRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientContactMethodRcd) {
            base.Channel.Delete(clientContactMethodRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName) {
            return base.Channel.FetchByClientContactMethodName(clientContactMethodName);
        }
        
        // fetch all rows from table client_contact_method_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientContactMethodRcd: clientContactMethodRcd,
                clientContactMethodName: clientContactMethodName,
                clientContactMethodDescription: clientContactMethodDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
