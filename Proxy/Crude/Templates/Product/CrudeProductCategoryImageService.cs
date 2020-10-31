/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:06:18 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductCategoryImage.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryImageService")]
    public partial interface ICrudeProductCategoryImageService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageI" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId);
        
        // fetch all rows matching foreign key: ProductCategoryId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryIdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageT" +
            "ypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageT" +
            "ypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/DeleteResponse")]
        void Delete(System.Guid productCategoryImageId);
        
        // fetch all rows from table product_category_image into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryImageServiceChannel : ICrudeProductCategoryImageService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductCategoryImageServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryImageService>, ICrudeProductCategoryImageService {
        
        public CrudeProductCategoryImageServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductCategoryImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            return base.Channel.FetchByProductCategoryImageId(productCategoryImageId);
        }
        
        // fetch all rows matching foreign key: ProductCategoryId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductCategoryImageTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return base.Channel.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productCategoryImageId) {
            base.Channel.Delete(productCategoryImageId);
        }
        
        // fetch all rows from table product_category_image into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryImageId: productCategoryImageId,
                productCategoryId: productCategoryId,
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                image: image,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
