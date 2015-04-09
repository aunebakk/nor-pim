using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductCategoryDocumentationTypeRefContract {
        
        [DataMember()]
        public string ProductCategoryDocumentationTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryDocumentationTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductCategoryDocumentationTypeRefService {
        
        [OperationContract()]
        CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductCategoryDocumentationTypeRefService : ICrudeProductCategoryDocumentationTypeRefService {
        
        public CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefContract> DataListToContractList(List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            var contractList = new List<CrudeProductCategoryDocumentationTypeRefContract>();

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryDocumentationTypeRefContract> contractList, List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            foreach (CrudeProductCategoryDocumentationTypeRefContract contract in contractList) {
                var data = new CrudeProductCategoryDocumentationTypeRefData();
                CrudeProductCategoryDocumentationTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductCategoryDocumentationTypeRefData().FetchAllCount();

        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productCategoryDocumentationTypeRcd,productCategoryDocumentationTypeName,userId,dateTime);

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var crudeProductCategoryDocumentationTypeRefContract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(data, crudeProductCategoryDocumentationTypeRefContract);
                list.Add(crudeProductCategoryDocumentationTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductCategoryDocumentationTypeRefContract contract, CrudeProductCategoryDocumentationTypeRefData data) {
            data.ProductCategoryDocumentationTypeRcd = contract.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryDocumentationTypeName = contract.ProductCategoryDocumentationTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryDocumentationTypeRefData data, CrudeProductCategoryDocumentationTypeRefContract contract) {
            contract.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            contract.ProductCategoryDocumentationTypeName = data.ProductCategoryDocumentationTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
