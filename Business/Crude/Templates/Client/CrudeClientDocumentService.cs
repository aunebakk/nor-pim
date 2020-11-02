/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 8:02:35 PM
  From Machine: DESKTOP-517I8BU
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
    public partial interface ICrudeClientDocumentService {
        
        [OperationContract()]
        CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd);
        
        [OperationContract()]
        CrudeClientDocumentContract FetchByDocumentName(string documentName);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientDocumentContract contract);
        
        [OperationContract()]
        void Update(CrudeClientDocumentContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientDocumentId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_document's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientDocumentService : ICrudeClientDocumentService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientDocumentId: primary key of table client_document
        public CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId) {
            var dataAccessLayer = new CrudeClientDocumentData();
            var contract = new CrudeClientDocumentContract();

            dataAccessLayer.FetchByClientDocumentId(clientDocumentId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientDocumentContract FetchByDocumentName(string documentName) {
            var dataAccessLayer = new CrudeClientDocumentData();
            var contract = new CrudeClientDocumentContract();

            dataAccessLayer.FetchByDocumentName(documentName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientDocumentContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientDocumentData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientDocumentContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientDocumentData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            return DataListToContractList(CrudeClientDocumentData.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientDocumentContract> DataListToContractList(List<CrudeClientDocumentData> dataList) {
            var contractList = new List<CrudeClientDocumentContract>();

            foreach (CrudeClientDocumentData data in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientDocumentContract> contractList, List<CrudeClientDocumentData> dataList) {
            foreach (CrudeClientDocumentContract contract in contractList) {
                var data = new CrudeClientDocumentData();
                CrudeClientDocumentService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientDocumentData to a List of SOAP Contracts
        public List<CrudeClientDocumentContract> FetchAll() {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAll();

            foreach (CrudeClientDocumentData crudeClientDocument in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(crudeClientDocument, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientDocumentContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAllWithLimit(limit);

            foreach (CrudeClientDocumentData crudeClientDocument in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(crudeClientDocument, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientDocumentData crudeClientDocument in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(crudeClientDocument, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientDocumentData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientDocumentContract> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchWithFilter(
                clientDocumentId: clientDocumentId,
                clientId: clientId,
                clientDocumentTypeRcd: clientDocumentTypeRcd,
                documentName: documentName,
                documentDateTime: documentDateTime,
                expiryDateTime: expiryDateTime,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientDocumentData data in dataList) {
                var crudeClientDocumentContract = new CrudeClientDocumentContract();
                DataToContract(data, crudeClientDocumentContract);
                list.Add(crudeClientDocumentContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientDocumentContract contract) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientDocumentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientDocumentContract contract) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientDocumentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientDocumentId) {
            CrudeClientDocumentData.Delete(clientDocumentId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientDocumentContract contract, CrudeClientDocumentData data) {
            data.ClientDocumentId = contract.ClientDocumentId;
            data.ClientId = contract.ClientId;
            data.ClientDocumentTypeRcd = contract.ClientDocumentTypeRcd;
            data.DocumentName = contract.DocumentName;
            data.DocumentDateTime = contract.DocumentDateTime;
            data.ExpiryDateTime = contract.ExpiryDateTime;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientDocumentData data, CrudeClientDocumentContract contract) {
            contract.ClientDocumentId = data.ClientDocumentId;
            contract.ClientId = data.ClientId;
            contract.ClientDocumentTypeRcd = data.ClientDocumentTypeRcd;
            contract.DocumentName = data.DocumentName;
            contract.DocumentDateTime = data.DocumentDateTime;
            contract.ExpiryDateTime = data.ExpiryDateTime;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
