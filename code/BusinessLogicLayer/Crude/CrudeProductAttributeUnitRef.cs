using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductAttributeUnitRefContract {
        
        [DataMember()]
        public string ProductAttributeUnitRcd { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeUnitName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductAttributeUnitRefService {
        
        [OperationContract()]
        CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeUnitRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeUnitRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductAttributeUnitRefService : ICrudeProductAttributeUnitRefService {
        
        public CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            var contract = new CrudeProductAttributeUnitRefContract();

            dataAccessLayer.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeUnitRefContract> DataListToContractList(List<CrudeProductAttributeUnitRefData> dataList) {
            var contractList = new List<CrudeProductAttributeUnitRefContract>();

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductAttributeUnitRefContract> contractList, List<CrudeProductAttributeUnitRefData> dataList) {
            foreach (CrudeProductAttributeUnitRefContract contract in contractList) {
                var data = new CrudeProductAttributeUnitRefData();
                CrudeProductAttributeUnitRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchAll() {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            List<CrudeProductAttributeUnitRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            List<CrudeProductAttributeUnitRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            List<CrudeProductAttributeUnitRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductAttributeUnitRefData().FetchAllCount();

        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            List<CrudeProductAttributeUnitRefData> dataList = dataAccessLayer.FetchWithFilter(productAttributeUnitRcd,productAttributeUnitName,userId,dateTime);

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var crudeProductAttributeUnitRefContract = new CrudeProductAttributeUnitRefContract();
                DataToContract(data, crudeProductAttributeUnitRefContract);
                list.Add(crudeProductAttributeUnitRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeUnitRefContract contract) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductAttributeUnitRefContract contract) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductAttributeUnitRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductAttributeUnitRefContract contract, CrudeProductAttributeUnitRefData data) {
            data.ProductAttributeUnitRcd = contract.ProductAttributeUnitRcd;
            data.ProductAttributeUnitName = contract.ProductAttributeUnitName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductAttributeUnitRefData data, CrudeProductAttributeUnitRefContract contract) {
            contract.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            contract.ProductAttributeUnitName = data.ProductAttributeUnitName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
