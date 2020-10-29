/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:48:56 PM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductGatherAttribute.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherAttributeService")]
    public partial interface ICrudeProductGatherAttributeService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId);
        
        // fetch all rows matching foreign key: ProductGatherKeyId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherKeyIdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/DeleteResponse")]
        void Delete(System.Guid productGatherAttributeId);
        
        // fetch all rows from table product_gather_attribute into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherAttributeServiceChannel : ICrudeProductGatherAttributeService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductGatherAttributeServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherAttributeService>, ICrudeProductGatherAttributeService {
        
        public CrudeProductGatherAttributeServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductGatherAttributeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherAttributeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            return base.Channel.FetchByProductGatherAttributeId(productGatherAttributeId);
        }
        
        // fetch all rows matching foreign key: ProductGatherKeyId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductGatherAttributeTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return base.Channel.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productGatherAttributeId) {
            base.Channel.Delete(productGatherAttributeId);
        }
        
        // fetch all rows from table product_gather_attribute into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherAttributeId: productGatherAttributeId,
                productGatherAttributeValue: productGatherAttributeValue,
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
