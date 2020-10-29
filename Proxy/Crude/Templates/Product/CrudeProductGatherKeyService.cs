/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:57:06 PM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductGatherKey.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherKeyService")]
    public partial interface ICrudeProductGatherKeyService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherKeyIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        // fetch all rows matching foreign key: ProductGatherId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/DeleteResponse")]
        void Delete(System.Guid productGatherKeyId);
        
        // fetch all rows from table product_gather_key into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherKeyServiceChannel : ICrudeProductGatherKeyService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductGatherKeyServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherKeyService>, ICrudeProductGatherKeyService {
        
        public CrudeProductGatherKeyServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductGatherKeyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherKeyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherKeyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherKeyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        // fetch all rows matching foreign key: ProductGatherId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId) {
            return base.Channel.FetchByProductGatherId(productGatherId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productGatherKeyId) {
            base.Channel.Delete(productGatherKeyId);
        }
        
        // fetch all rows from table product_gather_key into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherKeyId: productGatherKeyId,
                productGatherKeyValue: productGatherKeyValue,
                productGatherId: productGatherId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
