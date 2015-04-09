using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductInfoContract {
        
        [DataMember()]
        public System.Guid ProductInfoId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductInfoRcd { get; set; } //;
        
        [DataMember()]
        public string ProductInfoValue { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductInfoService {
        
        [OperationContract()]
        CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductInfoContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInfoContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductInfoService : ICrudeProductInfoService {
        
        public CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId) {
            var dataAccessLayer = new CrudeProductInfoData();
            var contract = new CrudeProductInfoContract();

            dataAccessLayer.FetchByProductInfoId(productInfoId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductInfoContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductInfoData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductInfoContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductInfoData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductInfoContract> DataListToContractList(List<CrudeProductInfoData> dataList) {
            var contractList = new List<CrudeProductInfoContract>();

            foreach (CrudeProductInfoData data in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductInfoContract> contractList, List<CrudeProductInfoData> dataList) {
            foreach (CrudeProductInfoContract contract in contractList) {
                var data = new CrudeProductInfoData();
                CrudeProductInfoService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInfoContract> FetchAll() {
            var list = new List<CrudeProductInfoContract>();
            var dataAccessLayer = new CrudeProductInfoData();
            List<CrudeProductInfoData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductInfoContract>();
            var dataAccessLayer = new CrudeProductInfoData();
            List<CrudeProductInfoData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductInfoContract>();
            var dataAccessLayer = new CrudeProductInfoData();
            List<CrudeProductInfoData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductInfoData().FetchAllCount();

        }
        
        public List<CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoContract>();
            var dataAccessLayer = new CrudeProductInfoData();
            List<CrudeProductInfoData> dataList = dataAccessLayer.FetchWithFilter(productInfoId,productId,productInfoRcd,productInfoValue,userId,dateTime);

            foreach (CrudeProductInfoData data in dataList) {
                var crudeProductInfoContract = new CrudeProductInfoContract();
                DataToContract(data, crudeProductInfoContract);
                list.Add(crudeProductInfoContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductInfoContract contract) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductInfoContract contract) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductInfoData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductInfoContract contract, CrudeProductInfoData data) {
            data.ProductInfoId = contract.ProductInfoId;
            data.ProductId = contract.ProductId;
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductInfoValue = contract.ProductInfoValue;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductInfoData data, CrudeProductInfoContract contract) {
            contract.ProductInfoId = data.ProductInfoId;
            contract.ProductId = data.ProductId;
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductInfoValue = data.ProductInfoValue;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
