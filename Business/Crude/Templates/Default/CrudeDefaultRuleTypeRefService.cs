/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 8:04:59 PM
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
    public partial interface ICrudeDefaultRuleTypeRefService {
        
        [OperationContract()]
        CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultRuleTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultRuleTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultRuleTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_rule_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultRuleTypeRefService : ICrudeDefaultRuleTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultRuleTypeRcd: primary key of table default_rule_type_ref
        public CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            var dataAccessLayer = new CrudeDefaultRuleTypeRefData();
            var contract = new CrudeDefaultRuleTypeRefContract();

            dataAccessLayer.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName) {
            var dataAccessLayer = new CrudeDefaultRuleTypeRefData();
            var contract = new CrudeDefaultRuleTypeRefContract();

            dataAccessLayer.FetchByDefaultRuleTypeName(defaultRuleTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultRuleTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultRuleTypeRefContract> DataListToContractList(List<CrudeDefaultRuleTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultRuleTypeRefContract>();

            foreach (CrudeDefaultRuleTypeRefData data in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultRuleTypeRefContract> contractList, List<CrudeDefaultRuleTypeRefData> dataList) {
            foreach (CrudeDefaultRuleTypeRefContract contract in contractList) {
                var data = new CrudeDefaultRuleTypeRefData();
                CrudeDefaultRuleTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultRuleTypeRefData to a List of SOAP Contracts
        public List<CrudeDefaultRuleTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAll();

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRef in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(crudeDefaultRuleTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRef in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(crudeDefaultRuleTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRef in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(crudeDefaultRuleTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultRuleTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchWithFilter(
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                defaultRuleTypeName: defaultRuleTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultRuleTypeRefData data in dataList) {
                var crudeDefaultRuleTypeRefContract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(data, crudeDefaultRuleTypeRefContract);
                list.Add(crudeDefaultRuleTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultRuleTypeRefContract contract) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultRuleTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultRuleTypeRefContract contract) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultRuleTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultRuleTypeRcd) {
            CrudeDefaultRuleTypeRefData.Delete(defaultRuleTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultRuleTypeRefContract contract, CrudeDefaultRuleTypeRefData data) {
            data.DefaultRuleTypeRcd = contract.DefaultRuleTypeRcd;
            data.DefaultRuleTypeName = contract.DefaultRuleTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultRuleTypeRefData data, CrudeDefaultRuleTypeRefContract contract) {
            contract.DefaultRuleTypeRcd = data.DefaultRuleTypeRcd;
            contract.DefaultRuleTypeName = data.DefaultRuleTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
