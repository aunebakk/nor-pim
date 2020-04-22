/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:51:09 AM
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
    public partial interface ICrudeFinancialOrderSourceRefService {
        
        [OperationContract()]
        CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderSourceRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceName(string financialOrderSourceName);
        
        [OperationContract()]
        List<CrudeFinancialOrderSourceRefContract> FetchWithFilter(string financialOrderSourceRcd, string financialOrderSourceName, string financialOrderSourceCode, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialOrderSourceRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderSourceRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderSourceRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderSourceRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderSourceRefContract contract);
        
        [OperationContract()]
        void Delete(string financialOrderSourceRcd);
    }
    
    public partial class CrudeFinancialOrderSourceRefService : ICrudeFinancialOrderSourceRefService {
        
        public CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            var dataAccessLayer = new CrudeFinancialOrderSourceRefData();
            var contract = new CrudeFinancialOrderSourceRefContract();

            dataAccessLayer.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialOrderSourceRefContract FetchByFinancialOrderSourceName(string financialOrderSourceName) {
            var dataAccessLayer = new CrudeFinancialOrderSourceRefData();
            var contract = new CrudeFinancialOrderSourceRefContract();

            dataAccessLayer.FetchByFinancialOrderSourceName(financialOrderSourceName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderSourceRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderSourceRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderSourceRefContract> DataListToContractList(List<CrudeFinancialOrderSourceRefData> dataList) {
            var contractList = new List<CrudeFinancialOrderSourceRefContract>();

            foreach (CrudeFinancialOrderSourceRefData data in dataList) {
                var contract = new CrudeFinancialOrderSourceRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderSourceRefContract> contractList, List<CrudeFinancialOrderSourceRefData> dataList) {
            foreach (CrudeFinancialOrderSourceRefContract contract in contractList) {
                var data = new CrudeFinancialOrderSourceRefData();
                CrudeFinancialOrderSourceRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderSourceRefContract> FetchAll() {
            var list = new List<CrudeFinancialOrderSourceRefContract>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchAll();

            foreach (CrudeFinancialOrderSourceRefData crudeFinancialOrderSourceRef in dataList) {
                var contract = new CrudeFinancialOrderSourceRefContract();
                DataToContract(crudeFinancialOrderSourceRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderSourceRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderSourceRefContract>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderSourceRefData crudeFinancialOrderSourceRef in dataList) {
                var contract = new CrudeFinancialOrderSourceRefContract();
                DataToContract(crudeFinancialOrderSourceRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderSourceRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderSourceRefContract>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderSourceRefData crudeFinancialOrderSourceRef in dataList) {
                var contract = new CrudeFinancialOrderSourceRefContract();
                DataToContract(crudeFinancialOrderSourceRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderSourceRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderSourceRefContract> FetchWithFilter(string financialOrderSourceRcd, string financialOrderSourceName, string financialOrderSourceCode, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderSourceRefContract>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchWithFilter(
                financialOrderSourceRcd: financialOrderSourceRcd,
                financialOrderSourceName: financialOrderSourceName,
                financialOrderSourceCode: financialOrderSourceCode,
                sortSequenceNumber: sortSequenceNumber,
                changeFlag: changeFlag,
                statusCode: statusCode,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialOrderSourceRefData data in dataList) {
                var crudeFinancialOrderSourceRefContract = new CrudeFinancialOrderSourceRefContract();
                DataToContract(data, crudeFinancialOrderSourceRefContract);
                list.Add(crudeFinancialOrderSourceRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderSourceRefContract contract) {
            var data = new CrudeFinancialOrderSourceRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderSourceRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderSourceRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderSourceRefContract contract) {
            var data = new CrudeFinancialOrderSourceRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderSourceRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderSourceRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderSourceRcd) {
            CrudeFinancialOrderSourceRefData.Delete(financialOrderSourceRcd);
        }
        
        public static void ContractToData(CrudeFinancialOrderSourceRefContract contract, CrudeFinancialOrderSourceRefData data) {
            data.FinancialOrderSourceRcd = contract.FinancialOrderSourceRcd;
            data.FinancialOrderSourceName = contract.FinancialOrderSourceName;
            data.FinancialOrderSourceCode = contract.FinancialOrderSourceCode;
            data.SortSequenceNumber = contract.SortSequenceNumber;
            data.ChangeFlag = contract.ChangeFlag;
            data.StatusCode = contract.StatusCode;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialOrderSourceRefData data, CrudeFinancialOrderSourceRefContract contract) {
            contract.FinancialOrderSourceRcd = data.FinancialOrderSourceRcd;
            contract.FinancialOrderSourceName = data.FinancialOrderSourceName;
            contract.FinancialOrderSourceCode = data.FinancialOrderSourceCode;
            contract.SortSequenceNumber = data.SortSequenceNumber;
            contract.ChangeFlag = data.ChangeFlag;
            contract.StatusCode = data.StatusCode;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
