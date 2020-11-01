/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:52:43 AM
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
    public partial interface ICrudeClientTypeRefService {
        
        [OperationContract()]
        CrudeClientTypeRefContract FetchByClientTypeRcd(string clientTypeRcd);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientTypeRefContract FetchByClientTypeName(string clientTypeName);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchWithFilter(string clientTypeRcd, string clientTypeName, string clientTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientTypeRefService : ICrudeClientTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientTypeRcd: primary key of table client_type_ref
        public CrudeClientTypeRefContract FetchByClientTypeRcd(string clientTypeRcd) {
            var dataAccessLayer = new CrudeClientTypeRefData();
            var contract = new CrudeClientTypeRefContract();

            dataAccessLayer.FetchByClientTypeRcd(clientTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientTypeRefContract FetchByClientTypeName(string clientTypeName) {
            var dataAccessLayer = new CrudeClientTypeRefData();
            var contract = new CrudeClientTypeRefContract();

            dataAccessLayer.FetchByClientTypeName(clientTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientTypeRefContract> DataListToContractList(List<CrudeClientTypeRefData> dataList) {
            var contractList = new List<CrudeClientTypeRefContract>();

            foreach (CrudeClientTypeRefData data in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientTypeRefContract> contractList, List<CrudeClientTypeRefData> dataList) {
            foreach (CrudeClientTypeRefContract contract in contractList) {
                var data = new CrudeClientTypeRefData();
                CrudeClientTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientTypeRefData to a List of SOAP Contracts
        public List<CrudeClientTypeRefContract> FetchAll() {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAll();

            foreach (CrudeClientTypeRefData crudeClientTypeRef in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(crudeClientTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientTypeRefData crudeClientTypeRef in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(crudeClientTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientTypeRefData crudeClientTypeRef in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(crudeClientTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientTypeRefContract> FetchWithFilter(string clientTypeRcd, string clientTypeName, string clientTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchWithFilter(
                clientTypeRcd: clientTypeRcd,
                clientTypeName: clientTypeName,
                clientTypeDescription: clientTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientTypeRefData data in dataList) {
                var crudeClientTypeRefContract = new CrudeClientTypeRefContract();
                DataToContract(data, crudeClientTypeRefContract);
                list.Add(crudeClientTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientTypeRefContract contract) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientTypeRefContract contract) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientTypeRcd) {
            CrudeClientTypeRefData.Delete(clientTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientTypeRefContract contract, CrudeClientTypeRefData data) {
            data.ClientTypeRcd = contract.ClientTypeRcd;
            data.ClientTypeName = contract.ClientTypeName;
            data.ClientTypeDescription = contract.ClientTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientTypeRefData data, CrudeClientTypeRefContract contract) {
            contract.ClientTypeRcd = data.ClientTypeRcd;
            contract.ClientTypeName = data.ClientTypeName;
            contract.ClientTypeDescription = data.ClientTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
