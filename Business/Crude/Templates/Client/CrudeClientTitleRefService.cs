/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:20 PM
  From Machine: DESKTOP-KE5CSN3
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
    public partial interface ICrudeClientTitleRefService {
        
        [OperationContract()]
        CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientTitleRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientTitleRefContract contract);
        
        [OperationContract()]
        void Delete(string clientTitleRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_title_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientTitleRefService : ICrudeClientTitleRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientTitleRcd: primary key of table client_title_ref
        public CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd) {
            var dataAccessLayer = new CrudeClientTitleRefData();
            var contract = new CrudeClientTitleRefContract();

            dataAccessLayer.FetchByClientTitleRcd(clientTitleRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName) {
            var dataAccessLayer = new CrudeClientTitleRefData();
            var contract = new CrudeClientTitleRefContract();

            dataAccessLayer.FetchByClientTitleName(clientTitleName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientTitleRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientTitleRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientTitleRefContract> DataListToContractList(List<CrudeClientTitleRefData> dataList) {
            var contractList = new List<CrudeClientTitleRefContract>();

            foreach (CrudeClientTitleRefData data in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientTitleRefContract> contractList, List<CrudeClientTitleRefData> dataList) {
            foreach (CrudeClientTitleRefContract contract in contractList) {
                var data = new CrudeClientTitleRefData();
                CrudeClientTitleRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientTitleRefData to a List of SOAP Contracts
        public List<CrudeClientTitleRefContract> FetchAll() {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAll();

            foreach (CrudeClientTitleRefData crudeClientTitleRef in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(crudeClientTitleRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientTitleRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientTitleRefData crudeClientTitleRef in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(crudeClientTitleRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientTitleRefData crudeClientTitleRef in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(crudeClientTitleRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientTitleRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchWithFilter(
                clientTitleRcd: clientTitleRcd,
                clientTitleName: clientTitleName,
                clientTitleDescription: clientTitleDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientTitleRefData data in dataList) {
                var crudeClientTitleRefContract = new CrudeClientTitleRefContract();
                DataToContract(data, crudeClientTitleRefContract);
                list.Add(crudeClientTitleRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientTitleRefContract contract) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientTitleRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientTitleRefContract contract) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientTitleRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientTitleRcd) {
            CrudeClientTitleRefData.Delete(clientTitleRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientTitleRefContract contract, CrudeClientTitleRefData data) {
            data.ClientTitleRcd = contract.ClientTitleRcd;
            data.ClientTitleName = contract.ClientTitleName;
            data.ClientTitleDescription = contract.ClientTitleDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientTitleRefData data, CrudeClientTitleRefContract contract) {
            contract.ClientTitleRcd = data.ClientTitleRcd;
            contract.ClientTitleName = data.ClientTitleName;
            contract.ClientTitleDescription = data.ClientTitleDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
