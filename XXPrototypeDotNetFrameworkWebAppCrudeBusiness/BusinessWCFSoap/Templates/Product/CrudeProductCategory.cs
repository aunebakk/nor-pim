/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:39:05 AM
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
    public partial interface ICrudeProductCategoryService {
        
        [OperationContract()]
        CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchByProductCategoryParentId(System.Guid productCategoryParentId);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        CrudeProductCategoryContract FetchByProductCategoryName(string productCategoryName);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productCategoryId);
    }
    
    public partial class CrudeProductCategoryService : ICrudeProductCategoryService {
        
        public CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataAccessLayer = new CrudeProductCategoryData();
            var contract = new CrudeProductCategoryContract();

            dataAccessLayer.FetchByProductCategoryId(productCategoryId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductCategoryContract FetchByProductCategoryName(string productCategoryName) {
            var dataAccessLayer = new CrudeProductCategoryData();
            var contract = new CrudeProductCategoryContract();

            dataAccessLayer.FetchByProductCategoryName(productCategoryName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryContract> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId) {
            return DataListToContractList(CrudeProductCategoryData.FetchByProductCategoryBecameId(productCategoryBecameId));
        }
        
        public List<CrudeProductCategoryContract> FetchByProductCategoryParentId(System.Guid productCategoryParentId) {
            return DataListToContractList(CrudeProductCategoryData.FetchByProductCategoryParentId(productCategoryParentId));
        }
        
        public List<CrudeProductCategoryContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryData.FetchByUserId(userId));
        }
        
        public List<CrudeProductCategoryContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeProductCategoryData.FetchByStateRcd(stateRcd));
        }
        
        public static List<CrudeProductCategoryContract> DataListToContractList(List<CrudeProductCategoryData> dataList) {
            var contractList = new List<CrudeProductCategoryContract>();

            foreach (CrudeProductCategoryData data in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryContract> contractList, List<CrudeProductCategoryData> dataList) {
            foreach (CrudeProductCategoryContract contract in contractList) {
                var data = new CrudeProductCategoryData();
                CrudeProductCategoryService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryContract> FetchAll() {
            var list = new List<CrudeProductCategoryContract>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchAll();

            foreach (CrudeProductCategoryData crudeProductCategory in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(crudeProductCategory, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryContract>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryData crudeProductCategory in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(crudeProductCategory, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryContract>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryData crudeProductCategory in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(crudeProductCategory, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryData.FetchAllCount();
        }
        
        public List<CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryContract>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchWithFilter(
                productCategoryId: productCategoryId,
                productCategoryBecameId: productCategoryBecameId,
                productCategoryParentId: productCategoryParentId,
                productCategoryCode: productCategoryCode,
                productCategoryName: productCategoryName,
                productCategoryPosition: productCategoryPosition,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryData data in dataList) {
                var crudeProductCategoryContract = new CrudeProductCategoryContract();
                DataToContract(data, crudeProductCategoryContract);
                list.Add(crudeProductCategoryContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryContract contract) {
            var data = new CrudeProductCategoryData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryContract contract) {
            var data = new CrudeProductCategoryData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryId) {
            CrudeProductCategoryData.Delete(productCategoryId);
        }
        
        public static void ContractToData(CrudeProductCategoryContract contract, CrudeProductCategoryData data) {
            data.ProductCategoryId = contract.ProductCategoryId;
            data.ProductCategoryBecameId = contract.ProductCategoryBecameId;
            data.ProductCategoryParentId = contract.ProductCategoryParentId;
            data.ProductCategoryCode = contract.ProductCategoryCode;
            data.ProductCategoryName = contract.ProductCategoryName;
            data.ProductCategoryPosition = contract.ProductCategoryPosition;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryData data, CrudeProductCategoryContract contract) {
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.ProductCategoryBecameId = data.ProductCategoryBecameId;
            contract.ProductCategoryParentId = data.ProductCategoryParentId;
            contract.ProductCategoryCode = data.ProductCategoryCode;
            contract.ProductCategoryName = data.ProductCategoryName;
            contract.ProductCategoryPosition = data.ProductCategoryPosition;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
