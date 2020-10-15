/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 12:15:31 PM
  From Machine: DESKTOP-742U247
  Filename: ProductCategoryDocumentation.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryDocumentationService")]
    public partial interface ICrudeProductCategoryDocumentationService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId);
        
        // fetch all rows matching foreign key: ProductCategoryId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByUserIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/DeleteResponse")]
        void Delete(System.Guid productCategoryDocumentationId);
        
        // fetch all rows from table product_category_documentation into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitAnd" +
            "Offset", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitAnd" +
            "OffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllCountRespons" +
            "e")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchWithFilterRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryDocumentationServiceChannel : ICrudeProductCategoryDocumentationService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductCategoryDocumentationServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryDocumentationService>, ICrudeProductCategoryDocumentationService {
        
        public CrudeProductCategoryDocumentationServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductCategoryDocumentationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryDocumentationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            return base.Channel.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
        }
        
        // fetch all rows matching foreign key: ProductCategoryId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductCategoryDocumentationTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return base.Channel.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productCategoryDocumentationId) {
            base.Channel.Delete(productCategoryDocumentationId);
        }
        
        // fetch all rows from table product_category_documentation into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryDocumentationId: productCategoryDocumentationId,
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryId: productCategoryId,
                documentation: documentation,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
