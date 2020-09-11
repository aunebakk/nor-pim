/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:09 AM
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
    public partial interface ICrudeDefaultIssueStatusRefService {
        
        [OperationContract()]
        CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd);
        
        [OperationContract()]
        List<CrudeDefaultIssueStatusRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusName(string defaultIssueStatusName);
        
        [OperationContract()]
        List<CrudeDefaultIssueStatusRefContract> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultIssueStatusRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultIssueStatusRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultIssueStatusRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultIssueStatusRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultIssueStatusRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultIssueStatusRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_issue_status_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultIssueStatusRefService : ICrudeDefaultIssueStatusRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultIssueStatusRcd: primary key of table default_issue_status_ref
        public CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            var dataAccessLayer = new CrudeDefaultIssueStatusRefData();
            var contract = new CrudeDefaultIssueStatusRefContract();

            dataAccessLayer.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultIssueStatusRefContract FetchByDefaultIssueStatusName(string defaultIssueStatusName) {
            var dataAccessLayer = new CrudeDefaultIssueStatusRefData();
            var contract = new CrudeDefaultIssueStatusRefContract();

            dataAccessLayer.FetchByDefaultIssueStatusName(defaultIssueStatusName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultIssueStatusRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultIssueStatusRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultIssueStatusRefContract> DataListToContractList(List<CrudeDefaultIssueStatusRefData> dataList) {
            var contractList = new List<CrudeDefaultIssueStatusRefContract>();

            foreach (CrudeDefaultIssueStatusRefData data in dataList) {
                var contract = new CrudeDefaultIssueStatusRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultIssueStatusRefContract> contractList, List<CrudeDefaultIssueStatusRefData> dataList) {
            foreach (CrudeDefaultIssueStatusRefContract contract in contractList) {
                var data = new CrudeDefaultIssueStatusRefData();
                CrudeDefaultIssueStatusRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultIssueStatusRefContract> FetchAll() {
            var list = new List<CrudeDefaultIssueStatusRefContract>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchAll();

            foreach (CrudeDefaultIssueStatusRefData crudeDefaultIssueStatusRef in dataList) {
                var contract = new CrudeDefaultIssueStatusRefContract();
                DataToContract(crudeDefaultIssueStatusRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueStatusRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultIssueStatusRefContract>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultIssueStatusRefData crudeDefaultIssueStatusRef in dataList) {
                var contract = new CrudeDefaultIssueStatusRefContract();
                DataToContract(crudeDefaultIssueStatusRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueStatusRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultIssueStatusRefContract>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultIssueStatusRefData crudeDefaultIssueStatusRef in dataList) {
                var contract = new CrudeDefaultIssueStatusRefContract();
                DataToContract(crudeDefaultIssueStatusRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultIssueStatusRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultIssueStatusRefContract> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultIssueStatusRefContract>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchWithFilter(
                defaultIssueStatusRcd: defaultIssueStatusRcd,
                defaultIssueStatusName: defaultIssueStatusName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultIssueStatusRefData data in dataList) {
                var crudeDefaultIssueStatusRefContract = new CrudeDefaultIssueStatusRefContract();
                DataToContract(data, crudeDefaultIssueStatusRefContract);
                list.Add(crudeDefaultIssueStatusRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultIssueStatusRefContract contract) {
            var data = new CrudeDefaultIssueStatusRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultIssueStatusRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueStatusRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultIssueStatusRefContract contract) {
            var data = new CrudeDefaultIssueStatusRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultIssueStatusRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueStatusRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultIssueStatusRcd) {
            CrudeDefaultIssueStatusRefData.Delete(defaultIssueStatusRcd);
        }
        
        public static void ContractToData(CrudeDefaultIssueStatusRefContract contract, CrudeDefaultIssueStatusRefData data) {
            data.DefaultIssueStatusRcd = contract.DefaultIssueStatusRcd;
            data.DefaultIssueStatusName = contract.DefaultIssueStatusName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultIssueStatusRefData data, CrudeDefaultIssueStatusRefContract contract) {
            contract.DefaultIssueStatusRcd = data.DefaultIssueStatusRcd;
            contract.DefaultIssueStatusName = data.DefaultIssueStatusName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
