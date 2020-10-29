/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:05:58 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductExposeSet.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeSetService")]
    public partial interface ICrudeProductExposeSetService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/DeleteResponse")]
        void Delete(System.Guid productExposeSetId);
        
        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetName", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetNameRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName);
        
        // fetch all rows from table product_expose_set into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposeSetServiceChannel : ICrudeProductExposeSetService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductExposeSetServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposeSetService>, ICrudeProductExposeSetService {
        
        public CrudeProductExposeSetServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductExposeSetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeSetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return base.Channel.FetchByProductExposeSetId(productExposeSetId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductExposeSetTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return base.Channel.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productExposeSetId) {
            base.Channel.Delete(productExposeSetId);
        }
        
        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName) {
            return base.Channel.FetchByProductExposeSetName(productExposeSetName);
        }
        
        // fetch all rows from table product_expose_set into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposeSetId: productExposeSetId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetName: productExposeSetName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
