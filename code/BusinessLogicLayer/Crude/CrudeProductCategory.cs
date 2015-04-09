using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductCategoryContract {
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryBecameId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryParentId { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryCode { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryName { get; set; } //;
        
        [DataMember()]
        public int ProductCategoryPosition { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductCategoryService {
        
        [OperationContract()]
        CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductCategoryContract FetchByProductCategoryCode(string productCategoryCode);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductCategoryService : ICrudeProductCategoryService {
        
        public CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataAccessLayer = new CrudeProductCategoryData();
            var contract = new CrudeProductCategoryContract();

            dataAccessLayer.FetchByProductCategoryId(productCategoryId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductCategoryContract FetchByProductCategoryCode(string productCategoryCode) {
            var dataAccessLayer = new CrudeProductCategoryData();
            var contract = new CrudeProductCategoryContract();

            dataAccessLayer.FetchByProductCategoryCode(productCategoryCode);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductCategoryData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryContract> DataListToContractList(List<CrudeProductCategoryData> dataList) {
            var contractList = new List<CrudeProductCategoryContract>();

            foreach (CrudeProductCategoryData data in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryContract> contractList, List<CrudeProductCategoryData> dataList) {
            foreach (CrudeProductCategoryContract contract in contractList) {
                var data = new CrudeProductCategoryData();
                CrudeProductCategoryService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryContract> FetchAll() {
            var list = new List<CrudeProductCategoryContract>();
            var dataAccessLayer = new CrudeProductCategoryData();
            List<CrudeProductCategoryData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductCategoryData crudeProductCategory in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(crudeProductCategory, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryContract>();
            var dataAccessLayer = new CrudeProductCategoryData();
            List<CrudeProductCategoryData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryData crudeProductCategory in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(crudeProductCategory, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryContract>();
            var dataAccessLayer = new CrudeProductCategoryData();
            List<CrudeProductCategoryData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryData crudeProductCategory in dataList) {
                var contract = new CrudeProductCategoryContract();
                DataToContract(crudeProductCategory, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductCategoryData().FetchAllCount();

        }
        
        public List<CrudeProductCategoryContract> FetchWithFilter(System.Guid productCategoryId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryContract>();
            var dataAccessLayer = new CrudeProductCategoryData();
            List<CrudeProductCategoryData> dataList = dataAccessLayer.FetchWithFilter(productCategoryId,productCategoryCode,productCategoryName,productCategoryPosition,stateRcd,userId,dateTime);

            foreach (CrudeProductCategoryData data in dataList) {
                var crudeProductCategoryContract = new CrudeProductCategoryContract();
                DataToContract(data, crudeProductCategoryContract);
                list.Add(crudeProductCategoryContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryContract contract) {
            var data = new CrudeProductCategoryData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductCategoryContract contract) {
            var data = new CrudeProductCategoryData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductCategoryData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductCategoryContract contract, CrudeProductCategoryData data) {
            data.ProductCategoryId = contract.ProductCategoryId;
            data.ProductCategoryBecameId = contract.ProductCategoryBecameId;
            data.ProductCategoryParentId = contract.ProductCategoryParentId;
            data.ProductCategoryCode = contract.ProductCategoryCode;
            data.ProductCategoryName = contract.ProductCategoryName;
            data.ProductCategoryPosition = contract.ProductCategoryPosition;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryData data, CrudeProductCategoryContract contract) {
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.ProductCategoryBecameId = data.ProductCategoryBecameId;
            contract.ProductCategoryParentId = data.ProductCategoryParentId;
            contract.ProductCategoryCode = data.ProductCategoryCode;
            contract.ProductCategoryName = data.ProductCategoryName;
            contract.ProductCategoryPosition = data.ProductCategoryPosition;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
