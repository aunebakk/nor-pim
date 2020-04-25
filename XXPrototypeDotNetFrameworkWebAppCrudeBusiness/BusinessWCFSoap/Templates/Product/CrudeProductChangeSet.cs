/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:19:51 AM
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
    public partial interface ICrudeProductChangeSetService {
        
        [OperationContract()]
        CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductChangeSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductChangeSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productChangeSetId);
    }
    
    public partial class CrudeProductChangeSetService : ICrudeProductChangeSetService {
        
        public CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId) {
            var dataAccessLayer = new CrudeProductChangeSetData();
            var contract = new CrudeProductChangeSetContract();

            dataAccessLayer.FetchByProductChangeSetId(productChangeSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductChangeSetContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductChangeSetData.FetchByProductId(productId));
        }
        
        public List<CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return DataListToContractList(CrudeProductChangeSetData.FetchByProductGatherKeyId(productGatherKeyId));
        }
        
        public List<CrudeProductChangeSetContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductChangeSetData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductChangeSetContract> DataListToContractList(List<CrudeProductChangeSetData> dataList) {
            var contractList = new List<CrudeProductChangeSetContract>();

            foreach (CrudeProductChangeSetData data in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductChangeSetContract> contractList, List<CrudeProductChangeSetData> dataList) {
            foreach (CrudeProductChangeSetContract contract in contractList) {
                var data = new CrudeProductChangeSetData();
                CrudeProductChangeSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductChangeSetContract> FetchAll() {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAll();

            foreach (CrudeProductChangeSetData crudeProductChangeSet in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(crudeProductChangeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductChangeSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAllWithLimit(limit);

            foreach (CrudeProductChangeSetData crudeProductChangeSet in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(crudeProductChangeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductChangeSetData crudeProductChangeSet in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(crudeProductChangeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductChangeSetData.FetchAllCount();
        }
        
        public List<CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchWithFilter(
                productChangeSetId: productChangeSetId,
                productId: productId,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductChangeSetData data in dataList) {
                var crudeProductChangeSetContract = new CrudeProductChangeSetContract();
                DataToContract(data, crudeProductChangeSetContract);
                list.Add(crudeProductChangeSetContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductChangeSetContract contract) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductChangeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductChangeSetContract contract) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductChangeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productChangeSetId) {
            CrudeProductChangeSetData.Delete(productChangeSetId);
        }
        
        public static void ContractToData(CrudeProductChangeSetContract contract, CrudeProductChangeSetData data) {
            data.ProductChangeSetId = contract.ProductChangeSetId;
            data.ProductId = contract.ProductId;
            data.ProductGatherKeyId = contract.ProductGatherKeyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductChangeSetData data, CrudeProductChangeSetContract contract) {
            contract.ProductChangeSetId = data.ProductChangeSetId;
            contract.ProductId = data.ProductId;
            contract.ProductGatherKeyId = data.ProductGatherKeyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
