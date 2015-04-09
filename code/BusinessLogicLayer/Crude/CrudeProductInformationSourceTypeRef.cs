using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductInformationSourceTypeRefContract {
        
        [DataMember()]
        public string ProductInformationSourceTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductInformationSourceTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductInformationSourceTypeRefService {
        
        [OperationContract()]
        CrudeProductInformationSourceTypeRefContract FetchByProductInformationSourceTypeRcd(string productInformationSourceTypeRcd);
        
        [OperationContract()]
        List<CrudeProductInformationSourceTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductInformationSourceTypeRefContract> FetchWithFilter(string productInformationSourceTypeRcd, string productInformationSourceTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInformationSourceTypeRefContract> FetchAll();
        
        [OperationContract()]
        void Insert(CrudeProductInformationSourceTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInformationSourceTypeRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductInformationSourceTypeRefService : ICrudeProductInformationSourceTypeRefService {
        
        public CrudeProductInformationSourceTypeRefContract FetchByProductInformationSourceTypeRcd(string productInformationSourceTypeRcd) {
            var dataAccessLayer = new CrudeProductInformationSourceTypeRefData();
            var contract = new CrudeProductInformationSourceTypeRefContract();

            dataAccessLayer.FetchByProductInformationSourceTypeRcd(productInformationSourceTypeRcd);
            CopyDalToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductInformationSourceTypeRefContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductInformationSourceTypeRefData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductInformationSourceTypeRefContract> DataListToContractList(List<CrudeProductInformationSourceTypeRefData> dataList) {
            var contractList = new List<CrudeProductInformationSourceTypeRefContract>();

            foreach (CrudeProductInformationSourceTypeRefData data in dataList) {
                var contract = new CrudeProductInformationSourceTypeRefContract();
                CopyDalToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductInformationSourceTypeRefContract> contractList, List<CrudeProductInformationSourceTypeRefData> dataList) {
            foreach (CrudeProductInformationSourceTypeRefContract contract in contractList) {
                var data = new CrudeProductInformationSourceTypeRefData();
                CrudeProductInformationSourceTypeRefService.CopyContractToDal(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInformationSourceTypeRefContract> FetchAll() {
            var list = new List<CrudeProductInformationSourceTypeRefContract>();
            var dataAccessLayer = new CrudeProductInformationSourceTypeRefData();
            List<CrudeProductInformationSourceTypeRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductInformationSourceTypeRefData crudeProductInformationSourceTypeRef in dataList) {
                var contract = new CrudeProductInformationSourceTypeRefContract();
                CopyDalToContract(crudeProductInformationSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInformationSourceTypeRefContract> FetchWithFilter(string productInformationSourceTypeRcd, string productInformationSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInformationSourceTypeRefContract>();
            var dataAccessLayer = new CrudeProductInformationSourceTypeRefData();
            List<CrudeProductInformationSourceTypeRefData> dataList = dataAccessLayer.FetchWithFilter(productInformationSourceTypeRcd,productInformationSourceTypeName,userId,dateTime);

            foreach (CrudeProductInformationSourceTypeRefData data in dataList) {
                var crudeProductInformationSourceTypeRefContract = new CrudeProductInformationSourceTypeRefContract();
                CopyDalToContract(data, crudeProductInformationSourceTypeRefContract);
                list.Add(crudeProductInformationSourceTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductInformationSourceTypeRefContract contract) {
            var data = new CrudeProductInformationSourceTypeRefData();
            CopyContractToDal(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductInformationSourceTypeRefContract contract) {
            var data = new CrudeProductInformationSourceTypeRefData();
            CopyContractToDal(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductInformationSourceTypeRefData();
            data.Delete(id);
        }
        
        public static void CopyContractToDal(CrudeProductInformationSourceTypeRefContract contract, CrudeProductInformationSourceTypeRefData data) {
            data.ProductInformationSourceTypeRcd = contract.ProductInformationSourceTypeRcd;
            data.ProductInformationSourceTypeName = contract.ProductInformationSourceTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void CopyDalToContract(CrudeProductInformationSourceTypeRefData data, CrudeProductInformationSourceTypeRefContract contract) {
            contract.ProductInformationSourceTypeRcd = data.ProductInformationSourceTypeRcd;
            contract.ProductInformationSourceTypeName = data.ProductInformationSourceTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
