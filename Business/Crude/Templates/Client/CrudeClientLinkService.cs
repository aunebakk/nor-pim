/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:05:41 AM
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
    public partial interface ICrudeClientLinkService {
        
        [OperationContract()]
        CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd);
        
        [OperationContract()]
        CrudeClientLinkContract FetchByLinkName(string linkName);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientLinkContract contract);
        
        [OperationContract()]
        void Update(CrudeClientLinkContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientLinkId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_link's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientLinkService : ICrudeClientLinkService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientLinkId: primary key of table client_link
        public CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId) {
            var dataAccessLayer = new CrudeClientLinkData();
            var contract = new CrudeClientLinkContract();

            dataAccessLayer.FetchByClientLinkId(clientLinkId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientLinkContract FetchByLinkName(string linkName) {
            var dataAccessLayer = new CrudeClientLinkData();
            var contract = new CrudeClientLinkContract();

            dataAccessLayer.FetchByLinkName(linkName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientLinkContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientLinkData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientLinkContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientLinkData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            return DataListToContractList(CrudeClientLinkData.FetchByClientLinkTypeRcd(clientLinkTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientLinkContract> DataListToContractList(List<CrudeClientLinkData> dataList) {
            var contractList = new List<CrudeClientLinkContract>();

            foreach (CrudeClientLinkData data in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientLinkContract> contractList, List<CrudeClientLinkData> dataList) {
            foreach (CrudeClientLinkContract contract in contractList) {
                var data = new CrudeClientLinkData();
                CrudeClientLinkService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientLinkData to a List of SOAP Contracts
        public List<CrudeClientLinkContract> FetchAll() {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAll();

            foreach (CrudeClientLinkData crudeClientLink in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(crudeClientLink, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientLinkContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAllWithLimit(limit);

            foreach (CrudeClientLinkData crudeClientLink in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(crudeClientLink, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientLinkData crudeClientLink in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(crudeClientLink, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientLinkData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchWithFilter(
                clientLinkId: clientLinkId,
                clientId: clientId,
                clientLinkTypeRcd: clientLinkTypeRcd,
                linkName: linkName,
                link: link,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientLinkData data in dataList) {
                var crudeClientLinkContract = new CrudeClientLinkContract();
                DataToContract(data, crudeClientLinkContract);
                list.Add(crudeClientLinkContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientLinkContract contract) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientLinkContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientLinkContract contract) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientLinkContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientLinkId) {
            CrudeClientLinkData.Delete(clientLinkId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientLinkContract contract, CrudeClientLinkData data) {
            data.ClientLinkId = contract.ClientLinkId;
            data.ClientId = contract.ClientId;
            data.ClientLinkTypeRcd = contract.ClientLinkTypeRcd;
            data.LinkName = contract.LinkName;
            data.Link = contract.Link;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientLinkData data, CrudeClientLinkContract contract) {
            contract.ClientLinkId = data.ClientLinkId;
            contract.ClientId = data.ClientId;
            contract.ClientLinkTypeRcd = data.ClientLinkTypeRcd;
            contract.LinkName = data.LinkName;
            contract.Link = data.Link;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
