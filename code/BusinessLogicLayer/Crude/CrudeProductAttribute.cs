using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductAttributeContract {
        
        [DataMember()]
        public System.Guid ProductAttributeId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeUnitRcd { get; set; } //;
        
        [DataMember()]
        public string Value { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductAttributeService {
        
        [OperationContract()]
        CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductAttributeService : ICrudeProductAttributeService {
        
        public CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId) {
            var dataAccessLayer = new CrudeProductAttributeData();
            var contract = new CrudeProductAttributeContract();

            dataAccessLayer.FetchByProductAttributeId(productAttributeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductAttributeContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductAttributeData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductAttributeContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductAttributeData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeContract> DataListToContractList(List<CrudeProductAttributeData> dataList) {
            var contractList = new List<CrudeProductAttributeContract>();

            foreach (CrudeProductAttributeData data in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductAttributeContract> contractList, List<CrudeProductAttributeData> dataList) {
            foreach (CrudeProductAttributeContract contract in contractList) {
                var data = new CrudeProductAttributeData();
                CrudeProductAttributeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeContract> FetchAll() {
            var list = new List<CrudeProductAttributeContract>();
            var dataAccessLayer = new CrudeProductAttributeData();
            List<CrudeProductAttributeData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeContract>();
            var dataAccessLayer = new CrudeProductAttributeData();
            List<CrudeProductAttributeData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeContract>();
            var dataAccessLayer = new CrudeProductAttributeData();
            List<CrudeProductAttributeData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductAttributeData().FetchAllCount();

        }
        
        public List<CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeContract>();
            var dataAccessLayer = new CrudeProductAttributeData();
            List<CrudeProductAttributeData> dataList = dataAccessLayer.FetchWithFilter(productAttributeId,productId,productAttributeRcd,productAttributeUnitRcd,value,userId,dateTime);

            foreach (CrudeProductAttributeData data in dataList) {
                var crudeProductAttributeContract = new CrudeProductAttributeContract();
                DataToContract(data, crudeProductAttributeContract);
                list.Add(crudeProductAttributeContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeContract contract) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductAttributeContract contract) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductAttributeData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductAttributeContract contract, CrudeProductAttributeData data) {
            data.ProductAttributeId = contract.ProductAttributeId;
            data.ProductId = contract.ProductId;
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductAttributeUnitRcd = contract.ProductAttributeUnitRcd;
            data.Value = contract.Value;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductAttributeData data, CrudeProductAttributeContract contract) {
            contract.ProductAttributeId = data.ProductAttributeId;
            contract.ProductId = data.ProductId;
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            contract.Value = data.Value;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
