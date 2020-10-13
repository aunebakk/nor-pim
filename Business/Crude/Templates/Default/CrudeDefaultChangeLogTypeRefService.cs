/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 2:14:56 PM
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
    public partial interface ICrudeDefaultChangeLogTypeRefService {
        
        [OperationContract()]
        CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultChangeLogTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultChangeLogTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultChangeLogTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_change_log_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultChangeLogTypeRefService : ICrudeDefaultChangeLogTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultChangeLogTypeRcd: primary key of table default_change_log_type_ref
        public CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            var dataAccessLayer = new CrudeDefaultChangeLogTypeRefData();
            var contract = new CrudeDefaultChangeLogTypeRefContract();

            dataAccessLayer.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName) {
            var dataAccessLayer = new CrudeDefaultChangeLogTypeRefData();
            var contract = new CrudeDefaultChangeLogTypeRefContract();

            dataAccessLayer.FetchByDefaultChangeLogTypeName(defaultChangeLogTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultChangeLogTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultChangeLogTypeRefContract> DataListToContractList(List<CrudeDefaultChangeLogTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultChangeLogTypeRefContract>();

            foreach (CrudeDefaultChangeLogTypeRefData data in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultChangeLogTypeRefContract> contractList, List<CrudeDefaultChangeLogTypeRefData> dataList) {
            foreach (CrudeDefaultChangeLogTypeRefContract contract in contractList) {
                var data = new CrudeDefaultChangeLogTypeRefData();
                CrudeDefaultChangeLogTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultChangeLogTypeRefData to a List of SOAP Contracts
        public List<CrudeDefaultChangeLogTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAll();

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRef in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(crudeDefaultChangeLogTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRef in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(crudeDefaultChangeLogTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRef in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(crudeDefaultChangeLogTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultChangeLogTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchWithFilter(
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultChangeLogTypeName: defaultChangeLogTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultChangeLogTypeRefData data in dataList) {
                var crudeDefaultChangeLogTypeRefContract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(data, crudeDefaultChangeLogTypeRefContract);
                list.Add(crudeDefaultChangeLogTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultChangeLogTypeRefContract contract) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultChangeLogTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultChangeLogTypeRefContract contract) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultChangeLogTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultChangeLogTypeRcd) {
            CrudeDefaultChangeLogTypeRefData.Delete(defaultChangeLogTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultChangeLogTypeRefContract contract, CrudeDefaultChangeLogTypeRefData data) {
            data.DefaultChangeLogTypeRcd = contract.DefaultChangeLogTypeRcd;
            data.DefaultChangeLogTypeName = contract.DefaultChangeLogTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultChangeLogTypeRefData data, CrudeDefaultChangeLogTypeRefContract contract) {
            contract.DefaultChangeLogTypeRcd = data.DefaultChangeLogTypeRcd;
            contract.DefaultChangeLogTypeName = data.DefaultChangeLogTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
