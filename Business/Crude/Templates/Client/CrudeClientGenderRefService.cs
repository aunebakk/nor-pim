/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:18:28 PM
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
    public partial interface ICrudeClientGenderRefService {
        
        [OperationContract()]
        CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientGenderRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientGenderRefContract contract);
        
        [OperationContract()]
        void Delete(string clientGenderRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_gender_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientGenderRefService : ICrudeClientGenderRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientGenderRcd: primary key of table client_gender_ref
        public CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var contract = new CrudeClientGenderRefContract();

            dataAccessLayer.FetchByClientGenderRcd(clientGenderRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var contract = new CrudeClientGenderRefContract();

            dataAccessLayer.FetchByClientGenderName(clientGenderName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientGenderRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientGenderRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientGenderRefContract> DataListToContractList(List<CrudeClientGenderRefData> dataList) {
            var contractList = new List<CrudeClientGenderRefContract>();

            foreach (CrudeClientGenderRefData data in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientGenderRefContract> contractList, List<CrudeClientGenderRefData> dataList) {
            foreach (CrudeClientGenderRefContract contract in contractList) {
                var data = new CrudeClientGenderRefData();
                CrudeClientGenderRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientGenderRefData to a List of SOAP Contracts
        public List<CrudeClientGenderRefContract> FetchAll() {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAll();

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientGenderRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientGenderRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchWithFilter(
                clientGenderRcd: clientGenderRcd,
                clientGenderName: clientGenderName,
                clientGenderDescription: clientGenderDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientGenderRefData data in dataList) {
                var crudeClientGenderRefContract = new CrudeClientGenderRefContract();
                DataToContract(data, crudeClientGenderRefContract);
                list.Add(crudeClientGenderRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientGenderRefContract contract) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientGenderRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientGenderRefContract contract) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientGenderRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientGenderRcd) {
            CrudeClientGenderRefData.Delete(clientGenderRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientGenderRefContract contract, CrudeClientGenderRefData data) {
            data.ClientGenderRcd = contract.ClientGenderRcd;
            data.ClientGenderName = contract.ClientGenderName;
            data.ClientGenderDescription = contract.ClientGenderDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientGenderRefData data, CrudeClientGenderRefContract contract) {
            contract.ClientGenderRcd = data.ClientGenderRcd;
            contract.ClientGenderName = data.ClientGenderName;
            contract.ClientGenderDescription = data.ClientGenderDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
