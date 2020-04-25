/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:04 AM
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
    public partial interface ICrudeFinancialCompanyService {
        
        [OperationContract()]
        CrudeFinancialCompanyContract FetchByFinancialCompanyId(System.Guid financialCompanyId);
        
        [OperationContract()]
        List<CrudeFinancialCompanyContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialCompanyContract FetchByFinancialCompanyName(string financialCompanyName);
        
        [OperationContract()]
        List<CrudeFinancialCompanyContract> FetchWithFilter(System.Guid financialCompanyId, string financialCompanyName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialCompanyContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCompanyContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCompanyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCompanyContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCompanyContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialCompanyId);
    }
    
    public partial class CrudeFinancialCompanyService : ICrudeFinancialCompanyService {
        
        public CrudeFinancialCompanyContract FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            var dataAccessLayer = new CrudeFinancialCompanyData();
            var contract = new CrudeFinancialCompanyContract();

            dataAccessLayer.FetchByFinancialCompanyId(financialCompanyId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialCompanyContract FetchByFinancialCompanyName(string financialCompanyName) {
            var dataAccessLayer = new CrudeFinancialCompanyData();
            var contract = new CrudeFinancialCompanyContract();

            dataAccessLayer.FetchByFinancialCompanyName(financialCompanyName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialCompanyContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCompanyData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCompanyContract> DataListToContractList(List<CrudeFinancialCompanyData> dataList) {
            var contractList = new List<CrudeFinancialCompanyContract>();

            foreach (CrudeFinancialCompanyData data in dataList) {
                var contract = new CrudeFinancialCompanyContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialCompanyContract> contractList, List<CrudeFinancialCompanyData> dataList) {
            foreach (CrudeFinancialCompanyContract contract in contractList) {
                var data = new CrudeFinancialCompanyData();
                CrudeFinancialCompanyService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCompanyContract> FetchAll() {
            var list = new List<CrudeFinancialCompanyContract>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchAll();

            foreach (CrudeFinancialCompanyData crudeFinancialCompany in dataList) {
                var contract = new CrudeFinancialCompanyContract();
                DataToContract(crudeFinancialCompany, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCompanyContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCompanyContract>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCompanyData crudeFinancialCompany in dataList) {
                var contract = new CrudeFinancialCompanyContract();
                DataToContract(crudeFinancialCompany, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCompanyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCompanyContract>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCompanyData crudeFinancialCompany in dataList) {
                var contract = new CrudeFinancialCompanyContract();
                DataToContract(crudeFinancialCompany, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCompanyData.FetchAllCount();
        }
        
        public List<CrudeFinancialCompanyContract> FetchWithFilter(System.Guid financialCompanyId, string financialCompanyName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCompanyContract>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchWithFilter(
                financialCompanyId: financialCompanyId,
                financialCompanyName: financialCompanyName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialCompanyData data in dataList) {
                var crudeFinancialCompanyContract = new CrudeFinancialCompanyContract();
                DataToContract(data, crudeFinancialCompanyContract);
                list.Add(crudeFinancialCompanyContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCompanyContract contract) {
            var data = new CrudeFinancialCompanyData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCompanyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCompanyData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCompanyContract contract) {
            var data = new CrudeFinancialCompanyData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCompanyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCompanyData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCompanyId) {
            CrudeFinancialCompanyData.Delete(financialCompanyId);
        }
        
        public static void ContractToData(CrudeFinancialCompanyContract contract, CrudeFinancialCompanyData data) {
            data.FinancialCompanyId = contract.FinancialCompanyId;
            data.FinancialCompanyName = contract.FinancialCompanyName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialCompanyData data, CrudeFinancialCompanyContract contract) {
            contract.FinancialCompanyId = data.FinancialCompanyId;
            contract.FinancialCompanyName = data.FinancialCompanyName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
