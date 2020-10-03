/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/3/2020 3:48:14 PM
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
    public partial interface ICrudeDefaultTestRunResultRefService {
        
        [OperationContract()]
        CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultName(string defaultTestRunResultName);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultTestRunResultRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultTestRunResultRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultTestRunResultRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_test_run_result_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultTestRunResultRefService : ICrudeDefaultTestRunResultRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultTestRunResultRcd: primary key of table default_test_run_result_ref
        public CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            var dataAccessLayer = new CrudeDefaultTestRunResultRefData();
            var contract = new CrudeDefaultTestRunResultRefContract();

            dataAccessLayer.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultName(string defaultTestRunResultName) {
            var dataAccessLayer = new CrudeDefaultTestRunResultRefData();
            var contract = new CrudeDefaultTestRunResultRefContract();

            dataAccessLayer.FetchByDefaultTestRunResultName(defaultTestRunResultName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultTestRunResultRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeDefaultTestRunResultRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultTestRunResultRefContract> DataListToContractList(List<CrudeDefaultTestRunResultRefData> dataList) {
            var contractList = new List<CrudeDefaultTestRunResultRefContract>();

            foreach (CrudeDefaultTestRunResultRefData data in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultTestRunResultRefContract> contractList, List<CrudeDefaultTestRunResultRefData> dataList) {
            foreach (CrudeDefaultTestRunResultRefContract contract in contractList) {
                var data = new CrudeDefaultTestRunResultRefData();
                CrudeDefaultTestRunResultRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultTestRunResultRefData to a List of SOAP Contracts
        public List<CrudeDefaultTestRunResultRefContract> FetchAll() {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAll();

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRef in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(crudeDefaultTestRunResultRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRef in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(crudeDefaultTestRunResultRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRef in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(crudeDefaultTestRunResultRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultTestRunResultRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultTestRunResultRefContract> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchWithFilter(
                defaultTestRunResultRcd: defaultTestRunResultRcd,
                defaultTestRunResultName: defaultTestRunResultName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultTestRunResultRefData data in dataList) {
                var crudeDefaultTestRunResultRefContract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(data, crudeDefaultTestRunResultRefContract);
                list.Add(crudeDefaultTestRunResultRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultTestRunResultRefContract contract) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultTestRunResultRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultTestRunResultRefContract contract) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultTestRunResultRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultTestRunResultRcd) {
            CrudeDefaultTestRunResultRefData.Delete(defaultTestRunResultRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultTestRunResultRefContract contract, CrudeDefaultTestRunResultRefData data) {
            data.DefaultTestRunResultRcd = contract.DefaultTestRunResultRcd;
            data.DefaultTestRunResultName = contract.DefaultTestRunResultName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultTestRunResultRefData data, CrudeDefaultTestRunResultRefContract contract) {
            contract.DefaultTestRunResultRcd = data.DefaultTestRunResultRcd;
            contract.DefaultTestRunResultName = data.DefaultTestRunResultName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
