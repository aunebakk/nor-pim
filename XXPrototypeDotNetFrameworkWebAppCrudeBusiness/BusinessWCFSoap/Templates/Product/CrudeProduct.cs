/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:22:47 PM
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
    public partial interface ICrudeProductService {
        
        [OperationContract()]
        CrudeProductContract FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductContract> FetchByProductBecameId(System.Guid productBecameId);
        
        [OperationContract()]
        List<CrudeProductContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        CrudeProductContract FetchByProductName(string productName);
        
        [OperationContract()]
        List<CrudeProductContract> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductContract contract);
        
        [OperationContract()]
        void Update(CrudeProductContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productId);
    }
    
    public partial class CrudeProductService : ICrudeProductService {
        
        public CrudeProductContract FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductData();
            var contract = new CrudeProductContract();

            dataAccessLayer.FetchByProductId(productId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductContract FetchByProductName(string productName) {
            var dataAccessLayer = new CrudeProductData();
            var contract = new CrudeProductContract();

            dataAccessLayer.FetchByProductName(productName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductContract> FetchByProductBecameId(System.Guid productBecameId) {
            return DataListToContractList(CrudeProductData.FetchByProductBecameId(productBecameId));
        }
        
        public List<CrudeProductContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductData.FetchByUserId(userId));
        }
        
        public List<CrudeProductContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeProductData.FetchByStateRcd(stateRcd));
        }
        
        public static List<CrudeProductContract> DataListToContractList(List<CrudeProductData> dataList) {
            var contractList = new List<CrudeProductContract>();

            foreach (CrudeProductData data in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductContract> contractList, List<CrudeProductData> dataList) {
            foreach (CrudeProductContract contract in contractList) {
                var data = new CrudeProductData();
                CrudeProductService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductContract> FetchAll() {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAll();

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAllWithLimit(limit);

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductData.FetchAllCount();
        }
        
        public List<CrudeProductContract> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchWithFilter(
                productId: productId,
                productBecameId: productBecameId,
                productName: productName,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductData data in dataList) {
                var crudeProductContract = new CrudeProductContract();
                DataToContract(data, crudeProductContract);
                list.Add(crudeProductContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductContract contract) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductContract contract) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productId) {
            CrudeProductData.Delete(productId);
        }
        
        public static void ContractToData(CrudeProductContract contract, CrudeProductData data) {
            data.ProductId = contract.ProductId;
            data.ProductBecameId = contract.ProductBecameId;
            data.ProductName = contract.ProductName;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductData data, CrudeProductContract contract) {
            contract.ProductId = data.ProductId;
            contract.ProductBecameId = data.ProductBecameId;
            contract.ProductName = data.ProductName;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
