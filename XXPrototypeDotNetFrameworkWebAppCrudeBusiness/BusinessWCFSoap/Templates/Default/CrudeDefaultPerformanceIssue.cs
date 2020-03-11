/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:56:07 PM
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
    public partial interface ICrudeDefaultPerformanceIssueService {
        
        [OperationContract()]
        CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultPerformanceIssueContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultPerformanceIssueContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultPerformanceIssueId);
    }
    
    public partial class CrudeDefaultPerformanceIssueService : ICrudeDefaultPerformanceIssueService {
        
        public CrudeDefaultPerformanceIssueContract FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            var dataAccessLayer = new CrudeDefaultPerformanceIssueData();
            var contract = new CrudeDefaultPerformanceIssueContract();

            dataAccessLayer.FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultPerformanceIssueContract FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceIssueData();
            var contract = new CrudeDefaultPerformanceIssueContract();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultPerformanceIssueContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultPerformanceIssueData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultPerformanceIssueContract> DataListToContractList(List<CrudeDefaultPerformanceIssueData> dataList) {
            var contractList = new List<CrudeDefaultPerformanceIssueContract>();

            foreach (CrudeDefaultPerformanceIssueData data in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultPerformanceIssueContract> contractList, List<CrudeDefaultPerformanceIssueData> dataList) {
            foreach (CrudeDefaultPerformanceIssueContract contract in contractList) {
                var data = new CrudeDefaultPerformanceIssueData();
                CrudeDefaultPerformanceIssueService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultPerformanceIssueContract> FetchAll() {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAll();

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssue in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(crudeDefaultPerformanceIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssue in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(crudeDefaultPerformanceIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceIssueContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssue in dataList) {
                var contract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(crudeDefaultPerformanceIssue, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultPerformanceIssueData.FetchAllCount();
        }
        
        public List<CrudeDefaultPerformanceIssueContract> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceIssueContract>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchWithFilter(
                defaultPerformanceIssueId: defaultPerformanceIssueId,
                commandName: commandName,
                commandText: commandText,
                milliseconds: milliseconds,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultPerformanceIssueData data in dataList) {
                var crudeDefaultPerformanceIssueContract = new CrudeDefaultPerformanceIssueContract();
                DataToContract(data, crudeDefaultPerformanceIssueContract);
                list.Add(crudeDefaultPerformanceIssueContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultPerformanceIssueContract contract) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultPerformanceIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultPerformanceIssueContract contract) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultPerformanceIssueContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceIssueData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultPerformanceIssueId) {
            CrudeDefaultPerformanceIssueData.Delete(defaultPerformanceIssueId);
        }
        
        public static void ContractToData(CrudeDefaultPerformanceIssueContract contract, CrudeDefaultPerformanceIssueData data) {
            data.DefaultPerformanceIssueId = contract.DefaultPerformanceIssueId;
            data.CommandName = contract.CommandName;
            data.CommandText = contract.CommandText;
            data.Milliseconds = contract.Milliseconds;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultPerformanceIssueData data, CrudeDefaultPerformanceIssueContract contract) {
            contract.DefaultPerformanceIssueId = data.DefaultPerformanceIssueId;
            contract.CommandName = data.CommandName;
            contract.CommandText = data.CommandText;
            contract.Milliseconds = data.Milliseconds;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
