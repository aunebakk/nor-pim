/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 8:59:29 AM
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
    public partial interface ICrudeDefaultRuleService {
        
        [OperationContract()]
        CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultRuleContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultRuleContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultRuleId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_rule's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultRuleService : ICrudeDefaultRuleService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultRuleId: primary key of table default_rule
        public CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId) {
            var dataAccessLayer = new CrudeDefaultRuleData();
            var contract = new CrudeDefaultRuleContract();

            dataAccessLayer.FetchByDefaultRuleId(defaultRuleId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultRuleData.FetchByDefaultUserId(defaultUserId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            return DataListToContractList(CrudeDefaultRuleData.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultRuleContract> DataListToContractList(List<CrudeDefaultRuleData> dataList) {
            var contractList = new List<CrudeDefaultRuleContract>();

            foreach (CrudeDefaultRuleData data in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultRuleContract> contractList, List<CrudeDefaultRuleData> dataList) {
            foreach (CrudeDefaultRuleContract contract in contractList) {
                var data = new CrudeDefaultRuleData();
                CrudeDefaultRuleService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultRuleData to a List of SOAP Contracts
        public List<CrudeDefaultRuleContract> FetchAll() {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAll();

            foreach (CrudeDefaultRuleData crudeDefaultRule in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(crudeDefaultRule, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultRuleContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultRuleData crudeDefaultRule in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(crudeDefaultRule, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultRuleData crudeDefaultRule in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(crudeDefaultRule, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultRuleData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchWithFilter(
                defaultRuleId: defaultRuleId,
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                address: address,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultRuleData data in dataList) {
                var crudeDefaultRuleContract = new CrudeDefaultRuleContract();
                DataToContract(data, crudeDefaultRuleContract);
                list.Add(crudeDefaultRuleContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultRuleContract contract) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultRuleContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultRuleContract contract) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultRuleContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultRuleId) {
            CrudeDefaultRuleData.Delete(defaultRuleId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultRuleContract contract, CrudeDefaultRuleData data) {
            data.DefaultRuleId = contract.DefaultRuleId;
            data.DefaultRuleTypeRcd = contract.DefaultRuleTypeRcd;
            data.Address = contract.Address;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultRuleData data, CrudeDefaultRuleContract contract) {
            contract.DefaultRuleId = data.DefaultRuleId;
            contract.DefaultRuleTypeRcd = data.DefaultRuleTypeRcd;
            contract.Address = data.Address;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
