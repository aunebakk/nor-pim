using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeUserActivityTypeRefContract {
        
        [DataMember()]
        public string UserActivityTypeRcd { get; set; } //;
        
        [DataMember()]
        public string UserActivityTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeUserActivityTypeRefService {
        
        [OperationContract()]
        CrudeUserActivityTypeRefContract FetchByUserActivityTypeRcd(string userActivityTypeRcd);
        
        [OperationContract()]
        List<CrudeUserActivityTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeUserActivityTypeRefContract> FetchWithFilter(string userActivityTypeRcd, string userActivityTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeUserActivityTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeUserActivityTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeUserActivityTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeUserActivityTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeUserActivityTypeRefService : ICrudeUserActivityTypeRefService {
        
        public CrudeUserActivityTypeRefContract FetchByUserActivityTypeRcd(string userActivityTypeRcd) {
            var dataAccessLayer = new CrudeUserActivityTypeRefData();
            var contract = new CrudeUserActivityTypeRefContract();

            dataAccessLayer.FetchByUserActivityTypeRcd(userActivityTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeUserActivityTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeUserActivityTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeUserActivityTypeRefContract> DataListToContractList(List<CrudeUserActivityTypeRefData> dataList) {
            var contractList = new List<CrudeUserActivityTypeRefContract>();

            foreach (CrudeUserActivityTypeRefData data in dataList) {
                var contract = new CrudeUserActivityTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeUserActivityTypeRefContract> contractList, List<CrudeUserActivityTypeRefData> dataList) {
            foreach (CrudeUserActivityTypeRefContract contract in contractList) {
                var data = new CrudeUserActivityTypeRefData();
                CrudeUserActivityTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeUserActivityTypeRefContract> FetchAll() {
            var list = new List<CrudeUserActivityTypeRefContract>();
            var dataAccessLayer = new CrudeUserActivityTypeRefData();
            List<CrudeUserActivityTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeUserActivityTypeRefData crudeUserActivityTypeRef in dataList) {
                var contract = new CrudeUserActivityTypeRefContract();
                DataToContract(crudeUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeUserActivityTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeUserActivityTypeRefContract>();
            var dataAccessLayer = new CrudeUserActivityTypeRefData();
            List<CrudeUserActivityTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeUserActivityTypeRefData crudeUserActivityTypeRef in dataList) {
                var contract = new CrudeUserActivityTypeRefContract();
                DataToContract(crudeUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeUserActivityTypeRefContract>();
            var dataAccessLayer = new CrudeUserActivityTypeRefData();
            List<CrudeUserActivityTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeUserActivityTypeRefData crudeUserActivityTypeRef in dataList) {
                var contract = new CrudeUserActivityTypeRefContract();
                DataToContract(crudeUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeUserActivityTypeRefData().FetchAllCount();

        }
        
        public List<CrudeUserActivityTypeRefContract> FetchWithFilter(string userActivityTypeRcd, string userActivityTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeUserActivityTypeRefContract>();
            var dataAccessLayer = new CrudeUserActivityTypeRefData();
            List<CrudeUserActivityTypeRefData> dataList = dataAccessLayer.FetchWithFilter(userActivityTypeRcd,userActivityTypeName,userId,dateTime);

            foreach (CrudeUserActivityTypeRefData data in dataList) {
                var crudeUserActivityTypeRefContract = new CrudeUserActivityTypeRefContract();
                DataToContract(data, crudeUserActivityTypeRefContract);
                list.Add(crudeUserActivityTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeUserActivityTypeRefContract contract) {
            var data = new CrudeUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeUserActivityTypeRefContract contract) {
            var data = new CrudeUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeUserActivityTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeUserActivityTypeRefContract contract, CrudeUserActivityTypeRefData data) {
            data.UserActivityTypeRcd = contract.UserActivityTypeRcd;
            data.UserActivityTypeName = contract.UserActivityTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeUserActivityTypeRefData data, CrudeUserActivityTypeRefContract contract) {
            contract.UserActivityTypeRcd = data.UserActivityTypeRcd;
            contract.UserActivityTypeName = data.UserActivityTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
