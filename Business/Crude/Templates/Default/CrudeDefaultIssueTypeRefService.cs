/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/27/2020 8:21:00 PM
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
    public partial interface ICrudeDefaultIssueTypeRefService {
        
        [OperationContract()]
        CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeName(string defaultIssueTypeName);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultIssueTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultIssueTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultIssueTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_issue_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultIssueTypeRefService : ICrudeDefaultIssueTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultIssueTypeRcd: primary key of table default_issue_type_ref
        public CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var contract = new CrudeDefaultIssueTypeRefContract();

            dataAccessLayer.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeName(string defaultIssueTypeName) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var contract = new CrudeDefaultIssueTypeRefContract();

            dataAccessLayer.FetchByDefaultIssueTypeName(defaultIssueTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultIssueTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultIssueTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultIssueTypeRefContract> DataListToContractList(List<CrudeDefaultIssueTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultIssueTypeRefContract>();

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultIssueTypeRefContract> contractList, List<CrudeDefaultIssueTypeRefData> dataList) {
            foreach (CrudeDefaultIssueTypeRefContract contract in contractList) {
                var data = new CrudeDefaultIssueTypeRefData();
                CrudeDefaultIssueTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultIssueTypeRefData to a List of SOAP Contracts
        public List<CrudeDefaultIssueTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAll();

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRef in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(crudeDefaultIssueTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRef in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(crudeDefaultIssueTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRef in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(crudeDefaultIssueTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultIssueTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultIssueTypeRefContract> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchWithFilter(
                defaultIssueTypeRcd: defaultIssueTypeRcd,
                defaultIssueTypeName: defaultIssueTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var crudeDefaultIssueTypeRefContract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(data, crudeDefaultIssueTypeRefContract);
                list.Add(crudeDefaultIssueTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultIssueTypeRefContract contract) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultIssueTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultIssueTypeRefContract contract) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultIssueTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultIssueTypeRcd) {
            CrudeDefaultIssueTypeRefData.Delete(defaultIssueTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultIssueTypeRefContract contract, CrudeDefaultIssueTypeRefData data) {
            data.DefaultIssueTypeRcd = contract.DefaultIssueTypeRcd;
            data.DefaultIssueTypeName = contract.DefaultIssueTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultIssueTypeRefData data, CrudeDefaultIssueTypeRefContract contract) {
            contract.DefaultIssueTypeRcd = data.DefaultIssueTypeRcd;
            contract.DefaultIssueTypeName = data.DefaultIssueTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
