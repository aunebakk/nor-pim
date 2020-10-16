/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 8:59:45 AM
  From Machine: DESKTOP-742U247
  Filename: ProductFieldSetMapping.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductFieldSetMappingService")]
    public partial interface ICrudeProductFieldSetMappingService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetMapp" +
            "ingId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetMapp" +
            "ingIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId);
        
        // fetch all rows matching foreign key: ProductFieldSetId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductIdentifierRc" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductIdentifierRc" +
            "dResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductAttributeRcd" +
            "", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductAttributeRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductInfoRcd", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductInfoRcdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductImageTypeRcd" +
            "", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductImageTypeRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductDocumentatio" +
            "nTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductDocumentatio" +
            "nTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Insert", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Update", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Delete", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/DeleteResponse")]
        void Delete(System.Guid productFieldSetMappingId);
        
        // fetch all rows from table product_field_set_mapping into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductFieldSetMappingServiceChannel : ICrudeProductFieldSetMappingService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductFieldSetMappingServiceClient : System.ServiceModel.ClientBase<ICrudeProductFieldSetMappingService>, ICrudeProductFieldSetMappingService {
        
        public CrudeProductFieldSetMappingServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductFieldSetMappingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductFieldSetMappingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetMappingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetMappingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            return base.Channel.FetchByProductFieldSetMappingId(productFieldSetMappingId);
        }
        
        // fetch all rows matching foreign key: ProductFieldSetId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return base.Channel.FetchByProductFieldSetId(productFieldSetId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductIdentifierRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return base.Channel.FetchByProductIdentifierRcd(productIdentifierRcd);
        }
        
        // fetch all rows matching foreign key: ProductAttributeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd) {
            return base.Channel.FetchByProductAttributeRcd(productAttributeRcd);
        }
        
        // fetch all rows matching foreign key: ProductInfoRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd) {
            return base.Channel.FetchByProductInfoRcd(productInfoRcd);
        }
        
        // fetch all rows matching foreign key: ProductImageTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return base.Channel.FetchByProductImageTypeRcd(productImageTypeRcd);
        }
        
        // fetch all rows matching foreign key: ProductDocumentationTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return base.Channel.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productFieldSetMappingId) {
            base.Channel.Delete(productFieldSetMappingId);
        }
        
        // fetch all rows from table product_field_set_mapping into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productFieldSetMappingId: productFieldSetMappingId,
                productFieldSetId: productFieldSetId,
                productIdentifierRcd: productIdentifierRcd,
                productAttributeRcd: productAttributeRcd,
                productInfoRcd: productInfoRcd,
                productImageTypeRcd: productImageTypeRcd,
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
