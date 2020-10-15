/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 2:55:27 PM
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
    public partial interface ICrudeClientDocumentTypeRefService {
        
        [OperationContract()]
        CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeName(string clientDocumentTypeName);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchWithFilter(string clientDocumentTypeRcd, string clientDocumentTypeName, string clientDocumentTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientDocumentTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientDocumentTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientDocumentTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_document_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientDocumentTypeRefService : ICrudeClientDocumentTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientDocumentTypeRcd: primary key of table client_document_type_ref
        public CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            var dataAccessLayer = new CrudeClientDocumentTypeRefData();
            var contract = new CrudeClientDocumentTypeRefContract();

            dataAccessLayer.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeName(string clientDocumentTypeName) {
            var dataAccessLayer = new CrudeClientDocumentTypeRefData();
            var contract = new CrudeClientDocumentTypeRefContract();

            dataAccessLayer.FetchByClientDocumentTypeName(clientDocumentTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientDocumentTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientDocumentTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientDocumentTypeRefContract> DataListToContractList(List<CrudeClientDocumentTypeRefData> dataList) {
            var contractList = new List<CrudeClientDocumentTypeRefContract>();

            foreach (CrudeClientDocumentTypeRefData data in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientDocumentTypeRefContract> contractList, List<CrudeClientDocumentTypeRefData> dataList) {
            foreach (CrudeClientDocumentTypeRefContract contract in contractList) {
                var data = new CrudeClientDocumentTypeRefData();
                CrudeClientDocumentTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientDocumentTypeRefData to a List of SOAP Contracts
        public List<CrudeClientDocumentTypeRefContract> FetchAll() {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAll();

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRef in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(crudeClientDocumentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientDocumentTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRef in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(crudeClientDocumentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientDocumentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRef in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(crudeClientDocumentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientDocumentTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientDocumentTypeRefContract> FetchWithFilter(string clientDocumentTypeRcd, string clientDocumentTypeName, string clientDocumentTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchWithFilter(
                clientDocumentTypeRcd: clientDocumentTypeRcd,
                clientDocumentTypeName: clientDocumentTypeName,
                clientDocumentTypeDescription: clientDocumentTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientDocumentTypeRefData data in dataList) {
                var crudeClientDocumentTypeRefContract = new CrudeClientDocumentTypeRefContract();
                DataToContract(data, crudeClientDocumentTypeRefContract);
                list.Add(crudeClientDocumentTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientDocumentTypeRefContract contract) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientDocumentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientDocumentTypeRefContract contract) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientDocumentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string clientDocumentTypeRcd) {
            CrudeClientDocumentTypeRefData.Delete(clientDocumentTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientDocumentTypeRefContract contract, CrudeClientDocumentTypeRefData data) {
            data.ClientDocumentTypeRcd = contract.ClientDocumentTypeRcd;
            data.ClientDocumentTypeName = contract.ClientDocumentTypeName;
            data.ClientDocumentTypeDescription = contract.ClientDocumentTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientDocumentTypeRefData data, CrudeClientDocumentTypeRefContract contract) {
            contract.ClientDocumentTypeRcd = data.ClientDocumentTypeRcd;
            contract.ClientDocumentTypeName = data.ClientDocumentTypeName;
            contract.ClientDocumentTypeDescription = data.ClientDocumentTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
