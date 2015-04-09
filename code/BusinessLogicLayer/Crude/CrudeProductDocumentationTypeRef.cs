using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductDocumentationTypeRefContract {
        
        [DataMember()]
        public string ProductDocumentationTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductDocumentationTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductDocumentationTypeRefService {
        
        [OperationContract()]
        CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductDocumentationTypeRefService : ICrudeProductDocumentationTypeRefService {
        
        public CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            var contract = new CrudeProductDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductDocumentationTypeRefContract> DataListToContractList(List<CrudeProductDocumentationTypeRefData> dataList) {
            var contractList = new List<CrudeProductDocumentationTypeRefContract>();

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductDocumentationTypeRefContract> contractList, List<CrudeProductDocumentationTypeRefData> dataList) {
            foreach (CrudeProductDocumentationTypeRefContract contract in contractList) {
                var data = new CrudeProductDocumentationTypeRefData();
                CrudeProductDocumentationTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchAll() {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            List<CrudeProductDocumentationTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            List<CrudeProductDocumentationTypeRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            List<CrudeProductDocumentationTypeRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductDocumentationTypeRefData().FetchAllCount();

        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            List<CrudeProductDocumentationTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productDocumentationTypeRcd,productDocumentationTypeName,userId,dateTime);

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var crudeProductDocumentationTypeRefContract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(data, crudeProductDocumentationTypeRefContract);
                list.Add(crudeProductDocumentationTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductDocumentationTypeRefContract contract) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductDocumentationTypeRefContract contract) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductDocumentationTypeRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductDocumentationTypeRefContract contract, CrudeProductDocumentationTypeRefData data) {
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.ProductDocumentationTypeName = contract.ProductDocumentationTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductDocumentationTypeRefData data, CrudeProductDocumentationTypeRefContract contract) {
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.ProductDocumentationTypeName = data.ProductDocumentationTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
