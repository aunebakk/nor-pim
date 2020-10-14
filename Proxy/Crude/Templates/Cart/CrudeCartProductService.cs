/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 8:33:28 PM
  From Machine: DESKTOP-742U247
  Filename: CartProduct.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeCartProductService")]
    public partial interface ICrudeCartProductService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByCartProductId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByCartProductIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId);
        
        // fetch all rows matching foreign key: ClientId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByClientId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByClientIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByClientId(System.Guid clientId);
        
        // fetch all rows matching foreign key: ProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByProductId(System.Guid productId);
        
        // fetch all rows matching foreign key: FinancialCurrencyId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByFinancialCurrencyIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        // fetch all rows matching foreign key: SessionId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchBySessionId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchBySessionIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchBySessionId(System.Guid sessionId);
        
        // fetch all rows matching foreign key: AspId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByAspId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByAspIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByAspId(System.Guid aspId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchByStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByStateRcd(string stateRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/Insert", ReplyAction="http://tempuri.org/ICrudeCartProductService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/Update", ReplyAction="http://tempuri.org/ICrudeCartProductService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/Delete", ReplyAction="http://tempuri.org/ICrudeCartProductService/DeleteResponse")]
        void Delete(System.Guid cartProductId);
        
        // fetch all rows from table cart_product into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAll", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeCartProductService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, System.Guid sessionId, string sessionIdentificator, System.Guid aspId, string stateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeCartProductServiceChannel : ICrudeCartProductService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeCartProductServiceClient : System.ServiceModel.ClientBase<ICrudeCartProductService>, ICrudeCartProductService {
        
        public CrudeCartProductServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeCartProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeCartProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId) {
            return base.Channel.FetchByCartProductId(cartProductId);
        }
        
        // fetch all rows matching foreign key: ClientId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByClientId(System.Guid clientId) {
            return base.Channel.FetchByClientId(clientId);
        }
        
        // fetch all rows matching foreign key: ProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        // fetch all rows matching foreign key: FinancialCurrencyId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        // fetch all rows matching foreign key: SessionId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchBySessionId(System.Guid sessionId) {
            return base.Channel.FetchBySessionId(sessionId);
        }
        
        // fetch all rows matching foreign key: AspId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByAspId(System.Guid aspId) {
            return base.Channel.FetchByAspId(aspId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: StateRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid cartProductId) {
            base.Channel.Delete(cartProductId);
        }
        
        // fetch all rows from table cart_product into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, System.Guid sessionId, string sessionIdentificator, System.Guid aspId, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                cartProductId: cartProductId,
                clientId: clientId,
                productId: productId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                sessionId: sessionId,
                sessionIdentificator: sessionIdentificator,
                aspId: aspId,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
