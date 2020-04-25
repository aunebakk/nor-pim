/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:04 AM
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
    public partial interface ICrudeCartProductPriceService {
        
        [OperationContract()]
        CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAll();
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeCartProductPriceContract contract);
        
        [OperationContract()]
        void Update(CrudeCartProductPriceContract contract);
        
        [OperationContract()]
        void Delete(System.Guid cartProductPriceId);
    }
    
    public partial class CrudeCartProductPriceService : ICrudeCartProductPriceService {
        
        public CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId) {
            var dataAccessLayer = new CrudeCartProductPriceData();
            var contract = new CrudeCartProductPriceContract();

            dataAccessLayer.FetchByCartProductPriceId(cartProductPriceId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeCartProductPriceContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByUserId(userId));
        }
        
        public List<CrudeCartProductPriceContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByProductId(productId));
        }
        
        public List<CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByStateRcd(stateRcd));
        }
        
        public static List<CrudeCartProductPriceContract> DataListToContractList(List<CrudeCartProductPriceData> dataList) {
            var contractList = new List<CrudeCartProductPriceContract>();

            foreach (CrudeCartProductPriceData data in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeCartProductPriceContract> contractList, List<CrudeCartProductPriceData> dataList) {
            foreach (CrudeCartProductPriceContract contract in contractList) {
                var data = new CrudeCartProductPriceData();
                CrudeCartProductPriceService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeCartProductPriceContract> FetchAll() {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAll();

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductPriceContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimit(limit);

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeCartProductPriceData.FetchAllCount();
        }
        
        public List<CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchWithFilter(
                cartProductPriceId: cartProductPriceId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime,
                productId: productId
                );

            foreach (CrudeCartProductPriceData data in dataList) {
                var crudeCartProductPriceContract = new CrudeCartProductPriceContract();
                DataToContract(data, crudeCartProductPriceContract);
                list.Add(crudeCartProductPriceContract);
            }

            return list;
        }
        
        public void Insert(CrudeCartProductPriceContract contract) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeCartProductPriceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeCartProductPriceContract contract) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeCartProductPriceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid cartProductPriceId) {
            CrudeCartProductPriceData.Delete(cartProductPriceId);
        }
        
        public static void ContractToData(CrudeCartProductPriceContract contract, CrudeCartProductPriceData data) {
            data.CartProductPriceId = contract.CartProductPriceId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ProductId = contract.ProductId;
        }
        
        public static void DataToContract(CrudeCartProductPriceData data, CrudeCartProductPriceContract contract) {
            contract.CartProductPriceId = data.CartProductPriceId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ProductId = data.ProductId;
        }
    }
}
