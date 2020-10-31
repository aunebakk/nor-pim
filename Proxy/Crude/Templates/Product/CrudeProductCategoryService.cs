/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:06:18 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductCategory.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryService")]
    public partial interface ICrudeProductCategoryService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId);
        
        // fetch all rows matching foreign key: ProductCategoryBecameId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryBecameId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryBecameIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId);
        
        // fetch all rows matching foreign key: ProductCategoryParentId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryParentId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryParentIdRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryParentId(System.Guid productCategoryParentId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByStateRcd(string stateRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/DeleteResponse")]
        void Delete(System.Guid productCategoryId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryName", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryNameRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryName(string productCategoryName);
        
        // fetch all rows from table product_category into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryServiceChannel : ICrudeProductCategoryService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductCategoryServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryService>, ICrudeProductCategoryService {
        
        public CrudeProductCategoryServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductCategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        // fetch all rows matching foreign key: ProductCategoryBecameId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId) {
            return base.Channel.FetchByProductCategoryBecameId(productCategoryBecameId);
        }
        
        // fetch all rows matching foreign key: ProductCategoryParentId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByProductCategoryParentId(System.Guid productCategoryParentId) {
            return base.Channel.FetchByProductCategoryParentId(productCategoryParentId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: StateRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productCategoryId) {
            base.Channel.Delete(productCategoryId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryName(string productCategoryName) {
            return base.Channel.FetchByProductCategoryName(productCategoryName);
        }
        
        // fetch all rows from table product_category into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryId: productCategoryId,
                productCategoryBecameId: productCategoryBecameId,
                productCategoryParentId: productCategoryParentId,
                productCategoryCode: productCategoryCode,
                productCategoryName: productCategoryName,
                productCategoryPosition: productCategoryPosition,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
