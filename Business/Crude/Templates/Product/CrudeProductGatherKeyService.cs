/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:53:15 AM
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
    public partial interface ICrudeProductGatherKeyService {
        
        [OperationContract()]
        CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherKeyContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherKeyContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherKeyId);
    }
    
    public partial class CrudeProductGatherKeyService : ICrudeProductGatherKeyService {
        
        public CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            var dataAccessLayer = new CrudeProductGatherKeyData();
            var contract = new CrudeProductGatherKeyContract();

            dataAccessLayer.FetchByProductGatherKeyId(productGatherKeyId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId) {
            return DataListToContractList(CrudeProductGatherKeyData.FetchByProductGatherId(productGatherId));
        }
        
        public List<CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherKeyData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherKeyContract> DataListToContractList(List<CrudeProductGatherKeyData> dataList) {
            var contractList = new List<CrudeProductGatherKeyContract>();

            foreach (CrudeProductGatherKeyData data in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherKeyContract> contractList, List<CrudeProductGatherKeyData> dataList) {
            foreach (CrudeProductGatherKeyContract contract in contractList) {
                var data = new CrudeProductGatherKeyData();
                CrudeProductGatherKeyService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherKeyContract> FetchAll() {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAll();

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherKeyData.FetchAllCount();
        }
        
        public List<CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchWithFilter(
                productGatherKeyId: productGatherKeyId,
                productGatherKeyValue: productGatherKeyValue,
                productGatherId: productGatherId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherKeyData data in dataList) {
                var crudeProductGatherKeyContract = new CrudeProductGatherKeyContract();
                DataToContract(data, crudeProductGatherKeyContract);
                list.Add(crudeProductGatherKeyContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherKeyContract contract) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherKeyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherKeyContract contract) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherKeyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherKeyId) {
            CrudeProductGatherKeyData.Delete(productGatherKeyId);
        }
        
        public static void ContractToData(CrudeProductGatherKeyContract contract, CrudeProductGatherKeyData data) {
            data.ProductGatherKeyId = contract.ProductGatherKeyId;
            data.ProductGatherKeyValue = contract.ProductGatherKeyValue;
            data.ProductGatherId = contract.ProductGatherId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherKeyData data, CrudeProductGatherKeyContract contract) {
            contract.ProductGatherKeyId = data.ProductGatherKeyId;
            contract.ProductGatherKeyValue = data.ProductGatherKeyValue;
            contract.ProductGatherId = data.ProductGatherId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
