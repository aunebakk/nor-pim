/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 5:48:20 PM
  From Machine: DESKTOP-742U247
  Filename: CartProductPrice.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeCartProductPriceService")]
    public partial interface ICrudeCartProductPriceService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByCartProductPriceId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByCartProductPriceIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId);
        
        // fetch all rows matching foreign key: FinancialCurrencyId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByFinancialCurrencyIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByUserId(System.Guid userId);
        
        // fetch all rows matching foreign key: ProductId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByProductId(System.Guid productId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchByStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/Insert", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/Update", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/Delete", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/DeleteResponse")]
        void Delete(System.Guid cartProductPriceId);
        
        // fetch all rows from table cart_product_price into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAll", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeCartProductPriceService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeCartProductPriceService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeCartProductPriceServiceChannel : ICrudeCartProductPriceService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeCartProductPriceServiceClient : System.ServiceModel.ClientBase<ICrudeCartProductPriceService>, ICrudeCartProductPriceService {
        
        public CrudeCartProductPriceServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeCartProductPriceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeCartProductPriceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductPriceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeCartProductPriceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId) {
            return base.Channel.FetchByCartProductPriceId(cartProductPriceId);
        }
        
        // fetch all rows matching foreign key: FinancialCurrencyId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: ProductId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        // fetch all rows matching foreign key: StateRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid cartProductPriceId) {
            base.Channel.Delete(cartProductPriceId);
        }
        
        // fetch all rows from table cart_product_price into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId) {
            return base.Channel.FetchWithFilter(
                cartProductPriceId: cartProductPriceId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime,
                productId: productId
                );
        }
    }
}
