using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductCategoryMappingContract {
        
        [DataMember()]
        public System.Guid ProductCategoryMappingId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductCategoryMappingService {
        
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
        void Delete(System.Guid id);
    }
    
    public class CrudeProductCategoryMappingService : ICrudeProductCategoryMappingService {
        
        public CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId) {
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            var contract = new CrudeProductCategoryMappingContract();

            dataAccessLayer.FetchByProductCategoryMappingId(productCategoryMappingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryMappingContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            return DataListToContractList(dataAccessLayer.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryMappingContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductCategoryMappingContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
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
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            List<CrudeProductCategoryMappingData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryMappingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryMappingContract>();
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            List<CrudeProductCategoryMappingData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryMappingContract>();
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            List<CrudeProductCategoryMappingData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductCategoryMappingData().FetchAllCount();

        }
        
        public List<CrudeProductCategoryMappingContract> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryMappingContract>();
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            List<CrudeProductCategoryMappingData> dataList = dataAccessLayer.FetchWithFilter(productCategoryMappingId,productCategoryId,productId,userId,dateTime);

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
        
        public void Update(CrudeProductCategoryMappingContract contract) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductCategoryMappingData();
            data.Delete(id);
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
