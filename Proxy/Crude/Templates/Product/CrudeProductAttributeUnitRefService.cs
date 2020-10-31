/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:17:27 AM
  From Machine: DESKTOP-742U247
  Filename: ProductAttributeUnitRef.json
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
    public partial class ProductAttributeUnitRef {
        
        public const string Color = "Co";
        
        public const string Grams = "G";
        
        public const string KiloMeter = "KM";
        
        public const string Meters = "METER";
        
        public const string MilliMeters = "MM";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeUnitRefService")]
    public partial interface ICrudeProductAttributeUnitRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/DeleteResponse")]
        void Delete(string productAttributeUnitRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itName", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName);
        
        // fetch all rows from table product_attribute_unit_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductAttributeUnitRefServiceChannel : ICrudeProductAttributeUnitRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductAttributeUnitRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductAttributeUnitRefService>, ICrudeProductAttributeUnitRefService {
        
        public CrudeProductAttributeUnitRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductAttributeUnitRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeUnitRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeUnitRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeUnitRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            return base.Channel.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productAttributeUnitRcd) {
            base.Channel.Delete(productAttributeUnitRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName) {
            return base.Channel.FetchByProductAttributeUnitName(productAttributeUnitName);
        }
        
        // fetch all rows from table product_attribute_unit_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productAttributeUnitRcd: productAttributeUnitRcd,
                productAttributeUnitName: productAttributeUnitName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
