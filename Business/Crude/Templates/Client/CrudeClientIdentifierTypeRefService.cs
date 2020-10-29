/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:56:50 PM
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
    public partial interface ICrudeClientIdentifierTypeRefService {
        
        [OperationContract()]
        CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd);
        
        [OperationContract()]
        List<CrudeClientIdentifierTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeName(string clientIdentifierTypeName);
        
        [OperationContract()]
        List<CrudeClientIdentifierTypeRefContract> FetchWithFilter(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientIdentifierTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientIdentifierTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientIdentifierTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientIdentifierTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientIdentifierTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_identifier_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientIdentifierTypeRefService : ICrudeClientIdentifierTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientIdentifierTypeRcd: primary key of table client_identifier_type_ref
        public CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            var dataAccessLayer = new CrudeClientIdentifierTypeRefData();
            var contract = new CrudeClientIdentifierTypeRefContract();

            dataAccessLayer.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeName(string clientIdentifierTypeName) {
            var dataAccessLayer = new CrudeClientIdentifierTypeRefData();
            var contract = new CrudeClientIdentifierTypeRefContract();

            dataAccessLayer.FetchByClientIdentifierTypeName(clientIdentifierTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientIdentifierTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientIdentifierTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientIdentifierTypeRefContract> DataListToContractList(List<CrudeClientIdentifierTypeRefData> dataList) {
            var contractList = new List<CrudeClientIdentifierTypeRefContract>();

            foreach (CrudeClientIdentifierTypeRefData data in dataList) {
                var contract = new CrudeClientIdentifierTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientIdentifierTypeRefContract> contractList, List<CrudeClientIdentifierTypeRefData> dataList) {
            foreach (CrudeClientIdentifierTypeRefContract contract in contractList) {
                var data = new CrudeClientIdentifierTypeRefData();
                CrudeClientIdentifierTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientIdentifierTypeRefData to a List of SOAP Contracts
        public List<CrudeClientIdentifierTypeRefContract> FetchAll() {
            var list = new List<CrudeClientIdentifierTypeRefContract>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchAll();

            foreach (CrudeClientIdentifierTypeRefData crudeClientIdentifierTypeRef in dataList) {
                var contract = new CrudeClientIdentifierTypeRefContract();
                DataToContract(crudeClientIdentifierTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientIdentifierTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientIdentifierTypeRefContract>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientIdentifierTypeRefData crudeClientIdentifierTypeRef in dataList) {
                var contract = new CrudeClientIdentifierTypeRefContract();
                DataToContract(crudeClientIdentifierTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientIdentifierTypeRefContract>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientIdentifierTypeRefData crudeClientIdentifierTypeRef in dataList) {
                var contract = new CrudeClientIdentifierTypeRefContract();
                DataToContract(crudeClientIdentifierTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientIdentifierTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientIdentifierTypeRefContract> FetchWithFilter(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientIdentifierTypeRefContract>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchWithFilter(
                clientIdentifierTypeRcd: clientIdentifierTypeRcd,
                clientIdentifierTypeName: clientIdentifierTypeName,
                clientIdentifierTypeDescription: clientIdentifierTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientIdentifierTypeRefData data in dataList) {
                var crudeClientIdentifierTypeRefContract = new CrudeClientIdentifierTypeRefContract();
                DataToContract(data, crudeClientIdentifierTypeRefContract);
                list.Add(crudeClientIdentifierTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientIdentifierTypeRefContract contract) {
            var data = new CrudeClientIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientIdentifierTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientIdentifierTypeRefContract contract) {
            var data = new CrudeClientIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientIdentifierTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientIdentifierTypeRcd) {
            CrudeClientIdentifierTypeRefData.Delete(clientIdentifierTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientIdentifierTypeRefContract contract, CrudeClientIdentifierTypeRefData data) {
            data.ClientIdentifierTypeRcd = contract.ClientIdentifierTypeRcd;
            data.ClientIdentifierTypeName = contract.ClientIdentifierTypeName;
            data.ClientIdentifierTypeDescription = contract.ClientIdentifierTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientIdentifierTypeRefData data, CrudeClientIdentifierTypeRefContract contract) {
            contract.ClientIdentifierTypeRcd = data.ClientIdentifierTypeRcd;
            contract.ClientIdentifierTypeName = data.ClientIdentifierTypeName;
            contract.ClientIdentifierTypeDescription = data.ClientIdentifierTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
