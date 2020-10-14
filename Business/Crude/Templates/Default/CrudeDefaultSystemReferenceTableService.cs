/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 5:48:05 PM
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
    public partial interface ICrudeDefaultSystemReferenceTableService {
        
        [OperationContract()]
        CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultSystemReferenceTableId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_system_reference_table's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultSystemReferenceTableService : ICrudeDefaultSystemReferenceTableService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultSystemReferenceTableId: primary key of table default_system_reference_table
        public CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var contract = new CrudeDefaultSystemReferenceTableContract();

            dataAccessLayer.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var contract = new CrudeDefaultSystemReferenceTableContract();

            dataAccessLayer.FetchByDefaultSystemReferenceTableName(defaultSystemReferenceTableName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultSystemReferenceTableData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultSystemReferenceTableContract> DataListToContractList(List<CrudeDefaultSystemReferenceTableData> dataList) {
            var contractList = new List<CrudeDefaultSystemReferenceTableContract>();

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultSystemReferenceTableContract> contractList, List<CrudeDefaultSystemReferenceTableData> dataList) {
            foreach (CrudeDefaultSystemReferenceTableContract contract in contractList) {
                var data = new CrudeDefaultSystemReferenceTableData();
                CrudeDefaultSystemReferenceTableService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultSystemReferenceTableData to a List of SOAP Contracts
        public List<CrudeDefaultSystemReferenceTableContract> FetchAll() {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAll();

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultSystemReferenceTableData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchWithFilter(
                defaultSystemReferenceTableId: defaultSystemReferenceTableId,
                defaultSystemReferenceTableName: defaultSystemReferenceTableName,
                defaultSystemReferenceDisplayName: defaultSystemReferenceDisplayName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var crudeDefaultSystemReferenceTableContract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(data, crudeDefaultSystemReferenceTableContract);
                list.Add(crudeDefaultSystemReferenceTableContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultSystemReferenceTableContract contract) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultSystemReferenceTableContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultSystemReferenceTableContract contract) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultSystemReferenceTableContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultSystemReferenceTableId) {
            CrudeDefaultSystemReferenceTableData.Delete(defaultSystemReferenceTableId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultSystemReferenceTableContract contract, CrudeDefaultSystemReferenceTableData data) {
            data.DefaultSystemReferenceTableId = contract.DefaultSystemReferenceTableId;
            data.DefaultSystemReferenceTableName = contract.DefaultSystemReferenceTableName;
            data.DefaultSystemReferenceDisplayName = contract.DefaultSystemReferenceDisplayName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultSystemReferenceTableData data, CrudeDefaultSystemReferenceTableContract contract) {
            contract.DefaultSystemReferenceTableId = data.DefaultSystemReferenceTableId;
            contract.DefaultSystemReferenceTableName = data.DefaultSystemReferenceTableName;
            contract.DefaultSystemReferenceDisplayName = data.DefaultSystemReferenceDisplayName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
