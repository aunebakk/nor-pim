using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductExposeSetContract {
        
        [DataMember()]
        public System.Guid ProductExposeSetId { get; set; } //;
        
        [DataMember()]
        public string ProductExposeSetTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductExposeSetName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductExposeSetService {
        
        [OperationContract()]
        CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductExposeSetService : ICrudeProductExposeSetService {
        
        public CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            var contract = new CrudeProductExposeSetContract();

            dataAccessLayer.FetchByProductExposeSetId(productExposeSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductExposeSetContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeSetContract> DataListToContractList(List<CrudeProductExposeSetData> dataList) {
            var contractList = new List<CrudeProductExposeSetContract>();

            foreach (CrudeProductExposeSetData data in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposeSetContract> contractList, List<CrudeProductExposeSetData> dataList) {
            foreach (CrudeProductExposeSetContract contract in contractList) {
                var data = new CrudeProductExposeSetData();
                CrudeProductExposeSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeSetContract> FetchAll() {
            var list = new List<CrudeProductExposeSetContract>();
            var dataAccessLayer = new CrudeProductExposeSetData();
            List<CrudeProductExposeSetData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeSetContract>();
            var dataAccessLayer = new CrudeProductExposeSetData();
            List<CrudeProductExposeSetData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeSetContract>();
            var dataAccessLayer = new CrudeProductExposeSetData();
            List<CrudeProductExposeSetData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductExposeSetData().FetchAllCount();

        }
        
        public List<CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetContract>();
            var dataAccessLayer = new CrudeProductExposeSetData();
            List<CrudeProductExposeSetData> dataList = dataAccessLayer.FetchWithFilter(productExposeSetId,productExposeSetTypeRcd,productExposeSetName,userId,dateTime);

            foreach (CrudeProductExposeSetData data in dataList) {
                var crudeProductExposeSetContract = new CrudeProductExposeSetContract();
                DataToContract(data, crudeProductExposeSetContract);
                list.Add(crudeProductExposeSetContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeSetContract contract) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductExposeSetContract contract) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductExposeSetData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductExposeSetContract contract, CrudeProductExposeSetData data) {
            data.ProductExposeSetId = contract.ProductExposeSetId;
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.ProductExposeSetName = contract.ProductExposeSetName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposeSetData data, CrudeProductExposeSetContract contract) {
            contract.ProductExposeSetId = data.ProductExposeSetId;
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.ProductExposeSetName = data.ProductExposeSetName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
