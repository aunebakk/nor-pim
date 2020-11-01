/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:02:59 AM
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
    public partial interface ICrudeClientEventService {
        
        [OperationContract()]
        CrudeClientEventContract FetchByClientEventId(System.Guid clientEventId);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchByClientEventTypeRcd(string clientEventTypeRcd);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientEventContract contract);
        
        [OperationContract()]
        void Update(CrudeClientEventContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientEventId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_event's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientEventService : ICrudeClientEventService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientEventId: primary key of table client_event
        public CrudeClientEventContract FetchByClientEventId(System.Guid clientEventId) {
            var dataAccessLayer = new CrudeClientEventData();
            var contract = new CrudeClientEventContract();

            dataAccessLayer.FetchByClientEventId(clientEventId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientEventContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientEventData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientEventContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientEventData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientEventContract> FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            return DataListToContractList(CrudeClientEventData.FetchByClientEventTypeRcd(clientEventTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientEventContract> DataListToContractList(List<CrudeClientEventData> dataList) {
            var contractList = new List<CrudeClientEventContract>();

            foreach (CrudeClientEventData data in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientEventContract> contractList, List<CrudeClientEventData> dataList) {
            foreach (CrudeClientEventContract contract in contractList) {
                var data = new CrudeClientEventData();
                CrudeClientEventService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientEventData to a List of SOAP Contracts
        public List<CrudeClientEventContract> FetchAll() {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAll();

            foreach (CrudeClientEventData crudeClientEvent in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(crudeClientEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientEventContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAllWithLimit(limit);

            foreach (CrudeClientEventData crudeClientEvent in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(crudeClientEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientEventContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientEventData crudeClientEvent in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(crudeClientEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientEventData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientEventContract> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchWithFilter(
                clientEventId: clientEventId,
                clientId: clientId,
                clientEventTypeRcd: clientEventTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientEventData data in dataList) {
                var crudeClientEventContract = new CrudeClientEventContract();
                DataToContract(data, crudeClientEventContract);
                list.Add(crudeClientEventContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientEventContract contract) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientEventContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientEventContract contract) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientEventContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientEventId) {
            CrudeClientEventData.Delete(clientEventId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientEventContract contract, CrudeClientEventData data) {
            data.ClientEventId = contract.ClientEventId;
            data.ClientId = contract.ClientId;
            data.ClientEventTypeRcd = contract.ClientEventTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientEventData data, CrudeClientEventContract contract) {
            contract.ClientEventId = data.ClientEventId;
            contract.ClientId = data.ClientId;
            contract.ClientEventTypeRcd = data.ClientEventTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
