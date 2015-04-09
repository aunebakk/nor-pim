using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeProductImageContract {
        
        [DataMember()]
        public System.Guid ProductImageId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductImageTypeRcd { get; set; } //;
        
        [DataMember()]
        public byte[] Image { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string ImageFileName { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeProductImageService {
        
        [OperationContract()]
        CrudeProductImageContract FetchByProductImageId(System.Guid productImageId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime, string imageFileName);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductImageContract contract);
        
        [OperationContract()]
        void Update(CrudeProductImageContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeProductImageService : ICrudeProductImageService {
        
        public CrudeProductImageContract FetchByProductImageId(System.Guid productImageId) {
            var dataAccessLayer = new CrudeProductImageData();
            var contract = new CrudeProductImageContract();

            dataAccessLayer.FetchByProductImageId(productImageId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductImageContract> FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductImageData();
            return DataListToContractList(dataAccessLayer.FetchByProductId(productId));
        }
        
        public List<CrudeProductImageContract> FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeProductImageData();
            return DataListToContractList(dataAccessLayer.FetchByUserId(userId));
        }
        
        public static List<CrudeProductImageContract> DataListToContractList(List<CrudeProductImageData> dataList) {
            var contractList = new List<CrudeProductImageContract>();

            foreach (CrudeProductImageData data in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductImageContract> contractList, List<CrudeProductImageData> dataList) {
            foreach (CrudeProductImageContract contract in contractList) {
                var data = new CrudeProductImageData();
                CrudeProductImageService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductImageContract> FetchAll() {
            var list = new List<CrudeProductImageContract>();
            var dataAccessLayer = new CrudeProductImageData();
            List<CrudeProductImageData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductImageContract>();
            var dataAccessLayer = new CrudeProductImageData();
            List<CrudeProductImageData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductImageContract>();
            var dataAccessLayer = new CrudeProductImageData();
            List<CrudeProductImageData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeProductImageData().FetchAllCount();

        }
        
        public List<CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime, string imageFileName) {
            var list = new List<CrudeProductImageContract>();
            var dataAccessLayer = new CrudeProductImageData();
            List<CrudeProductImageData> dataList = dataAccessLayer.FetchWithFilter(productImageId,productId,productImageTypeRcd,image,userId,dateTime,imageFileName);

            foreach (CrudeProductImageData data in dataList) {
                var crudeProductImageContract = new CrudeProductImageContract();
                DataToContract(data, crudeProductImageContract);
                list.Add(crudeProductImageContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductImageContract contract) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeProductImageContract contract) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeProductImageData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeProductImageContract contract, CrudeProductImageData data) {
            data.ProductImageId = contract.ProductImageId;
            data.ProductId = contract.ProductId;
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.Image = contract.Image;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ImageFileName = contract.ImageFileName;
        }
        
        public static void DataToContract(CrudeProductImageData data, CrudeProductImageContract contract) {
            contract.ProductImageId = data.ProductImageId;
            contract.ProductId = data.ProductId;
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.Image = data.Image;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ImageFileName = data.ImageFileName;
        }
    }
}
