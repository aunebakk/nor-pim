/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:11:48 PM
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
    public partial interface ICrudeClientLinkTypeRefService {
        
        [OperationContract()]
        CrudeClientLinkTypeRefContract FetchByClientLinkTypeRcd(string clientLinkTypeRcd);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientLinkTypeRefContract FetchByClientLinkTypeName(string clientLinkTypeName);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientLinkTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientLinkTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientLinkTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_link_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientLinkTypeRefService : ICrudeClientLinkTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientLinkTypeRcd: primary key of table client_link_type_ref
        public CrudeClientLinkTypeRefContract FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            var dataAccessLayer = new CrudeClientLinkTypeRefData();
            var contract = new CrudeClientLinkTypeRefContract();

            dataAccessLayer.FetchByClientLinkTypeRcd(clientLinkTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientLinkTypeRefContract FetchByClientLinkTypeName(string clientLinkTypeName) {
            var dataAccessLayer = new CrudeClientLinkTypeRefData();
            var contract = new CrudeClientLinkTypeRefContract();

            dataAccessLayer.FetchByClientLinkTypeName(clientLinkTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientLinkTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientLinkTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientLinkTypeRefContract> DataListToContractList(List<CrudeClientLinkTypeRefData> dataList) {
            var contractList = new List<CrudeClientLinkTypeRefContract>();

            foreach (CrudeClientLinkTypeRefData data in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientLinkTypeRefContract> contractList, List<CrudeClientLinkTypeRefData> dataList) {
            foreach (CrudeClientLinkTypeRefContract contract in contractList) {
                var data = new CrudeClientLinkTypeRefData();
                CrudeClientLinkTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientLinkTypeRefData to a List of SOAP Contracts
        public List<CrudeClientLinkTypeRefContract> FetchAll() {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAll();

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRef in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(crudeClientLinkTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientLinkTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRef in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(crudeClientLinkTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientLinkTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRef in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(crudeClientLinkTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientLinkTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientLinkTypeRefContract> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchWithFilter(
                clientLinkTypeRcd: clientLinkTypeRcd,
                clientLinkTypeName: clientLinkTypeName,
                clientLinkTypeDescription: clientLinkTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientLinkTypeRefData data in dataList) {
                var crudeClientLinkTypeRefContract = new CrudeClientLinkTypeRefContract();
                DataToContract(data, crudeClientLinkTypeRefContract);
                list.Add(crudeClientLinkTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientLinkTypeRefContract contract) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientLinkTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientLinkTypeRefContract contract) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientLinkTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientLinkTypeRcd) {
            CrudeClientLinkTypeRefData.Delete(clientLinkTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientLinkTypeRefContract contract, CrudeClientLinkTypeRefData data) {
            data.ClientLinkTypeRcd = contract.ClientLinkTypeRcd;
            data.ClientLinkTypeName = contract.ClientLinkTypeName;
            data.ClientLinkTypeDescription = contract.ClientLinkTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientLinkTypeRefData data, CrudeClientLinkTypeRefContract contract) {
            contract.ClientLinkTypeRcd = data.ClientLinkTypeRcd;
            contract.ClientLinkTypeName = data.ClientLinkTypeName;
            contract.ClientLinkTypeDescription = data.ClientLinkTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
