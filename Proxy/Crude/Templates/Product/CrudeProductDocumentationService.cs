/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 2:55:48 PM
  From Machine: DESKTOP-742U247
  Filename: ProductDocumentation.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductDocumentationService")]
    public partial interface ICrudeProductDocumentationService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationI" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId);
        
        // fetch all rows matching foreign key: ProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductId(System.Guid productId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationT" +
            "ypeRcd", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationT" +
            "ypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Insert", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Update", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Delete", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/DeleteResponse")]
        void Delete(System.Guid productDocumentationId);
        
        // fetch all rows from table product_documentation into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductDocumentationServiceChannel : ICrudeProductDocumentationService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductDocumentationServiceClient : System.ServiceModel.ClientBase<ICrudeProductDocumentationService>, ICrudeProductDocumentationService {
        
        public CrudeProductDocumentationServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductDocumentationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductDocumentationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId) {
            return base.Channel.FetchByProductDocumentationId(productDocumentationId);
        }
        
        // fetch all rows matching foreign key: ProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductDocumentationTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return base.Channel.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productDocumentationId) {
            base.Channel.Delete(productDocumentationId);
        }
        
        // fetch all rows from table product_documentation into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productDocumentationId: productDocumentationId,
                productId: productId,
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                documentation: documentation,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
