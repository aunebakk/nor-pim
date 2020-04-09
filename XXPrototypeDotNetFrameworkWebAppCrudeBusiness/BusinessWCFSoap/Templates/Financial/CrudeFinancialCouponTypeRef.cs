/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:02 AM
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
    public partial interface ICrudeFinancialCouponTypeRefService {
        
        [OperationContract()]
        CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialCouponTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeName(string financialCouponTypeName);
        
        [OperationContract()]
        List<CrudeFinancialCouponTypeRefContract> FetchWithFilter(string financialCouponTypeRcd, string financialCouponTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialCouponTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCouponTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCouponTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCouponTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCouponTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialCouponTypeRcd);
    }
    
    public partial class CrudeFinancialCouponTypeRefService : ICrudeFinancialCouponTypeRefService {
        
        public CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            var dataAccessLayer = new CrudeFinancialCouponTypeRefData();
            var contract = new CrudeFinancialCouponTypeRefContract();

            dataAccessLayer.FetchByFinancialCouponTypeRcd(financialCouponTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialCouponTypeRefContract FetchByFinancialCouponTypeName(string financialCouponTypeName) {
            var dataAccessLayer = new CrudeFinancialCouponTypeRefData();
            var contract = new CrudeFinancialCouponTypeRefContract();

            dataAccessLayer.FetchByFinancialCouponTypeName(financialCouponTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialCouponTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCouponTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCouponTypeRefContract> DataListToContractList(List<CrudeFinancialCouponTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialCouponTypeRefContract>();

            foreach (CrudeFinancialCouponTypeRefData data in dataList) {
                var contract = new CrudeFinancialCouponTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialCouponTypeRefContract> contractList, List<CrudeFinancialCouponTypeRefData> dataList) {
            foreach (CrudeFinancialCouponTypeRefContract contract in contractList) {
                var data = new CrudeFinancialCouponTypeRefData();
                CrudeFinancialCouponTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCouponTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialCouponTypeRefContract>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchAll();

            foreach (CrudeFinancialCouponTypeRefData crudeFinancialCouponTypeRef in dataList) {
                var contract = new CrudeFinancialCouponTypeRefContract();
                DataToContract(crudeFinancialCouponTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCouponTypeRefContract>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCouponTypeRefData crudeFinancialCouponTypeRef in dataList) {
                var contract = new CrudeFinancialCouponTypeRefContract();
                DataToContract(crudeFinancialCouponTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCouponTypeRefContract>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCouponTypeRefData crudeFinancialCouponTypeRef in dataList) {
                var contract = new CrudeFinancialCouponTypeRefContract();
                DataToContract(crudeFinancialCouponTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCouponTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialCouponTypeRefContract> FetchWithFilter(string financialCouponTypeRcd, string financialCouponTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCouponTypeRefContract>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchWithFilter(
                financialCouponTypeRcd: financialCouponTypeRcd,
                financialCouponTypeName: financialCouponTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialCouponTypeRefData data in dataList) {
                var crudeFinancialCouponTypeRefContract = new CrudeFinancialCouponTypeRefContract();
                DataToContract(data, crudeFinancialCouponTypeRefContract);
                list.Add(crudeFinancialCouponTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCouponTypeRefContract contract) {
            var data = new CrudeFinancialCouponTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCouponTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCouponTypeRefContract contract) {
            var data = new CrudeFinancialCouponTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCouponTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialCouponTypeRcd) {
            CrudeFinancialCouponTypeRefData.Delete(financialCouponTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialCouponTypeRefContract contract, CrudeFinancialCouponTypeRefData data) {
            data.FinancialCouponTypeRcd = contract.FinancialCouponTypeRcd;
            data.FinancialCouponTypeName = contract.FinancialCouponTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialCouponTypeRefData data, CrudeFinancialCouponTypeRefContract contract) {
            contract.FinancialCouponTypeRcd = data.FinancialCouponTypeRcd;
            contract.FinancialCouponTypeName = data.FinancialCouponTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
