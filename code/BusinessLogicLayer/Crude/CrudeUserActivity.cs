using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeUserActivityContract {
        
        [DataMember()]
        public System.Guid UserActivityId { get; set; } //;
        
        [DataMember()]
        public string UserActivityTypeRcd { get; set; } //;
        
        [DataMember()]
        public string UserActivityNote { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeUserActivityService {
        
        [OperationContract()]
        CrudeUserActivityContract FetchByUserActivityId(System.Guid userActivityId);
        
        [OperationContract()]
        List<CrudeUserActivityContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeUserActivityContract> FetchWithFilter(System.Guid userActivityId, string userActivityTypeRcd, string userActivityNote, System.Guid userId, System.DateTime dateTime, string originatingAddress);
        
        [OperationContract()]
        List<CrudeUserActivityContract> FetchAll();
        
        [OperationContract()]
        List<CrudeUserActivityContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeUserActivityContract contract);
        
        [OperationContract()]
        void Update(CrudeUserActivityContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeUserActivityService : ICrudeUserActivityService {
        
        public CrudeUserActivityContract FetchByUserActivityId(System.Guid userActivityId) {
            var dataAccessLayer = new CrudeUserActivityData();
            var contract = new CrudeUserActivityContract();

            dataAccessLayer.FetchByUserActivityId(userActivityId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeUserActivityContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeUserActivityData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeUserActivityContract> DataListToContractList(List<CrudeUserActivityData> dataList) {
            var contractList = new List<CrudeUserActivityContract>();

            foreach (CrudeUserActivityData data in dataList) {
                var contract = new CrudeUserActivityContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeUserActivityContract> contractList, List<CrudeUserActivityData> dataList) {
            foreach (CrudeUserActivityContract contract in contractList) {
                var data = new CrudeUserActivityData();
                CrudeUserActivityService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeUserActivityContract> FetchAll() {
            var list = new List<CrudeUserActivityContract>();
            var dataAccessLayer = new CrudeUserActivityData();
            List<CrudeUserActivityData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeUserActivityData crudeUserActivity in dataList) {
                var contract = new CrudeUserActivityContract();
                DataToContract(crudeUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeUserActivityContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeUserActivityContract>();
            var dataAccessLayer = new CrudeUserActivityData();
            List<CrudeUserActivityData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeUserActivityData crudeUserActivity in dataList) {
                var contract = new CrudeUserActivityContract();
                DataToContract(crudeUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeUserActivityContract>();
            var dataAccessLayer = new CrudeUserActivityData();
            List<CrudeUserActivityData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeUserActivityData crudeUserActivity in dataList) {
                var contract = new CrudeUserActivityContract();
                DataToContract(crudeUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeUserActivityData().FetchAllCount();

        }
        
        public List<CrudeUserActivityContract> FetchWithFilter(System.Guid userActivityId, string userActivityTypeRcd, string userActivityNote, System.Guid userId, System.DateTime dateTime, string originatingAddress) {
            var list = new List<CrudeUserActivityContract>();
            var dataAccessLayer = new CrudeUserActivityData();
            List<CrudeUserActivityData> dataList = dataAccessLayer.FetchWithFilter(userActivityId,userActivityTypeRcd,userActivityNote,userId,dateTime,originatingAddress);

            foreach (CrudeUserActivityData data in dataList) {
                var crudeUserActivityContract = new CrudeUserActivityContract();
                DataToContract(data, crudeUserActivityContract);
                list.Add(crudeUserActivityContract);
            }

            return list;
        }
        
        public void Insert(CrudeUserActivityContract contract) {
            var data = new CrudeUserActivityData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeUserActivityContract contract) {
            var data = new CrudeUserActivityData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeUserActivityData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeUserActivityContract contract, CrudeUserActivityData data) {
            data.UserActivityId = contract.UserActivityId;
            data.UserActivityTypeRcd = contract.UserActivityTypeRcd;
            data.UserActivityNote = contract.UserActivityNote;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.OriginatingAddress = contract.OriginatingAddress;
        }
        
        public static void DataToContract(CrudeUserActivityData data, CrudeUserActivityContract contract) {
            contract.UserActivityId = data.UserActivityId;
            contract.UserActivityTypeRcd = data.UserActivityTypeRcd;
            contract.UserActivityNote = data.UserActivityNote;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.OriginatingAddress = data.OriginatingAddress;
        }
    }
}
