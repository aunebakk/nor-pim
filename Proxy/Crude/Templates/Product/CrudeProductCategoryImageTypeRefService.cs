/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/12/2020 5:03:30 AM
  From Machine: DESKTOP-LSRVP12
  Filename: ProductCategoryImageTypeRef.json
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
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
//   https://www.c-sharpcorner.com/UploadFile/8a67c0/proxy-class-for-the-wcf-service/: client Proxy
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class is used to expose reference codes from the database
    // links:
    //   https://norsolutionsql2xcore.azurewebsites.net/sql2xIndex#documentation: sql2x.org
    public partial class ProductCategoryImageTypeRef {
        
        public const string LargeSize = "LS";
        
        public const string SmallSize = "SS";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryImageTypeRefService")]
    public partial interface ICrudeProductCategoryImageTypeRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/DeleteResponse")]
        void Delete(string productCategoryImageTypeRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeName", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName);
        
        // fetch all rows from table product_category_image_type_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchWithFilterRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryImageTypeRefServiceChannel : ICrudeProductCategoryImageTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductCategoryImageTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryImageTypeRefService>, ICrudeProductCategoryImageTypeRefService {
        
        public CrudeProductCategoryImageTypeRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductCategoryImageTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryImageTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return base.Channel.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productCategoryImageTypeRcd) {
            base.Channel.Delete(productCategoryImageTypeRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName) {
            return base.Channel.FetchByProductCategoryImageTypeName(productCategoryImageTypeName);
        }
        
        // fetch all rows from table product_category_image_type_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                productCategoryImageTypeName: productCategoryImageTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
