/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:26:57 PM
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
    public partial interface ICrudeFinancialCostcentreService {
        
        [OperationContract()]
        CrudeFinancialCostcentreContract FetchByFinancialCostcentreId(System.Guid financialCostcentreId);
        
        [OperationContract()]
        List<CrudeFinancialCostcentreContract> FetchByFinancialCompanyId(System.Guid financialCompanyId);
        
        [OperationContract()]
        List<CrudeFinancialCostcentreContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialCostcentreContract FetchByFinancialCostcentreName(string financialCostcentreName);
        
        [OperationContract()]
        List<CrudeFinancialCostcentreContract> FetchWithFilter(System.Guid financialCostcentreId, string financialCostcentreName, string financialCostcentreCode, System.Guid financialCompanyId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialCostcentreContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCostcentreContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCostcentreContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCostcentreContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCostcentreContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialCostcentreId);
    }
    
    public partial class CrudeFinancialCostcentreService : ICrudeFinancialCostcentreService {
        
        public CrudeFinancialCostcentreContract FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            var dataAccessLayer = new CrudeFinancialCostcentreData();
            var contract = new CrudeFinancialCostcentreContract();

            dataAccessLayer.FetchByFinancialCostcentreId(financialCostcentreId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialCostcentreContract FetchByFinancialCostcentreName(string financialCostcentreName) {
            var dataAccessLayer = new CrudeFinancialCostcentreData();
            var contract = new CrudeFinancialCostcentreContract();

            dataAccessLayer.FetchByFinancialCostcentreName(financialCostcentreName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialCostcentreContract> FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            return DataListToContractList(CrudeFinancialCostcentreData.FetchByFinancialCompanyId(financialCompanyId));
        }
        
        public List<CrudeFinancialCostcentreContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCostcentreData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCostcentreContract> DataListToContractList(List<CrudeFinancialCostcentreData> dataList) {
            var contractList = new List<CrudeFinancialCostcentreContract>();

            foreach (CrudeFinancialCostcentreData data in dataList) {
                var contract = new CrudeFinancialCostcentreContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialCostcentreContract> contractList, List<CrudeFinancialCostcentreData> dataList) {
            foreach (CrudeFinancialCostcentreContract contract in contractList) {
                var data = new CrudeFinancialCostcentreData();
                CrudeFinancialCostcentreService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCostcentreContract> FetchAll() {
            var list = new List<CrudeFinancialCostcentreContract>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchAll();

            foreach (CrudeFinancialCostcentreData crudeFinancialCostcentre in dataList) {
                var contract = new CrudeFinancialCostcentreContract();
                DataToContract(crudeFinancialCostcentre, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCostcentreContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCostcentreContract>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCostcentreData crudeFinancialCostcentre in dataList) {
                var contract = new CrudeFinancialCostcentreContract();
                DataToContract(crudeFinancialCostcentre, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCostcentreContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCostcentreContract>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCostcentreData crudeFinancialCostcentre in dataList) {
                var contract = new CrudeFinancialCostcentreContract();
                DataToContract(crudeFinancialCostcentre, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCostcentreData.FetchAllCount();
        }
        
        public List<CrudeFinancialCostcentreContract> FetchWithFilter(System.Guid financialCostcentreId, string financialCostcentreName, string financialCostcentreCode, System.Guid financialCompanyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCostcentreContract>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchWithFilter(
                financialCostcentreId: financialCostcentreId,
                financialCostcentreName: financialCostcentreName,
                financialCostcentreCode: financialCostcentreCode,
                financialCompanyId: financialCompanyId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialCostcentreData data in dataList) {
                var crudeFinancialCostcentreContract = new CrudeFinancialCostcentreContract();
                DataToContract(data, crudeFinancialCostcentreContract);
                list.Add(crudeFinancialCostcentreContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCostcentreContract contract) {
            var data = new CrudeFinancialCostcentreData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCostcentreContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCostcentreData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCostcentreContract contract) {
            var data = new CrudeFinancialCostcentreData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCostcentreContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCostcentreData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCostcentreId) {
            CrudeFinancialCostcentreData.Delete(financialCostcentreId);
        }
        
        public static void ContractToData(CrudeFinancialCostcentreContract contract, CrudeFinancialCostcentreData data) {
            data.FinancialCostcentreId = contract.FinancialCostcentreId;
            data.FinancialCostcentreName = contract.FinancialCostcentreName;
            data.FinancialCostcentreCode = contract.FinancialCostcentreCode;
            data.FinancialCompanyId = contract.FinancialCompanyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialCostcentreData data, CrudeFinancialCostcentreContract contract) {
            contract.FinancialCostcentreId = data.FinancialCostcentreId;
            contract.FinancialCostcentreName = data.FinancialCostcentreName;
            contract.FinancialCostcentreCode = data.FinancialCostcentreCode;
            contract.FinancialCompanyId = data.FinancialCompanyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
