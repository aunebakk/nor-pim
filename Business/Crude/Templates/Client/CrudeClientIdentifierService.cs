/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:05:41 AM
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
    public partial interface ICrudeClientIdentifierService {
        
        [OperationContract()]
        CrudeClientIdentifierContract FetchByClientIdentifierId(System.Guid clientIdentifierId);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientIdentifierContract contract);
        
        [OperationContract()]
        void Update(CrudeClientIdentifierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientIdentifierId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_identifier's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientIdentifierService : ICrudeClientIdentifierService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientIdentifierId: primary key of table client_identifier
        public CrudeClientIdentifierContract FetchByClientIdentifierId(System.Guid clientIdentifierId) {
            var dataAccessLayer = new CrudeClientIdentifierData();
            var contract = new CrudeClientIdentifierContract();

            dataAccessLayer.FetchByClientIdentifierId(clientIdentifierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientIdentifierContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientIdentifierData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientIdentifierContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientIdentifierData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientIdentifierContract> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            return DataListToContractList(CrudeClientIdentifierData.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientIdentifierContract> DataListToContractList(List<CrudeClientIdentifierData> dataList) {
            var contractList = new List<CrudeClientIdentifierContract>();

            foreach (CrudeClientIdentifierData data in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientIdentifierContract> contractList, List<CrudeClientIdentifierData> dataList) {
            foreach (CrudeClientIdentifierContract contract in contractList) {
                var data = new CrudeClientIdentifierData();
                CrudeClientIdentifierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientIdentifierData to a List of SOAP Contracts
        public List<CrudeClientIdentifierContract> FetchAll() {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAll();

            foreach (CrudeClientIdentifierData crudeClientIdentifier in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(crudeClientIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientIdentifierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAllWithLimit(limit);

            foreach (CrudeClientIdentifierData crudeClientIdentifier in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(crudeClientIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientIdentifierData crudeClientIdentifier in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(crudeClientIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientIdentifierData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientIdentifierContract> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchWithFilter(
                clientIdentifierId: clientIdentifierId,
                clientId: clientId,
                clientIdentifierTypeRcd: clientIdentifierTypeRcd,
                clientIdentifierCode: clientIdentifierCode,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientIdentifierData data in dataList) {
                var crudeClientIdentifierContract = new CrudeClientIdentifierContract();
                DataToContract(data, crudeClientIdentifierContract);
                list.Add(crudeClientIdentifierContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientIdentifierContract contract) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientIdentifierContract contract) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientIdentifierId) {
            CrudeClientIdentifierData.Delete(clientIdentifierId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientIdentifierContract contract, CrudeClientIdentifierData data) {
            data.ClientIdentifierId = contract.ClientIdentifierId;
            data.ClientId = contract.ClientId;
            data.ClientIdentifierTypeRcd = contract.ClientIdentifierTypeRcd;
            data.ClientIdentifierCode = contract.ClientIdentifierCode;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientIdentifierData data, CrudeClientIdentifierContract contract) {
            contract.ClientIdentifierId = data.ClientIdentifierId;
            contract.ClientId = data.ClientId;
            contract.ClientIdentifierTypeRcd = data.ClientIdentifierTypeRcd;
            contract.ClientIdentifierCode = data.ClientIdentifierCode;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
