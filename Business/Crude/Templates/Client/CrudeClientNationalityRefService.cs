/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:20:53 PM
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
    public partial interface ICrudeClientNationalityRefService {
        
        [OperationContract()]
        CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientNationalityRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientNationalityRefContract contract);
        
        [OperationContract()]
        void Delete(string clientNationalityRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_nationality_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientNationalityRefService : ICrudeClientNationalityRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientNationalityRcd: primary key of table client_nationality_ref
        public CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd) {
            var dataAccessLayer = new CrudeClientNationalityRefData();
            var contract = new CrudeClientNationalityRefContract();

            dataAccessLayer.FetchByClientNationalityRcd(clientNationalityRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName) {
            var dataAccessLayer = new CrudeClientNationalityRefData();
            var contract = new CrudeClientNationalityRefContract();

            dataAccessLayer.FetchByClientNationalityName(clientNationalityName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientNationalityRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientNationalityRefContract> DataListToContractList(List<CrudeClientNationalityRefData> dataList) {
            var contractList = new List<CrudeClientNationalityRefContract>();

            foreach (CrudeClientNationalityRefData data in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientNationalityRefContract> contractList, List<CrudeClientNationalityRefData> dataList) {
            foreach (CrudeClientNationalityRefContract contract in contractList) {
                var data = new CrudeClientNationalityRefData();
                CrudeClientNationalityRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientNationalityRefData to a List of SOAP Contracts
        public List<CrudeClientNationalityRefContract> FetchAll() {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAll();

            foreach (CrudeClientNationalityRefData crudeClientNationalityRef in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(crudeClientNationalityRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientNationalityRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientNationalityRefData crudeClientNationalityRef in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(crudeClientNationalityRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientNationalityRefData crudeClientNationalityRef in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(crudeClientNationalityRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientNationalityRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientNationalityRefContract> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchWithFilter(
                clientNationalityRcd: clientNationalityRcd,
                clientNationalityName: clientNationalityName,
                clientNationalityDescription: clientNationalityDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientNationalityRefData data in dataList) {
                var crudeClientNationalityRefContract = new CrudeClientNationalityRefContract();
                DataToContract(data, crudeClientNationalityRefContract);
                list.Add(crudeClientNationalityRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientNationalityRefContract contract) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientNationalityRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientNationalityRefContract contract) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientNationalityRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientNationalityRcd) {
            CrudeClientNationalityRefData.Delete(clientNationalityRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientNationalityRefContract contract, CrudeClientNationalityRefData data) {
            data.ClientNationalityRcd = contract.ClientNationalityRcd;
            data.ClientNationalityName = contract.ClientNationalityName;
            data.ClientNationalityDescription = contract.ClientNationalityDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientNationalityRefData data, CrudeClientNationalityRefContract contract) {
            contract.ClientNationalityRcd = data.ClientNationalityRcd;
            contract.ClientNationalityName = data.ClientNationalityName;
            contract.ClientNationalityDescription = data.ClientNationalityDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
