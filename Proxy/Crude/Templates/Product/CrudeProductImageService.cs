/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:03:34 PM
  From Machine: DESKTOP-517I8BU
  Filename: ProductImage.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductImageService")]
    public partial interface ICrudeProductImageService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductImageId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductImageIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByProductImageId(System.Guid productImageId);
        
        // fetch all rows matching foreign key: ProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductId(System.Guid productId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductImageTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductImageTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Insert", ReplyAction="http://tempuri.org/ICrudeProductImageService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Update", ReplyAction="http://tempuri.org/ICrudeProductImageService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Delete", ReplyAction="http://tempuri.org/ICrudeProductImageService/DeleteResponse")]
        void Delete(System.Guid productImageId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByImageFileName", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByImageFileNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByImageFileName(string imageFileName);
        
        // fetch all rows from table product_image into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductImageServiceChannel : ICrudeProductImageService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductImageServiceClient : System.ServiceModel.ClientBase<ICrudeProductImageService>, ICrudeProductImageService {
        
        public CrudeProductImageServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByProductImageId(System.Guid productImageId) {
            return base.Channel.FetchByProductImageId(productImageId);
        }
        
        // fetch all rows matching foreign key: ProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductImageTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return base.Channel.FetchByProductImageTypeRcd(productImageTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productImageId) {
            base.Channel.Delete(productImageId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByImageFileName(string imageFileName) {
            return base.Channel.FetchByImageFileName(imageFileName);
        }
        
        // fetch all rows from table product_image into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productImageId: productImageId,
                productId: productId,
                productImageTypeRcd: productImageTypeRcd,
                imageFileName: imageFileName,
                image: image,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
