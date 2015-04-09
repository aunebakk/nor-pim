using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductGatherAttributeTypeRefContract {
        
        [DataMember()]
        public string ProductGatherAttributeTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductGatherAttributeTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductGatherAttributeTypeRefService {
        
        [OperationContract()]
        CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherAttributeTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherAttributeTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductGatherAttributeTypeRefService : ICrudeProductGatherAttributeTypeRefService {
        
        public CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            var contract = new CrudeProductGatherAttributeTypeRefContract();

            dataAccessLayer.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherAttributeTypeRefContract> DataListToContractList(List<CrudeProductGatherAttributeTypeRefData> dataList) {
            var contractList = new List<CrudeProductGatherAttributeTypeRefContract>();

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherAttributeTypeRefContract> contractList, List<CrudeProductGatherAttributeTypeRefData> dataList) {
            foreach (CrudeProductGatherAttributeTypeRefContract contract in contractList) {
                var data = new CrudeProductGatherAttributeTypeRefData();
                CrudeProductGatherAttributeTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAll() {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            List<CrudeProductGatherAttributeTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            List<CrudeProductGatherAttributeTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            List<CrudeProductGatherAttributeTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductGatherAttributeTypeRefData().FetchAllCount();

        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            List<CrudeProductGatherAttributeTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productGatherAttributeTypeRcd,productGatherAttributeTypeName,userId,dateTime);

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                var crudeProductGatherAttributeTypeRefContract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(data, crudeProductGatherAttributeTypeRefContract);
                list.Add(crudeProductGatherAttributeTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherAttributeTypeRefContract contract) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductGatherAttributeTypeRefContract contract) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductGatherAttributeTypeRefContract contract, CrudeProductGatherAttributeTypeRefData data) {
            data.ProductGatherAttributeTypeRcd = contract.ProductGatherAttributeTypeRcd;
            data.ProductGatherAttributeTypeName = contract.ProductGatherAttributeTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherAttributeTypeRefData data, CrudeProductGatherAttributeTypeRefContract contract) {
            contract.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            contract.ProductGatherAttributeTypeName = data.ProductGatherAttributeTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
