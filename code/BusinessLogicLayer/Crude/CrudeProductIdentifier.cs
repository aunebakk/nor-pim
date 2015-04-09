using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductIdentifierContract {
        
        [DataMember()]
        public System.Guid ProductIdentifierId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductIdentifierRcd { get; set; } //;
        
        [DataMember()]
        public string Identifier { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductIdentifierService {
        
        [OperationContract()]
        CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductIdentifierContract contract);
        
        [OperationContract()]
        void Update(CrudeProductIdentifierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductIdentifierService : ICrudeProductIdentifierService {
        
        public CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId) {
            var dataAccessLayer = new CrudeProductIdentifierData();
            var contract = new CrudeProductIdentifierContract();

            dataAccessLayer.FetchByProductIdentifierId(productIdentifierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductIdentifierContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductIdentifierData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductIdentifierContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductIdentifierData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductIdentifierContract> DataListToContractList(List<CrudeProductIdentifierData> dataList) {
            var contractList = new List<CrudeProductIdentifierContract>();

            foreach (CrudeProductIdentifierData data in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductIdentifierContract> contractList, List<CrudeProductIdentifierData> dataList) {
            foreach (CrudeProductIdentifierContract contract in contractList) {
                var data = new CrudeProductIdentifierData();
                CrudeProductIdentifierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductIdentifierContract> FetchAll() {
            var list = new List<CrudeProductIdentifierContract>();
            var dataAccessLayer = new CrudeProductIdentifierData();
            List<CrudeProductIdentifierData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductIdentifierData crudeProductIdentifier in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(crudeProductIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductIdentifierContract>();
            var dataAccessLayer = new CrudeProductIdentifierData();
            List<CrudeProductIdentifierData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductIdentifierData crudeProductIdentifier in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(crudeProductIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductIdentifierContract>();
            var dataAccessLayer = new CrudeProductIdentifierData();
            List<CrudeProductIdentifierData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductIdentifierData crudeProductIdentifier in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(crudeProductIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductIdentifierData().FetchAllCount();

        }
        
        public List<CrudeProductIdentifierContract> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductIdentifierContract>();
            var dataAccessLayer = new CrudeProductIdentifierData();
            List<CrudeProductIdentifierData> dataList = dataAccessLayer.FetchWithFilter(productIdentifierId,productId,productIdentifierRcd,identifier,userId,dateTime);

            foreach (CrudeProductIdentifierData data in dataList) {
                var crudeProductIdentifierContract = new CrudeProductIdentifierContract();
                DataToContract(data, crudeProductIdentifierContract);
                list.Add(crudeProductIdentifierContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductIdentifierContract contract) {
            var data = new CrudeProductIdentifierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductIdentifierContract contract) {
            var data = new CrudeProductIdentifierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductIdentifierData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductIdentifierContract contract, CrudeProductIdentifierData data) {
            data.ProductIdentifierId = contract.ProductIdentifierId;
            data.ProductId = contract.ProductId;
            data.ProductIdentifierRcd = contract.ProductIdentifierRcd;
            data.Identifier = contract.Identifier;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductIdentifierData data, CrudeProductIdentifierContract contract) {
            contract.ProductIdentifierId = data.ProductIdentifierId;
            contract.ProductId = data.ProductId;
            contract.ProductIdentifierRcd = data.ProductIdentifierRcd;
            contract.Identifier = data.Identifier;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
