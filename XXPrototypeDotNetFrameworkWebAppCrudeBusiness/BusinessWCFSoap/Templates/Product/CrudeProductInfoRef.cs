/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:00 AM
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
    public partial interface ICrudeProductInfoRefService {
        
        [OperationContract()]
        CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductInfoRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInfoRefContract contract);
        
        [OperationContract()]
        void Delete(string productInfoRcd);
    }
    
    public partial class CrudeProductInfoRefService : ICrudeProductInfoRefService {
        
        public CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            var contract = new CrudeProductInfoRefContract();

            dataAccessLayer.FetchByProductInfoRcd(productInfoRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            var contract = new CrudeProductInfoRefContract();

            dataAccessLayer.FetchByProductInfoName(productInfoName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductInfoRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductInfoRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductInfoRefContract> DataListToContractList(List<CrudeProductInfoRefData> dataList) {
            var contractList = new List<CrudeProductInfoRefContract>();

            foreach (CrudeProductInfoRefData data in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductInfoRefContract> contractList, List<CrudeProductInfoRefData> dataList) {
            foreach (CrudeProductInfoRefContract contract in contractList) {
                var data = new CrudeProductInfoRefData();
                CrudeProductInfoRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInfoRefContract> FetchAll() {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAll();

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductInfoRefData.FetchAllCount();
        }
        
        public List<CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchWithFilter(
                productInfoRcd: productInfoRcd,
                productInfoName: productInfoName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductInfoRefData data in dataList) {
                var crudeProductInfoRefContract = new CrudeProductInfoRefContract();
                DataToContract(data, crudeProductInfoRefContract);
                list.Add(crudeProductInfoRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductInfoRefContract contract) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductInfoRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductInfoRefContract contract) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductInfoRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productInfoRcd) {
            CrudeProductInfoRefData.Delete(productInfoRcd);
        }
        
        public static void ContractToData(CrudeProductInfoRefContract contract, CrudeProductInfoRefData data) {
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductInfoName = contract.ProductInfoName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductInfoRefData data, CrudeProductInfoRefContract contract) {
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductInfoName = data.ProductInfoName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
