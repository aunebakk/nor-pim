/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:47:52 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductAttributeRef.json
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
    public partial class ProductAttributeRef {
        
        public const string Color = "Color";
        
        public const string Height = "H";
        
        public const string Length = "L";
        
        public const string Model = "MOD";
        
        public const string MaxTakeOffWeight = "MTOW";
        
        public const string PriceUnit = "PU";
        
        public const string RangeInKilometer = "RKM";
        
        public const string AverageSeats = "SEAT";
        
        public const string SupplierNumber = "SUP";
        
        public const string SuppliedId = "SUPID";
        
        public const string Width = "W";
        
        public const string Weight = "WE";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeRefService")]
    public partial interface ICrudeProductAttributeRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeRcdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/DeleteResponse")]
        void Delete(string productAttributeRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeName", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName);
        
        // fetch all rows from table product_attribute_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductAttributeRefServiceChannel : ICrudeProductAttributeRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductAttributeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductAttributeRefService>, ICrudeProductAttributeRefService {
        
        public CrudeProductAttributeRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductAttributeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd) {
            return base.Channel.FetchByProductAttributeRcd(productAttributeRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productAttributeRcd) {
            base.Channel.Delete(productAttributeRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName) {
            return base.Channel.FetchByProductAttributeName(productAttributeName);
        }
        
        // fetch all rows from table product_attribute_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productAttributeRcd: productAttributeRcd,
                productAttributeName: productAttributeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
