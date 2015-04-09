using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductGatherSourceTypeRefContract {
        
        [DataMember()]
        public string ProductGatherSourceTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductGatherSourceTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductGatherSourceTypeRefService {
        
        [OperationContract()]
        CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherSourceTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherSourceTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductGatherSourceTypeRefService : ICrudeProductGatherSourceTypeRefService {
        
        public CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            var contract = new CrudeProductGatherSourceTypeRefContract();

            dataAccessLayer.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherSourceTypeRefContract> DataListToContractList(List<CrudeProductGatherSourceTypeRefData> dataList) {
            var contractList = new List<CrudeProductGatherSourceTypeRefContract>();

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherSourceTypeRefContract> contractList, List<CrudeProductGatherSourceTypeRefData> dataList) {
            foreach (CrudeProductGatherSourceTypeRefContract contract in contractList) {
                var data = new CrudeProductGatherSourceTypeRefData();
                CrudeProductGatherSourceTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchAll() {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            List<CrudeProductGatherSourceTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            List<CrudeProductGatherSourceTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            List<CrudeProductGatherSourceTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductGatherSourceTypeRefData().FetchAllCount();

        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            List<CrudeProductGatherSourceTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productGatherSourceTypeRcd,productGatherSourceTypeName,userId,dateTime);

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var crudeProductGatherSourceTypeRefContract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(data, crudeProductGatherSourceTypeRefContract);
                list.Add(crudeProductGatherSourceTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherSourceTypeRefContract contract) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductGatherSourceTypeRefContract contract) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductGatherSourceTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductGatherSourceTypeRefContract contract, CrudeProductGatherSourceTypeRefData data) {
            data.ProductGatherSourceTypeRcd = contract.ProductGatherSourceTypeRcd;
            data.ProductGatherSourceTypeName = contract.ProductGatherSourceTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherSourceTypeRefData data, CrudeProductGatherSourceTypeRefContract contract) {
            contract.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
            contract.ProductGatherSourceTypeName = data.ProductGatherSourceTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
