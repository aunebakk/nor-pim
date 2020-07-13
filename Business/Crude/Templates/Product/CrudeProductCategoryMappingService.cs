/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:06:43 AM
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
    public partial interface ICrudeProductCategoryMappingService {
        
        [OperationContract()]
        CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryMappingContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryMappingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productCategoryMappingId);
    }
    
    public partial class CrudeProductCategoryMappingService : ICrudeProductCategoryMappingService {
        
        public CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId) {
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            var contract = new CrudeProductCategoryMappingContract();

            dataAccessLayer.FetchByProductCategoryMappingId(productCategoryMappingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryMappingContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToContractList(CrudeProductCategoryMappingData.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryMappingContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductCategoryMappingData.FetchByProductId(productId));
        }
        
        public List<CrudeProductCategoryMappingContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryMappingData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryMappingContract> DataListToContractList(List<CrudeProductCategoryMappingData> dataList) {
            var contractList = new List<CrudeProductCategoryMappingContract>();

            foreach (CrudeProductCategoryMappingData data in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryMappingContract> contractList, List<CrudeProductCategoryMappingData> dataList) {
            foreach (CrudeProductCategoryMappingContract contract in contractList) {
                var data = new CrudeProductCategoryMappingData();
                CrudeProductCategoryMappingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryMappingContract> FetchAll() {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAll();

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryMappingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryMappingData.FetchAllCount();
        }
        
        public List<CrudeProductCategoryMappingContract> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchWithFilter(
                productCategoryMappingId: productCategoryMappingId,
                productCategoryId: productCategoryId,
                productId: productId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryMappingData data in dataList) {
                var crudeProductCategoryMappingContract = new CrudeProductCategoryMappingContract();
                DataToContract(data, crudeProductCategoryMappingContract);
                list.Add(crudeProductCategoryMappingContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryMappingContract contract) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryMappingContract contract) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryMappingId) {
            CrudeProductCategoryMappingData.Delete(productCategoryMappingId);
        }
        
        public static void ContractToData(CrudeProductCategoryMappingContract contract, CrudeProductCategoryMappingData data) {
            data.ProductCategoryMappingId = contract.ProductCategoryMappingId;
            data.ProductCategoryId = contract.ProductCategoryId;
            data.ProductId = contract.ProductId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryMappingData data, CrudeProductCategoryMappingContract contract) {
            contract.ProductCategoryMappingId = data.ProductCategoryMappingId;
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.ProductId = data.ProductId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
