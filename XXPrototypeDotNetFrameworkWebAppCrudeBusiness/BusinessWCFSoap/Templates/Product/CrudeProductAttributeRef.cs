/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:23:37 PM
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
    public partial interface ICrudeProductAttributeRefService {
        
        [OperationContract()]
        CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeRefContract contract);
        
        [OperationContract()]
        void Delete(string productAttributeRcd);
    }
    
    public partial class CrudeProductAttributeRefService : ICrudeProductAttributeRefService {
        
        public CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            var contract = new CrudeProductAttributeRefContract();

            dataAccessLayer.FetchByProductAttributeRcd(productAttributeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            var contract = new CrudeProductAttributeRefContract();

            dataAccessLayer.FetchByProductAttributeName(productAttributeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductAttributeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeRefContract> DataListToContractList(List<CrudeProductAttributeRefData> dataList) {
            var contractList = new List<CrudeProductAttributeRefContract>();

            foreach (CrudeProductAttributeRefData data in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductAttributeRefContract> contractList, List<CrudeProductAttributeRefData> dataList) {
            foreach (CrudeProductAttributeRefContract contract in contractList) {
                var data = new CrudeProductAttributeRefData();
                CrudeProductAttributeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeRefContract> FetchAll() {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAll();

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductAttributeRefData.FetchAllCount();
        }
        
        public List<CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchWithFilter(
                productAttributeRcd: productAttributeRcd,
                productAttributeName: productAttributeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductAttributeRefData data in dataList) {
                var crudeProductAttributeRefContract = new CrudeProductAttributeRefContract();
                DataToContract(data, crudeProductAttributeRefContract);
                list.Add(crudeProductAttributeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeRefContract contract) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductAttributeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductAttributeRefContract contract) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductAttributeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productAttributeRcd) {
            CrudeProductAttributeRefData.Delete(productAttributeRcd);
        }
        
        public static void ContractToData(CrudeProductAttributeRefContract contract, CrudeProductAttributeRefData data) {
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductAttributeName = contract.ProductAttributeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductAttributeRefData data, CrudeProductAttributeRefContract contract) {
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductAttributeName = data.ProductAttributeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
