/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:38 AM
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
    public partial interface ICrudeFinancialOrderService {
        
        [OperationContract()]
        CrudeFinancialOrderContract FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByLocationAddressId(System.Guid locationAddressId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialOrderId);
    }
    
    public partial class CrudeFinancialOrderService : ICrudeFinancialOrderService {
        
        public CrudeFinancialOrderContract FetchByFinancialOrderId(System.Guid financialOrderId) {
            var dataAccessLayer = new CrudeFinancialOrderData();
            var contract = new CrudeFinancialOrderContract();

            dataAccessLayer.FetchByFinancialOrderId(financialOrderId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderContract> FetchByLocationAddressId(System.Guid locationAddressId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByLocationAddressId(locationAddressId));
        }
        
        public List<CrudeFinancialOrderContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialOrderContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByClientId(clientId));
        }
        
        public List<CrudeFinancialOrderContract> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd));
        }
        
        public static List<CrudeFinancialOrderContract> DataListToContractList(List<CrudeFinancialOrderData> dataList) {
            var contractList = new List<CrudeFinancialOrderContract>();

            foreach (CrudeFinancialOrderData data in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderContract> contractList, List<CrudeFinancialOrderData> dataList) {
            foreach (CrudeFinancialOrderContract contract in contractList) {
                var data = new CrudeFinancialOrderData();
                CrudeFinancialOrderService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderContract> FetchAll() {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAll();

            foreach (CrudeFinancialOrderData crudeFinancialOrder in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(crudeFinancialOrder, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderData crudeFinancialOrder in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(crudeFinancialOrder, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderData crudeFinancialOrder in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(crudeFinancialOrder, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderContract> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId) {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchWithFilter(
                financialOrderId: financialOrderId,
                userId: userId,
                dateTime: dateTime,
                comment: comment,
                locationAddressId: locationAddressId,
                financialCurrencyId: financialCurrencyId,
                financialOrderSourceRcd: financialOrderSourceRcd,
                clientId: clientId
                );

            foreach (CrudeFinancialOrderData data in dataList) {
                var crudeFinancialOrderContract = new CrudeFinancialOrderContract();
                DataToContract(data, crudeFinancialOrderContract);
                list.Add(crudeFinancialOrderContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderContract contract) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderContract contract) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialOrderId) {
            CrudeFinancialOrderData.Delete(financialOrderId);
        }
        
        public static void ContractToData(CrudeFinancialOrderContract contract, CrudeFinancialOrderData data) {
            data.FinancialOrderId = contract.FinancialOrderId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Comment = contract.Comment;
            data.LocationAddressId = contract.LocationAddressId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.FinancialOrderSourceRcd = contract.FinancialOrderSourceRcd;
            data.ClientId = contract.ClientId;
        }
        
        public static void DataToContract(CrudeFinancialOrderData data, CrudeFinancialOrderContract contract) {
            contract.FinancialOrderId = data.FinancialOrderId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Comment = data.Comment;
            contract.LocationAddressId = data.LocationAddressId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.FinancialOrderSourceRcd = data.FinancialOrderSourceRcd;
            contract.ClientId = data.ClientId;
        }
    }
}
