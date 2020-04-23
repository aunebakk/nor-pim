/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:43:30 AM
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
    public partial interface ICrudeFinancialTaxService {
        
        [OperationContract()]
        CrudeFinancialTaxContract FetchByFinancialTaxId(System.Guid financialTaxId);
        
        [OperationContract()]
        List<CrudeFinancialTaxContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialTaxContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialTaxContract> FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialTaxContract> FetchWithFilter(System.Guid financialTaxId, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialCurrencyId, decimal amount);
        
        [OperationContract()]
        List<CrudeFinancialTaxContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialTaxContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialTaxContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialTaxContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialTaxContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialTaxId);
    }
    
    public partial class CrudeFinancialTaxService : ICrudeFinancialTaxService {
        
        public CrudeFinancialTaxContract FetchByFinancialTaxId(System.Guid financialTaxId) {
            var dataAccessLayer = new CrudeFinancialTaxData();
            var contract = new CrudeFinancialTaxContract();

            dataAccessLayer.FetchByFinancialTaxId(financialTaxId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialTaxContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialTaxData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialTaxContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialTaxData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialTaxContract> FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            return DataListToContractList(CrudeFinancialTaxData.FetchByFinancialTaxTypeRcd(financialTaxTypeRcd));
        }
        
        public static List<CrudeFinancialTaxContract> DataListToContractList(List<CrudeFinancialTaxData> dataList) {
            var contractList = new List<CrudeFinancialTaxContract>();

            foreach (CrudeFinancialTaxData data in dataList) {
                var contract = new CrudeFinancialTaxContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialTaxContract> contractList, List<CrudeFinancialTaxData> dataList) {
            foreach (CrudeFinancialTaxContract contract in contractList) {
                var data = new CrudeFinancialTaxData();
                CrudeFinancialTaxService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialTaxContract> FetchAll() {
            var list = new List<CrudeFinancialTaxContract>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchAll();

            foreach (CrudeFinancialTaxData crudeFinancialTax in dataList) {
                var contract = new CrudeFinancialTaxContract();
                DataToContract(crudeFinancialTax, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialTaxContract>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialTaxData crudeFinancialTax in dataList) {
                var contract = new CrudeFinancialTaxContract();
                DataToContract(crudeFinancialTax, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialTaxContract>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialTaxData crudeFinancialTax in dataList) {
                var contract = new CrudeFinancialTaxContract();
                DataToContract(crudeFinancialTax, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialTaxData.FetchAllCount();
        }
        
        public List<CrudeFinancialTaxContract> FetchWithFilter(System.Guid financialTaxId, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialCurrencyId, decimal amount) {
            var list = new List<CrudeFinancialTaxContract>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchWithFilter(
                financialTaxId: financialTaxId,
                financialTaxTypeRcd: financialTaxTypeRcd,
                userId: userId,
                dateTime: dateTime,
                financialCurrencyId: financialCurrencyId,
                amount: amount
                );

            foreach (CrudeFinancialTaxData data in dataList) {
                var crudeFinancialTaxContract = new CrudeFinancialTaxContract();
                DataToContract(data, crudeFinancialTaxContract);
                list.Add(crudeFinancialTaxContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialTaxContract contract) {
            var data = new CrudeFinancialTaxData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialTaxContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialTaxContract contract) {
            var data = new CrudeFinancialTaxData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialTaxContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialTaxId) {
            CrudeFinancialTaxData.Delete(financialTaxId);
        }
        
        public static void ContractToData(CrudeFinancialTaxContract contract, CrudeFinancialTaxData data) {
            data.FinancialTaxId = contract.FinancialTaxId;
            data.FinancialTaxTypeRcd = contract.FinancialTaxTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
        }
        
        public static void DataToContract(CrudeFinancialTaxData data, CrudeFinancialTaxContract contract) {
            contract.FinancialTaxId = data.FinancialTaxId;
            contract.FinancialTaxTypeRcd = data.FinancialTaxTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
        }
    }
}
