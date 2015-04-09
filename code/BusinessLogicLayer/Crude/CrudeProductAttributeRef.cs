using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductAttributeRefContract {
        
        [DataMember()]
        public string ProductAttributeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductAttributeRefService {
        
        [OperationContract()]
        CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductAttributeRefService : ICrudeProductAttributeRefService {
        
        public CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            var contract = new CrudeProductAttributeRefContract();

            dataAccessLayer.FetchByProductAttributeRcd(productAttributeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeRefContract> DataListToContractList(List<CrudeProductAttributeRefData> dataList) {
            var contractList = new List<CrudeProductAttributeRefContract>();

            foreach (CrudeProductAttributeRefData data in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductAttributeRefContract> contractList, List<CrudeProductAttributeRefData> dataList) {
            foreach (CrudeProductAttributeRefContract contract in contractList) {
                var data = new CrudeProductAttributeRefData();
                CrudeProductAttributeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeRefContract> FetchAll() {
            var list = new List<CrudeProductAttributeRefContract>();
            var dataAccessLayer = new CrudeProductAttributeRefData();
            List<CrudeProductAttributeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeRefContract>();
            var dataAccessLayer = new CrudeProductAttributeRefData();
            List<CrudeProductAttributeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeRefContract>();
            var dataAccessLayer = new CrudeProductAttributeRefData();
            List<CrudeProductAttributeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductAttributeRefData().FetchAllCount();

        }
        
        public List<CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeRefContract>();
            var dataAccessLayer = new CrudeProductAttributeRefData();
            List<CrudeProductAttributeRefData> dataList = dataAccessLayer.FetchWithFilter(productAttributeRcd,productAttributeName,userId,dateTime);

            foreach (CrudeProductAttributeRefData data in dataList) {
                var crudeProductAttributeRefContract = new CrudeProductAttributeRefContract();
                DataToContract(data, crudeProductAttributeRefContract);
                list.Add(crudeProductAttributeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeRefContract contract) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductAttributeRefContract contract) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductAttributeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductAttributeRefContract contract, CrudeProductAttributeRefData data) {
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductAttributeName = contract.ProductAttributeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductAttributeRefData data, CrudeProductAttributeRefContract contract) {
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductAttributeName = data.ProductAttributeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
