/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/12/2020 5:03:12 AM
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
    public partial interface ICrudeClientAddressTypeRefService {
        
        [OperationContract()]
        CrudeClientAddressTypeRefContract FetchByClientAddressTypeRcd(string clientAddressTypeRcd);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientAddressTypeRefContract FetchByClientAddressTypeName(string clientAddressTypeName);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchWithFilter(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientAddressTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientAddressTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientAddressTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_address_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientAddressTypeRefService : ICrudeClientAddressTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientAddressTypeRcd: primary key of table client_address_type_ref
        public CrudeClientAddressTypeRefContract FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            var dataAccessLayer = new CrudeClientAddressTypeRefData();
            var contract = new CrudeClientAddressTypeRefContract();

            dataAccessLayer.FetchByClientAddressTypeRcd(clientAddressTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientAddressTypeRefContract FetchByClientAddressTypeName(string clientAddressTypeName) {
            var dataAccessLayer = new CrudeClientAddressTypeRefData();
            var contract = new CrudeClientAddressTypeRefContract();

            dataAccessLayer.FetchByClientAddressTypeName(clientAddressTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientAddressTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientAddressTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientAddressTypeRefContract> DataListToContractList(List<CrudeClientAddressTypeRefData> dataList) {
            var contractList = new List<CrudeClientAddressTypeRefContract>();

            foreach (CrudeClientAddressTypeRefData data in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientAddressTypeRefContract> contractList, List<CrudeClientAddressTypeRefData> dataList) {
            foreach (CrudeClientAddressTypeRefContract contract in contractList) {
                var data = new CrudeClientAddressTypeRefData();
                CrudeClientAddressTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientAddressTypeRefData to a List of SOAP Contracts
        public List<CrudeClientAddressTypeRefContract> FetchAll() {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAll();

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRef in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(crudeClientAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientAddressTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRef in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(crudeClientAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRef in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(crudeClientAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientAddressTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientAddressTypeRefContract> FetchWithFilter(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchWithFilter(
                clientAddressTypeRcd: clientAddressTypeRcd,
                clientAddressTypeName: clientAddressTypeName,
                clientAddressTypeDescription: clientAddressTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientAddressTypeRefData data in dataList) {
                var crudeClientAddressTypeRefContract = new CrudeClientAddressTypeRefContract();
                DataToContract(data, crudeClientAddressTypeRefContract);
                list.Add(crudeClientAddressTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientAddressTypeRefContract contract) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientAddressTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientAddressTypeRefContract contract) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientAddressTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientAddressTypeRcd) {
            CrudeClientAddressTypeRefData.Delete(clientAddressTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientAddressTypeRefContract contract, CrudeClientAddressTypeRefData data) {
            data.ClientAddressTypeRcd = contract.ClientAddressTypeRcd;
            data.ClientAddressTypeName = contract.ClientAddressTypeName;
            data.ClientAddressTypeDescription = contract.ClientAddressTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientAddressTypeRefData data, CrudeClientAddressTypeRefContract contract) {
            contract.ClientAddressTypeRcd = data.ClientAddressTypeRcd;
            contract.ClientAddressTypeName = data.ClientAddressTypeName;
            contract.ClientAddressTypeDescription = data.ClientAddressTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
