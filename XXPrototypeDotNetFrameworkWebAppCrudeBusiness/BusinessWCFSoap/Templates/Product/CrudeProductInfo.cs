/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:41:18 AM
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
    public partial interface ICrudeProductInfoService {
        
        [OperationContract()]
        CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByProductInfoRcd(string productInfoRcd);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductInfoContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInfoContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productInfoId);
    }
    
    public partial class CrudeProductInfoService : ICrudeProductInfoService {
        
        public CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId) {
            var dataAccessLayer = new CrudeProductInfoData();
            var contract = new CrudeProductInfoContract();

            dataAccessLayer.FetchByProductInfoId(productInfoId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductInfoContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductInfoData.FetchByProductId(productId));
        }
        
        public List<CrudeProductInfoContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductInfoData.FetchByUserId(userId));
        }
        
        public List<CrudeProductInfoContract> FetchByProductInfoRcd(string productInfoRcd) {
            return DataListToContractList(CrudeProductInfoData.FetchByProductInfoRcd(productInfoRcd));
        }
        
        public static List<CrudeProductInfoContract> DataListToContractList(List<CrudeProductInfoData> dataList) {
            var contractList = new List<CrudeProductInfoContract>();

            foreach (CrudeProductInfoData data in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductInfoContract> contractList, List<CrudeProductInfoData> dataList) {
            foreach (CrudeProductInfoContract contract in contractList) {
                var data = new CrudeProductInfoData();
                CrudeProductInfoService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInfoContract> FetchAll() {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAll();

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAllWithLimit(limit);

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductInfoData.FetchAllCount();
        }
        
        public List<CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchWithFilter(
                productInfoId: productInfoId,
                productId: productId,
                productInfoRcd: productInfoRcd,
                productInfoValue: productInfoValue,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductInfoData data in dataList) {
                var crudeProductInfoContract = new CrudeProductInfoContract();
                DataToContract(data, crudeProductInfoContract);
                list.Add(crudeProductInfoContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductInfoContract contract) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductInfoContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductInfoContract contract) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductInfoContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productInfoId) {
            CrudeProductInfoData.Delete(productInfoId);
        }
        
        public static void ContractToData(CrudeProductInfoContract contract, CrudeProductInfoData data) {
            data.ProductInfoId = contract.ProductInfoId;
            data.ProductId = contract.ProductId;
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductInfoValue = contract.ProductInfoValue;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductInfoData data, CrudeProductInfoContract contract) {
            contract.ProductInfoId = data.ProductInfoId;
            contract.ProductId = data.ProductId;
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductInfoValue = data.ProductInfoValue;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
