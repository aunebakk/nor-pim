/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:34:34 PM
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
    public partial interface ICrudeFinancialOrderIdentifierTypeRefService {
        
        [OperationContract()]
        CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeName(string financialOrderIdentifierTypeName);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierTypeRefContract> FetchWithFilter(string financialOrderIdentifierTypeRcd, string financialOrderIdentifierTypeCode, string financialOrderIdentifierTypeName, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderIdentifierTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderIdentifierTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialOrderIdentifierTypeRcd);
    }
    
    public partial class CrudeFinancialOrderIdentifierTypeRefService : ICrudeFinancialOrderIdentifierTypeRefService {
        
        public CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            var dataAccessLayer = new CrudeFinancialOrderIdentifierTypeRefData();
            var contract = new CrudeFinancialOrderIdentifierTypeRefContract();

            dataAccessLayer.FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialOrderIdentifierTypeRefContract FetchByFinancialOrderIdentifierTypeName(string financialOrderIdentifierTypeName) {
            var dataAccessLayer = new CrudeFinancialOrderIdentifierTypeRefData();
            var contract = new CrudeFinancialOrderIdentifierTypeRefContract();

            dataAccessLayer.FetchByFinancialOrderIdentifierTypeName(financialOrderIdentifierTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderIdentifierTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderIdentifierTypeRefContract> DataListToContractList(List<CrudeFinancialOrderIdentifierTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialOrderIdentifierTypeRefContract>();

            foreach (CrudeFinancialOrderIdentifierTypeRefData data in dataList) {
                var contract = new CrudeFinancialOrderIdentifierTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderIdentifierTypeRefContract> contractList, List<CrudeFinancialOrderIdentifierTypeRefData> dataList) {
            foreach (CrudeFinancialOrderIdentifierTypeRefContract contract in contractList) {
                var data = new CrudeFinancialOrderIdentifierTypeRefData();
                CrudeFinancialOrderIdentifierTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefContract>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchAll();

            foreach (CrudeFinancialOrderIdentifierTypeRefData crudeFinancialOrderIdentifierTypeRef in dataList) {
                var contract = new CrudeFinancialOrderIdentifierTypeRefContract();
                DataToContract(crudeFinancialOrderIdentifierTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefContract>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderIdentifierTypeRefData crudeFinancialOrderIdentifierTypeRef in dataList) {
                var contract = new CrudeFinancialOrderIdentifierTypeRefContract();
                DataToContract(crudeFinancialOrderIdentifierTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefContract>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderIdentifierTypeRefData crudeFinancialOrderIdentifierTypeRef in dataList) {
                var contract = new CrudeFinancialOrderIdentifierTypeRefContract();
                DataToContract(crudeFinancialOrderIdentifierTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderIdentifierTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefContract> FetchWithFilter(string financialOrderIdentifierTypeRcd, string financialOrderIdentifierTypeCode, string financialOrderIdentifierTypeName, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefContract>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchWithFilter(
                financialOrderIdentifierTypeRcd: financialOrderIdentifierTypeRcd,
                financialOrderIdentifierTypeCode: financialOrderIdentifierTypeCode,
                financialOrderIdentifierTypeName: financialOrderIdentifierTypeName,
                sortSequenceNumber: sortSequenceNumber,
                changeFlag: changeFlag,
                statusCode: statusCode,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialOrderIdentifierTypeRefData data in dataList) {
                var crudeFinancialOrderIdentifierTypeRefContract = new CrudeFinancialOrderIdentifierTypeRefContract();
                DataToContract(data, crudeFinancialOrderIdentifierTypeRefContract);
                list.Add(crudeFinancialOrderIdentifierTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderIdentifierTypeRefContract contract) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderIdentifierTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderIdentifierTypeRefContract contract) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderIdentifierTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderIdentifierTypeRcd) {
            CrudeFinancialOrderIdentifierTypeRefData.Delete(financialOrderIdentifierTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialOrderIdentifierTypeRefContract contract, CrudeFinancialOrderIdentifierTypeRefData data) {
            data.FinancialOrderIdentifierTypeRcd = contract.FinancialOrderIdentifierTypeRcd;
            data.FinancialOrderIdentifierTypeCode = contract.FinancialOrderIdentifierTypeCode;
            data.FinancialOrderIdentifierTypeName = contract.FinancialOrderIdentifierTypeName;
            data.SortSequenceNumber = contract.SortSequenceNumber;
            data.ChangeFlag = contract.ChangeFlag;
            data.StatusCode = contract.StatusCode;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialOrderIdentifierTypeRefData data, CrudeFinancialOrderIdentifierTypeRefContract contract) {
            contract.FinancialOrderIdentifierTypeRcd = data.FinancialOrderIdentifierTypeRcd;
            contract.FinancialOrderIdentifierTypeCode = data.FinancialOrderIdentifierTypeCode;
            contract.FinancialOrderIdentifierTypeName = data.FinancialOrderIdentifierTypeName;
            contract.SortSequenceNumber = data.SortSequenceNumber;
            contract.ChangeFlag = data.ChangeFlag;
            contract.StatusCode = data.StatusCode;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
