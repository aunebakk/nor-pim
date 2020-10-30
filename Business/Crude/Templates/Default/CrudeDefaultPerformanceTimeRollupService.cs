/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 9:51:12 PM
  From Machine: DESKTOP-9A2DH39
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
    public partial interface ICrudeDefaultPerformanceTimeRollupService {
        
        [OperationContract()]
        CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultPerformanceTimeRollupContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultPerformanceTimeRollupContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultPerformanceTimeRollupId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_performance_time_rollup's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultPerformanceTimeRollupService : ICrudeDefaultPerformanceTimeRollupService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultPerformanceTimeRollupId: primary key of table default_performance_time_rollup
        public CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeRollupData();
            var contract = new CrudeDefaultPerformanceTimeRollupContract();

            dataAccessLayer.FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeRollupData();
            var contract = new CrudeDefaultPerformanceTimeRollupContract();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultPerformanceTimeRollupData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultPerformanceTimeRollupContract> DataListToContractList(List<CrudeDefaultPerformanceTimeRollupData> dataList) {
            var contractList = new List<CrudeDefaultPerformanceTimeRollupContract>();

            foreach (CrudeDefaultPerformanceTimeRollupData data in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultPerformanceTimeRollupContract> contractList, List<CrudeDefaultPerformanceTimeRollupData> dataList) {
            foreach (CrudeDefaultPerformanceTimeRollupContract contract in contractList) {
                var data = new CrudeDefaultPerformanceTimeRollupData();
                CrudeDefaultPerformanceTimeRollupService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultPerformanceTimeRollupData to a List of SOAP Contracts
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchAll() {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAll();

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollup in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(crudeDefaultPerformanceTimeRollup, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollup in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(crudeDefaultPerformanceTimeRollup, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollup in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(crudeDefaultPerformanceTimeRollup, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultPerformanceTimeRollupData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchWithFilter(
                defaultPerformanceTimeRollupId: defaultPerformanceTimeRollupId,
                commandName: commandName,
                milliseconds: milliseconds,
                hits: hits,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultPerformanceTimeRollupData data in dataList) {
                var crudeDefaultPerformanceTimeRollupContract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(data, crudeDefaultPerformanceTimeRollupContract);
                list.Add(crudeDefaultPerformanceTimeRollupContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultPerformanceTimeRollupContract contract) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultPerformanceTimeRollupContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultPerformanceTimeRollupContract contract) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultPerformanceTimeRollupContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultPerformanceTimeRollupId) {
            CrudeDefaultPerformanceTimeRollupData.Delete(defaultPerformanceTimeRollupId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultPerformanceTimeRollupContract contract, CrudeDefaultPerformanceTimeRollupData data) {
            data.DefaultPerformanceTimeRollupId = contract.DefaultPerformanceTimeRollupId;
            data.CommandName = contract.CommandName;
            data.Milliseconds = contract.Milliseconds;
            data.Hits = contract.Hits;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultPerformanceTimeRollupData data, CrudeDefaultPerformanceTimeRollupContract contract) {
            contract.DefaultPerformanceTimeRollupId = data.DefaultPerformanceTimeRollupId;
            contract.CommandName = data.CommandName;
            contract.Milliseconds = data.Milliseconds;
            contract.Hits = data.Hits;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
