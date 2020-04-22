/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:01 AM
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
    public partial interface ICrudeClientEventService {
        
        [OperationContract()]
        CrudeClientEventContract FetchByClientEventId(System.Guid clientEventId);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchByClientEventTypeRcd(string clientEventTypeRcd);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientEventContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientEventContract contract);
        
        [OperationContract()]
        void Update(CrudeClientEventContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientEventId);
    }
    
    public partial class CrudeClientEventService : ICrudeClientEventService {
        
        public CrudeClientEventContract FetchByClientEventId(System.Guid clientEventId) {
            var dataAccessLayer = new CrudeClientEventData();
            var contract = new CrudeClientEventContract();

            dataAccessLayer.FetchByClientEventId(clientEventId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientEventContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientEventData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientEventContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientEventData.FetchByUserId(userId));
        }
        
        public List<CrudeClientEventContract> FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            return DataListToContractList(CrudeClientEventData.FetchByClientEventTypeRcd(clientEventTypeRcd));
        }
        
        public static List<CrudeClientEventContract> DataListToContractList(List<CrudeClientEventData> dataList) {
            var contractList = new List<CrudeClientEventContract>();

            foreach (CrudeClientEventData data in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientEventContract> contractList, List<CrudeClientEventData> dataList) {
            foreach (CrudeClientEventContract contract in contractList) {
                var data = new CrudeClientEventData();
                CrudeClientEventService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientEventContract> FetchAll() {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAll();

            foreach (CrudeClientEventData crudeClientEvent in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(crudeClientEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientEventContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAllWithLimit(limit);

            foreach (CrudeClientEventData crudeClientEvent in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(crudeClientEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientEventContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientEventData crudeClientEvent in dataList) {
                var contract = new CrudeClientEventContract();
                DataToContract(crudeClientEvent, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientEventData.FetchAllCount();
        }
        
        public List<CrudeClientEventContract> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientEventContract>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchWithFilter(
                clientEventId: clientEventId,
                clientId: clientId,
                clientEventTypeRcd: clientEventTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientEventData data in dataList) {
                var crudeClientEventContract = new CrudeClientEventContract();
                DataToContract(data, crudeClientEventContract);
                list.Add(crudeClientEventContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientEventContract contract) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientEventContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientEventContract contract) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientEventContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientEventId) {
            CrudeClientEventData.Delete(clientEventId);
        }
        
        public static void ContractToData(CrudeClientEventContract contract, CrudeClientEventData data) {
            data.ClientEventId = contract.ClientEventId;
            data.ClientId = contract.ClientId;
            data.ClientEventTypeRcd = contract.ClientEventTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientEventData data, CrudeClientEventContract contract) {
            contract.ClientEventId = data.ClientEventId;
            contract.ClientId = data.ClientId;
            contract.ClientEventTypeRcd = data.ClientEventTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
