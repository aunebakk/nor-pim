/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:00 PM
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
    public partial interface ICrudeClientTitleRefService {
        
        [OperationContract()]
        CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientTitleRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientTitleRefContract contract);
        
        [OperationContract()]
        void Delete(string clientTitleRcd);
    }
    
    public partial class CrudeClientTitleRefService : ICrudeClientTitleRefService {
        
        public CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd) {
            var dataAccessLayer = new CrudeClientTitleRefData();
            var contract = new CrudeClientTitleRefContract();

            dataAccessLayer.FetchByClientTitleRcd(clientTitleRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName) {
            var dataAccessLayer = new CrudeClientTitleRefData();
            var contract = new CrudeClientTitleRefContract();

            dataAccessLayer.FetchByClientTitleName(clientTitleName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientTitleRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientTitleRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientTitleRefContract> DataListToContractList(List<CrudeClientTitleRefData> dataList) {
            var contractList = new List<CrudeClientTitleRefContract>();

            foreach (CrudeClientTitleRefData data in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientTitleRefContract> contractList, List<CrudeClientTitleRefData> dataList) {
            foreach (CrudeClientTitleRefContract contract in contractList) {
                var data = new CrudeClientTitleRefData();
                CrudeClientTitleRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientTitleRefContract> FetchAll() {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAll();

            foreach (CrudeClientTitleRefData crudeClientTitleRef in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(crudeClientTitleRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientTitleRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientTitleRefData crudeClientTitleRef in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(crudeClientTitleRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientTitleRefData crudeClientTitleRef in dataList) {
                var contract = new CrudeClientTitleRefContract();
                DataToContract(crudeClientTitleRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientTitleRefData.FetchAllCount();
        }
        
        public List<CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientTitleRefContract>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchWithFilter(
                clientTitleRcd: clientTitleRcd,
                clientTitleName: clientTitleName,
                clientTitleDescription: clientTitleDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientTitleRefData data in dataList) {
                var crudeClientTitleRefContract = new CrudeClientTitleRefContract();
                DataToContract(data, crudeClientTitleRefContract);
                list.Add(crudeClientTitleRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientTitleRefContract contract) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientTitleRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientTitleRefContract contract) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientTitleRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTitleRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientTitleRcd) {
            CrudeClientTitleRefData.Delete(clientTitleRcd);
        }
        
        public static void ContractToData(CrudeClientTitleRefContract contract, CrudeClientTitleRefData data) {
            data.ClientTitleRcd = contract.ClientTitleRcd;
            data.ClientTitleName = contract.ClientTitleName;
            data.ClientTitleDescription = contract.ClientTitleDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientTitleRefData data, CrudeClientTitleRefContract contract) {
            contract.ClientTitleRcd = data.ClientTitleRcd;
            contract.ClientTitleName = data.ClientTitleName;
            contract.ClientTitleDescription = data.ClientTitleDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
