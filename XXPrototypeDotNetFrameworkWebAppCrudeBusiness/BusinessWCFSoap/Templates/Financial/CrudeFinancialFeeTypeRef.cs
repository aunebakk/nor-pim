/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:36:46 PM
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
    public partial interface ICrudeFinancialFeeTypeRefService {
        
        [OperationContract()]
        CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialFeeTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeName(string financialFeeTypeName);
        
        [OperationContract()]
        List<CrudeFinancialFeeTypeRefContract> FetchWithFilter(string financialFeeTypeRcd, string financialFeeTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialFeeTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialFeeTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialFeeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialFeeTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialFeeTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialFeeTypeRcd);
    }
    
    public partial class CrudeFinancialFeeTypeRefService : ICrudeFinancialFeeTypeRefService {
        
        public CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd) {
            var dataAccessLayer = new CrudeFinancialFeeTypeRefData();
            var contract = new CrudeFinancialFeeTypeRefContract();

            dataAccessLayer.FetchByFinancialFeeTypeRcd(financialFeeTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialFeeTypeRefContract FetchByFinancialFeeTypeName(string financialFeeTypeName) {
            var dataAccessLayer = new CrudeFinancialFeeTypeRefData();
            var contract = new CrudeFinancialFeeTypeRefContract();

            dataAccessLayer.FetchByFinancialFeeTypeName(financialFeeTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialFeeTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialFeeTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialFeeTypeRefContract> DataListToContractList(List<CrudeFinancialFeeTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialFeeTypeRefContract>();

            foreach (CrudeFinancialFeeTypeRefData data in dataList) {
                var contract = new CrudeFinancialFeeTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialFeeTypeRefContract> contractList, List<CrudeFinancialFeeTypeRefData> dataList) {
            foreach (CrudeFinancialFeeTypeRefContract contract in contractList) {
                var data = new CrudeFinancialFeeTypeRefData();
                CrudeFinancialFeeTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialFeeTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialFeeTypeRefContract>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchAll();

            foreach (CrudeFinancialFeeTypeRefData crudeFinancialFeeTypeRef in dataList) {
                var contract = new CrudeFinancialFeeTypeRefContract();
                DataToContract(crudeFinancialFeeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialFeeTypeRefContract>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialFeeTypeRefData crudeFinancialFeeTypeRef in dataList) {
                var contract = new CrudeFinancialFeeTypeRefContract();
                DataToContract(crudeFinancialFeeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialFeeTypeRefContract>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialFeeTypeRefData crudeFinancialFeeTypeRef in dataList) {
                var contract = new CrudeFinancialFeeTypeRefContract();
                DataToContract(crudeFinancialFeeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialFeeTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialFeeTypeRefContract> FetchWithFilter(string financialFeeTypeRcd, string financialFeeTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialFeeTypeRefContract>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchWithFilter(
                financialFeeTypeRcd: financialFeeTypeRcd,
                financialFeeTypeName: financialFeeTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialFeeTypeRefData data in dataList) {
                var crudeFinancialFeeTypeRefContract = new CrudeFinancialFeeTypeRefContract();
                DataToContract(data, crudeFinancialFeeTypeRefContract);
                list.Add(crudeFinancialFeeTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialFeeTypeRefContract contract) {
            var data = new CrudeFinancialFeeTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialFeeTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialFeeTypeRefContract contract) {
            var data = new CrudeFinancialFeeTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialFeeTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialFeeTypeRcd) {
            CrudeFinancialFeeTypeRefData.Delete(financialFeeTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialFeeTypeRefContract contract, CrudeFinancialFeeTypeRefData data) {
            data.FinancialFeeTypeRcd = contract.FinancialFeeTypeRcd;
            data.FinancialFeeTypeName = contract.FinancialFeeTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialFeeTypeRefData data, CrudeFinancialFeeTypeRefContract contract) {
            contract.FinancialFeeTypeRcd = data.FinancialFeeTypeRcd;
            contract.FinancialFeeTypeName = data.FinancialFeeTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
