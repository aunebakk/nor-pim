using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductCategoryImageTypeRefContract {
        
        [DataMember()]
        public string ProductCategoryImageTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryImageTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductCategoryImageTypeRefService {
        
        [OperationContract()]
        CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryImageTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryImageTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductCategoryImageTypeRefService : ICrudeProductCategoryImageTypeRefService {
        
        public CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            var contract = new CrudeProductCategoryImageTypeRefContract();

            dataAccessLayer.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryImageTypeRefContract> DataListToContractList(List<CrudeProductCategoryImageTypeRefData> dataList) {
            var contractList = new List<CrudeProductCategoryImageTypeRefContract>();

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryImageTypeRefContract> contractList, List<CrudeProductCategoryImageTypeRefData> dataList) {
            foreach (CrudeProductCategoryImageTypeRefContract contract in contractList) {
                var data = new CrudeProductCategoryImageTypeRefData();
                CrudeProductCategoryImageTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchAll() {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            List<CrudeProductCategoryImageTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            List<CrudeProductCategoryImageTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            List<CrudeProductCategoryImageTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductCategoryImageTypeRefData().FetchAllCount();

        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            List<CrudeProductCategoryImageTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productCategoryImageTypeRcd,productCategoryImageTypeName,userId,dateTime);

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var crudeProductCategoryImageTypeRefContract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(data, crudeProductCategoryImageTypeRefContract);
                list.Add(crudeProductCategoryImageTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryImageTypeRefContract contract) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductCategoryImageTypeRefContract contract) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductCategoryImageTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductCategoryImageTypeRefContract contract, CrudeProductCategoryImageTypeRefData data) {
            data.ProductCategoryImageTypeRcd = contract.ProductCategoryImageTypeRcd;
            data.ProductCategoryImageTypeName = contract.ProductCategoryImageTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryImageTypeRefData data, CrudeProductCategoryImageTypeRefContract contract) {
            contract.ProductCategoryImageTypeRcd = data.ProductCategoryImageTypeRcd;
            contract.ProductCategoryImageTypeName = data.ProductCategoryImageTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
