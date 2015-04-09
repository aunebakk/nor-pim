using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductContract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductBecameId { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductService {
        
        [OperationContract()]
        CrudeProductContract FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductContract FetchByProductName(string productName);
        
        [OperationContract()]
        List<CrudeProductContract> FetchWithFilter(System.Guid productId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime);
        
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
        void Delete(System.Guid id);
    }
    
    public class CrudeProductService : ICrudeProductService {
        
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
        
        public List<CrudeProductContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
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
            var dataAccessLayer = new CrudeProductData();
            List<CrudeProductData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductContract>();
            var dataAccessLayer = new CrudeProductData();
            List<CrudeProductData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductContract>();
            var dataAccessLayer = new CrudeProductData();
            List<CrudeProductData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductData().FetchAllCount();

        }
        
        public List<CrudeProductContract> FetchWithFilter(System.Guid productId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductContract>();
            var dataAccessLayer = new CrudeProductData();
            List<CrudeProductData> dataList = dataAccessLayer.FetchWithFilter(productId,productName,stateRcd,userId,dateTime);

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
        
        public void Update(CrudeProductContract contract) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductData();
            data.Delete(id);
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
