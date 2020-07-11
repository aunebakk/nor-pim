/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:25:42 AM
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
    public partial interface ICrudeDefaultTestRunService {
        
        [OperationContract()]
        CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId);
        
        [OperationContract()]
        List<CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId);
        
        [OperationContract()]
        List<CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd);
        
        [OperationContract()]
        List<CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultTestRunContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultTestRunContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultTestRunContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultTestRunContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultTestRunId);
    }
    
    public partial class CrudeDefaultTestRunService : ICrudeDefaultTestRunService {
        
        public CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId) {
            var dataAccessLayer = new CrudeDefaultTestRunData();
            var contract = new CrudeDefaultTestRunContract();

            dataAccessLayer.FetchByDefaultTestRunId(defaultTestRunId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId) {
            return DataListToContractList(CrudeDefaultTestRunData.FetchByDefaultTestId(defaultTestId));
        }
        
        public List<CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeDefaultTestRunData.FetchByUserId(userId));
        }
        
        public List<CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            return DataListToContractList(CrudeDefaultTestRunData.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd));
        }
        
        public static List<CrudeDefaultTestRunContract> DataListToContractList(List<CrudeDefaultTestRunData> dataList) {
            var contractList = new List<CrudeDefaultTestRunContract>();

            foreach (CrudeDefaultTestRunData data in dataList) {
                var contract = new CrudeDefaultTestRunContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultTestRunContract> contractList, List<CrudeDefaultTestRunData> dataList) {
            foreach (CrudeDefaultTestRunContract contract in contractList) {
                var data = new CrudeDefaultTestRunData();
                CrudeDefaultTestRunService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultTestRunContract> FetchAll() {
            var list = new List<CrudeDefaultTestRunContract>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchAll();

            foreach (CrudeDefaultTestRunData crudeDefaultTestRun in dataList) {
                var contract = new CrudeDefaultTestRunContract();
                DataToContract(crudeDefaultTestRun, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultTestRunContract>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultTestRunData crudeDefaultTestRun in dataList) {
                var contract = new CrudeDefaultTestRunContract();
                DataToContract(crudeDefaultTestRun, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultTestRunContract>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultTestRunData crudeDefaultTestRun in dataList) {
                var contract = new CrudeDefaultTestRunContract();
                DataToContract(crudeDefaultTestRun, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultTestRunData.FetchAllCount();
        }
        
        public List<CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestRunContract>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchWithFilter(
                defaultTestRunId: defaultTestRunId,
                defaultTestId: defaultTestId,
                defaultTestRunResultRcd: defaultTestRunResultRcd,
                result: result,
                startDateTime: startDateTime,
                endDateTime: endDateTime,
                elapsedMilliseconds: elapsedMilliseconds,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultTestRunData data in dataList) {
                var crudeDefaultTestRunContract = new CrudeDefaultTestRunContract();
                DataToContract(data, crudeDefaultTestRunContract);
                list.Add(crudeDefaultTestRunContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultTestRunContract contract) {
            var data = new CrudeDefaultTestRunData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultTestRunContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultTestRunContract contract) {
            var data = new CrudeDefaultTestRunData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultTestRunContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultTestRunId) {
            CrudeDefaultTestRunData.Delete(defaultTestRunId);
        }
        
        public static void ContractToData(CrudeDefaultTestRunContract contract, CrudeDefaultTestRunData data) {
            data.DefaultTestRunId = contract.DefaultTestRunId;
            data.DefaultTestId = contract.DefaultTestId;
            data.DefaultTestRunResultRcd = contract.DefaultTestRunResultRcd;
            data.Result = contract.Result;
            data.StartDateTime = contract.StartDateTime;
            data.EndDateTime = contract.EndDateTime;
            data.ElapsedMilliseconds = contract.ElapsedMilliseconds;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultTestRunData data, CrudeDefaultTestRunContract contract) {
            contract.DefaultTestRunId = data.DefaultTestRunId;
            contract.DefaultTestId = data.DefaultTestId;
            contract.DefaultTestRunResultRcd = data.DefaultTestRunResultRcd;
            contract.Result = data.Result;
            contract.StartDateTime = data.StartDateTime;
            contract.EndDateTime = data.EndDateTime;
            contract.ElapsedMilliseconds = data.ElapsedMilliseconds;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
