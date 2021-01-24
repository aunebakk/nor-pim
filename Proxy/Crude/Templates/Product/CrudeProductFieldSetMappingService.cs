/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:26:06 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductFieldSetMapping.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: DotNetFrameworkCrudeProxy
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
//  docLink: http://sql2x.org/documentationLink/a58883c6-e6e2-4265-98ad-0268dbbdb1b1
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/8638d459-df50-43f0-9fb3-f120e7937ccb
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductFieldSetMappingService")]
    public partial interface ICrudeProductFieldSetMappingService {
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/70a1f934-1d8a-43a0-8896-3ec370944938
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetMapp" +
            "ingId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetMapp" +
            "ingIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId);
        
        // fetch all rows matching foreign key: ProductFieldSetId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductIdentifierRc" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductIdentifierRc" +
            "dResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductAttributeRcd" +
            "", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductAttributeRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductInfoRcd", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductInfoRcdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductImageTypeRcd" +
            "", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductImageTypeRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductDocumentatio" +
            "nTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductDocumentatio" +
            "nTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/54a1998f-1667-4680-ae80-cb0c31dd5872
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Insert", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract);
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/c1ccee6d-504c-4fe8-bf7c-57624012598a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Update", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract);
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d2e5c69-6801-43a2-9daf-0ff04fa6c996
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Delete", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/DeleteResponse")]
        void Delete(System.Guid productFieldSetMappingId);
        
        // fetch all rows from table product_field_set_mapping into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/4ac8b1d2-0562-43e9-b63f-8973ca381a0a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/7e45d3c9-f66e-4ad7-8620-df8a4eae6177
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/886cf296-7b9c-4a1a-8b40-8150e605ba11
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/dd08755c-f264-4c12-8d69-18c190b13a6e
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/754c25f9-c499-45f3-9fdb-03850db5c79d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/ccc2e33d-a5a7-4751-a433-07dd3f2b90a4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductFieldSetMappingServiceChannel : ICrudeProductFieldSetMappingService, System.ServiceModel.IClientChannel {
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/2ec85c1f-4aad-46ef-a4d4-179312974bf1
    public class CrudeProductFieldSetMappingServiceClient : System.ServiceModel.ClientBase<ICrudeProductFieldSetMappingService>, ICrudeProductFieldSetMappingService {
        
        public CrudeProductFieldSetMappingServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9b6c163a-8411-40ba-bb08-e390673c9ab3
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/0bf226bb-0d8e-4930-90b9-d0e53a1f9c2a
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            return base.Channel.FetchByProductFieldSetMappingId(productFieldSetMappingId);
        }
        
        // fetch all rows matching foreign key: ProductFieldSetId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return base.Channel.FetchByProductFieldSetId(productFieldSetId);
        }
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductIdentifierRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return base.Channel.FetchByProductIdentifierRcd(productIdentifierRcd);
        }
        
        // fetch all rows matching foreign key: ProductAttributeRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd) {
            return base.Channel.FetchByProductAttributeRcd(productAttributeRcd);
        }
        
        // fetch all rows matching foreign key: ProductInfoRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd) {
            return base.Channel.FetchByProductInfoRcd(productInfoRcd);
        }
        
        // fetch all rows matching foreign key: ProductImageTypeRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return base.Channel.FetchByProductImageTypeRcd(productImageTypeRcd);
        }
        
        // fetch all rows matching foreign key: ProductDocumentationTypeRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return base.Channel.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/606647e9-2bdb-4b55-9541-449812c123d2
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/cda8cbb1-dc3e-461a-8c98-5c277efe7e86
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/8513f38a-4552-4020-95b2-78c872a82ffe
        public void Delete(System.Guid productFieldSetMappingId) {
            base.Channel.Delete(productFieldSetMappingId);
        }
        
        // fetch all rows from table product_field_set_mapping into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/168c348a-8e3d-463e-8e60-727047f10afc
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/05a908ff-897b-49a5-a5e4-fd57e1ddca0d
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9ac77a1-e367-4bbd-89ed-c65f56d14f3c
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b5f68e2-e3e0-4f82-8f99-f3ce860dc8fe
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/c10bac90-d91e-47a6-bd52-f537c96471cd
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
