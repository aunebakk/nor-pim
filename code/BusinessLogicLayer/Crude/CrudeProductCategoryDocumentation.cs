using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductCategoryDocumentationContract {
        
        [DataMember()]
        public System.Guid ProductCategoryDocumentationId { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryDocumentationTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [DataMember()]
        public string Documentation { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductCategoryDocumentationService {
        
        [OperationContract()]
        CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryDocumentationContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryDocumentationContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductCategoryDocumentationService : ICrudeProductCategoryDocumentationService {
        
        public CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            var contract = new CrudeProductCategoryDocumentationContract();

            dataAccessLayer.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            return DataListToContractList(dataAccessLayer.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryDocumentationContract> DataListToContractList(List<CrudeProductCategoryDocumentationData> dataList) {
            var contractList = new List<CrudeProductCategoryDocumentationContract>();

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryDocumentationContract> contractList, List<CrudeProductCategoryDocumentationData> dataList) {
            foreach (CrudeProductCategoryDocumentationContract contract in contractList) {
                var data = new CrudeProductCategoryDocumentationData();
                CrudeProductCategoryDocumentationService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            List<CrudeProductCategoryDocumentationData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            List<CrudeProductCategoryDocumentationData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            List<CrudeProductCategoryDocumentationData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductCategoryDocumentationData().FetchAllCount();

        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            List<CrudeProductCategoryDocumentationData> dataList = dataAccessLayer.FetchWithFilter(productCategoryDocumentationId,productCategoryDocumentationTypeRcd,productCategoryId,documentation,userId,dateTime);

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var crudeProductCategoryDocumentationContract = new CrudeProductCategoryDocumentationContract();
                DataToContract(data, crudeProductCategoryDocumentationContract);
                list.Add(crudeProductCategoryDocumentationContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryDocumentationContract contract) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductCategoryDocumentationContract contract) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductCategoryDocumentationData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductCategoryDocumentationContract contract, CrudeProductCategoryDocumentationData data) {
            data.ProductCategoryDocumentationId = contract.ProductCategoryDocumentationId;
            data.ProductCategoryDocumentationTypeRcd = contract.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryId = contract.ProductCategoryId;
            data.Documentation = contract.Documentation;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryDocumentationData data, CrudeProductCategoryDocumentationContract contract) {
            contract.ProductCategoryDocumentationId = data.ProductCategoryDocumentationId;
            contract.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.Documentation = data.Documentation;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
