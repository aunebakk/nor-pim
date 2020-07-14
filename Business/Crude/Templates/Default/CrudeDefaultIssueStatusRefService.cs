/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:12:11 AM
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
    
    public partial class CrudeDefaultIssueStatusRefService : ICrudeDefaultIssueStatusRefService {
        
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
