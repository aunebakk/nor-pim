/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:26 PM
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
    public partial interface ICrudeCartProductService {
        
        [OperationContract()]
        CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchAll();
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeCartProductContract contract);
        
        [OperationContract()]
        void Update(CrudeCartProductContract contract);
        
        [OperationContract()]
        void Delete(System.Guid cartProductId);
    }
    
    public partial class CrudeCartProductService : ICrudeCartProductService {
        
        public CrudeCartProductContract FetchByCartProductId(System.Guid cartProductId) {
            var dataAccessLayer = new CrudeCartProductData();
            var contract = new CrudeCartProductContract();

            dataAccessLayer.FetchByCartProductId(cartProductId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeCartProductContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeCartProductData.FetchByClientId(clientId));
        }
        
        public List<CrudeCartProductContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeCartProductData.FetchByProductId(productId));
        }
        
        public List<CrudeCartProductContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeCartProductData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeCartProductContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeCartProductData.FetchByUserId(userId));
        }
        
        public List<CrudeCartProductContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeCartProductData.FetchByStateRcd(stateRcd));
        }
        
        public static List<CrudeCartProductContract> DataListToContractList(List<CrudeCartProductData> dataList) {
            var contractList = new List<CrudeCartProductContract>();

            foreach (CrudeCartProductData data in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeCartProductContract> contractList, List<CrudeCartProductData> dataList) {
            foreach (CrudeCartProductContract contract in contractList) {
                var data = new CrudeCartProductData();
                CrudeCartProductService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeCartProductContract> FetchAll() {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAll();

            foreach (CrudeCartProductData crudeCartProduct in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(crudeCartProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAllWithLimit(limit);

            foreach (CrudeCartProductData crudeCartProduct in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(crudeCartProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeCartProductData crudeCartProduct in dataList) {
                var contract = new CrudeCartProductContract();
                DataToContract(crudeCartProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeCartProductData.FetchAllCount();
        }
        
        public List<CrudeCartProductContract> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeCartProductContract>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchWithFilter(
                cartProductId: cartProductId,
                clientId: clientId,
                productId: productId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeCartProductData data in dataList) {
                var crudeCartProductContract = new CrudeCartProductContract();
                DataToContract(data, crudeCartProductContract);
                list.Add(crudeCartProductContract);
            }

            return list;
        }
        
        public void Insert(CrudeCartProductContract contract) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeCartProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeCartProductContract contract) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeCartProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid cartProductId) {
            CrudeCartProductData.Delete(cartProductId);
        }
        
        public static void ContractToData(CrudeCartProductContract contract, CrudeCartProductData data) {
            data.CartProductId = contract.CartProductId;
            data.ClientId = contract.ClientId;
            data.ProductId = contract.ProductId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeCartProductData data, CrudeCartProductContract contract) {
            contract.CartProductId = data.CartProductId;
            contract.ClientId = data.ClientId;
            contract.ProductId = data.ProductId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
