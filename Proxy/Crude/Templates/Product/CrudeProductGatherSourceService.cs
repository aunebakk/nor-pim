/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 10:09:14 PM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductGatherSource.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherSourceService")]
    public partial interface ICrudeProductGatherSourceService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceIdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId);
        
        // fetch all rows matching foreign key: ProductGatherId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherIdRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceTyp" +
            "eRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceTyp" +
            "eRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/DeleteResponse")]
        void Delete(System.Guid productGatherSourceId);
        
        // fetch all rows from table product_gather_source into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductGatherSourceServiceChannel : ICrudeProductGatherSourceService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductGatherSourceServiceClient : System.ServiceModel.ClientBase<ICrudeProductGatherSourceService>, ICrudeProductGatherSourceService {
        
        public CrudeProductGatherSourceServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductGatherSourceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherSourceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            return base.Channel.FetchByProductGatherSourceId(productGatherSourceId);
        }
        
        // fetch all rows matching foreign key: ProductGatherId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId) {
            return base.Channel.FetchByProductGatherId(productGatherId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductGatherSourceTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            return base.Channel.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productGatherSourceId) {
            base.Channel.Delete(productGatherSourceId);
        }
        
        // fetch all rows from table product_gather_source into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productGatherSourceId: productGatherSourceId,
                productGatherId: productGatherId,
                productGatherSourceTypeRcd: productGatherSourceTypeRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
