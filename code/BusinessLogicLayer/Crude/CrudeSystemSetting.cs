using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeSystemSettingContract {
        
        [DataMember()]
        public System.Guid SystemSettingId { get; set; } //;
        
        [DataMember()]
        public string SystemSettingRcd { get; set; } //;
        
        [DataMember()]
        public string SystemSettingValue { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeSystemSettingService {
        
        [OperationContract()]
        CrudeSystemSettingContract FetchBySystemSettingId(System.Guid systemSettingId);
        
        [OperationContract()]
        List<CrudeSystemSettingContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeSystemSettingContract> FetchWithFilter(System.Guid systemSettingId, string systemSettingRcd, string systemSettingValue, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeSystemSettingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeSystemSettingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeSystemSettingContract contract);
        
        [OperationContract()]
        void Update(CrudeSystemSettingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeSystemSettingService : ICrudeSystemSettingService {
        
        public CrudeSystemSettingContract FetchBySystemSettingId(System.Guid systemSettingId) {
            var dataAccessLayer = new CrudeSystemSettingData();
            var contract = new CrudeSystemSettingContract();

            dataAccessLayer.FetchBySystemSettingId(systemSettingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeSystemSettingContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeSystemSettingData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeSystemSettingContract> DataListToContractList(List<CrudeSystemSettingData> dataList) {
            var contractList = new List<CrudeSystemSettingContract>();

            foreach (CrudeSystemSettingData data in dataList) {
                var contract = new CrudeSystemSettingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeSystemSettingContract> contractList, List<CrudeSystemSettingData> dataList) {
            foreach (CrudeSystemSettingContract contract in contractList) {
                var data = new CrudeSystemSettingData();
                CrudeSystemSettingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeSystemSettingContract> FetchAll() {
            var list = new List<CrudeSystemSettingContract>();
            var dataAccessLayer = new CrudeSystemSettingData();
            List<CrudeSystemSettingData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeSystemSettingData crudeSystemSetting in dataList) {
                var contract = new CrudeSystemSettingContract();
                DataToContract(crudeSystemSetting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeSystemSettingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeSystemSettingContract>();
            var dataAccessLayer = new CrudeSystemSettingData();
            List<CrudeSystemSettingData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeSystemSettingData crudeSystemSetting in dataList) {
                var contract = new CrudeSystemSettingContract();
                DataToContract(crudeSystemSetting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeSystemSettingContract>();
            var dataAccessLayer = new CrudeSystemSettingData();
            List<CrudeSystemSettingData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeSystemSettingData crudeSystemSetting in dataList) {
                var contract = new CrudeSystemSettingContract();
                DataToContract(crudeSystemSetting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeSystemSettingData().FetchAllCount();

        }
        
        public List<CrudeSystemSettingContract> FetchWithFilter(System.Guid systemSettingId, string systemSettingRcd, string systemSettingValue, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeSystemSettingContract>();
            var dataAccessLayer = new CrudeSystemSettingData();
            List<CrudeSystemSettingData> dataList = dataAccessLayer.FetchWithFilter(systemSettingId,systemSettingRcd,systemSettingValue,userId,dateTime);

            foreach (CrudeSystemSettingData data in dataList) {
                var crudeSystemSettingContract = new CrudeSystemSettingContract();
                DataToContract(data, crudeSystemSettingContract);
                list.Add(crudeSystemSettingContract);
            }

            return list;
        }
        
        public void Insert(CrudeSystemSettingContract contract) {
            var data = new CrudeSystemSettingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeSystemSettingContract contract) {
            var data = new CrudeSystemSettingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeSystemSettingData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeSystemSettingContract contract, CrudeSystemSettingData data) {
            data.SystemSettingId = contract.SystemSettingId;
            data.SystemSettingRcd = contract.SystemSettingRcd;
            data.SystemSettingValue = contract.SystemSettingValue;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeSystemSettingData data, CrudeSystemSettingContract contract) {
            contract.SystemSettingId = data.SystemSettingId;
            contract.SystemSettingRcd = data.SystemSettingRcd;
            contract.SystemSettingValue = data.SystemSettingValue;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
