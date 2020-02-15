/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:38:57 AM
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
    public partial interface ICrudeFinancialOrderIdentifierService {
        
        [OperationContract()]
        CrudeFinancialOrderIdentifierContract FetchByFinancialOrderIdentifierId(System.Guid financialOrderIdentifierId);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierContract> FetchWithFilter(System.Guid financialOrderIdentifierId, System.Guid financialOrderId, string financialOrderIdentifierTypeRcd, string financialOrderIdentifierCode, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderIdentifierContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderIdentifierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialOrderIdentifierId);
    }
    
    public partial class CrudeFinancialOrderIdentifierService : ICrudeFinancialOrderIdentifierService {
        
        public CrudeFinancialOrderIdentifierContract FetchByFinancialOrderIdentifierId(System.Guid financialOrderIdentifierId) {
            var dataAccessLayer = new CrudeFinancialOrderIdentifierData();
            var contract = new CrudeFinancialOrderIdentifierContract();

            dataAccessLayer.FetchByFinancialOrderIdentifierId(financialOrderIdentifierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToContractList(CrudeFinancialOrderIdentifierData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public List<CrudeFinancialOrderIdentifierContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderIdentifierData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderIdentifierContract> FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            return DataListToContractList(CrudeFinancialOrderIdentifierData.FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd));
        }
        
        public static List<CrudeFinancialOrderIdentifierContract> DataListToContractList(List<CrudeFinancialOrderIdentifierData> dataList) {
            var contractList = new List<CrudeFinancialOrderIdentifierContract>();

            foreach (CrudeFinancialOrderIdentifierData data in dataList) {
                var contract = new CrudeFinancialOrderIdentifierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderIdentifierContract> contractList, List<CrudeFinancialOrderIdentifierData> dataList) {
            foreach (CrudeFinancialOrderIdentifierContract contract in contractList) {
                var data = new CrudeFinancialOrderIdentifierData();
                CrudeFinancialOrderIdentifierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderIdentifierContract> FetchAll() {
            var list = new List<CrudeFinancialOrderIdentifierContract>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchAll();

            foreach (CrudeFinancialOrderIdentifierData crudeFinancialOrderIdentifier in dataList) {
                var contract = new CrudeFinancialOrderIdentifierContract();
                DataToContract(crudeFinancialOrderIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderIdentifierContract>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderIdentifierData crudeFinancialOrderIdentifier in dataList) {
                var contract = new CrudeFinancialOrderIdentifierContract();
                DataToContract(crudeFinancialOrderIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderIdentifierContract>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderIdentifierData crudeFinancialOrderIdentifier in dataList) {
                var contract = new CrudeFinancialOrderIdentifierContract();
                DataToContract(crudeFinancialOrderIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderIdentifierData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderIdentifierContract> FetchWithFilter(System.Guid financialOrderIdentifierId, System.Guid financialOrderId, string financialOrderIdentifierTypeRcd, string financialOrderIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderIdentifierContract>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchWithFilter(
                financialOrderIdentifierId: financialOrderIdentifierId,
                financialOrderId: financialOrderId,
                financialOrderIdentifierTypeRcd: financialOrderIdentifierTypeRcd,
                financialOrderIdentifierCode: financialOrderIdentifierCode,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialOrderIdentifierData data in dataList) {
                var crudeFinancialOrderIdentifierContract = new CrudeFinancialOrderIdentifierContract();
                DataToContract(data, crudeFinancialOrderIdentifierContract);
                list.Add(crudeFinancialOrderIdentifierContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderIdentifierContract contract) {
            var data = new CrudeFinancialOrderIdentifierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderIdentifierContract contract) {
            var data = new CrudeFinancialOrderIdentifierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialOrderIdentifierId) {
            CrudeFinancialOrderIdentifierData.Delete(financialOrderIdentifierId);
        }
        
        public static void ContractToData(CrudeFinancialOrderIdentifierContract contract, CrudeFinancialOrderIdentifierData data) {
            data.FinancialOrderIdentifierId = contract.FinancialOrderIdentifierId;
            data.FinancialOrderId = contract.FinancialOrderId;
            data.FinancialOrderIdentifierTypeRcd = contract.FinancialOrderIdentifierTypeRcd;
            data.FinancialOrderIdentifierCode = contract.FinancialOrderIdentifierCode;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialOrderIdentifierData data, CrudeFinancialOrderIdentifierContract contract) {
            contract.FinancialOrderIdentifierId = data.FinancialOrderIdentifierId;
            contract.FinancialOrderId = data.FinancialOrderId;
            contract.FinancialOrderIdentifierTypeRcd = data.FinancialOrderIdentifierTypeRcd;
            contract.FinancialOrderIdentifierCode = data.FinancialOrderIdentifierCode;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
