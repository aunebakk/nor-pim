/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:41:47 AM
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
    public partial interface ICrudeFinancialFeeService {
        
        [OperationContract()]
        CrudeFinancialFeeContract FetchByFinancialFeeId(System.Guid financialFeeId);
        
        [OperationContract()]
        List<CrudeFinancialFeeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialFeeContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialFeeContract> FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialFeeContract> FetchWithFilter(System.Guid financialFeeId, System.Guid userId, System.DateTime dateTime, string financialFeeTypeRcd, System.Guid financialCurrencyId, decimal amount);
        
        [OperationContract()]
        List<CrudeFinancialFeeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialFeeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialFeeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialFeeContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialFeeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialFeeId);
    }
    
    public partial class CrudeFinancialFeeService : ICrudeFinancialFeeService {
        
        public CrudeFinancialFeeContract FetchByFinancialFeeId(System.Guid financialFeeId) {
            var dataAccessLayer = new CrudeFinancialFeeData();
            var contract = new CrudeFinancialFeeContract();

            dataAccessLayer.FetchByFinancialFeeId(financialFeeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialFeeContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialFeeData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialFeeContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialFeeData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialFeeContract> FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd) {
            return DataListToContractList(CrudeFinancialFeeData.FetchByFinancialFeeTypeRcd(financialFeeTypeRcd));
        }
        
        public static List<CrudeFinancialFeeContract> DataListToContractList(List<CrudeFinancialFeeData> dataList) {
            var contractList = new List<CrudeFinancialFeeContract>();

            foreach (CrudeFinancialFeeData data in dataList) {
                var contract = new CrudeFinancialFeeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialFeeContract> contractList, List<CrudeFinancialFeeData> dataList) {
            foreach (CrudeFinancialFeeContract contract in contractList) {
                var data = new CrudeFinancialFeeData();
                CrudeFinancialFeeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialFeeContract> FetchAll() {
            var list = new List<CrudeFinancialFeeContract>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchAll();

            foreach (CrudeFinancialFeeData crudeFinancialFee in dataList) {
                var contract = new CrudeFinancialFeeContract();
                DataToContract(crudeFinancialFee, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialFeeContract>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialFeeData crudeFinancialFee in dataList) {
                var contract = new CrudeFinancialFeeContract();
                DataToContract(crudeFinancialFee, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialFeeContract>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialFeeData crudeFinancialFee in dataList) {
                var contract = new CrudeFinancialFeeContract();
                DataToContract(crudeFinancialFee, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialFeeData.FetchAllCount();
        }
        
        public List<CrudeFinancialFeeContract> FetchWithFilter(System.Guid financialFeeId, System.Guid userId, System.DateTime dateTime, string financialFeeTypeRcd, System.Guid financialCurrencyId, decimal amount) {
            var list = new List<CrudeFinancialFeeContract>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchWithFilter(
                financialFeeId: financialFeeId,
                userId: userId,
                dateTime: dateTime,
                financialFeeTypeRcd: financialFeeTypeRcd,
                financialCurrencyId: financialCurrencyId,
                amount: amount
                );

            foreach (CrudeFinancialFeeData data in dataList) {
                var crudeFinancialFeeContract = new CrudeFinancialFeeContract();
                DataToContract(data, crudeFinancialFeeContract);
                list.Add(crudeFinancialFeeContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialFeeContract contract) {
            var data = new CrudeFinancialFeeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialFeeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialFeeContract contract) {
            var data = new CrudeFinancialFeeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialFeeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialFeeId) {
            CrudeFinancialFeeData.Delete(financialFeeId);
        }
        
        public static void ContractToData(CrudeFinancialFeeContract contract, CrudeFinancialFeeData data) {
            data.FinancialFeeId = contract.FinancialFeeId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.FinancialFeeTypeRcd = contract.FinancialFeeTypeRcd;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
        }
        
        public static void DataToContract(CrudeFinancialFeeData data, CrudeFinancialFeeContract contract) {
            contract.FinancialFeeId = data.FinancialFeeId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.FinancialFeeTypeRcd = data.FinancialFeeTypeRcd;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
        }
    }
}
