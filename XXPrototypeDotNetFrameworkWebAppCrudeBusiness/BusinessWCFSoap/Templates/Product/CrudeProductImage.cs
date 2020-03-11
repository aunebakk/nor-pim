/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:57:05 PM
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public partial interface ICrudeProductImageService {
        
        [OperationContract()]
        CrudeProductImageContract FetchByProductImageId(System.Guid productImageId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [OperationContract()]
        CrudeProductImageContract FetchByImageFileName(string imageFileName);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime);
        
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
        void Delete(System.Guid productImageId);
    }
    
    public partial class CrudeProductImageService : ICrudeProductImageService {
        
        public CrudeProductImageContract FetchByProductImageId(System.Guid productImageId) {
            var dataAccessLayer = new CrudeProductImageData();
            var contract = new CrudeProductImageContract();

            dataAccessLayer.FetchByProductImageId(productImageId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductImageContract FetchByImageFileName(string imageFileName) {
            var dataAccessLayer = new CrudeProductImageData();
            var contract = new CrudeProductImageContract();

            dataAccessLayer.FetchByImageFileName(imageFileName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductImageContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductImageData.FetchByProductId(productId));
        }
        
        public List<CrudeProductImageContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductImageData.FetchByUserId(userId));
        }
        
        public List<CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return DataListToContractList(CrudeProductImageData.FetchByProductImageTypeRcd(productImageTypeRcd));
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
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAll();

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductImageContract>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAllWithLimit(limit);

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductImageContract>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductImageData.FetchAllCount();
        }
        
        public List<CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductImageContract>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchWithFilter(
                productImageId: productImageId,
                productId: productId,
                productImageTypeRcd: productImageTypeRcd,
                imageFileName: imageFileName,
                image: image,
                userId: userId,
                dateTime: dateTime
                );

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
        
        public void Insert(CrudeProductImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductImageContract contract) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productImageId) {
            CrudeProductImageData.Delete(productImageId);
        }
        
        public static void ContractToData(CrudeProductImageContract contract, CrudeProductImageData data) {
            data.ProductImageId = contract.ProductImageId;
            data.ProductId = contract.ProductId;
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ImageFileName = contract.ImageFileName;
            data.Image = contract.Image;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductImageData data, CrudeProductImageContract contract) {
            contract.ProductImageId = data.ProductImageId;
            contract.ProductId = data.ProductId;
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ImageFileName = data.ImageFileName;
            contract.Image = data.Image;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
