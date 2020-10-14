/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 8:33:07 PM
  From Machine: DESKTOP-742U247
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
    public partial interface ICrudeCartProductPriceService {
        
        [OperationContract()]
        CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAll();
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeCartProductPriceContract contract);
        
        [OperationContract()]
        void Update(CrudeCartProductPriceContract contract);
        
        [OperationContract()]
        void Delete(System.Guid cartProductPriceId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of cart_product_price's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeCartProductPriceService : ICrudeCartProductPriceService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   cartProductPriceId: primary key of table cart_product_price
        public CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId) {
            var dataAccessLayer = new CrudeCartProductPriceData();
            var contract = new CrudeCartProductPriceContract();

            dataAccessLayer.FetchByCartProductPriceId(cartProductPriceId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByStateRcd(stateRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeCartProductPriceContract> DataListToContractList(List<CrudeCartProductPriceData> dataList) {
            var contractList = new List<CrudeCartProductPriceContract>();

            foreach (CrudeCartProductPriceData data in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeCartProductPriceContract> contractList, List<CrudeCartProductPriceData> dataList) {
            foreach (CrudeCartProductPriceContract contract in contractList) {
                var data = new CrudeCartProductPriceData();
                CrudeCartProductPriceService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeCartProductPriceData to a List of SOAP Contracts
        public List<CrudeCartProductPriceContract> FetchAll() {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAll();

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeCartProductPriceContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimit(limit);

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeCartProductPriceData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchWithFilter(
                cartProductPriceId: cartProductPriceId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime,
                productId: productId
                );

            foreach (CrudeCartProductPriceData data in dataList) {
                var crudeCartProductPriceContract = new CrudeCartProductPriceContract();
                DataToContract(data, crudeCartProductPriceContract);
                list.Add(crudeCartProductPriceContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeCartProductPriceContract contract) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeCartProductPriceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeCartProductPriceContract contract) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeCartProductPriceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid cartProductPriceId) {
            CrudeCartProductPriceData.Delete(cartProductPriceId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeCartProductPriceContract contract, CrudeCartProductPriceData data) {
            data.CartProductPriceId = contract.CartProductPriceId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ProductId = contract.ProductId;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeCartProductPriceData data, CrudeCartProductPriceContract contract) {
            contract.CartProductPriceId = data.CartProductPriceId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ProductId = data.ProductId;
        }
    }
}
