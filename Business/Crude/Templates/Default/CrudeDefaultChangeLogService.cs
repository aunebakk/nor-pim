/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:44:49 PM
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
    public partial interface ICrudeDefaultChangeLogService {
        
        [OperationContract()]
        CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);
        
        [OperationContract()]
        CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultChangeLogContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultChangeLogContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultChangeLogId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_change_log's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultChangeLogService : ICrudeDefaultChangeLogService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultChangeLogId: primary key of table default_change_log
        public CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            var dataAccessLayer = new CrudeDefaultChangeLogData();
            var contract = new CrudeDefaultChangeLogContract();

            dataAccessLayer.FetchByDefaultChangeLogId(defaultChangeLogId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName) {
            var dataAccessLayer = new CrudeDefaultChangeLogData();
            var contract = new CrudeDefaultChangeLogContract();

            dataAccessLayer.FetchByDefaultChangeName(defaultChangeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultChangeLogData.FetchByDefaultUserId(defaultUserId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId) {
            return DataListToContractList(CrudeDefaultChangeLogData.FetchByDefaultIssueId(defaultIssueId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            return DataListToContractList(CrudeDefaultChangeLogData.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultChangeLogContract> DataListToContractList(List<CrudeDefaultChangeLogData> dataList) {
            var contractList = new List<CrudeDefaultChangeLogContract>();

            foreach (CrudeDefaultChangeLogData data in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultChangeLogContract> contractList, List<CrudeDefaultChangeLogData> dataList) {
            foreach (CrudeDefaultChangeLogContract contract in contractList) {
                var data = new CrudeDefaultChangeLogData();
                CrudeDefaultChangeLogService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultChangeLogData to a List of SOAP Contracts
        public List<CrudeDefaultChangeLogContract> FetchAll() {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAll();

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLog in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(crudeDefaultChangeLog, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLog in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(crudeDefaultChangeLog, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLog in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(crudeDefaultChangeLog, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultChangeLogData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchWithFilter(
                defaultChangeLogId: defaultChangeLogId,
                defaultChangeName: defaultChangeName,
                defaultChangeDescription: defaultChangeDescription,
                defaultUserId: defaultUserId,
                dateTime: dateTime,
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultIssueId: defaultIssueId
                );

            foreach (CrudeDefaultChangeLogData data in dataList) {
                var crudeDefaultChangeLogContract = new CrudeDefaultChangeLogContract();
                DataToContract(data, crudeDefaultChangeLogContract);
                list.Add(crudeDefaultChangeLogContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultChangeLogContract contract) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultChangeLogContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultChangeLogContract contract) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultChangeLogContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultChangeLogId) {
            CrudeDefaultChangeLogData.Delete(defaultChangeLogId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultChangeLogContract contract, CrudeDefaultChangeLogData data) {
            data.DefaultChangeLogId = contract.DefaultChangeLogId;
            data.DefaultChangeName = contract.DefaultChangeName;
            data.DefaultChangeDescription = contract.DefaultChangeDescription;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
            data.DefaultChangeLogTypeRcd = contract.DefaultChangeLogTypeRcd;
            data.DefaultIssueId = contract.DefaultIssueId;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultChangeLogData data, CrudeDefaultChangeLogContract contract) {
            contract.DefaultChangeLogId = data.DefaultChangeLogId;
            contract.DefaultChangeName = data.DefaultChangeName;
            contract.DefaultChangeDescription = data.DefaultChangeDescription;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
            contract.DefaultChangeLogTypeRcd = data.DefaultChangeLogTypeRcd;
            contract.DefaultIssueId = data.DefaultIssueId;
        }
    }
}
