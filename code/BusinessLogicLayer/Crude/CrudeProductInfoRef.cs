using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductInfoRefContract {
        
        [DataMember()]
        public string ProductInfoRcd { get; set; } //;
        
        [DataMember()]
        public string ProductInfoName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductInfoRefService {
        
        [OperationContract()]
        CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductInfoRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInfoRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductInfoRefService : ICrudeProductInfoRefService {
        
        public CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            var contract = new CrudeProductInfoRefContract();

            dataAccessLayer.FetchByProductInfoRcd(productInfoRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductInfoRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductInfoRefContract> DataListToContractList(List<CrudeProductInfoRefData> dataList) {
            var contractList = new List<CrudeProductInfoRefContract>();

            foreach (CrudeProductInfoRefData data in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductInfoRefContract> contractList, List<CrudeProductInfoRefData> dataList) {
            foreach (CrudeProductInfoRefContract contract in contractList) {
                var data = new CrudeProductInfoRefData();
                CrudeProductInfoRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInfoRefContract> FetchAll() {
            var list = new List<CrudeProductInfoRefContract>();
            var dataAccessLayer = new CrudeProductInfoRefData();
            List<CrudeProductInfoRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductInfoRefContract>();
            var dataAccessLayer = new CrudeProductInfoRefData();
            List<CrudeProductInfoRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductInfoRefContract>();
            var dataAccessLayer = new CrudeProductInfoRefData();
            List<CrudeProductInfoRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductInfoRefData().FetchAllCount();

        }
        
        public List<CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoRefContract>();
            var dataAccessLayer = new CrudeProductInfoRefData();
            List<CrudeProductInfoRefData> dataList = dataAccessLayer.FetchWithFilter(productInfoRcd,productInfoName,userId,dateTime);

            foreach (CrudeProductInfoRefData data in dataList) {
                var crudeProductInfoRefContract = new CrudeProductInfoRefContract();
                DataToContract(data, crudeProductInfoRefContract);
                list.Add(crudeProductInfoRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductInfoRefContract contract) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductInfoRefContract contract) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductInfoRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductInfoRefContract contract, CrudeProductInfoRefData data) {
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductInfoName = contract.ProductInfoName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductInfoRefData data, CrudeProductInfoRefContract contract) {
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductInfoName = data.ProductInfoName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
