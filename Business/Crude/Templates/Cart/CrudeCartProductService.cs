/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:05 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPim.DataAccessLayer;

// Business Logic Layer
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface is used to expose C# objects as SOAP services using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [ServiceContract()]
    public partial interface ICrudeCartProductService {
        
        [OperationContract()]
        CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchBySessionId(System.Guid sessionId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByAspId(System.Guid aspId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, System.Guid sessionId, string sessionIdentificator, System.Guid aspId, string stateRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchAll();
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeCartProductContract contract);
        
        [OperationContract()]
        void Update(CrudeCartProductContract contract);
        
        [OperationContract()]
        void Delete(System.Guid cartProductId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of cart_product's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeCartProductService : ICrudeCartProductService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   cartProductId: primary key of table cart_product
        public CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId) {
            var dataAccessLayer = new CrudeCartProductData();
            var contract = new CrudeCartProductContract();

            dataAccessLayer.FetchByCartProductId(cartProductId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeCartProductData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeCartProductData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeCartProductData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductContract> FetchBySessionId(System.Guid sessionId) {
            return DataListToContractList(CrudeCartProductData.FetchBySessionId(sessionId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductContract> FetchByAspId(System.Guid aspId) {
            return DataListToContractList(CrudeCartProductData.FetchByAspId(aspId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeCartProductData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeCartProductData.FetchByStateRcd(stateRcd));
        }
        
        public static List<CrudeCartProductContract> DataListToContractList(List<CrudeCartProductData> dataList) {
            var contractList = new List<CrudeCartProductContract>();

            foreach (CrudeCartProductData data in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeCartProductContract> contractList, List<CrudeCartProductData> dataList) {
            foreach (CrudeCartProductContract contract in contractList) {
                var data = new CrudeCartProductData();
                CrudeCartProductService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeCartProductContract> FetchAll() {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAll();

            foreach (CrudeCartProductData crudeCartProduct in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(crudeCartProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAllWithLimit(limit);

            foreach (CrudeCartProductData crudeCartProduct in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(crudeCartProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeCartProductData crudeCartProduct in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(crudeCartProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeCartProductData.FetchAllCount();
        }
        
        public List<CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, System.Guid sessionId, string sessionIdentificator, System.Guid aspId, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchWithFilter(
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

            foreach (CrudeCartProductData data in dataList) {
                var crudeCartProductContract = new CrudeCartProductContract();
                DataToContract(data, crudeCartProductContract);
                list.Add(crudeCartProductContract);
            }

            return list;
        }
        
        public void Insert(CrudeCartProductContract contract) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeCartProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeCartProductContract contract) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeCartProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid cartProductId) {
            CrudeCartProductData.Delete(cartProductId);
        }
        
        public static void ContractToData(CrudeCartProductContract contract, CrudeCartProductData data) {
            data.CartProductId = contract.CartProductId;
            data.ClientId = contract.ClientId;
            data.ProductId = contract.ProductId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
            data.SessionId = contract.SessionId;
            data.SessionIdentificator = contract.SessionIdentificator;
            data.AspId = contract.AspId;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeCartProductData data, CrudeCartProductContract contract) {
            contract.CartProductId = data.CartProductId;
            contract.ClientId = data.ClientId;
            contract.ProductId = data.ProductId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
            contract.SessionId = data.SessionId;
            contract.SessionIdentificator = data.SessionIdentificator;
            contract.AspId = data.AspId;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
