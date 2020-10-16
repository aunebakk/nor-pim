/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:20:54 PM
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
    public partial interface ICrudeDefaultErrorTypeRefService {
        
        [OperationContract()]
        CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeName(string defaultErrorTypeName);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultErrorTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultErrorTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultErrorTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_error_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultErrorTypeRefService : ICrudeDefaultErrorTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultErrorTypeRcd: primary key of table default_error_type_ref
        public CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            var dataAccessLayer = new CrudeDefaultErrorTypeRefData();
            var contract = new CrudeDefaultErrorTypeRefContract();

            dataAccessLayer.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeName(string defaultErrorTypeName) {
            var dataAccessLayer = new CrudeDefaultErrorTypeRefData();
            var contract = new CrudeDefaultErrorTypeRefContract();

            dataAccessLayer.FetchByDefaultErrorTypeName(defaultErrorTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultErrorTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultErrorTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultErrorTypeRefContract> DataListToContractList(List<CrudeDefaultErrorTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultErrorTypeRefContract>();

            foreach (CrudeDefaultErrorTypeRefData data in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultErrorTypeRefContract> contractList, List<CrudeDefaultErrorTypeRefData> dataList) {
            foreach (CrudeDefaultErrorTypeRefContract contract in contractList) {
                var data = new CrudeDefaultErrorTypeRefData();
                CrudeDefaultErrorTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultErrorTypeRefData to a List of SOAP Contracts
        public List<CrudeDefaultErrorTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAll();

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRef in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(crudeDefaultErrorTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRef in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(crudeDefaultErrorTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRef in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(crudeDefaultErrorTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultErrorTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultErrorTypeRefContract> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchWithFilter(
                defaultErrorTypeRcd: defaultErrorTypeRcd,
                defaultErrorTypeName: defaultErrorTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultErrorTypeRefData data in dataList) {
                var crudeDefaultErrorTypeRefContract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(data, crudeDefaultErrorTypeRefContract);
                list.Add(crudeDefaultErrorTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultErrorTypeRefContract contract) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultErrorTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultErrorTypeRefContract contract) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultErrorTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultErrorTypeRcd) {
            CrudeDefaultErrorTypeRefData.Delete(defaultErrorTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultErrorTypeRefContract contract, CrudeDefaultErrorTypeRefData data) {
            data.DefaultErrorTypeRcd = contract.DefaultErrorTypeRcd;
            data.DefaultErrorTypeName = contract.DefaultErrorTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultErrorTypeRefData data, CrudeDefaultErrorTypeRefContract contract) {
            contract.DefaultErrorTypeRcd = data.DefaultErrorTypeRcd;
            contract.DefaultErrorTypeName = data.DefaultErrorTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
