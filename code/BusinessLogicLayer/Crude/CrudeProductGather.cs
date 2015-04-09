using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductGatherContract {
        
        [DataMember()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [DataMember()]
        public System.DateTime StartDateTime { get; set; } //;
        
        [DataMember()]
        public System.DateTime FinishDateTime { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductGatherService {
        
        [OperationContract()]
        CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductGatherService : ICrudeProductGatherService {
        
        public CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId) {
            var dataAccessLayer = new CrudeProductGatherData();
            var contract = new CrudeProductGatherContract();

            dataAccessLayer.FetchByProductGatherId(productGatherId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductGatherData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherContract> DataListToContractList(List<CrudeProductGatherData> dataList) {
            var contractList = new List<CrudeProductGatherContract>();

            foreach (CrudeProductGatherData data in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherContract> contractList, List<CrudeProductGatherData> dataList) {
            foreach (CrudeProductGatherContract contract in contractList) {
                var data = new CrudeProductGatherData();
                CrudeProductGatherService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherContract> FetchAll() {
            var list = new List<CrudeProductGatherContract>();
            var dataAccessLayer = new CrudeProductGatherData();
            List<CrudeProductGatherData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherContract>();
            var dataAccessLayer = new CrudeProductGatherData();
            List<CrudeProductGatherData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherContract>();
            var dataAccessLayer = new CrudeProductGatherData();
            List<CrudeProductGatherData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductGatherData().FetchAllCount();

        }
        
        public List<CrudeProductGatherContract> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherContract>();
            var dataAccessLayer = new CrudeProductGatherData();
            List<CrudeProductGatherData> dataList = dataAccessLayer.FetchWithFilter(productGatherId,startDateTime,finishDateTime,userId,dateTime);

            foreach (CrudeProductGatherData data in dataList) {
                var crudeProductGatherContract = new CrudeProductGatherContract();
                DataToContract(data, crudeProductGatherContract);
                list.Add(crudeProductGatherContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherContract contract) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductGatherContract contract) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductGatherData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductGatherContract contract, CrudeProductGatherData data) {
            data.ProductGatherId = contract.ProductGatherId;
            data.StartDateTime = contract.StartDateTime;
            data.FinishDateTime = contract.FinishDateTime;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherData data, CrudeProductGatherContract contract) {
            contract.ProductGatherId = data.ProductGatherId;
            contract.StartDateTime = data.StartDateTime;
            contract.FinishDateTime = data.FinishDateTime;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
