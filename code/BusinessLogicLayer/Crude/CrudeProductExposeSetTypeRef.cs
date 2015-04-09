using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductExposeSetTypeRefContract {
        
        [DataMember()]
        public string ProductExposeSetTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductExposeSetTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductExposeSetTypeRefService {
        
        [OperationContract()]
        CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductExposeSetTypeRefService : ICrudeProductExposeSetTypeRefService {
        
        public CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var contract = new CrudeProductExposeSetTypeRefContract();

            dataAccessLayer.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeSetTypeRefContract> DataListToContractList(List<CrudeProductExposeSetTypeRefData> dataList) {
            var contractList = new List<CrudeProductExposeSetTypeRefContract>();

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposeSetTypeRefContract> contractList, List<CrudeProductExposeSetTypeRefData> dataList) {
            foreach (CrudeProductExposeSetTypeRefContract contract in contractList) {
                var data = new CrudeProductExposeSetTypeRefData();
                CrudeProductExposeSetTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAll() {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            List<CrudeProductExposeSetTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            List<CrudeProductExposeSetTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            List<CrudeProductExposeSetTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductExposeSetTypeRefData().FetchAllCount();

        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            List<CrudeProductExposeSetTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productExposeSetTypeRcd,productExposeSetTypeName,userId,dateTime);

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var crudeProductExposeSetTypeRefContract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, crudeProductExposeSetTypeRefContract);
                list.Add(crudeProductExposeSetTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductExposeSetTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductExposeSetTypeRefContract contract, CrudeProductExposeSetTypeRefData data) {
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.ProductExposeSetTypeName = contract.ProductExposeSetTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposeSetTypeRefData data, CrudeProductExposeSetTypeRefContract contract) {
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.ProductExposeSetTypeName = data.ProductExposeSetTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
