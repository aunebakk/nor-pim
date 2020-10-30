/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 7:42:00 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductExpose.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeService")]
    public partial interface ICrudeProductExposeService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId);
        
        // fetch all rows matching foreign key: ExposeProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByExposeProductId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByExposeProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId);
        
        // fetch all rows matching foreign key: ExposeBasedOnProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByExposeBasedOnProductId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByExposeBasedOnProductIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId);
        
        // fetch all rows matching foreign key: ProductExposeSetId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeSetId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeSetIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeService/DeleteResponse")]
        void Delete(System.Guid productExposeId);
        
        // fetch all rows from table product_expose into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposeServiceChannel : ICrudeProductExposeService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductExposeServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposeService>, ICrudeProductExposeService {
        
        public CrudeProductExposeServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductExposeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId) {
            return base.Channel.FetchByProductExposeId(productExposeId);
        }
        
        // fetch all rows matching foreign key: ExposeProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId) {
            return base.Channel.FetchByExposeProductId(exposeProductId);
        }
        
        // fetch all rows matching foreign key: ExposeBasedOnProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId) {
            return base.Channel.FetchByExposeBasedOnProductId(exposeBasedOnProductId);
        }
        
        // fetch all rows matching foreign key: ProductExposeSetId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return base.Channel.FetchByProductExposeSetId(productExposeSetId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productExposeId) {
            base.Channel.Delete(productExposeId);
        }
        
        // fetch all rows from table product_expose into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposeId: productExposeId,
                exposeProductId: exposeProductId,
                exposeBasedOnProductId: exposeBasedOnProductId,
                productExposeSetId: productExposeSetId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
