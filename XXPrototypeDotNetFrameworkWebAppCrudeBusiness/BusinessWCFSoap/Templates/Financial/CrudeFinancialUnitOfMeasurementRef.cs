/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:10 PM
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
    public partial interface ICrudeFinancialUnitOfMeasurementRefService {
        
        [OperationContract()]
        CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd);
        
        [OperationContract()]
        List<CrudeFinancialUnitOfMeasurementRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementName(string financialUnitOfMeasurementName);
        
        [OperationContract()]
        List<CrudeFinancialUnitOfMeasurementRefContract> FetchWithFilter(string financialUnitOfMeasurementRcd, int sortSequenceNumber, bool changeFlag, string statusCode, string financialUnitOfMeasurementName, string financialUnitOfMeasurementCode, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialUnitOfMeasurementRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialUnitOfMeasurementRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialUnitOfMeasurementRefContract contract);
        
        [OperationContract()]
        void Delete(string financialUnitOfMeasurementRcd);
    }
    
    public partial class CrudeFinancialUnitOfMeasurementRefService : ICrudeFinancialUnitOfMeasurementRefService {
        
        public CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            var dataAccessLayer = new CrudeFinancialUnitOfMeasurementRefData();
            var contract = new CrudeFinancialUnitOfMeasurementRefContract();

            dataAccessLayer.FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialUnitOfMeasurementRefContract FetchByFinancialUnitOfMeasurementName(string financialUnitOfMeasurementName) {
            var dataAccessLayer = new CrudeFinancialUnitOfMeasurementRefData();
            var contract = new CrudeFinancialUnitOfMeasurementRefContract();

            dataAccessLayer.FetchByFinancialUnitOfMeasurementName(financialUnitOfMeasurementName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialUnitOfMeasurementRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialUnitOfMeasurementRefContract> DataListToContractList(List<CrudeFinancialUnitOfMeasurementRefData> dataList) {
            var contractList = new List<CrudeFinancialUnitOfMeasurementRefContract>();

            foreach (CrudeFinancialUnitOfMeasurementRefData data in dataList) {
                var contract = new CrudeFinancialUnitOfMeasurementRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialUnitOfMeasurementRefContract> contractList, List<CrudeFinancialUnitOfMeasurementRefData> dataList) {
            foreach (CrudeFinancialUnitOfMeasurementRefContract contract in contractList) {
                var data = new CrudeFinancialUnitOfMeasurementRefData();
                CrudeFinancialUnitOfMeasurementRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefContract> FetchAll() {
            var list = new List<CrudeFinancialUnitOfMeasurementRefContract>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchAll();

            foreach (CrudeFinancialUnitOfMeasurementRefData crudeFinancialUnitOfMeasurementRef in dataList) {
                var contract = new CrudeFinancialUnitOfMeasurementRefContract();
                DataToContract(crudeFinancialUnitOfMeasurementRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialUnitOfMeasurementRefContract>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialUnitOfMeasurementRefData crudeFinancialUnitOfMeasurementRef in dataList) {
                var contract = new CrudeFinancialUnitOfMeasurementRefContract();
                DataToContract(crudeFinancialUnitOfMeasurementRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialUnitOfMeasurementRefContract>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialUnitOfMeasurementRefData crudeFinancialUnitOfMeasurementRef in dataList) {
                var contract = new CrudeFinancialUnitOfMeasurementRefContract();
                DataToContract(crudeFinancialUnitOfMeasurementRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialUnitOfMeasurementRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefContract> FetchWithFilter(string financialUnitOfMeasurementRcd, int sortSequenceNumber, bool changeFlag, string statusCode, string financialUnitOfMeasurementName, string financialUnitOfMeasurementCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialUnitOfMeasurementRefContract>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchWithFilter(
                financialUnitOfMeasurementRcd: financialUnitOfMeasurementRcd,
                sortSequenceNumber: sortSequenceNumber,
                changeFlag: changeFlag,
                statusCode: statusCode,
                financialUnitOfMeasurementName: financialUnitOfMeasurementName,
                financialUnitOfMeasurementCode: financialUnitOfMeasurementCode,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialUnitOfMeasurementRefData data in dataList) {
                var crudeFinancialUnitOfMeasurementRefContract = new CrudeFinancialUnitOfMeasurementRefContract();
                DataToContract(data, crudeFinancialUnitOfMeasurementRefContract);
                list.Add(crudeFinancialUnitOfMeasurementRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialUnitOfMeasurementRefContract contract) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialUnitOfMeasurementRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialUnitOfMeasurementRefContract contract) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialUnitOfMeasurementRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialUnitOfMeasurementRcd) {
            CrudeFinancialUnitOfMeasurementRefData.Delete(financialUnitOfMeasurementRcd);
        }
        
        public static void ContractToData(CrudeFinancialUnitOfMeasurementRefContract contract, CrudeFinancialUnitOfMeasurementRefData data) {
            data.FinancialUnitOfMeasurementRcd = contract.FinancialUnitOfMeasurementRcd;
            data.SortSequenceNumber = contract.SortSequenceNumber;
            data.ChangeFlag = contract.ChangeFlag;
            data.StatusCode = contract.StatusCode;
            data.FinancialUnitOfMeasurementName = contract.FinancialUnitOfMeasurementName;
            data.FinancialUnitOfMeasurementCode = contract.FinancialUnitOfMeasurementCode;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialUnitOfMeasurementRefData data, CrudeFinancialUnitOfMeasurementRefContract contract) {
            contract.FinancialUnitOfMeasurementRcd = data.FinancialUnitOfMeasurementRcd;
            contract.SortSequenceNumber = data.SortSequenceNumber;
            contract.ChangeFlag = data.ChangeFlag;
            contract.StatusCode = data.StatusCode;
            contract.FinancialUnitOfMeasurementName = data.FinancialUnitOfMeasurementName;
            contract.FinancialUnitOfMeasurementCode = data.FinancialUnitOfMeasurementCode;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
