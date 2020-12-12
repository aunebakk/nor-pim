/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/12/2020 5:03:17 AM
  From Machine: DESKTOP-LSRVP12
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
    public partial interface ICrudeDefaultResourceMeasurementService {
        
        [OperationContract()]
        CrudeDefaultResourceMeasurementContract FetchByDefaultResourceMeasurementId(System.Guid defaultResourceMeasurementId);
        
        [OperationContract()]
        List<CrudeDefaultResourceMeasurementContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultResourceMeasurementContract> FetchWithFilter(System.Guid defaultResourceMeasurementId, int clientWorkingsetBytes, int businessWorkingsetBytes, int databaseSizeBytes, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultResourceMeasurementContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultResourceMeasurementContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultResourceMeasurementContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultResourceMeasurementContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultResourceMeasurementContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultResourceMeasurementId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_resource_measurement's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultResourceMeasurementService : ICrudeDefaultResourceMeasurementService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultResourceMeasurementId: primary key of table default_resource_measurement
        public CrudeDefaultResourceMeasurementContract FetchByDefaultResourceMeasurementId(System.Guid defaultResourceMeasurementId) {
            var dataAccessLayer = new CrudeDefaultResourceMeasurementData();
            var contract = new CrudeDefaultResourceMeasurementContract();

            dataAccessLayer.FetchByDefaultResourceMeasurementId(defaultResourceMeasurementId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultResourceMeasurementContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultResourceMeasurementData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultResourceMeasurementContract> DataListToContractList(List<CrudeDefaultResourceMeasurementData> dataList) {
            var contractList = new List<CrudeDefaultResourceMeasurementContract>();

            foreach (CrudeDefaultResourceMeasurementData data in dataList) {
                var contract = new CrudeDefaultResourceMeasurementContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultResourceMeasurementContract> contractList, List<CrudeDefaultResourceMeasurementData> dataList) {
            foreach (CrudeDefaultResourceMeasurementContract contract in contractList) {
                var data = new CrudeDefaultResourceMeasurementData();
                CrudeDefaultResourceMeasurementService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultResourceMeasurementData to a List of SOAP Contracts
        public List<CrudeDefaultResourceMeasurementContract> FetchAll() {
            var list = new List<CrudeDefaultResourceMeasurementContract>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchAll();

            foreach (CrudeDefaultResourceMeasurementData crudeDefaultResourceMeasurement in dataList) {
                var contract = new CrudeDefaultResourceMeasurementContract();
                DataToContract(crudeDefaultResourceMeasurement, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultResourceMeasurementContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultResourceMeasurementContract>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultResourceMeasurementData crudeDefaultResourceMeasurement in dataList) {
                var contract = new CrudeDefaultResourceMeasurementContract();
                DataToContract(crudeDefaultResourceMeasurement, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultResourceMeasurementContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultResourceMeasurementContract>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultResourceMeasurementData crudeDefaultResourceMeasurement in dataList) {
                var contract = new CrudeDefaultResourceMeasurementContract();
                DataToContract(crudeDefaultResourceMeasurement, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultResourceMeasurementData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultResourceMeasurementContract> FetchWithFilter(System.Guid defaultResourceMeasurementId, int clientWorkingsetBytes, int businessWorkingsetBytes, int databaseSizeBytes, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultResourceMeasurementContract>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchWithFilter(
                defaultResourceMeasurementId: defaultResourceMeasurementId,
                clientWorkingsetBytes: clientWorkingsetBytes,
                businessWorkingsetBytes: businessWorkingsetBytes,
                databaseSizeBytes: databaseSizeBytes,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultResourceMeasurementData data in dataList) {
                var crudeDefaultResourceMeasurementContract = new CrudeDefaultResourceMeasurementContract();
                DataToContract(data, crudeDefaultResourceMeasurementContract);
                list.Add(crudeDefaultResourceMeasurementContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultResourceMeasurementContract contract) {
            var data = new CrudeDefaultResourceMeasurementData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultResourceMeasurementContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultResourceMeasurementData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultResourceMeasurementContract contract) {
            var data = new CrudeDefaultResourceMeasurementData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultResourceMeasurementContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultResourceMeasurementData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultResourceMeasurementId) {
            CrudeDefaultResourceMeasurementData.Delete(defaultResourceMeasurementId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultResourceMeasurementContract contract, CrudeDefaultResourceMeasurementData data) {
            data.DefaultResourceMeasurementId = contract.DefaultResourceMeasurementId;
            data.ClientWorkingsetBytes = contract.ClientWorkingsetBytes;
            data.BusinessWorkingsetBytes = contract.BusinessWorkingsetBytes;
            data.DatabaseSizeBytes = contract.DatabaseSizeBytes;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultResourceMeasurementData data, CrudeDefaultResourceMeasurementContract contract) {
            contract.DefaultResourceMeasurementId = data.DefaultResourceMeasurementId;
            contract.ClientWorkingsetBytes = data.ClientWorkingsetBytes;
            contract.BusinessWorkingsetBytes = data.BusinessWorkingsetBytes;
            contract.DatabaseSizeBytes = data.DatabaseSizeBytes;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
