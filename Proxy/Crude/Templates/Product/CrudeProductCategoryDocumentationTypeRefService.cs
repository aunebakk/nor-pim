/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 9:35:13 AM
  From Machine: DESKTOP-742U247
  Filename: ProductCategoryDocumentationTypeRef.json
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
    public partial class ProductCategoryDocumentationTypeRef {
        
        public const string BottomText = "BT";
        
        public const string TopText = "TT";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryDocumentationTypeRefService")]
    public partial interface ICrudeProductCategoryDocumentationTypeRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByUserId" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByUserId" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/InsertRespons" +
            "e")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/UpdateRespons" +
            "e")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/DeleteRespons" +
            "e")]
        void Delete(string productCategoryDocumentationTypeRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeName", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName);
        
        // fetch all rows from table product_category_documentation_type_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imit", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllCount" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllCount" +
            "Response")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchWithFilt" +
            "er", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchWithFilt" +
            "erResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryDocumentationTypeRefServiceChannel : ICrudeProductCategoryDocumentationTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductCategoryDocumentationTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryDocumentationTypeRefService>, ICrudeProductCategoryDocumentationTypeRefService {
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductCategoryDocumentationTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return base.Channel.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productCategoryDocumentationTypeRcd) {
            base.Channel.Delete(productCategoryDocumentationTypeRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName) {
            return base.Channel.FetchByProductCategoryDocumentationTypeName(productCategoryDocumentationTypeName);
        }
        
        // fetch all rows from table product_category_documentation_type_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryDocumentationTypeName: productCategoryDocumentationTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
