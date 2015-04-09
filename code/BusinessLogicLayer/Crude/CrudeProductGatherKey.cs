using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductGatherKeyContract {
        
        [DataMember()]
        public System.Guid ProductGatherKeyId { get; set; } //;
        
        [DataMember()]
        public string ProductGatherKeyValue { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductGatherKeyService {
        
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
        void Delete(System.Guid id);
    }
    
    public class CrudeProductGatherKeyService : ICrudeProductGatherKeyService {
        
        public CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            var dataAccessLayer = new CrudeProductGatherKeyData();
            var contract = new CrudeProductGatherKeyContract();

            dataAccessLayer.FetchByProductGatherKeyId(productGatherKeyId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId) {
            var dataAccessLayer = new CrudeProductGatherKeyData();
            return DataListToContractList(dataAccessLayer.FetchByProductGatherId(productGatherId));
        }
        
        public List<CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductGatherKeyData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
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
            var dataAccessLayer = new CrudeProductGatherKeyData();
            List<CrudeProductGatherKeyData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherKeyContract>();
            var dataAccessLayer = new CrudeProductGatherKeyData();
            List<CrudeProductGatherKeyData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherKeyContract>();
            var dataAccessLayer = new CrudeProductGatherKeyData();
            List<CrudeProductGatherKeyData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductGatherKeyData().FetchAllCount();

        }
        
        public List<CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherKeyContract>();
            var dataAccessLayer = new CrudeProductGatherKeyData();
            List<CrudeProductGatherKeyData> dataList = dataAccessLayer.FetchWithFilter(productGatherKeyId,productGatherKeyValue,productGatherId,userId,dateTime);

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
        
        public void Update(CrudeProductGatherKeyContract contract) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductGatherKeyData();
            data.Delete(id);
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
