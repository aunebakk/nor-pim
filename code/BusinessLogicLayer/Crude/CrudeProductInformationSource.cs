using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductInformationSourceContract {
        
        [DataMember()]
        public System.Guid ProductInformationSourceId { get; set; } //;
        
        [DataMember()]
        public string ProductInformationSourceTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductInformationSource { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductInformationSourceService {
        
        [OperationContract()]
        CrudeProductInformationSourceContract FetchByProductInformationSourceId(System.Guid productInformationSourceId);
        
        [OperationContract()]
        List<CrudeProductInformationSourceContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductInformationSourceContract> FetchWithFilter(System.Guid productInformationSourceId, string productInformationSourceTypeRcd, string productInformationSource, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInformationSourceContract> FetchAll();
        
        [OperationContract()]
        void Insert(CrudeProductInformationSourceContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInformationSourceContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductInformationSourceService : ICrudeProductInformationSourceService {
        
        public CrudeProductInformationSourceContract FetchByProductInformationSourceId(System.Guid productInformationSourceId) {
            var dataAccessLayer = new CrudeProductInformationSourceData();
            var contract = new CrudeProductInformationSourceContract();

            dataAccessLayer.FetchByProductInformationSourceId(productInformationSourceId);
            CopyDalToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductInformationSourceContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductInformationSourceData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductInformationSourceContract> DataListToContractList(List<CrudeProductInformationSourceData> dataList) {
            var contractList = new List<CrudeProductInformationSourceContract>();

            foreach (CrudeProductInformationSourceData data in dataList) {
                var contract = new CrudeProductInformationSourceContract();
                CopyDalToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductInformationSourceContract> contractList, List<CrudeProductInformationSourceData> dataList) {
            foreach (CrudeProductInformationSourceContract contract in contractList) {
                var data = new CrudeProductInformationSourceData();
                CrudeProductInformationSourceService.CopyContractToDal(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInformationSourceContract> FetchAll() {
            var list = new List<CrudeProductInformationSourceContract>();
            var dataAccessLayer = new CrudeProductInformationSourceData();
            List<CrudeProductInformationSourceData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductInformationSourceData crudeProductInformationSource in dataList) {
                var contract = new CrudeProductInformationSourceContract();
                CopyDalToContract(crudeProductInformationSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInformationSourceContract> FetchWithFilter(System.Guid productInformationSourceId, string productInformationSourceTypeRcd, string productInformationSource, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInformationSourceContract>();
            var dataAccessLayer = new CrudeProductInformationSourceData();
            List<CrudeProductInformationSourceData> dataList = dataAccessLayer.FetchWithFilter(productInformationSourceId,productInformationSourceTypeRcd,productInformationSource,userId,dateTime);

            foreach (CrudeProductInformationSourceData data in dataList) {
                var crudeProductInformationSourceContract = new CrudeProductInformationSourceContract();
                CopyDalToContract(data, crudeProductInformationSourceContract);
                list.Add(crudeProductInformationSourceContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductInformationSourceContract contract) {
            var data = new CrudeProductInformationSourceData();
            CopyContractToDal(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductInformationSourceContract contract) {
            var data = new CrudeProductInformationSourceData();
            CopyContractToDal(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductInformationSourceData();
            data.Delete(id);
        }
        
        public static void CopyContractToDal(CrudeProductInformationSourceContract contract, CrudeProductInformationSourceData data) {
            data.ProductInformationSourceId = contract.ProductInformationSourceId;
            data.ProductInformationSourceTypeRcd = contract.ProductInformationSourceTypeRcd;
            data.ProductInformationSource = contract.ProductInformationSource;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void CopyDalToContract(CrudeProductInformationSourceData data, CrudeProductInformationSourceContract contract) {
            contract.ProductInformationSourceId = data.ProductInformationSourceId;
            contract.ProductInformationSourceTypeRcd = data.ProductInformationSourceTypeRcd;
            contract.ProductInformationSource = data.ProductInformationSource;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
