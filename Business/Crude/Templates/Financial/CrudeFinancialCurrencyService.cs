/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 1:35:12 PM
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
    public partial interface ICrudeFinancialCurrencyService {
        
        [OperationContract()]
        CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd);
        
        [OperationContract()]
        CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCurrencyContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCurrencyContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialCurrencyId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of financial_currency's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeFinancialCurrencyService : ICrudeFinancialCurrencyService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   financialCurrencyId: primary key of table financial_currency
        public CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataAccessLayer = new CrudeFinancialCurrencyData();
            var contract = new CrudeFinancialCurrencyContract();

            dataAccessLayer.FetchByFinancialCurrencyId(financialCurrencyId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            var dataAccessLayer = new CrudeFinancialCurrencyData();
            var contract = new CrudeFinancialCurrencyContract();

            dataAccessLayer.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCurrencyData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            return DataListToContractList(CrudeFinancialCurrencyData.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            return DataListToContractList(CrudeFinancialCurrencyData.FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(financialCurrencyAgainstFinancialCurrencyTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeFinancialCurrencyContract> DataListToContractList(List<CrudeFinancialCurrencyData> dataList) {
            var contractList = new List<CrudeFinancialCurrencyContract>();

            foreach (CrudeFinancialCurrencyData data in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeFinancialCurrencyContract> contractList, List<CrudeFinancialCurrencyData> dataList) {
            foreach (CrudeFinancialCurrencyContract contract in contractList) {
                var data = new CrudeFinancialCurrencyData();
                CrudeFinancialCurrencyService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeFinancialCurrencyData to a List of SOAP Contracts
        public List<CrudeFinancialCurrencyContract> FetchAll() {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAll();

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrency in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(crudeFinancialCurrency, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrency in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(crudeFinancialCurrency, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrency in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(crudeFinancialCurrency, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeFinancialCurrencyData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeFinancialCurrencyContract> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName) {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchWithFilter(
                financialCurrencyId: financialCurrencyId,
                financialCurrencyTypeRcd: financialCurrencyTypeRcd,
                financialCurrencyAgainstFinancialCurrencyTypeRcd: financialCurrencyAgainstFinancialCurrencyTypeRcd,
                userId: userId,
                dateTime: dateTime,
                validFromDateTime: validFromDateTime,
                validUntilDateTime: validUntilDateTime,
                amount: amount,
                equalsAmount: equalsAmount,
                decimalCount: decimalCount,
                financialCurrencyTypeCode: financialCurrencyTypeCode,
                financialCurrencyTypeName: financialCurrencyTypeName
                );

            foreach (CrudeFinancialCurrencyData data in dataList) {
                var crudeFinancialCurrencyContract = new CrudeFinancialCurrencyContract();
                DataToContract(data, crudeFinancialCurrencyContract);
                list.Add(crudeFinancialCurrencyContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeFinancialCurrencyContract contract) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeFinancialCurrencyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeFinancialCurrencyContract contract) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeFinancialCurrencyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid financialCurrencyId) {
            CrudeFinancialCurrencyData.Delete(financialCurrencyId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeFinancialCurrencyContract contract, CrudeFinancialCurrencyData data) {
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.FinancialCurrencyTypeRcd = contract.FinancialCurrencyTypeRcd;
            data.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ValidFromDateTime = contract.ValidFromDateTime;
            data.ValidUntilDateTime = contract.ValidUntilDateTime;
            data.Amount = contract.Amount;
            data.EqualsAmount = contract.EqualsAmount;
            data.DecimalCount = contract.DecimalCount;
            data.FinancialCurrencyTypeCode = contract.FinancialCurrencyTypeCode;
            data.FinancialCurrencyTypeName = contract.FinancialCurrencyTypeName;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeFinancialCurrencyData data, CrudeFinancialCurrencyContract contract) {
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.FinancialCurrencyTypeRcd = data.FinancialCurrencyTypeRcd;
            contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = data.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ValidFromDateTime = data.ValidFromDateTime;
            contract.ValidUntilDateTime = data.ValidUntilDateTime;
            contract.Amount = data.Amount;
            contract.EqualsAmount = data.EqualsAmount;
            contract.DecimalCount = data.DecimalCount;
            contract.FinancialCurrencyTypeCode = data.FinancialCurrencyTypeCode;
            contract.FinancialCurrencyTypeName = data.FinancialCurrencyTypeName;
        }
    }
}
