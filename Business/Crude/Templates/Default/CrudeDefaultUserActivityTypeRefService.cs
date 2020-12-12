/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/12/2020 5:03:19 AM
  From Machine: DESKTOP-LSRVP12
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
    public partial interface ICrudeDefaultUserActivityTypeRefService {
        
        [OperationContract()]
        CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultUserActivityTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultUserActivityTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultUserActivityTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_user_activity_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultUserActivityTypeRefService : ICrudeDefaultUserActivityTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultUserActivityTypeRcd: primary key of table default_user_activity_type_ref
        public CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            var dataAccessLayer = new CrudeDefaultUserActivityTypeRefData();
            var contract = new CrudeDefaultUserActivityTypeRefContract();

            dataAccessLayer.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName) {
            var dataAccessLayer = new CrudeDefaultUserActivityTypeRefData();
            var contract = new CrudeDefaultUserActivityTypeRefContract();

            dataAccessLayer.FetchByDefaultUserActivityTypeName(defaultUserActivityTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultUserActivityTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultUserActivityTypeRefContract> DataListToContractList(List<CrudeDefaultUserActivityTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultUserActivityTypeRefContract>();

            foreach (CrudeDefaultUserActivityTypeRefData data in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultUserActivityTypeRefContract> contractList, List<CrudeDefaultUserActivityTypeRefData> dataList) {
            foreach (CrudeDefaultUserActivityTypeRefContract contract in contractList) {
                var data = new CrudeDefaultUserActivityTypeRefData();
                CrudeDefaultUserActivityTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultUserActivityTypeRefData to a List of SOAP Contracts
        public List<CrudeDefaultUserActivityTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAll();

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRef in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(crudeDefaultUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRef in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(crudeDefaultUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRef in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(crudeDefaultUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultUserActivityTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchWithFilter(
                defaultUserActivityTypeRcd: defaultUserActivityTypeRcd,
                defaultUserActivityTypeName: defaultUserActivityTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultUserActivityTypeRefData data in dataList) {
                var crudeDefaultUserActivityTypeRefContract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(data, crudeDefaultUserActivityTypeRefContract);
                list.Add(crudeDefaultUserActivityTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultUserActivityTypeRefContract contract) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultUserActivityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultUserActivityTypeRefContract contract) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultUserActivityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultUserActivityTypeRcd) {
            CrudeDefaultUserActivityTypeRefData.Delete(defaultUserActivityTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultUserActivityTypeRefContract contract, CrudeDefaultUserActivityTypeRefData data) {
            data.DefaultUserActivityTypeRcd = contract.DefaultUserActivityTypeRcd;
            data.DefaultUserActivityTypeName = contract.DefaultUserActivityTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultUserActivityTypeRefData data, CrudeDefaultUserActivityTypeRefContract contract) {
            contract.DefaultUserActivityTypeRcd = data.DefaultUserActivityTypeRcd;
            contract.DefaultUserActivityTypeName = data.DefaultUserActivityTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
