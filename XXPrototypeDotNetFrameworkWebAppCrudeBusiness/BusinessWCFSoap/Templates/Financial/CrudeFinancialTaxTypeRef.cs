/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:42:50 AM
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
    public partial interface ICrudeFinancialTaxTypeRefService {
        
        [OperationContract()]
        CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialTaxTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeName(string financialTaxTypeName);
        
        [OperationContract()]
        List<CrudeFinancialTaxTypeRefContract> FetchWithFilter(string financialTaxTypeName, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialTaxTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialTaxTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialTaxTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialTaxTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialTaxTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialTaxTypeRcd);
    }
    
    public partial class CrudeFinancialTaxTypeRefService : ICrudeFinancialTaxTypeRefService {
        
        public CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            var dataAccessLayer = new CrudeFinancialTaxTypeRefData();
            var contract = new CrudeFinancialTaxTypeRefContract();

            dataAccessLayer.FetchByFinancialTaxTypeRcd(financialTaxTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialTaxTypeRefContract FetchByFinancialTaxTypeName(string financialTaxTypeName) {
            var dataAccessLayer = new CrudeFinancialTaxTypeRefData();
            var contract = new CrudeFinancialTaxTypeRefContract();

            dataAccessLayer.FetchByFinancialTaxTypeName(financialTaxTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialTaxTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialTaxTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialTaxTypeRefContract> DataListToContractList(List<CrudeFinancialTaxTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialTaxTypeRefContract>();

            foreach (CrudeFinancialTaxTypeRefData data in dataList) {
                var contract = new CrudeFinancialTaxTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialTaxTypeRefContract> contractList, List<CrudeFinancialTaxTypeRefData> dataList) {
            foreach (CrudeFinancialTaxTypeRefContract contract in contractList) {
                var data = new CrudeFinancialTaxTypeRefData();
                CrudeFinancialTaxTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialTaxTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialTaxTypeRefContract>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchAll();

            foreach (CrudeFinancialTaxTypeRefData crudeFinancialTaxTypeRef in dataList) {
                var contract = new CrudeFinancialTaxTypeRefContract();
                DataToContract(crudeFinancialTaxTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialTaxTypeRefContract>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialTaxTypeRefData crudeFinancialTaxTypeRef in dataList) {
                var contract = new CrudeFinancialTaxTypeRefContract();
                DataToContract(crudeFinancialTaxTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialTaxTypeRefContract>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialTaxTypeRefData crudeFinancialTaxTypeRef in dataList) {
                var contract = new CrudeFinancialTaxTypeRefContract();
                DataToContract(crudeFinancialTaxTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialTaxTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialTaxTypeRefContract> FetchWithFilter(string financialTaxTypeName, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialTaxTypeRefContract>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchWithFilter(
                financialTaxTypeName: financialTaxTypeName,
                financialTaxTypeRcd: financialTaxTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialTaxTypeRefData data in dataList) {
                var crudeFinancialTaxTypeRefContract = new CrudeFinancialTaxTypeRefContract();
                DataToContract(data, crudeFinancialTaxTypeRefContract);
                list.Add(crudeFinancialTaxTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialTaxTypeRefContract contract) {
            var data = new CrudeFinancialTaxTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialTaxTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialTaxTypeRefContract contract) {
            var data = new CrudeFinancialTaxTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialTaxTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialTaxTypeRcd) {
            CrudeFinancialTaxTypeRefData.Delete(financialTaxTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialTaxTypeRefContract contract, CrudeFinancialTaxTypeRefData data) {
            data.FinancialTaxTypeName = contract.FinancialTaxTypeName;
            data.FinancialTaxTypeRcd = contract.FinancialTaxTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialTaxTypeRefData data, CrudeFinancialTaxTypeRefContract contract) {
            contract.FinancialTaxTypeName = data.FinancialTaxTypeName;
            contract.FinancialTaxTypeRcd = data.FinancialTaxTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
