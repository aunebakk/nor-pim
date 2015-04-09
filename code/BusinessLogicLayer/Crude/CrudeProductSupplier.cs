using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductSupplierContract {
        
        [DataMember()]
        public System.Guid ProductSupplierId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string SupplierName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductSupplierService {
        
        [OperationContract()]
        CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductSupplierContract contract);
        
        [OperationContract()]
        void Update(CrudeProductSupplierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductSupplierService : ICrudeProductSupplierService {
        
        public CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId) {
            var dataAccessLayer = new CrudeProductSupplierData();
            var contract = new CrudeProductSupplierContract();

            dataAccessLayer.FetchByProductSupplierId(productSupplierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductSupplierContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductSupplierData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductSupplierContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductSupplierData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductSupplierContract> DataListToContractList(List<CrudeProductSupplierData> dataList) {
            var contractList = new List<CrudeProductSupplierContract>();

            foreach (CrudeProductSupplierData data in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductSupplierContract> contractList, List<CrudeProductSupplierData> dataList) {
            foreach (CrudeProductSupplierContract contract in contractList) {
                var data = new CrudeProductSupplierData();
                CrudeProductSupplierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductSupplierContract> FetchAll() {
            var list = new List<CrudeProductSupplierContract>();
            var dataAccessLayer = new CrudeProductSupplierData();
            List<CrudeProductSupplierData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductSupplierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductSupplierContract>();
            var dataAccessLayer = new CrudeProductSupplierData();
            List<CrudeProductSupplierData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductSupplierContract>();
            var dataAccessLayer = new CrudeProductSupplierData();
            List<CrudeProductSupplierData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductSupplierData().FetchAllCount();

        }
        
        public List<CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductSupplierContract>();
            var dataAccessLayer = new CrudeProductSupplierData();
            List<CrudeProductSupplierData> dataList = dataAccessLayer.FetchWithFilter(productSupplierId,productId,supplierName,userId,dateTime);

            foreach (CrudeProductSupplierData data in dataList) {
                var crudeProductSupplierContract = new CrudeProductSupplierContract();
                DataToContract(data, crudeProductSupplierContract);
                list.Add(crudeProductSupplierContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductSupplierContract contract) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductSupplierContract contract) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductSupplierData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductSupplierContract contract, CrudeProductSupplierData data) {
            data.ProductSupplierId = contract.ProductSupplierId;
            data.ProductId = contract.ProductId;
            data.SupplierName = contract.SupplierName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductSupplierData data, CrudeProductSupplierContract contract) {
            contract.ProductSupplierId = data.ProductSupplierId;
            contract.ProductId = data.ProductId;
            contract.SupplierName = data.SupplierName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
