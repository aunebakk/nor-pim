/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:25:39 AM
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

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface ICrudeDefaultPerformanceTimeRollupService {
        
        [OperationContract()]
        CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultPerformanceTimeRollupContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultPerformanceTimeRollupContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultPerformanceTimeRollupId);
    }
    
    public partial class CrudeDefaultPerformanceTimeRollupService : ICrudeDefaultPerformanceTimeRollupService {
        
        public CrudeDefaultPerformanceTimeRollupContract FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeRollupData();
            var contract = new CrudeDefaultPerformanceTimeRollupContract();

            dataAccessLayer.FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultPerformanceTimeRollupContract FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeRollupData();
            var contract = new CrudeDefaultPerformanceTimeRollupContract();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultPerformanceTimeRollupData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultPerformanceTimeRollupContract> DataListToContractList(List<CrudeDefaultPerformanceTimeRollupData> dataList) {
            var contractList = new List<CrudeDefaultPerformanceTimeRollupContract>();

            foreach (CrudeDefaultPerformanceTimeRollupData data in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultPerformanceTimeRollupContract> contractList, List<CrudeDefaultPerformanceTimeRollupData> dataList) {
            foreach (CrudeDefaultPerformanceTimeRollupContract contract in contractList) {
                var data = new CrudeDefaultPerformanceTimeRollupData();
                CrudeDefaultPerformanceTimeRollupService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchAll() {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAll();

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollup in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(crudeDefaultPerformanceTimeRollup, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollup in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(crudeDefaultPerformanceTimeRollup, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollup in dataList) {
                var contract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(crudeDefaultPerformanceTimeRollup, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultPerformanceTimeRollupData.FetchAllCount();
        }
        
        public List<CrudeDefaultPerformanceTimeRollupContract> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceTimeRollupContract>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchWithFilter(
                defaultPerformanceTimeRollupId: defaultPerformanceTimeRollupId,
                commandName: commandName,
                milliseconds: milliseconds,
                hits: hits,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultPerformanceTimeRollupData data in dataList) {
                var crudeDefaultPerformanceTimeRollupContract = new CrudeDefaultPerformanceTimeRollupContract();
                DataToContract(data, crudeDefaultPerformanceTimeRollupContract);
                list.Add(crudeDefaultPerformanceTimeRollupContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultPerformanceTimeRollupContract contract) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultPerformanceTimeRollupContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultPerformanceTimeRollupContract contract) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultPerformanceTimeRollupContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultPerformanceTimeRollupId) {
            CrudeDefaultPerformanceTimeRollupData.Delete(defaultPerformanceTimeRollupId);
        }
        
        public static void ContractToData(CrudeDefaultPerformanceTimeRollupContract contract, CrudeDefaultPerformanceTimeRollupData data) {
            data.DefaultPerformanceTimeRollupId = contract.DefaultPerformanceTimeRollupId;
            data.CommandName = contract.CommandName;
            data.Milliseconds = contract.Milliseconds;
            data.Hits = contract.Hits;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultPerformanceTimeRollupData data, CrudeDefaultPerformanceTimeRollupContract contract) {
            contract.DefaultPerformanceTimeRollupId = data.DefaultPerformanceTimeRollupId;
            contract.CommandName = data.CommandName;
            contract.Milliseconds = data.Milliseconds;
            contract.Hits = data.Hits;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
