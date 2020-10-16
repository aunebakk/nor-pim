/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 8:59:45 AM
  From Machine: DESKTOP-742U247
  Filename: ProductGatherAttributeTypeRef.json
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
    public partial class ProductGatherAttributeTypeRef {
        
        public const string Color = "color";
        
        public const string Name = "name";
    }
    
    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherAttributeTypeRefService")]
    public partial interface ICrudeProductGatherAttributeTypeRefService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByUserIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/DeleteResponse")]
        void Delete(string productGatherAttributeTypeRcd);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeName", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName);
        
        // fetch all rows from table product_gather_attribute_type_ref into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitAn" +
            "dOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitAn" +
            "dOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllCountRespon" +
            "se")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchWithFilterResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherAttributeTypeRefServiceChannel : ICrudeProductGatherAttributeTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductGatherAttributeTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherAttributeTypeRefService>, ICrudeProductGatherAttributeTypeRefService {
        
        public CrudeProductGatherAttributeTypeRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductGatherAttributeTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherAttributeTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return base.Channel.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productGatherAttributeTypeRcd) {
            base.Channel.Delete(productGatherAttributeTypeRcd);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName) {
            return base.Channel.FetchByProductGatherAttributeTypeName(productGatherAttributeTypeName);
        }
        
        // fetch all rows from table product_gather_attribute_type_ref into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherAttributeTypeName: productGatherAttributeTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
