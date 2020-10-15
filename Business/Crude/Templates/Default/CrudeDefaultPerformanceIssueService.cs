/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 12:15:14 PM
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
    public partial interface ICrudeDefaultPerformanceIssueService {
        
        [OperationContract()]
        CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultPerformanceIssueContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultPerformanceIssueContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultPerformanceIssueId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_performance_issue's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultPerformanceIssueService : ICrudeDefaultPerformanceIssueService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultPerformanceIssueId: primary key of table default_performance_issue
        public CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            var dataAccessLayer = new CrudeDefaultPerformanceIssueData();
            var contract = new CrudeDefaultPerformanceIssueContract();

            dataAccessLayer.FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceIssueData();
            var contract = new CrudeDefaultPerformanceIssueContract();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultPerformanceIssueData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultPerformanceIssueContract> DataListToContractList(List<CrudeDefaultPerformanceIssueData> dataList) {
            var contractList = new List<CrudeDefaultPerformanceIssueContract>();

            foreach (CrudeDefaultPerformanceIssueData data in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultPerformanceIssueContract> contractList, List<CrudeDefaultPerformanceIssueData> dataList) {
            foreach (CrudeDefaultPerformanceIssueContract contract in contractList) {
                var data = new CrudeDefaultPerformanceIssueData();
                CrudeDefaultPerformanceIssueService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultPerformanceIssueData to a List of SOAP Contracts
        public List<CrudeDefaultPerformanceIssueContract> FetchAll() {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAll();

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssue in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(crudeDefaultPerformanceIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssue in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(crudeDefaultPerformanceIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssue in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(crudeDefaultPerformanceIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultPerformanceIssueData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchWithFilter(
                defaultPerformanceIssueId: defaultPerformanceIssueId,
                commandName: commandName,
                commandText: commandText,
                milliseconds: milliseconds,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultPerformanceIssueData data in dataList) {
                var crudeDefaultPerformanceIssueContract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(data, crudeDefaultPerformanceIssueContract);
                list.Add(crudeDefaultPerformanceIssueContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultPerformanceIssueContract contract) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultPerformanceIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultPerformanceIssueContract contract) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultPerformanceIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultPerformanceIssueId) {
            CrudeDefaultPerformanceIssueData.Delete(defaultPerformanceIssueId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultPerformanceIssueContract contract, CrudeDefaultPerformanceIssueData data) {
            data.DefaultPerformanceIssueId = contract.DefaultPerformanceIssueId;
            data.CommandName = contract.CommandName;
            data.CommandText = contract.CommandText;
            data.Milliseconds = contract.Milliseconds;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultPerformanceIssueData data, CrudeDefaultPerformanceIssueContract contract) {
            contract.DefaultPerformanceIssueId = data.DefaultPerformanceIssueId;
            contract.CommandName = data.CommandName;
            contract.CommandText = data.CommandText;
            contract.Milliseconds = data.Milliseconds;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
