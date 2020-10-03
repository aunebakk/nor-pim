/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/3/2020 3:48:14 PM
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
    public partial interface ICrudeDefaultUserService {
        
        [OperationContract()]
        CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd);
        
        [OperationContract()]
        CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultUserContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultUserContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultUserId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_user's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultUserService : ICrudeDefaultUserService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultUserId: primary key of table default_user
        public CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataAccessLayer = new CrudeDefaultUserData();
            var contract = new CrudeDefaultUserContract();

            dataAccessLayer.FetchByDefaultUserId(defaultUserId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName) {
            var dataAccessLayer = new CrudeDefaultUserData();
            var contract = new CrudeDefaultUserContract();

            dataAccessLayer.FetchByDefaultUserName(defaultUserName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId) {
            return DataListToContractList(CrudeDefaultUserData.FetchByCreatedByDefaultUserId(createdByDefaultUserId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd) {
            return DataListToContractList(CrudeDefaultUserData.FetchByDefaultStateRcd(defaultStateRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultUserContract> DataListToContractList(List<CrudeDefaultUserData> dataList) {
            var contractList = new List<CrudeDefaultUserContract>();

            foreach (CrudeDefaultUserData data in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultUserContract> contractList, List<CrudeDefaultUserData> dataList) {
            foreach (CrudeDefaultUserContract contract in contractList) {
                var data = new CrudeDefaultUserData();
                CrudeDefaultUserService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultUserData to a List of SOAP Contracts
        public List<CrudeDefaultUserContract> FetchAll() {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAll();

            foreach (CrudeDefaultUserData crudeDefaultUser in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(crudeDefaultUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultUserContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultUserData crudeDefaultUser in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(crudeDefaultUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultUserData crudeDefaultUser in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(crudeDefaultUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultUserData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchWithFilter(
                defaultUserId: defaultUserId,
                defaultUserCode: defaultUserCode,
                defaultUserName: defaultUserName,
                email: email,
                password: password,
                defaultStateRcd: defaultStateRcd,
                createdByDefaultUserId: createdByDefaultUserId,
                dateTime: dateTime,
                lastActivityDateTime: lastActivityDateTime
                );

            foreach (CrudeDefaultUserData data in dataList) {
                var crudeDefaultUserContract = new CrudeDefaultUserContract();
                DataToContract(data, crudeDefaultUserContract);
                list.Add(crudeDefaultUserContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultUserContract contract) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultUserContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultUserContract contract) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultUserContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultUserId) {
            CrudeDefaultUserData.Delete(defaultUserId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultUserContract contract, CrudeDefaultUserData data) {
            data.DefaultUserId = contract.DefaultUserId;
            data.DefaultUserCode = contract.DefaultUserCode;
            data.DefaultUserName = contract.DefaultUserName;
            data.Email = contract.Email;
            data.Password = contract.Password;
            data.DefaultStateRcd = contract.DefaultStateRcd;
            data.CreatedByDefaultUserId = contract.CreatedByDefaultUserId;
            data.DateTime = contract.DateTime;
            data.LastActivityDateTime = contract.LastActivityDateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultUserData data, CrudeDefaultUserContract contract) {
            contract.DefaultUserId = data.DefaultUserId;
            contract.DefaultUserCode = data.DefaultUserCode;
            contract.DefaultUserName = data.DefaultUserName;
            contract.Email = data.Email;
            contract.Password = data.Password;
            contract.DefaultStateRcd = data.DefaultStateRcd;
            contract.CreatedByDefaultUserId = data.CreatedByDefaultUserId;
            contract.DateTime = data.DateTime;
            contract.LastActivityDateTime = data.LastActivityDateTime;
        }
    }
}
