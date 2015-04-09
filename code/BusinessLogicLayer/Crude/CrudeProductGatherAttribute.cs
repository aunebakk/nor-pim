using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductGatherAttributeContract {
        
        [DataMember()]
        public System.Guid ProductGatherAttributeId { get; set; } //;
        
        [DataMember()]
        public string ProductGatherAttributeValue { get; set; } //;
        
        [DataMember()]
        public string ProductGatherAttributeTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductGatherKeyId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductGatherAttributeService {
        
        [OperationContract()]
        CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherAttributeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherAttributeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductGatherAttributeService : ICrudeProductGatherAttributeService {
        
        public CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            var contract = new CrudeProductGatherAttributeContract();

            dataAccessLayer.FetchByProductGatherAttributeId(productGatherAttributeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            return DataListToContractList(dataAccessLayer.FetchByProductGatherKeyId(productGatherKeyId));
        }
        
        public List<CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherAttributeContract> DataListToContractList(List<CrudeProductGatherAttributeData> dataList) {
            var contractList = new List<CrudeProductGatherAttributeContract>();

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherAttributeContract> contractList, List<CrudeProductGatherAttributeData> dataList) {
            foreach (CrudeProductGatherAttributeContract contract in contractList) {
                var data = new CrudeProductGatherAttributeData();
                CrudeProductGatherAttributeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherAttributeContract> FetchAll() {
            var list = new List<CrudeProductGatherAttributeContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            List<CrudeProductGatherAttributeData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherAttributeContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            List<CrudeProductGatherAttributeData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherAttributeContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            List<CrudeProductGatherAttributeData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductGatherAttributeData().FetchAllCount();

        }
        
        public List<CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherAttributeContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            List<CrudeProductGatherAttributeData> dataList = dataAccessLayer.FetchWithFilter(productGatherAttributeId,productGatherAttributeValue,productGatherAttributeTypeRcd,productGatherKeyId,userId,dateTime);

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var crudeProductGatherAttributeContract = new CrudeProductGatherAttributeContract();
                DataToContract(data, crudeProductGatherAttributeContract);
                list.Add(crudeProductGatherAttributeContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherAttributeContract contract) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductGatherAttributeContract contract) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductGatherAttributeData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductGatherAttributeContract contract, CrudeProductGatherAttributeData data) {
            data.ProductGatherAttributeId = contract.ProductGatherAttributeId;
            data.ProductGatherAttributeValue = contract.ProductGatherAttributeValue;
            data.ProductGatherAttributeTypeRcd = contract.ProductGatherAttributeTypeRcd;
            data.ProductGatherKeyId = contract.ProductGatherKeyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherAttributeData data, CrudeProductGatherAttributeContract contract) {
            contract.ProductGatherAttributeId = data.ProductGatherAttributeId;
            contract.ProductGatherAttributeValue = data.ProductGatherAttributeValue;
            contract.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            contract.ProductGatherKeyId = data.ProductGatherKeyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
