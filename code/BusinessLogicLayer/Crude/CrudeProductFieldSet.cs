using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductFieldSetContract {
        
        [DataMember()]
        public System.Guid ProductFieldSetId { get; set; } //;
        
        [DataMember()]
        public string ProductFieldSetName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductFieldSetService {
        
        [OperationContract()]
        CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductFieldSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductFieldSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductFieldSetService : ICrudeProductFieldSetService {
        
        public CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            var contract = new CrudeProductFieldSetContract();

            dataAccessLayer.FetchByProductFieldSetId(productFieldSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductFieldSetContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductFieldSetContract> DataListToContractList(List<CrudeProductFieldSetData> dataList) {
            var contractList = new List<CrudeProductFieldSetContract>();

            foreach (CrudeProductFieldSetData data in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductFieldSetContract> contractList, List<CrudeProductFieldSetData> dataList) {
            foreach (CrudeProductFieldSetContract contract in contractList) {
                var data = new CrudeProductFieldSetData();
                CrudeProductFieldSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductFieldSetContract> FetchAll() {
            var list = new List<CrudeProductFieldSetContract>();
            var dataAccessLayer = new CrudeProductFieldSetData();
            List<CrudeProductFieldSetData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductFieldSetContract>();
            var dataAccessLayer = new CrudeProductFieldSetData();
            List<CrudeProductFieldSetData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductFieldSetContract>();
            var dataAccessLayer = new CrudeProductFieldSetData();
            List<CrudeProductFieldSetData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductFieldSetData().FetchAllCount();

        }
        
        public List<CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetContract>();
            var dataAccessLayer = new CrudeProductFieldSetData();
            List<CrudeProductFieldSetData> dataList = dataAccessLayer.FetchWithFilter(productFieldSetId,productFieldSetName,userId,dateTime);

            foreach (CrudeProductFieldSetData data in dataList) {
                var crudeProductFieldSetContract = new CrudeProductFieldSetContract();
                DataToContract(data, crudeProductFieldSetContract);
                list.Add(crudeProductFieldSetContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductFieldSetContract contract) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductFieldSetContract contract) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductFieldSetData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductFieldSetContract contract, CrudeProductFieldSetData data) {
            data.ProductFieldSetId = contract.ProductFieldSetId;
            data.ProductFieldSetName = contract.ProductFieldSetName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductFieldSetData data, CrudeProductFieldSetContract contract) {
            contract.ProductFieldSetId = data.ProductFieldSetId;
            contract.ProductFieldSetName = data.ProductFieldSetName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
