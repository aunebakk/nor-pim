/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:18:24 PM
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
    public partial interface ICrudeDefaultTestService {
        
        [OperationContract()]
        CrudeDefaultTestContract FetchByDefaultTestId(System.Guid defaultTestId);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeDefaultTestContract FetchBySystemName(string systemName);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultTestContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultTestContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultTestId);
    }
    
    public partial class CrudeDefaultTestService : ICrudeDefaultTestService {
        
        public CrudeDefaultTestContract FetchByDefaultTestId(System.Guid defaultTestId) {
            var dataAccessLayer = new CrudeDefaultTestData();
            var contract = new CrudeDefaultTestContract();

            dataAccessLayer.FetchByDefaultTestId(defaultTestId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultTestContract FetchBySystemName(string systemName) {
            var dataAccessLayer = new CrudeDefaultTestData();
            var contract = new CrudeDefaultTestContract();

            dataAccessLayer.FetchBySystemName(systemName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultTestContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeDefaultTestData.FetchByUserId(userId));
        }
        
        public static List<CrudeDefaultTestContract> DataListToContractList(List<CrudeDefaultTestData> dataList) {
            var contractList = new List<CrudeDefaultTestContract>();

            foreach (CrudeDefaultTestData data in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultTestContract> contractList, List<CrudeDefaultTestData> dataList) {
            foreach (CrudeDefaultTestContract contract in contractList) {
                var data = new CrudeDefaultTestData();
                CrudeDefaultTestService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultTestContract> FetchAll() {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAll();

            foreach (CrudeDefaultTestData crudeDefaultTest in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(crudeDefaultTest, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultTestContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultTestData crudeDefaultTest in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(crudeDefaultTest, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultTestContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultTestData crudeDefaultTest in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(crudeDefaultTest, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultTestData.FetchAllCount();
        }
        
        public List<CrudeDefaultTestContract> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchWithFilter(
                defaultTestId: defaultTestId,
                systemName: systemName,
                testArea: testArea,
                testSubArea: testSubArea,
                testAddress: testAddress,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultTestData data in dataList) {
                var crudeDefaultTestContract = new CrudeDefaultTestContract();
                DataToContract(data, crudeDefaultTestContract);
                list.Add(crudeDefaultTestContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultTestContract contract) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultTestContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultTestContract contract) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultTestContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultTestId) {
            CrudeDefaultTestData.Delete(defaultTestId);
        }
        
        public static void ContractToData(CrudeDefaultTestContract contract, CrudeDefaultTestData data) {
            data.DefaultTestId = contract.DefaultTestId;
            data.SystemName = contract.SystemName;
            data.TestArea = contract.TestArea;
            data.TestSubArea = contract.TestSubArea;
            data.TestAddress = contract.TestAddress;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultTestData data, CrudeDefaultTestContract contract) {
            contract.DefaultTestId = data.DefaultTestId;
            contract.SystemName = data.SystemName;
            contract.TestArea = data.TestArea;
            contract.TestSubArea = data.TestSubArea;
            contract.TestAddress = data.TestAddress;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
