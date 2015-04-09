using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductFieldSetMappingContract {
        
        [DataMember()]
        public System.Guid ProductFieldSetMappingId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductFieldSetId { get; set; } //;
        
        [DataMember()]
        public string ProductIdentifierRcd { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductInfoRcd { get; set; } //;
        
        [DataMember()]
        public string ProductImageTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductDocumentationTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductFieldSetMappingService {
        
        [OperationContract()]
        CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductFieldSetMappingContract contract);
        
        [OperationContract()]
        void Update(CrudeProductFieldSetMappingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductFieldSetMappingService : ICrudeProductFieldSetMappingService {
        
        public CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            var contract = new CrudeProductFieldSetMappingContract();

            dataAccessLayer.FetchByProductFieldSetMappingId(productFieldSetMappingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            return DataListToContractList(dataAccessLayer.FetchByProductFieldSetId(productFieldSetId));
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductFieldSetMappingContract> DataListToContractList(List<CrudeProductFieldSetMappingData> dataList) {
            var contractList = new List<CrudeProductFieldSetMappingContract>();

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductFieldSetMappingContract> contractList, List<CrudeProductFieldSetMappingData> dataList) {
            foreach (CrudeProductFieldSetMappingContract contract in contractList) {
                var data = new CrudeProductFieldSetMappingData();
                CrudeProductFieldSetMappingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchAll() {
            var list = new List<CrudeProductFieldSetMappingContract>();
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            List<CrudeProductFieldSetMappingData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            List<CrudeProductFieldSetMappingData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            List<CrudeProductFieldSetMappingData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductFieldSetMappingData().FetchAllCount();

        }
        
        public List<CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            List<CrudeProductFieldSetMappingData> dataList = dataAccessLayer.FetchWithFilter(productFieldSetMappingId,productFieldSetId,productIdentifierRcd,productAttributeRcd,productInfoRcd,productImageTypeRcd,productDocumentationTypeRcd,userId,dateTime);

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var crudeProductFieldSetMappingContract = new CrudeProductFieldSetMappingContract();
                DataToContract(data, crudeProductFieldSetMappingContract);
                list.Add(crudeProductFieldSetMappingContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductFieldSetMappingData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductFieldSetMappingContract contract, CrudeProductFieldSetMappingData data) {
            data.ProductFieldSetMappingId = contract.ProductFieldSetMappingId;
            data.ProductFieldSetId = contract.ProductFieldSetId;
            data.ProductIdentifierRcd = contract.ProductIdentifierRcd;
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductFieldSetMappingData data, CrudeProductFieldSetMappingContract contract) {
            contract.ProductFieldSetMappingId = data.ProductFieldSetMappingId;
            contract.ProductFieldSetId = data.ProductFieldSetId;
            contract.ProductIdentifierRcd = data.ProductIdentifierRcd;
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
