/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:50:33 AM
  From Machine: DESKTOP-517I8BU
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
    public partial interface ICrudeClientIdentifierService {
        
        [OperationContract()]
        CrudeClientIdentifierContract FetchByClientIdentifierId(System.Guid clientIdentifierId);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientIdentifierContract contract);
        
        [OperationContract()]
        void Update(CrudeClientIdentifierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientIdentifierId);
    }
    
    public partial class CrudeClientIdentifierService : ICrudeClientIdentifierService {
        
        public CrudeClientIdentifierContract FetchByClientIdentifierId(System.Guid clientIdentifierId) {
            var dataAccessLayer = new CrudeClientIdentifierData();
            var contract = new CrudeClientIdentifierContract();

            dataAccessLayer.FetchByClientIdentifierId(clientIdentifierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientIdentifierContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientIdentifierData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientIdentifierContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientIdentifierData.FetchByUserId(userId));
        }
        
        public List<CrudeClientIdentifierContract> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            return DataListToContractList(CrudeClientIdentifierData.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd));
        }
        
        public static List<CrudeClientIdentifierContract> DataListToContractList(List<CrudeClientIdentifierData> dataList) {
            var contractList = new List<CrudeClientIdentifierContract>();

            foreach (CrudeClientIdentifierData data in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientIdentifierContract> contractList, List<CrudeClientIdentifierData> dataList) {
            foreach (CrudeClientIdentifierContract contract in contractList) {
                var data = new CrudeClientIdentifierData();
                CrudeClientIdentifierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientIdentifierContract> FetchAll() {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAll();

            foreach (CrudeClientIdentifierData crudeClientIdentifier in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(crudeClientIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientIdentifierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAllWithLimit(limit);

            foreach (CrudeClientIdentifierData crudeClientIdentifier in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(crudeClientIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientIdentifierData crudeClientIdentifier in dataList) {
                var contract = new CrudeClientIdentifierContract();
                DataToContract(crudeClientIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientIdentifierData.FetchAllCount();
        }
        
        public List<CrudeClientIdentifierContract> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientIdentifierContract>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchWithFilter(
                clientIdentifierId: clientIdentifierId,
                clientId: clientId,
                clientIdentifierTypeRcd: clientIdentifierTypeRcd,
                clientIdentifierCode: clientIdentifierCode,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientIdentifierData data in dataList) {
                var crudeClientIdentifierContract = new CrudeClientIdentifierContract();
                DataToContract(data, crudeClientIdentifierContract);
                list.Add(crudeClientIdentifierContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientIdentifierContract contract) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientIdentifierContract contract) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientIdentifierId) {
            CrudeClientIdentifierData.Delete(clientIdentifierId);
        }
        
        public static void ContractToData(CrudeClientIdentifierContract contract, CrudeClientIdentifierData data) {
            data.ClientIdentifierId = contract.ClientIdentifierId;
            data.ClientId = contract.ClientId;
            data.ClientIdentifierTypeRcd = contract.ClientIdentifierTypeRcd;
            data.ClientIdentifierCode = contract.ClientIdentifierCode;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientIdentifierData data, CrudeClientIdentifierContract contract) {
            contract.ClientIdentifierId = data.ClientIdentifierId;
            contract.ClientId = data.ClientId;
            contract.ClientIdentifierTypeRcd = data.ClientIdentifierTypeRcd;
            contract.ClientIdentifierCode = data.ClientIdentifierCode;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
