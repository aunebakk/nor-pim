using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductCategoryImageContract {
        
        [DataMember()]
        public System.Guid ProductCategoryImageId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryImageTypeRcd { get; set; } //;
        
        [DataMember()]
        public byte[] Image { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductCategoryImageService {
        
        [OperationContract()]
        CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryImageContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryImageContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductCategoryImageService : ICrudeProductCategoryImageService {
        
        public CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            var dataAccessLayer = new CrudeProductCategoryImageData();
            var contract = new CrudeProductCategoryImageContract();

            dataAccessLayer.FetchByProductCategoryImageId(productCategoryImageId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataAccessLayer = new CrudeProductCategoryImageData();
            return DataListToContractList(dataAccessLayer.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductCategoryImageData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryImageContract> DataListToContractList(List<CrudeProductCategoryImageData> dataList) {
            var contractList = new List<CrudeProductCategoryImageContract>();

            foreach (CrudeProductCategoryImageData data in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryImageContract> contractList, List<CrudeProductCategoryImageData> dataList) {
            foreach (CrudeProductCategoryImageContract contract in contractList) {
                var data = new CrudeProductCategoryImageData();
                CrudeProductCategoryImageService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryImageContract> FetchAll() {
            var list = new List<CrudeProductCategoryImageContract>();
            var dataAccessLayer = new CrudeProductCategoryImageData();
            List<CrudeProductCategoryImageData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryImageContract>();
            var dataAccessLayer = new CrudeProductCategoryImageData();
            List<CrudeProductCategoryImageData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryImageContract>();
            var dataAccessLayer = new CrudeProductCategoryImageData();
            List<CrudeProductCategoryImageData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductCategoryImageData().FetchAllCount();

        }
        
        public List<CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageContract>();
            var dataAccessLayer = new CrudeProductCategoryImageData();
            List<CrudeProductCategoryImageData> dataList = dataAccessLayer.FetchWithFilter(productCategoryImageId,productCategoryId,productCategoryImageTypeRcd,image,userId,dateTime);

            foreach (CrudeProductCategoryImageData data in dataList) {
                var crudeProductCategoryImageContract = new CrudeProductCategoryImageContract();
                DataToContract(data, crudeProductCategoryImageContract);
                list.Add(crudeProductCategoryImageContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryImageContract contract) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductCategoryImageContract contract) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductCategoryImageData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductCategoryImageContract contract, CrudeProductCategoryImageData data) {
            data.ProductCategoryImageId = contract.ProductCategoryImageId;
            data.ProductCategoryId = contract.ProductCategoryId;
            data.ProductCategoryImageTypeRcd = contract.ProductCategoryImageTypeRcd;
            data.Image = contract.Image;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryImageData data, CrudeProductCategoryImageContract contract) {
            contract.ProductCategoryImageId = data.ProductCategoryImageId;
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.ProductCategoryImageTypeRcd = data.ProductCategoryImageTypeRcd;
            contract.Image = data.Image;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
