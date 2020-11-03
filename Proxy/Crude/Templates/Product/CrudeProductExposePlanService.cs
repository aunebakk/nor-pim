/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:02:12 AM
  From Machine: DESKTOP-9A2DH39
  Filename: ProductExposePlan.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposePlanService")]
    public partial interface ICrudeProductExposePlanService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposePlanId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposePlanIdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId);
        
        // fetch all rows matching foreign key: ProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductId(System.Guid productId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposeSetTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposeSetTypeRcdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/DeleteResponse")]
        void Delete(System.Guid productExposePlanId);
        
        // fetch all rows from table product_expose_plan into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductExposePlanServiceChannel : ICrudeProductExposePlanService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeProductExposePlanServiceClient : System.ServiceModel.ClientBase<ICrudeProductExposePlanService>, ICrudeProductExposePlanService {
        
        public CrudeProductExposePlanServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeProductExposePlanServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposePlanServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposePlanServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposePlanServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId) {
            return base.Channel.FetchByProductExposePlanId(productExposePlanId);
        }
        
        // fetch all rows matching foreign key: ProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductExposeSetTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return base.Channel.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productExposePlanId) {
            base.Channel.Delete(productExposePlanId);
        }
        
        // fetch all rows from table product_expose_plan into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productExposePlanId: productExposePlanId,
                productId: productId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
