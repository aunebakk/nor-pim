using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductExposeContract {
        
        [DataMember()]
        public System.Guid ProductExposeId { get; set; } //;
        
        [DataMember()]
        public System.Guid ExposeProductId { get; set; } //;
        
        [DataMember()]
        public System.Guid ExposeBasedOnProductId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductExposeSetId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductExposeService {
        
        [OperationContract()]
        CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductExposeService : ICrudeProductExposeService {
        
        public CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId) {
            var dataAccessLayer = new CrudeProductExposeData();
            var contract = new CrudeProductExposeContract();

            dataAccessLayer.FetchByProductExposeId(productExposeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId) {
            var dataAccessLayer = new CrudeProductExposeData();
            return DataListToContractList(dataAccessLayer.FetchByProductExposeSetId(productExposeSetId));
        }
        
        public List<CrudeProductExposeContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductExposeData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeContract> DataListToContractList(List<CrudeProductExposeData> dataList) {
            var contractList = new List<CrudeProductExposeContract>();

            foreach (CrudeProductExposeData data in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposeContract> contractList, List<CrudeProductExposeData> dataList) {
            foreach (CrudeProductExposeContract contract in contractList) {
                var data = new CrudeProductExposeData();
                CrudeProductExposeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeContract> FetchAll() {
            var list = new List<CrudeProductExposeContract>();
            var dataAccessLayer = new CrudeProductExposeData();
            List<CrudeProductExposeData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeContract>();
            var dataAccessLayer = new CrudeProductExposeData();
            List<CrudeProductExposeData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeContract>();
            var dataAccessLayer = new CrudeProductExposeData();
            List<CrudeProductExposeData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductExposeData().FetchAllCount();

        }
        
        public List<CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeContract>();
            var dataAccessLayer = new CrudeProductExposeData();
            List<CrudeProductExposeData> dataList = dataAccessLayer.FetchWithFilter(productExposeId,productExposeSetId,userId,dateTime);

            foreach (CrudeProductExposeData data in dataList) {
                var crudeProductExposeContract = new CrudeProductExposeContract();
                DataToContract(data, crudeProductExposeContract);
                list.Add(crudeProductExposeContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeContract contract) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductExposeContract contract) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductExposeData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductExposeContract contract, CrudeProductExposeData data) {
            data.ProductExposeId = contract.ProductExposeId;
            data.ExposeProductId = contract.ExposeProductId;
            data.ExposeBasedOnProductId = contract.ExposeBasedOnProductId;
            data.ProductExposeSetId = contract.ProductExposeSetId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposeData data, CrudeProductExposeContract contract) {
            contract.ProductExposeId = data.ProductExposeId;
            contract.ExposeProductId = data.ExposeProductId;
            contract.ExposeBasedOnProductId = data.ExposeBasedOnProductId;
            contract.ProductExposeSetId = data.ProductExposeSetId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
