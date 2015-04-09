using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductIdentifierRefContract {
        
        [DataMember()]
        public string ProductIdentifierRcd { get; set; } //;
        
        [DataMember()]
        public string ProductIdentifierName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductIdentifierRefService {
        
        [OperationContract()]
        CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductIdentifierRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductIdentifierRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductIdentifierRefService : ICrudeProductIdentifierRefService {
        
        public CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd) {
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            var contract = new CrudeProductIdentifierRefContract();

            dataAccessLayer.FetchByProductIdentifierRcd(productIdentifierRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductIdentifierRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductIdentifierRefContract> DataListToContractList(List<CrudeProductIdentifierRefData> dataList) {
            var contractList = new List<CrudeProductIdentifierRefContract>();

            foreach (CrudeProductIdentifierRefData data in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductIdentifierRefContract> contractList, List<CrudeProductIdentifierRefData> dataList) {
            foreach (CrudeProductIdentifierRefContract contract in contractList) {
                var data = new CrudeProductIdentifierRefData();
                CrudeProductIdentifierRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductIdentifierRefContract> FetchAll() {
            var list = new List<CrudeProductIdentifierRefContract>();
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            List<CrudeProductIdentifierRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRef in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(crudeProductIdentifierRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductIdentifierRefContract>();
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            List<CrudeProductIdentifierRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRef in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(crudeProductIdentifierRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductIdentifierRefContract>();
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            List<CrudeProductIdentifierRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRef in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(crudeProductIdentifierRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductIdentifierRefData().FetchAllCount();

        }
        
        public List<CrudeProductIdentifierRefContract> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductIdentifierRefContract>();
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            List<CrudeProductIdentifierRefData> dataList = dataAccessLayer.FetchWithFilter(productIdentifierRcd,productIdentifierName,userId,dateTime);

            foreach (CrudeProductIdentifierRefData data in dataList) {
                var crudeProductIdentifierRefContract = new CrudeProductIdentifierRefContract();
                DataToContract(data, crudeProductIdentifierRefContract);
                list.Add(crudeProductIdentifierRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductIdentifierRefContract contract) {
            var data = new CrudeProductIdentifierRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductIdentifierRefContract contract) {
            var data = new CrudeProductIdentifierRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductIdentifierRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductIdentifierRefContract contract, CrudeProductIdentifierRefData data) {
            data.ProductIdentifierRcd = contract.ProductIdentifierRcd;
            data.ProductIdentifierName = contract.ProductIdentifierName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductIdentifierRefData data, CrudeProductIdentifierRefContract contract) {
            contract.ProductIdentifierRcd = data.ProductIdentifierRcd;
            contract.ProductIdentifierName = data.ProductIdentifierName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
