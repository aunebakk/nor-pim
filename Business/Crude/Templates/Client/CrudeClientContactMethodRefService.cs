/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 12:15:10 PM
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
    public partial interface ICrudeClientContactMethodRefService {
        
        [OperationContract()]
        CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientContactMethodRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientContactMethodRefContract contract);
        
        [OperationContract()]
        void Delete(string clientContactMethodRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_contact_method_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientContactMethodRefService : ICrudeClientContactMethodRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientContactMethodRcd: primary key of table client_contact_method_ref
        public CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            var dataAccessLayer = new CrudeClientContactMethodRefData();
            var contract = new CrudeClientContactMethodRefContract();

            dataAccessLayer.FetchByClientContactMethodRcd(clientContactMethodRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName) {
            var dataAccessLayer = new CrudeClientContactMethodRefData();
            var contract = new CrudeClientContactMethodRefContract();

            dataAccessLayer.FetchByClientContactMethodName(clientContactMethodName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientContactMethodRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientContactMethodRefContract> DataListToContractList(List<CrudeClientContactMethodRefData> dataList) {
            var contractList = new List<CrudeClientContactMethodRefContract>();

            foreach (CrudeClientContactMethodRefData data in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientContactMethodRefContract> contractList, List<CrudeClientContactMethodRefData> dataList) {
            foreach (CrudeClientContactMethodRefContract contract in contractList) {
                var data = new CrudeClientContactMethodRefData();
                CrudeClientContactMethodRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientContactMethodRefData to a List of SOAP Contracts
        public List<CrudeClientContactMethodRefContract> FetchAll() {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAll();

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRef in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(crudeClientContactMethodRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRef in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(crudeClientContactMethodRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRef in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(crudeClientContactMethodRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientContactMethodRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchWithFilter(
                clientContactMethodRcd: clientContactMethodRcd,
                clientContactMethodName: clientContactMethodName,
                clientContactMethodDescription: clientContactMethodDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientContactMethodRefData data in dataList) {
                var crudeClientContactMethodRefContract = new CrudeClientContactMethodRefContract();
                DataToContract(data, crudeClientContactMethodRefContract);
                list.Add(crudeClientContactMethodRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientContactMethodRefContract contract) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientContactMethodRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientContactMethodRefContract contract) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientContactMethodRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientContactMethodRcd) {
            CrudeClientContactMethodRefData.Delete(clientContactMethodRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientContactMethodRefContract contract, CrudeClientContactMethodRefData data) {
            data.ClientContactMethodRcd = contract.ClientContactMethodRcd;
            data.ClientContactMethodName = contract.ClientContactMethodName;
            data.ClientContactMethodDescription = contract.ClientContactMethodDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientContactMethodRefData data, CrudeClientContactMethodRefContract contract) {
            contract.ClientContactMethodRcd = data.ClientContactMethodRcd;
            contract.ClientContactMethodName = data.ClientContactMethodName;
            contract.ClientContactMethodDescription = data.ClientContactMethodDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
