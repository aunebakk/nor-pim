using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductGatherSourceContract {
        
        [DataMember()]
        public System.Guid ProductGatherSourceId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string ProductGatherSourceTypeRcd { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductGatherSourceService {
        
        [OperationContract()]
        CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime, string productGatherSourceTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherSourceContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherSourceContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductGatherSourceService : ICrudeProductGatherSourceService {
        
        public CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            var dataAccessLayer = new CrudeProductGatherSourceData();
            var contract = new CrudeProductGatherSourceContract();

            dataAccessLayer.FetchByProductGatherSourceId(productGatherSourceId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId) {
            var dataAccessLayer = new CrudeProductGatherSourceData();
            return DataListToContractList(dataAccessLayer.FetchByProductGatherId(productGatherId));
        }
        
        public List<CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductGatherSourceData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherSourceContract> DataListToContractList(List<CrudeProductGatherSourceData> dataList) {
            var contractList = new List<CrudeProductGatherSourceContract>();

            foreach (CrudeProductGatherSourceData data in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherSourceContract> contractList, List<CrudeProductGatherSourceData> dataList) {
            foreach (CrudeProductGatherSourceContract contract in contractList) {
                var data = new CrudeProductGatherSourceData();
                CrudeProductGatherSourceService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherSourceContract> FetchAll() {
            var list = new List<CrudeProductGatherSourceContract>();
            var dataAccessLayer = new CrudeProductGatherSourceData();
            List<CrudeProductGatherSourceData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherSourceContract>();
            var dataAccessLayer = new CrudeProductGatherSourceData();
            List<CrudeProductGatherSourceData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherSourceContract>();
            var dataAccessLayer = new CrudeProductGatherSourceData();
            List<CrudeProductGatherSourceData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductGatherSourceData().FetchAllCount();

        }
        
        public List<CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime, string productGatherSourceTypeRcd) {
            var list = new List<CrudeProductGatherSourceContract>();
            var dataAccessLayer = new CrudeProductGatherSourceData();
            List<CrudeProductGatherSourceData> dataList = dataAccessLayer.FetchWithFilter(productGatherSourceId,productGatherId,userId,dateTime,productGatherSourceTypeRcd);

            foreach (CrudeProductGatherSourceData data in dataList) {
                var crudeProductGatherSourceContract = new CrudeProductGatherSourceContract();
                DataToContract(data, crudeProductGatherSourceContract);
                list.Add(crudeProductGatherSourceContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherSourceContract contract) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductGatherSourceContract contract) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductGatherSourceData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductGatherSourceContract contract, CrudeProductGatherSourceData data) {
            data.ProductGatherSourceId = contract.ProductGatherSourceId;
            data.ProductGatherId = contract.ProductGatherId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ProductGatherSourceTypeRcd = contract.ProductGatherSourceTypeRcd;
        }
        
        public static void DataToContract(CrudeProductGatherSourceData data, CrudeProductGatherSourceContract contract) {
            contract.ProductGatherSourceId = data.ProductGatherSourceId;
            contract.ProductGatherId = data.ProductGatherId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
        }
    }
}
