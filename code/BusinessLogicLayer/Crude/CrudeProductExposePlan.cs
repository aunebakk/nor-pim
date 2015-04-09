using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductExposePlanContract {
        
        [DataMember()]
        public System.Guid ProductExposePlanId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductExposeSetTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductExposePlanService {
        
        [OperationContract()]
        CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposePlanContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposePlanContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductExposePlanService : ICrudeProductExposePlanService {
        
        public CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId) {
            var dataAccessLayer = new CrudeProductExposePlanData();
            var contract = new CrudeProductExposePlanContract();

            dataAccessLayer.FetchByProductExposePlanId(productExposePlanId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductExposePlanContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductExposePlanData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductExposePlanContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductExposePlanData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposePlanContract> DataListToContractList(List<CrudeProductExposePlanData> dataList) {
            var contractList = new List<CrudeProductExposePlanContract>();

            foreach (CrudeProductExposePlanData data in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposePlanContract> contractList, List<CrudeProductExposePlanData> dataList) {
            foreach (CrudeProductExposePlanContract contract in contractList) {
                var data = new CrudeProductExposePlanData();
                CrudeProductExposePlanService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposePlanContract> FetchAll() {
            var list = new List<CrudeProductExposePlanContract>();
            var dataAccessLayer = new CrudeProductExposePlanData();
            List<CrudeProductExposePlanData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposePlanContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposePlanContract>();
            var dataAccessLayer = new CrudeProductExposePlanData();
            List<CrudeProductExposePlanData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposePlanContract>();
            var dataAccessLayer = new CrudeProductExposePlanData();
            List<CrudeProductExposePlanData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductExposePlanData().FetchAllCount();

        }
        
        public List<CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposePlanContract>();
            var dataAccessLayer = new CrudeProductExposePlanData();
            List<CrudeProductExposePlanData> dataList = dataAccessLayer.FetchWithFilter(productExposePlanId,productId,productExposeSetTypeRcd,userId,dateTime);

            foreach (CrudeProductExposePlanData data in dataList) {
                var crudeProductExposePlanContract = new CrudeProductExposePlanContract();
                DataToContract(data, crudeProductExposePlanContract);
                list.Add(crudeProductExposePlanContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposePlanContract contract) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductExposePlanContract contract) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductExposePlanData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductExposePlanContract contract, CrudeProductExposePlanData data) {
            data.ProductExposePlanId = contract.ProductExposePlanId;
            data.ProductId = contract.ProductId;
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposePlanData data, CrudeProductExposePlanContract contract) {
            contract.ProductExposePlanId = data.ProductExposePlanId;
            contract.ProductId = data.ProductId;
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
