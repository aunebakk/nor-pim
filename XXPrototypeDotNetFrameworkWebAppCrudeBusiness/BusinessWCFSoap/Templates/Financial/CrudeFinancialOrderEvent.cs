/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:52 PM
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
    public partial interface ICrudeFinancialOrderEventService {
        
        [OperationContract()]
        CrudeFinancialOrderEventContract FetchByFiancialOrderEventId(System.Guid fiancialOrderEventId);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventContract> FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventContract> FetchWithFilter(System.Guid fiancialOrderEventId, System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, string financialOrderEventTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderEventContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderEventContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderEventContract contract);
        
        [OperationContract()]
        void Delete(System.Guid fiancialOrderEventId);
    }
    
    public partial class CrudeFinancialOrderEventService : ICrudeFinancialOrderEventService {
        
        public CrudeFinancialOrderEventContract FetchByFiancialOrderEventId(System.Guid fiancialOrderEventId) {
            var dataAccessLayer = new CrudeFinancialOrderEventData();
            var contract = new CrudeFinancialOrderEventContract();

            dataAccessLayer.FetchByFiancialOrderEventId(fiancialOrderEventId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderEventContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToContractList(CrudeFinancialOrderEventData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public List<CrudeFinancialOrderEventContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderEventData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderEventContract> FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd) {
            return DataListToContractList(CrudeFinancialOrderEventData.FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd));
        }
        
        public static List<CrudeFinancialOrderEventContract> DataListToContractList(List<CrudeFinancialOrderEventData> dataList) {
            var contractList = new List<CrudeFinancialOrderEventContract>();

            foreach (CrudeFinancialOrderEventData data in dataList) {
                var contract = new CrudeFinancialOrderEventContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderEventContract> contractList, List<CrudeFinancialOrderEventData> dataList) {
            foreach (CrudeFinancialOrderEventContract contract in contractList) {
                var data = new CrudeFinancialOrderEventData();
                CrudeFinancialOrderEventService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderEventContract> FetchAll() {
            var list = new List<CrudeFinancialOrderEventContract>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchAll();

            foreach (CrudeFinancialOrderEventData crudeFinancialOrderEvent in dataList) {
                var contract = new CrudeFinancialOrderEventContract();
                DataToContract(crudeFinancialOrderEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderEventContract>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderEventData crudeFinancialOrderEvent in dataList) {
                var contract = new CrudeFinancialOrderEventContract();
                DataToContract(crudeFinancialOrderEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderEventContract>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderEventData crudeFinancialOrderEvent in dataList) {
                var contract = new CrudeFinancialOrderEventContract();
                DataToContract(crudeFinancialOrderEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderEventData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderEventContract> FetchWithFilter(System.Guid fiancialOrderEventId, System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, string financialOrderEventTypeRcd) {
            var list = new List<CrudeFinancialOrderEventContract>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchWithFilter(
                fiancialOrderEventId: fiancialOrderEventId,
                financialOrderId: financialOrderId,
                userId: userId,
                dateTime: dateTime,
                comment: comment,
                financialOrderEventTypeRcd: financialOrderEventTypeRcd
                );

            foreach (CrudeFinancialOrderEventData data in dataList) {
                var crudeFinancialOrderEventContract = new CrudeFinancialOrderEventContract();
                DataToContract(data, crudeFinancialOrderEventContract);
                list.Add(crudeFinancialOrderEventContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderEventContract contract) {
            var data = new CrudeFinancialOrderEventData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderEventContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderEventContract contract) {
            var data = new CrudeFinancialOrderEventData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderEventContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid fiancialOrderEventId) {
            CrudeFinancialOrderEventData.Delete(fiancialOrderEventId);
        }
        
        public static void ContractToData(CrudeFinancialOrderEventContract contract, CrudeFinancialOrderEventData data) {
            data.FiancialOrderEventId = contract.FiancialOrderEventId;
            data.FinancialOrderId = contract.FinancialOrderId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Comment = contract.Comment;
            data.FinancialOrderEventTypeRcd = contract.FinancialOrderEventTypeRcd;
        }
        
        public static void DataToContract(CrudeFinancialOrderEventData data, CrudeFinancialOrderEventContract contract) {
            contract.FiancialOrderEventId = data.FiancialOrderEventId;
            contract.FinancialOrderId = data.FinancialOrderId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Comment = data.Comment;
            contract.FinancialOrderEventTypeRcd = data.FinancialOrderEventTypeRcd;
        }
    }
}
