/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:41:03 AM
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
    public partial interface ICrudeFinancialAdjustmentService {
        
        [OperationContract()]
        CrudeFinancialAdjustmentContract FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentContract> FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentContract> FetchWithFilter(System.Guid financialAdjustmentId, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialAdjustmentTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialAdjustmentContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialAdjustmentContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialAdjustmentId);
    }
    
    public partial class CrudeFinancialAdjustmentService : ICrudeFinancialAdjustmentService {
        
        public CrudeFinancialAdjustmentContract FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            var dataAccessLayer = new CrudeFinancialAdjustmentData();
            var contract = new CrudeFinancialAdjustmentContract();

            dataAccessLayer.FetchByFinancialAdjustmentId(financialAdjustmentId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialAdjustmentContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialAdjustmentData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialAdjustmentContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialAdjustmentData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialAdjustmentContract> FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd) {
            return DataListToContractList(CrudeFinancialAdjustmentData.FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd));
        }
        
        public static List<CrudeFinancialAdjustmentContract> DataListToContractList(List<CrudeFinancialAdjustmentData> dataList) {
            var contractList = new List<CrudeFinancialAdjustmentContract>();

            foreach (CrudeFinancialAdjustmentData data in dataList) {
                var contract = new CrudeFinancialAdjustmentContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialAdjustmentContract> contractList, List<CrudeFinancialAdjustmentData> dataList) {
            foreach (CrudeFinancialAdjustmentContract contract in contractList) {
                var data = new CrudeFinancialAdjustmentData();
                CrudeFinancialAdjustmentService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialAdjustmentContract> FetchAll() {
            var list = new List<CrudeFinancialAdjustmentContract>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchAll();

            foreach (CrudeFinancialAdjustmentData crudeFinancialAdjustment in dataList) {
                var contract = new CrudeFinancialAdjustmentContract();
                DataToContract(crudeFinancialAdjustment, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialAdjustmentContract>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialAdjustmentData crudeFinancialAdjustment in dataList) {
                var contract = new CrudeFinancialAdjustmentContract();
                DataToContract(crudeFinancialAdjustment, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialAdjustmentContract>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialAdjustmentData crudeFinancialAdjustment in dataList) {
                var contract = new CrudeFinancialAdjustmentContract();
                DataToContract(crudeFinancialAdjustment, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialAdjustmentData.FetchAllCount();
        }
        
        public List<CrudeFinancialAdjustmentContract> FetchWithFilter(System.Guid financialAdjustmentId, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialAdjustmentTypeRcd) {
            var list = new List<CrudeFinancialAdjustmentContract>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchWithFilter(
                financialAdjustmentId: financialAdjustmentId,
                amount: amount,
                financialCurrencyId: financialCurrencyId,
                userId: userId,
                dateTime: dateTime,
                financialAdjustmentTypeRcd: financialAdjustmentTypeRcd
                );

            foreach (CrudeFinancialAdjustmentData data in dataList) {
                var crudeFinancialAdjustmentContract = new CrudeFinancialAdjustmentContract();
                DataToContract(data, crudeFinancialAdjustmentContract);
                list.Add(crudeFinancialAdjustmentContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialAdjustmentContract contract) {
            var data = new CrudeFinancialAdjustmentData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialAdjustmentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialAdjustmentContract contract) {
            var data = new CrudeFinancialAdjustmentData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialAdjustmentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialAdjustmentId) {
            CrudeFinancialAdjustmentData.Delete(financialAdjustmentId);
        }
        
        public static void ContractToData(CrudeFinancialAdjustmentContract contract, CrudeFinancialAdjustmentData data) {
            data.FinancialAdjustmentId = contract.FinancialAdjustmentId;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.FinancialAdjustmentTypeRcd = contract.FinancialAdjustmentTypeRcd;
        }
        
        public static void DataToContract(CrudeFinancialAdjustmentData data, CrudeFinancialAdjustmentContract contract) {
            contract.FinancialAdjustmentId = data.FinancialAdjustmentId;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.FinancialAdjustmentTypeRcd = data.FinancialAdjustmentTypeRcd;
        }
    }
}
