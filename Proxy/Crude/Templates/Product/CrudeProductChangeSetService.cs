/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 2:55:48 PM
  From Machine: DESKTOP-742U247
  Filename: ProductChangeSet.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductChangeSetService")]
    public partial interface ICrudeProductChangeSetService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductChangeSetId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductChangeSetIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId);
        
        // fetch all rows matching foreign key: ProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductId(System.Guid productId);
        
        // fetch all rows matching foreign key: ProductGatherKeyId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductGatherKeyIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/DeleteResponse")]
        void Delete(System.Guid productChangeSetId);
        
        // fetch all rows from table product_change_set into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductChangeSetServiceChannel : ICrudeProductChangeSetService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductChangeSetServiceClient : System.ServiceModel.ClientBase<ICrudeProductChangeSetService>, ICrudeProductChangeSetService {
        
        public CrudeProductChangeSetServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductChangeSetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductChangeSetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductChangeSetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductChangeSetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId) {
            return base.Channel.FetchByProductChangeSetId(productChangeSetId);
        }
        
        // fetch all rows matching foreign key: ProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        // fetch all rows matching foreign key: ProductGatherKeyId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productChangeSetId) {
            base.Channel.Delete(productChangeSetId);
        }
        
        // fetch all rows from table product_change_set into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productChangeSetId: productChangeSetId,
                productId: productId,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
