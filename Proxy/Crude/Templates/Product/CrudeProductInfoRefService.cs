/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 8:58:37 AM
  From Machine: DESKTOP-742U247
  Filename: ProductInfoRef.json
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
    public partial class ProductInfoRef {
        
        public const string EANInfo = "EAN";
        
        public const string HMSInfo = "HMS";
        
        public const string HTMLInfo = "HTML";
        
        public const string ProductInfo = "PI";
        
        public const string UserManual = "UM";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductInfoRefService")]
    public partial interface ICrudeProductInfoRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoRcd", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/DeleteResponse")]
        void Delete(string productInfoRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoName", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName);
        
        // fetch all rows from table product_info_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductInfoRefServiceChannel : ICrudeProductInfoRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductInfoRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductInfoRefService>, ICrudeProductInfoRefService {
        
        public CrudeProductInfoRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductInfoRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductInfoRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd) {
            return base.Channel.FetchByProductInfoRcd(productInfoRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productInfoRcd) {
            base.Channel.Delete(productInfoRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName) {
            return base.Channel.FetchByProductInfoName(productInfoName);
        }
        
        // fetch all rows from table product_info_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productInfoRcd: productInfoRcd,
                productInfoName: productInfoName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
