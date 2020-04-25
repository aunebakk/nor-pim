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
    public partial interface ICrudeFinancialAdjustmentTypeRefService {
        
        [OperationContract()]
        CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeName(string financialAdjustmentTypeName);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentTypeRefContract> FetchWithFilter(string financialAdjustmentTypeRcd, string financialAdjustmentTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialAdjustmentTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialAdjustmentTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialAdjustmentTypeRcd);
    }
    
    public partial class CrudeFinancialAdjustmentTypeRefService : ICrudeFinancialAdjustmentTypeRefService {
        
        public CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd) {
            var dataAccessLayer = new CrudeFinancialAdjustmentTypeRefData();
            var contract = new CrudeFinancialAdjustmentTypeRefContract();

            dataAccessLayer.FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialAdjustmentTypeRefContract FetchByFinancialAdjustmentTypeName(string financialAdjustmentTypeName) {
            var dataAccessLayer = new CrudeFinancialAdjustmentTypeRefData();
            var contract = new CrudeFinancialAdjustmentTypeRefContract();

            dataAccessLayer.FetchByFinancialAdjustmentTypeName(financialAdjustmentTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialAdjustmentTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialAdjustmentTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialAdjustmentTypeRefContract> DataListToContractList(List<CrudeFinancialAdjustmentTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialAdjustmentTypeRefContract>();

            foreach (CrudeFinancialAdjustmentTypeRefData data in dataList) {
                var contract = new CrudeFinancialAdjustmentTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialAdjustmentTypeRefContract> contractList, List<CrudeFinancialAdjustmentTypeRefData> dataList) {
            foreach (CrudeFinancialAdjustmentTypeRefContract contract in contractList) {
                var data = new CrudeFinancialAdjustmentTypeRefData();
                CrudeFinancialAdjustmentTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialAdjustmentTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialAdjustmentTypeRefContract>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchAll();

            foreach (CrudeFinancialAdjustmentTypeRefData crudeFinancialAdjustmentTypeRef in dataList) {
                var contract = new CrudeFinancialAdjustmentTypeRefContract();
                DataToContract(crudeFinancialAdjustmentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialAdjustmentTypeRefContract>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialAdjustmentTypeRefData crudeFinancialAdjustmentTypeRef in dataList) {
                var contract = new CrudeFinancialAdjustmentTypeRefContract();
                DataToContract(crudeFinancialAdjustmentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialAdjustmentTypeRefContract>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialAdjustmentTypeRefData crudeFinancialAdjustmentTypeRef in dataList) {
                var contract = new CrudeFinancialAdjustmentTypeRefContract();
                DataToContract(crudeFinancialAdjustmentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialAdjustmentTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialAdjustmentTypeRefContract> FetchWithFilter(string financialAdjustmentTypeRcd, string financialAdjustmentTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialAdjustmentTypeRefContract>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchWithFilter(
                financialAdjustmentTypeRcd: financialAdjustmentTypeRcd,
                financialAdjustmentTypeName: financialAdjustmentTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialAdjustmentTypeRefData data in dataList) {
                var crudeFinancialAdjustmentTypeRefContract = new CrudeFinancialAdjustmentTypeRefContract();
                DataToContract(data, crudeFinancialAdjustmentTypeRefContract);
                list.Add(crudeFinancialAdjustmentTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialAdjustmentTypeRefContract contract) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialAdjustmentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialAdjustmentTypeRefContract contract) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialAdjustmentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialAdjustmentTypeRcd) {
            CrudeFinancialAdjustmentTypeRefData.Delete(financialAdjustmentTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialAdjustmentTypeRefContract contract, CrudeFinancialAdjustmentTypeRefData data) {
            data.FinancialAdjustmentTypeRcd = contract.FinancialAdjustmentTypeRcd;
            data.FinancialAdjustmentTypeName = contract.FinancialAdjustmentTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialAdjustmentTypeRefData data, CrudeFinancialAdjustmentTypeRefContract contract) {
            contract.FinancialAdjustmentTypeRcd = data.FinancialAdjustmentTypeRcd;
            contract.FinancialAdjustmentTypeName = data.FinancialAdjustmentTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
