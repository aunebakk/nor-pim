/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 12:52:43 PM
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
    public partial interface ICrudeDefaultIssueService {
        
        [OperationContract()]
        CrudeDefaultIssueContract FetchByDefaultIssueId(System.Guid defaultIssueId);
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchByDefaultErrorId(System.Guid defaultErrorId);
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd);
        
        [OperationContract()]
        CrudeDefaultIssueContract FetchByIssueName(string issueName);
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote);
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultIssueContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultIssueContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultIssueContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultIssueId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_issue's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultIssueService : ICrudeDefaultIssueService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultIssueId: primary key of table default_issue
        public CrudeDefaultIssueContract FetchByDefaultIssueId(System.Guid defaultIssueId) {
            var dataAccessLayer = new CrudeDefaultIssueData();
            var contract = new CrudeDefaultIssueContract();

            dataAccessLayer.FetchByDefaultIssueId(defaultIssueId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultIssueContract FetchByIssueName(string issueName) {
            var dataAccessLayer = new CrudeDefaultIssueData();
            var contract = new CrudeDefaultIssueContract();

            dataAccessLayer.FetchByIssueName(issueName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultIssueContract> FetchByDefaultErrorId(System.Guid defaultErrorId) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultErrorId(defaultErrorId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultUserId(defaultUserId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultIssueContract> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultIssueContract> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultIssueContract> DataListToContractList(List<CrudeDefaultIssueData> dataList) {
            var contractList = new List<CrudeDefaultIssueContract>();

            foreach (CrudeDefaultIssueData data in dataList) {
                var contract = new CrudeDefaultIssueContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultIssueContract> contractList, List<CrudeDefaultIssueData> dataList) {
            foreach (CrudeDefaultIssueContract contract in contractList) {
                var data = new CrudeDefaultIssueData();
                CrudeDefaultIssueService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultIssueData to a List of SOAP Contracts
        public List<CrudeDefaultIssueContract> FetchAll() {
            var list = new List<CrudeDefaultIssueContract>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchAll();

            foreach (CrudeDefaultIssueData crudeDefaultIssue in dataList) {
                var contract = new CrudeDefaultIssueContract();
                DataToContract(crudeDefaultIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultIssueContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultIssueContract>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultIssueData crudeDefaultIssue in dataList) {
                var contract = new CrudeDefaultIssueContract();
                DataToContract(crudeDefaultIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultIssueContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultIssueContract>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultIssueData crudeDefaultIssue in dataList) {
                var contract = new CrudeDefaultIssueContract();
                DataToContract(crudeDefaultIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultIssueData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultIssueContract> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote) {
            var list = new List<CrudeDefaultIssueContract>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchWithFilter(
                defaultIssueId: defaultIssueId,
                defaultIssueTypeRcd: defaultIssueTypeRcd,
                defaultIssueStatusRcd: defaultIssueStatusRcd,
                defaultErrorId: defaultErrorId,
                issueName: issueName,
                issueDescription: issueDescription,
                stepsToReproduce: stepsToReproduce,
                link: link,
                defaultUserId: defaultUserId,
                dateTime: dateTime,
                fixedNote: fixedNote
                );

            foreach (CrudeDefaultIssueData data in dataList) {
                var crudeDefaultIssueContract = new CrudeDefaultIssueContract();
                DataToContract(data, crudeDefaultIssueContract);
                list.Add(crudeDefaultIssueContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultIssueContract contract) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultIssueContract contract) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultIssueId) {
            CrudeDefaultIssueData.Delete(defaultIssueId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultIssueContract contract, CrudeDefaultIssueData data) {
            data.DefaultIssueId = contract.DefaultIssueId;
            data.DefaultIssueTypeRcd = contract.DefaultIssueTypeRcd;
            data.DefaultIssueStatusRcd = contract.DefaultIssueStatusRcd;
            data.DefaultErrorId = contract.DefaultErrorId;
            data.IssueName = contract.IssueName;
            data.IssueDescription = contract.IssueDescription;
            data.StepsToReproduce = contract.StepsToReproduce;
            data.Link = contract.Link;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
            data.FixedNote = contract.FixedNote;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultIssueData data, CrudeDefaultIssueContract contract) {
            contract.DefaultIssueId = data.DefaultIssueId;
            contract.DefaultIssueTypeRcd = data.DefaultIssueTypeRcd;
            contract.DefaultIssueStatusRcd = data.DefaultIssueStatusRcd;
            contract.DefaultErrorId = data.DefaultErrorId;
            contract.IssueName = data.IssueName;
            contract.IssueDescription = data.IssueDescription;
            contract.StepsToReproduce = data.StepsToReproduce;
            contract.Link = data.Link;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
            contract.FixedNote = data.FixedNote;
        }
    }
}
