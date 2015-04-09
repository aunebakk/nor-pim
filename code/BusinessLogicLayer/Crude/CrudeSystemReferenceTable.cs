using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeSystemReferenceTableContract {
        
        [DataMember()]
        public System.Guid SystemReferenceTableId { get; set; } //;
        
        [DataMember()]
        public string SystemReferenceTableName { get; set; } //;
        
        [DataMember()]
        public string SystemReferenceDisplayName { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeSystemReferenceTableService {
        
        [OperationContract()]
        CrudeSystemReferenceTableContract FetchBySystemReferenceTableId(System.Guid systemReferenceTableId);
        
        [OperationContract()]
        List<CrudeSystemReferenceTableContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeSystemReferenceTableContract> FetchWithFilter(System.Guid systemReferenceTableId, string systemReferenceTableName, string systemReferenceDisplayName, System.DateTime dateTime, System.Guid userId);
        
        [OperationContract()]
        List<CrudeSystemReferenceTableContract> FetchAll();
        
        [OperationContract()]
        List<CrudeSystemReferenceTableContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Update(CrudeSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeSystemReferenceTableService : ICrudeSystemReferenceTableService {
        
        public CrudeSystemReferenceTableContract FetchBySystemReferenceTableId(System.Guid systemReferenceTableId) {
            var dataAccessLayer = new CrudeSystemReferenceTableData();
            var contract = new CrudeSystemReferenceTableContract();

            dataAccessLayer.FetchBySystemReferenceTableId(systemReferenceTableId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeSystemReferenceTableContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeSystemReferenceTableData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeSystemReferenceTableContract> DataListToContractList(List<CrudeSystemReferenceTableData> dataList) {
            var contractList = new List<CrudeSystemReferenceTableContract>();

            foreach (CrudeSystemReferenceTableData data in dataList) {
                var contract = new CrudeSystemReferenceTableContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeSystemReferenceTableContract> contractList, List<CrudeSystemReferenceTableData> dataList) {
            foreach (CrudeSystemReferenceTableContract contract in contractList) {
                var data = new CrudeSystemReferenceTableData();
                CrudeSystemReferenceTableService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeSystemReferenceTableContract> FetchAll() {
            var list = new List<CrudeSystemReferenceTableContract>();
            var dataAccessLayer = new CrudeSystemReferenceTableData();
            List<CrudeSystemReferenceTableData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeSystemReferenceTableData crudeSystemReferenceTable in dataList) {
                var contract = new CrudeSystemReferenceTableContract();
                DataToContract(crudeSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeSystemReferenceTableContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeSystemReferenceTableContract>();
            var dataAccessLayer = new CrudeSystemReferenceTableData();
            List<CrudeSystemReferenceTableData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeSystemReferenceTableData crudeSystemReferenceTable in dataList) {
                var contract = new CrudeSystemReferenceTableContract();
                DataToContract(crudeSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeSystemReferenceTableContract>();
            var dataAccessLayer = new CrudeSystemReferenceTableData();
            List<CrudeSystemReferenceTableData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeSystemReferenceTableData crudeSystemReferenceTable in dataList) {
                var contract = new CrudeSystemReferenceTableContract();
                DataToContract(crudeSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeSystemReferenceTableData().FetchAllCount();

        }
        
        public List<CrudeSystemReferenceTableContract> FetchWithFilter(System.Guid systemReferenceTableId, string systemReferenceTableName, string systemReferenceDisplayName, System.DateTime dateTime, System.Guid userId) {
            var list = new List<CrudeSystemReferenceTableContract>();
            var dataAccessLayer = new CrudeSystemReferenceTableData();
            List<CrudeSystemReferenceTableData> dataList = dataAccessLayer.FetchWithFilter(systemReferenceTableId,systemReferenceTableName,systemReferenceDisplayName,dateTime,userId);

            foreach (CrudeSystemReferenceTableData data in dataList) {
                var crudeSystemReferenceTableContract = new CrudeSystemReferenceTableContract();
                DataToContract(data, crudeSystemReferenceTableContract);
                list.Add(crudeSystemReferenceTableContract);
            }

            return list;
        }
        
        public void Insert(CrudeSystemReferenceTableContract contract) {
            var data = new CrudeSystemReferenceTableData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeSystemReferenceTableContract contract) {
            var data = new CrudeSystemReferenceTableData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeSystemReferenceTableData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeSystemReferenceTableContract contract, CrudeSystemReferenceTableData data) {
            data.SystemReferenceTableId = contract.SystemReferenceTableId;
            data.SystemReferenceTableName = contract.SystemReferenceTableName;
            data.SystemReferenceDisplayName = contract.SystemReferenceDisplayName;
            data.DateTime = contract.DateTime;
            data.UserId = contract.UserId;
        }
        
        public static void DataToContract(CrudeSystemReferenceTableData data, CrudeSystemReferenceTableContract contract) {
            contract.SystemReferenceTableId = data.SystemReferenceTableId;
            contract.SystemReferenceTableName = data.SystemReferenceTableName;
            contract.SystemReferenceDisplayName = data.SystemReferenceDisplayName;
            contract.DateTime = data.DateTime;
            contract.UserId = data.UserId;
        }
    }
}
