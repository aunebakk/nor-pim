using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductDocumentationContract {
        
        [DataMember()]
        public System.Guid ProductDocumentationId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductDocumentationTypeRcd { get; set; } //;
        
        [DataMember()]
        public string Documentation { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductDocumentationService {
        
        [OperationContract()]
        CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductDocumentationContract contract);
        
        [OperationContract()]
        void Update(CrudeProductDocumentationContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductDocumentationService : ICrudeProductDocumentationService {
        
        public CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId) {
            var dataAccessLayer = new CrudeProductDocumentationData();
            var contract = new CrudeProductDocumentationContract();

            dataAccessLayer.FetchByProductDocumentationId(productDocumentationId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductDocumentationContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductDocumentationData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductDocumentationContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductDocumentationData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductDocumentationContract> DataListToContractList(List<CrudeProductDocumentationData> dataList) {
            var contractList = new List<CrudeProductDocumentationContract>();

            foreach (CrudeProductDocumentationData data in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductDocumentationContract> contractList, List<CrudeProductDocumentationData> dataList) {
            foreach (CrudeProductDocumentationContract contract in contractList) {
                var data = new CrudeProductDocumentationData();
                CrudeProductDocumentationService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductDocumentationContract> FetchAll() {
            var list = new List<CrudeProductDocumentationContract>();
            var dataAccessLayer = new CrudeProductDocumentationData();
            List<CrudeProductDocumentationData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductDocumentationData crudeProductDocumentation in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(crudeProductDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductDocumentationContract>();
            var dataAccessLayer = new CrudeProductDocumentationData();
            List<CrudeProductDocumentationData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductDocumentationData crudeProductDocumentation in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(crudeProductDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductDocumentationContract>();
            var dataAccessLayer = new CrudeProductDocumentationData();
            List<CrudeProductDocumentationData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductDocumentationData crudeProductDocumentation in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(crudeProductDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductDocumentationData().FetchAllCount();

        }
        
        public List<CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductDocumentationContract>();
            var dataAccessLayer = new CrudeProductDocumentationData();
            List<CrudeProductDocumentationData> dataList = dataAccessLayer.FetchWithFilter(productDocumentationId,productId,productDocumentationTypeRcd,documentation,userId,dateTime);

            foreach (CrudeProductDocumentationData data in dataList) {
                var crudeProductDocumentationContract = new CrudeProductDocumentationContract();
                DataToContract(data, crudeProductDocumentationContract);
                list.Add(crudeProductDocumentationContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductDocumentationContract contract) {
            var data = new CrudeProductDocumentationData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductDocumentationContract contract) {
            var data = new CrudeProductDocumentationData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductDocumentationData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductDocumentationContract contract, CrudeProductDocumentationData data) {
            data.ProductDocumentationId = contract.ProductDocumentationId;
            data.ProductId = contract.ProductId;
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.Documentation = contract.Documentation;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductDocumentationData data, CrudeProductDocumentationContract contract) {
            contract.ProductDocumentationId = data.ProductDocumentationId;
            contract.ProductId = data.ProductId;
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.Documentation = data.Documentation;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
