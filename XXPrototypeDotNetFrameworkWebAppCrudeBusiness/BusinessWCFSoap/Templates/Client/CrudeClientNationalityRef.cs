/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:09 PM
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
    public partial interface ICrudeClientNationalityRefService {
        
        [OperationContract()]
        CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientNationalityRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientNationalityRefContract contract);
        
        [OperationContract()]
        void Delete(string clientNationalityRcd);
    }
    
    public partial class CrudeClientNationalityRefService : ICrudeClientNationalityRefService {
        
        public CrudeClientNationalityRefContract FetchByClientNationalityRcd(string clientNationalityRcd) {
            var dataAccessLayer = new CrudeClientNationalityRefData();
            var contract = new CrudeClientNationalityRefContract();

            dataAccessLayer.FetchByClientNationalityRcd(clientNationalityRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientNationalityRefContract FetchByClientNationalityName(string clientNationalityName) {
            var dataAccessLayer = new CrudeClientNationalityRefData();
            var contract = new CrudeClientNationalityRefContract();

            dataAccessLayer.FetchByClientNationalityName(clientNationalityName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientNationalityRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientNationalityRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientNationalityRefContract> DataListToContractList(List<CrudeClientNationalityRefData> dataList) {
            var contractList = new List<CrudeClientNationalityRefContract>();

            foreach (CrudeClientNationalityRefData data in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientNationalityRefContract> contractList, List<CrudeClientNationalityRefData> dataList) {
            foreach (CrudeClientNationalityRefContract contract in contractList) {
                var data = new CrudeClientNationalityRefData();
                CrudeClientNationalityRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientNationalityRefContract> FetchAll() {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAll();

            foreach (CrudeClientNationalityRefData crudeClientNationalityRef in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(crudeClientNationalityRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientNationalityRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientNationalityRefData crudeClientNationalityRef in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(crudeClientNationalityRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientNationalityRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientNationalityRefData crudeClientNationalityRef in dataList) {
                var contract = new CrudeClientNationalityRefContract();
                DataToContract(crudeClientNationalityRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientNationalityRefData.FetchAllCount();
        }
        
        public List<CrudeClientNationalityRefContract> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientNationalityRefContract>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchWithFilter(
                clientNationalityRcd: clientNationalityRcd,
                clientNationalityName: clientNationalityName,
                clientNationalityDescription: clientNationalityDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientNationalityRefData data in dataList) {
                var crudeClientNationalityRefContract = new CrudeClientNationalityRefContract();
                DataToContract(data, crudeClientNationalityRefContract);
                list.Add(crudeClientNationalityRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientNationalityRefContract contract) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientNationalityRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientNationalityRefContract contract) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientNationalityRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientNationalityRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientNationalityRcd) {
            CrudeClientNationalityRefData.Delete(clientNationalityRcd);
        }
        
        public static void ContractToData(CrudeClientNationalityRefContract contract, CrudeClientNationalityRefData data) {
            data.ClientNationalityRcd = contract.ClientNationalityRcd;
            data.ClientNationalityName = contract.ClientNationalityName;
            data.ClientNationalityDescription = contract.ClientNationalityDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientNationalityRefData data, CrudeClientNationalityRefContract contract) {
            contract.ClientNationalityRcd = data.ClientNationalityRcd;
            contract.ClientNationalityName = data.ClientNationalityName;
            contract.ClientNationalityDescription = data.ClientNationalityDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
