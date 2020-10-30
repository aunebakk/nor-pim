/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 9:51:08 PM
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
    public partial interface ICrudeClientContactMethodService {
        
        [OperationContract()]
        CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientContactMethodContract contract);
        
        [OperationContract()]
        void Update(CrudeClientContactMethodContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientContactMethodId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_contact_method's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientContactMethodService : ICrudeClientContactMethodService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientContactMethodId: primary key of table client_contact_method
        public CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId) {
            var dataAccessLayer = new CrudeClientContactMethodData();
            var contract = new CrudeClientContactMethodContract();

            dataAccessLayer.FetchByClientContactMethodId(clientContactMethodId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientContactMethodData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContactMethodContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientContactMethodData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            return DataListToContractList(CrudeClientContactMethodData.FetchByClientContactMethodRcd(clientContactMethodRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientContactMethodContract> DataListToContractList(List<CrudeClientContactMethodData> dataList) {
            var contractList = new List<CrudeClientContactMethodContract>();

            foreach (CrudeClientContactMethodData data in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientContactMethodContract> contractList, List<CrudeClientContactMethodData> dataList) {
            foreach (CrudeClientContactMethodContract contract in contractList) {
                var data = new CrudeClientContactMethodData();
                CrudeClientContactMethodService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientContactMethodData to a List of SOAP Contracts
        public List<CrudeClientContactMethodContract> FetchAll() {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAll();

            foreach (CrudeClientContactMethodData crudeClientContactMethod in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(crudeClientContactMethod, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientContactMethodContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAllWithLimit(limit);

            foreach (CrudeClientContactMethodData crudeClientContactMethod in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(crudeClientContactMethod, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientContactMethodData crudeClientContactMethod in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(crudeClientContactMethod, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientContactMethodData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchWithFilter(
                clientContactMethodId: clientContactMethodId,
                clientId: clientId,
                clientContactMethodRcd: clientContactMethodRcd,
                contactMethodWay: contactMethodWay,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientContactMethodData data in dataList) {
                var crudeClientContactMethodContract = new CrudeClientContactMethodContract();
                DataToContract(data, crudeClientContactMethodContract);
                list.Add(crudeClientContactMethodContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientContactMethodContract contract) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientContactMethodContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientContactMethodContract contract) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientContactMethodContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientContactMethodId) {
            CrudeClientContactMethodData.Delete(clientContactMethodId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientContactMethodContract contract, CrudeClientContactMethodData data) {
            data.ClientContactMethodId = contract.ClientContactMethodId;
            data.ClientId = contract.ClientId;
            data.ClientContactMethodRcd = contract.ClientContactMethodRcd;
            data.ContactMethodWay = contract.ContactMethodWay;
            data.Comment = contract.Comment;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientContactMethodData data, CrudeClientContactMethodContract contract) {
            contract.ClientContactMethodId = data.ClientContactMethodId;
            contract.ClientId = data.ClientId;
            contract.ClientContactMethodRcd = data.ClientContactMethodRcd;
            contract.ContactMethodWay = data.ContactMethodWay;
            contract.Comment = data.Comment;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
