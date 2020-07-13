/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:49:10 PM
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
    public partial interface ICrudeClientContactMethodService {
        
        [OperationContract()]
        CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientContactMethodContract contract);
        
        [OperationContract()]
        void Update(CrudeClientContactMethodContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientContactMethodId);
    }
    
    public partial class CrudeClientContactMethodService : ICrudeClientContactMethodService {
        
        public CrudeClientContactMethodContract FetchByClientContactMethodId(System.Guid clientContactMethodId) {
            var dataAccessLayer = new CrudeClientContactMethodData();
            var contract = new CrudeClientContactMethodContract();

            dataAccessLayer.FetchByClientContactMethodId(clientContactMethodId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientContactMethodContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientContactMethodData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientContactMethodContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientContactMethodData.FetchByUserId(userId));
        }
        
        public List<CrudeClientContactMethodContract> FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            return DataListToContractList(CrudeClientContactMethodData.FetchByClientContactMethodRcd(clientContactMethodRcd));
        }
        
        public static List<CrudeClientContactMethodContract> DataListToContractList(List<CrudeClientContactMethodData> dataList) {
            var contractList = new List<CrudeClientContactMethodContract>();

            foreach (CrudeClientContactMethodData data in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientContactMethodContract> contractList, List<CrudeClientContactMethodData> dataList) {
            foreach (CrudeClientContactMethodContract contract in contractList) {
                var data = new CrudeClientContactMethodData();
                CrudeClientContactMethodService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientContactMethodContract> FetchAll() {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAll();

            foreach (CrudeClientContactMethodData crudeClientContactMethod in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(crudeClientContactMethod, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAllWithLimit(limit);

            foreach (CrudeClientContactMethodData crudeClientContactMethod in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(crudeClientContactMethod, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientContactMethodData crudeClientContactMethod in dataList) {
                var contract = new CrudeClientContactMethodContract();
                DataToContract(crudeClientContactMethod, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientContactMethodData.FetchAllCount();
        }
        
        public List<CrudeClientContactMethodContract> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContactMethodContract>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchWithFilter(
                clientContactMethodId: clientContactMethodId,
                clientId: clientId,
                clientContactMethodRcd: clientContactMethodRcd,
                contactMethodWay: contactMethodWay,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientContactMethodData data in dataList) {
                var crudeClientContactMethodContract = new CrudeClientContactMethodContract();
                DataToContract(data, crudeClientContactMethodContract);
                list.Add(crudeClientContactMethodContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientContactMethodContract contract) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientContactMethodContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientContactMethodContract contract) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientContactMethodContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientContactMethodId) {
            CrudeClientContactMethodData.Delete(clientContactMethodId);
        }
        
        public static void ContractToData(CrudeClientContactMethodContract contract, CrudeClientContactMethodData data) {
            data.ClientContactMethodId = contract.ClientContactMethodId;
            data.ClientId = contract.ClientId;
            data.ClientContactMethodRcd = contract.ClientContactMethodRcd;
            data.ContactMethodWay = contract.ContactMethodWay;
            data.Comment = contract.Comment;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientContactMethodData data, CrudeClientContactMethodContract contract) {
            contract.ClientContactMethodId = data.ClientContactMethodId;
            contract.ClientId = data.ClientId;
            contract.ClientContactMethodRcd = data.ClientContactMethodRcd;
            contract.ContactMethodWay = data.ContactMethodWay;
            contract.Comment = data.Comment;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
