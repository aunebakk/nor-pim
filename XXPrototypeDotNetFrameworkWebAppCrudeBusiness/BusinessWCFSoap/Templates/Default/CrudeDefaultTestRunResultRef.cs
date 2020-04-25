/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:23:37 PM
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
    public partial interface ICrudeDefaultTestRunResultRefService {
        
        [OperationContract()]
        CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultName(string defaultTestRunResultName);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultTestRunResultRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultTestRunResultRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultTestRunResultRcd);
    }
    
    public partial class CrudeDefaultTestRunResultRefService : ICrudeDefaultTestRunResultRefService {
        
        public CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            var dataAccessLayer = new CrudeDefaultTestRunResultRefData();
            var contract = new CrudeDefaultTestRunResultRefContract();

            dataAccessLayer.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultName(string defaultTestRunResultName) {
            var dataAccessLayer = new CrudeDefaultTestRunResultRefData();
            var contract = new CrudeDefaultTestRunResultRefContract();

            dataAccessLayer.FetchByDefaultTestRunResultName(defaultTestRunResultName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultTestRunResultRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeDefaultTestRunResultRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeDefaultTestRunResultRefContract> DataListToContractList(List<CrudeDefaultTestRunResultRefData> dataList) {
            var contractList = new List<CrudeDefaultTestRunResultRefContract>();

            foreach (CrudeDefaultTestRunResultRefData data in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultTestRunResultRefContract> contractList, List<CrudeDefaultTestRunResultRefData> dataList) {
            foreach (CrudeDefaultTestRunResultRefContract contract in contractList) {
                var data = new CrudeDefaultTestRunResultRefData();
                CrudeDefaultTestRunResultRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultTestRunResultRefContract> FetchAll() {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAll();

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRef in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(crudeDefaultTestRunResultRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRef in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(crudeDefaultTestRunResultRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunResultRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRef in dataList) {
                var contract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(crudeDefaultTestRunResultRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultTestRunResultRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultTestRunResultRefContract> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestRunResultRefContract>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchWithFilter(
                defaultTestRunResultRcd: defaultTestRunResultRcd,
                defaultTestRunResultName: defaultTestRunResultName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultTestRunResultRefData data in dataList) {
                var crudeDefaultTestRunResultRefContract = new CrudeDefaultTestRunResultRefContract();
                DataToContract(data, crudeDefaultTestRunResultRefContract);
                list.Add(crudeDefaultTestRunResultRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultTestRunResultRefContract contract) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultTestRunResultRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultTestRunResultRefContract contract) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultTestRunResultRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunResultRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultTestRunResultRcd) {
            CrudeDefaultTestRunResultRefData.Delete(defaultTestRunResultRcd);
        }
        
        public static void ContractToData(CrudeDefaultTestRunResultRefContract contract, CrudeDefaultTestRunResultRefData data) {
            data.DefaultTestRunResultRcd = contract.DefaultTestRunResultRcd;
            data.DefaultTestRunResultName = contract.DefaultTestRunResultName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultTestRunResultRefData data, CrudeDefaultTestRunResultRefContract contract) {
            contract.DefaultTestRunResultRcd = data.DefaultTestRunResultRcd;
            contract.DefaultTestRunResultName = data.DefaultTestRunResultName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
