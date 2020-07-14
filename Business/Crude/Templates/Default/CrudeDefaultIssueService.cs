/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:57:15 AM
  From Machine: DESKTOP-00MSEIL
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

namespace SolutionNorSolutionPim.BusinessLogicLayer {

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
    
    public partial class CrudeDefaultIssueService : ICrudeDefaultIssueService {
        
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
        
        public List<CrudeDefaultIssueContract> FetchByDefaultErrorId(System.Guid defaultErrorId) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultErrorId(defaultErrorId));
        }
        
        public List<CrudeDefaultIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultUserId(defaultUserId));
        }
        
        public List<CrudeDefaultIssueContract> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd));
        }
        
        public List<CrudeDefaultIssueContract> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            return DataListToContractList(CrudeDefaultIssueData.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd));
        }
        
        public static List<CrudeDefaultIssueContract> DataListToContractList(List<CrudeDefaultIssueData> dataList) {
            var contractList = new List<CrudeDefaultIssueContract>();

            foreach (CrudeDefaultIssueData data in dataList) {
                var contract = new CrudeDefaultIssueContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultIssueContract> contractList, List<CrudeDefaultIssueData> dataList) {
            foreach (CrudeDefaultIssueContract contract in contractList) {
                var data = new CrudeDefaultIssueData();
                CrudeDefaultIssueService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
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
        
        public int FetchAllCount() {
            return CrudeDefaultIssueData.FetchAllCount();
        }
        
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
        
        public void Insert(CrudeDefaultIssueContract contract) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultIssueContract contract) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultIssueId) {
            CrudeDefaultIssueData.Delete(defaultIssueId);
        }
        
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
