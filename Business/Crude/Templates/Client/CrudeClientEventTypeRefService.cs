/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 9:51:08 PM
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
    public partial interface ICrudeClientEventTypeRefService {
        
        [OperationContract()]
        CrudeClientEventTypeRefContract FetchByClientEventTypeRcd(string clientEventTypeRcd);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientEventTypeRefContract FetchByClientEventTypeName(string clientEventTypeName);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchWithFilter(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientEventTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientEventTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientEventTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_event_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientEventTypeRefService : ICrudeClientEventTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientEventTypeRcd: primary key of table client_event_type_ref
        public CrudeClientEventTypeRefContract FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            var dataAccessLayer = new CrudeClientEventTypeRefData();
            var contract = new CrudeClientEventTypeRefContract();

            dataAccessLayer.FetchByClientEventTypeRcd(clientEventTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientEventTypeRefContract FetchByClientEventTypeName(string clientEventTypeName) {
            var dataAccessLayer = new CrudeClientEventTypeRefData();
            var contract = new CrudeClientEventTypeRefContract();

            dataAccessLayer.FetchByClientEventTypeName(clientEventTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientEventTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientEventTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientEventTypeRefContract> DataListToContractList(List<CrudeClientEventTypeRefData> dataList) {
            var contractList = new List<CrudeClientEventTypeRefContract>();

            foreach (CrudeClientEventTypeRefData data in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientEventTypeRefContract> contractList, List<CrudeClientEventTypeRefData> dataList) {
            foreach (CrudeClientEventTypeRefContract contract in contractList) {
                var data = new CrudeClientEventTypeRefData();
                CrudeClientEventTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientEventTypeRefData to a List of SOAP Contracts
        public List<CrudeClientEventTypeRefContract> FetchAll() {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAll();

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRef in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(crudeClientEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientEventTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRef in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(crudeClientEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRef in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(crudeClientEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientEventTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientEventTypeRefContract> FetchWithFilter(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchWithFilter(
                clientEventTypeRcd: clientEventTypeRcd,
                clientEventTypeName: clientEventTypeName,
                clientEventTypeDescription: clientEventTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientEventTypeRefData data in dataList) {
                var crudeClientEventTypeRefContract = new CrudeClientEventTypeRefContract();
                DataToContract(data, crudeClientEventTypeRefContract);
                list.Add(crudeClientEventTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientEventTypeRefContract contract) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientEventTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientEventTypeRefContract contract) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientEventTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientEventTypeRcd) {
            CrudeClientEventTypeRefData.Delete(clientEventTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientEventTypeRefContract contract, CrudeClientEventTypeRefData data) {
            data.ClientEventTypeRcd = contract.ClientEventTypeRcd;
            data.ClientEventTypeName = contract.ClientEventTypeName;
            data.ClientEventTypeDescription = contract.ClientEventTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientEventTypeRefData data, CrudeClientEventTypeRefContract contract) {
            contract.ClientEventTypeRcd = data.ClientEventTypeRcd;
            contract.ClientEventTypeName = data.ClientEventTypeName;
            contract.ClientEventTypeDescription = data.ClientEventTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
