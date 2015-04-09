using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeSystemSettingRefContract {
        
        [DataMember()]
        public string SystemSettingRcd { get; set; } //;
        
        [DataMember()]
        public string SystemSettingName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeSystemSettingRefService {
        
        [OperationContract()]
        CrudeSystemSettingRefContract FetchBySystemSettingRcd(string systemSettingRcd);
        
        [OperationContract()]
        List<CrudeSystemSettingRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeSystemSettingRefContract> FetchWithFilter(string systemSettingRcd, string systemSettingName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeSystemSettingRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeSystemSettingRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeSystemSettingRefContract contract);
        
        [OperationContract()]
        void Update(CrudeSystemSettingRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeSystemSettingRefService : ICrudeSystemSettingRefService {
        
        public CrudeSystemSettingRefContract FetchBySystemSettingRcd(string systemSettingRcd) {
            var dataAccessLayer = new CrudeSystemSettingRefData();
            var contract = new CrudeSystemSettingRefContract();

            dataAccessLayer.FetchBySystemSettingRcd(systemSettingRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeSystemSettingRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeSystemSettingRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeSystemSettingRefContract> DataListToContractList(List<CrudeSystemSettingRefData> dataList) {
            var contractList = new List<CrudeSystemSettingRefContract>();

            foreach (CrudeSystemSettingRefData data in dataList) {
                var contract = new CrudeSystemSettingRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeSystemSettingRefContract> contractList, List<CrudeSystemSettingRefData> dataList) {
            foreach (CrudeSystemSettingRefContract contract in contractList) {
                var data = new CrudeSystemSettingRefData();
                CrudeSystemSettingRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeSystemSettingRefContract> FetchAll() {
            var list = new List<CrudeSystemSettingRefContract>();
            var dataAccessLayer = new CrudeSystemSettingRefData();
            List<CrudeSystemSettingRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeSystemSettingRefData crudeSystemSettingRef in dataList) {
                var contract = new CrudeSystemSettingRefContract();
                DataToContract(crudeSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeSystemSettingRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeSystemSettingRefContract>();
            var dataAccessLayer = new CrudeSystemSettingRefData();
            List<CrudeSystemSettingRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeSystemSettingRefData crudeSystemSettingRef in dataList) {
                var contract = new CrudeSystemSettingRefContract();
                DataToContract(crudeSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeSystemSettingRefContract>();
            var dataAccessLayer = new CrudeSystemSettingRefData();
            List<CrudeSystemSettingRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeSystemSettingRefData crudeSystemSettingRef in dataList) {
                var contract = new CrudeSystemSettingRefContract();
                DataToContract(crudeSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeSystemSettingRefData().FetchAllCount();

        }
        
        public List<CrudeSystemSettingRefContract> FetchWithFilter(string systemSettingRcd, string systemSettingName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeSystemSettingRefContract>();
            var dataAccessLayer = new CrudeSystemSettingRefData();
            List<CrudeSystemSettingRefData> dataList = dataAccessLayer.FetchWithFilter(systemSettingRcd,systemSettingName,userId,dateTime);

            foreach (CrudeSystemSettingRefData data in dataList) {
                var crudeSystemSettingRefContract = new CrudeSystemSettingRefContract();
                DataToContract(data, crudeSystemSettingRefContract);
                list.Add(crudeSystemSettingRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeSystemSettingRefContract contract) {
            var data = new CrudeSystemSettingRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeSystemSettingRefContract contract) {
            var data = new CrudeSystemSettingRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeSystemSettingRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeSystemSettingRefContract contract, CrudeSystemSettingRefData data) {
            data.SystemSettingRcd = contract.SystemSettingRcd;
            data.SystemSettingName = contract.SystemSettingName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeSystemSettingRefData data, CrudeSystemSettingRefContract contract) {
            contract.SystemSettingRcd = data.SystemSettingRcd;
            contract.SystemSettingName = data.SystemSettingName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
