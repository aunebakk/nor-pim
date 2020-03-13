/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:41:10 AM
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
    public partial interface ICrudeFinancialVoucherTypeRefService {
        
        [OperationContract()]
        CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialVoucherTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeName(string financialVoucherTypeName);
        
        [OperationContract()]
        List<CrudeFinancialVoucherTypeRefContract> FetchWithFilter(string financialVoucherTypeRcd, string financialVoucherTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialVoucherTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialVoucherTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialVoucherTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialVoucherTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialVoucherTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialVoucherTypeRcd);
    }
    
    public partial class CrudeFinancialVoucherTypeRefService : ICrudeFinancialVoucherTypeRefService {
        
        public CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            var dataAccessLayer = new CrudeFinancialVoucherTypeRefData();
            var contract = new CrudeFinancialVoucherTypeRefContract();

            dataAccessLayer.FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeName(string financialVoucherTypeName) {
            var dataAccessLayer = new CrudeFinancialVoucherTypeRefData();
            var contract = new CrudeFinancialVoucherTypeRefContract();

            dataAccessLayer.FetchByFinancialVoucherTypeName(financialVoucherTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialVoucherTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialVoucherTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialVoucherTypeRefContract> DataListToContractList(List<CrudeFinancialVoucherTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialVoucherTypeRefContract>();

            foreach (CrudeFinancialVoucherTypeRefData data in dataList) {
                var contract = new CrudeFinancialVoucherTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialVoucherTypeRefContract> contractList, List<CrudeFinancialVoucherTypeRefData> dataList) {
            foreach (CrudeFinancialVoucherTypeRefContract contract in contractList) {
                var data = new CrudeFinancialVoucherTypeRefData();
                CrudeFinancialVoucherTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialVoucherTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialVoucherTypeRefContract>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchAll();

            foreach (CrudeFinancialVoucherTypeRefData crudeFinancialVoucherTypeRef in dataList) {
                var contract = new CrudeFinancialVoucherTypeRefContract();
                DataToContract(crudeFinancialVoucherTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialVoucherTypeRefContract>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialVoucherTypeRefData crudeFinancialVoucherTypeRef in dataList) {
                var contract = new CrudeFinancialVoucherTypeRefContract();
                DataToContract(crudeFinancialVoucherTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialVoucherTypeRefContract>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialVoucherTypeRefData crudeFinancialVoucherTypeRef in dataList) {
                var contract = new CrudeFinancialVoucherTypeRefContract();
                DataToContract(crudeFinancialVoucherTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialVoucherTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialVoucherTypeRefContract> FetchWithFilter(string financialVoucherTypeRcd, string financialVoucherTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialVoucherTypeRefContract>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchWithFilter(
                financialVoucherTypeRcd: financialVoucherTypeRcd,
                financialVoucherTypeName: financialVoucherTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialVoucherTypeRefData data in dataList) {
                var crudeFinancialVoucherTypeRefContract = new CrudeFinancialVoucherTypeRefContract();
                DataToContract(data, crudeFinancialVoucherTypeRefContract);
                list.Add(crudeFinancialVoucherTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialVoucherTypeRefContract contract) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialVoucherTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialVoucherTypeRefContract contract) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialVoucherTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialVoucherTypeRcd) {
            CrudeFinancialVoucherTypeRefData.Delete(financialVoucherTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialVoucherTypeRefContract contract, CrudeFinancialVoucherTypeRefData data) {
            data.FinancialVoucherTypeRcd = contract.FinancialVoucherTypeRcd;
            data.FinancialVoucherTypeName = contract.FinancialVoucherTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialVoucherTypeRefData data, CrudeFinancialVoucherTypeRefContract contract) {
            contract.FinancialVoucherTypeRcd = data.FinancialVoucherTypeRcd;
            contract.FinancialVoucherTypeName = data.FinancialVoucherTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
