using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductImageTypeRefContract {
        
        [DataMember()]
        public string ProductImageTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductImageTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductImageTypeRefService {
        
        [OperationContract()]
        CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductImageTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductImageTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductImageTypeRefService : ICrudeProductImageTypeRefService {
        
        public CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            var contract = new CrudeProductImageTypeRefContract();

            dataAccessLayer.FetchByProductImageTypeRcd(productImageTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductImageTypeRefContract> DataListToContractList(List<CrudeProductImageTypeRefData> dataList) {
            var contractList = new List<CrudeProductImageTypeRefContract>();

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductImageTypeRefContract> contractList, List<CrudeProductImageTypeRefData> dataList) {
            foreach (CrudeProductImageTypeRefContract contract in contractList) {
                var data = new CrudeProductImageTypeRefData();
                CrudeProductImageTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductImageTypeRefContract> FetchAll() {
            var list = new List<CrudeProductImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            List<CrudeProductImageTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            List<CrudeProductImageTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            List<CrudeProductImageTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductImageTypeRefData().FetchAllCount();

        }
        
        public List<CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            List<CrudeProductImageTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productImageTypeRcd,productImageTypeName,userId,dateTime);

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var crudeProductImageTypeRefContract = new CrudeProductImageTypeRefContract();
                DataToContract(data, crudeProductImageTypeRefContract);
                list.Add(crudeProductImageTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductImageTypeRefContract contract) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductImageTypeRefContract contract) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductImageTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductImageTypeRefContract contract, CrudeProductImageTypeRefData data) {
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ProductImageTypeName = contract.ProductImageTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductImageTypeRefData data, CrudeProductImageTypeRefContract contract) {
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ProductImageTypeName = data.ProductImageTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
