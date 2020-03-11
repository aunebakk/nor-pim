/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:56:26 PM
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
    public partial interface ICrudeFinancialCurrencyTypeRefService {
        
        [OperationContract()]
        CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyTypeRefContract> FetchWithFilter(string financialCurrencyTypeRcd, string financialCurrencyTypeName, System.Guid userId, System.DateTime dateTime, int decimalCount, string financialCurrencyTypeCode);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCurrencyTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCurrencyTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialCurrencyTypeRcd);
    }
    
    public partial class CrudeFinancialCurrencyTypeRefService : ICrudeFinancialCurrencyTypeRefService {
        
        public CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            var dataAccessLayer = new CrudeFinancialCurrencyTypeRefData();
            var contract = new CrudeFinancialCurrencyTypeRefContract();

            dataAccessLayer.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialCurrencyTypeRefContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            var dataAccessLayer = new CrudeFinancialCurrencyTypeRefData();
            var contract = new CrudeFinancialCurrencyTypeRefContract();

            dataAccessLayer.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialCurrencyTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCurrencyTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCurrencyTypeRefContract> DataListToContractList(List<CrudeFinancialCurrencyTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialCurrencyTypeRefContract>();

            foreach (CrudeFinancialCurrencyTypeRefData data in dataList) {
                var contract = new CrudeFinancialCurrencyTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialCurrencyTypeRefContract> contractList, List<CrudeFinancialCurrencyTypeRefData> dataList) {
            foreach (CrudeFinancialCurrencyTypeRefContract contract in contractList) {
                var data = new CrudeFinancialCurrencyTypeRefData();
                CrudeFinancialCurrencyTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCurrencyTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialCurrencyTypeRefContract>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchAll();

            foreach (CrudeFinancialCurrencyTypeRefData crudeFinancialCurrencyTypeRef in dataList) {
                var contract = new CrudeFinancialCurrencyTypeRefContract();
                DataToContract(crudeFinancialCurrencyTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCurrencyTypeRefContract>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCurrencyTypeRefData crudeFinancialCurrencyTypeRef in dataList) {
                var contract = new CrudeFinancialCurrencyTypeRefContract();
                DataToContract(crudeFinancialCurrencyTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCurrencyTypeRefContract>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCurrencyTypeRefData crudeFinancialCurrencyTypeRef in dataList) {
                var contract = new CrudeFinancialCurrencyTypeRefContract();
                DataToContract(crudeFinancialCurrencyTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCurrencyTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialCurrencyTypeRefContract> FetchWithFilter(string financialCurrencyTypeRcd, string financialCurrencyTypeName, System.Guid userId, System.DateTime dateTime, int decimalCount, string financialCurrencyTypeCode) {
            var list = new List<CrudeFinancialCurrencyTypeRefContract>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchWithFilter(
                financialCurrencyTypeRcd: financialCurrencyTypeRcd,
                financialCurrencyTypeName: financialCurrencyTypeName,
                userId: userId,
                dateTime: dateTime,
                decimalCount: decimalCount,
                financialCurrencyTypeCode: financialCurrencyTypeCode
                );

            foreach (CrudeFinancialCurrencyTypeRefData data in dataList) {
                var crudeFinancialCurrencyTypeRefContract = new CrudeFinancialCurrencyTypeRefContract();
                DataToContract(data, crudeFinancialCurrencyTypeRefContract);
                list.Add(crudeFinancialCurrencyTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCurrencyTypeRefContract contract) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCurrencyTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCurrencyTypeRefContract contract) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCurrencyTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialCurrencyTypeRcd) {
            CrudeFinancialCurrencyTypeRefData.Delete(financialCurrencyTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialCurrencyTypeRefContract contract, CrudeFinancialCurrencyTypeRefData data) {
            data.FinancialCurrencyTypeRcd = contract.FinancialCurrencyTypeRcd;
            data.FinancialCurrencyTypeName = contract.FinancialCurrencyTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.DecimalCount = contract.DecimalCount;
            data.FinancialCurrencyTypeCode = contract.FinancialCurrencyTypeCode;
        }
        
        public static void DataToContract(CrudeFinancialCurrencyTypeRefData data, CrudeFinancialCurrencyTypeRefContract contract) {
            contract.FinancialCurrencyTypeRcd = data.FinancialCurrencyTypeRcd;
            contract.FinancialCurrencyTypeName = data.FinancialCurrencyTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.DecimalCount = data.DecimalCount;
            contract.FinancialCurrencyTypeCode = data.FinancialCurrencyTypeCode;
        }
    }
}
