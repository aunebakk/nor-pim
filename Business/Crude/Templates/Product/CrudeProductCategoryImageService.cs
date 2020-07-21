/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:12 AM
  From Machine: DESKTOP-00MSEIL
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
    public partial interface ICrudeProductCategoryImageService {
        
        [OperationContract()]
        CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
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
        void Delete(System.Guid productCategoryImageId);
    }
    
    public partial class CrudeProductCategoryImageService : ICrudeProductCategoryImageService {
        
        public CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            var dataAccessLayer = new CrudeProductCategoryImageData();
            var contract = new CrudeProductCategoryImageContract();

            dataAccessLayer.FetchByProductCategoryImageId(productCategoryImageId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToContractList(CrudeProductCategoryImageData.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryImageData.FetchByUserId(userId));
        }
        
        public List<CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return DataListToContractList(CrudeProductCategoryImageData.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd));
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
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAll();

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryImageContract>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryImageContract>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryImageData.FetchAllCount();
        }
        
        public List<CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageContract>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchWithFilter(
                productCategoryImageId: productCategoryImageId,
                productCategoryId: productCategoryId,
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                image: image,
                userId: userId,
                dateTime: dateTime
                );

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
        
        public void Insert(CrudeProductCategoryImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryImageContract contract) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryImageId) {
            CrudeProductCategoryImageData.Delete(productCategoryImageId);
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
