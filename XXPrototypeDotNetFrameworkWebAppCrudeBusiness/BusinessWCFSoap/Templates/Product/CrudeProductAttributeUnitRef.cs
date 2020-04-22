/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:01 AM
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
    public partial interface ICrudeProductAttributeUnitRefService {
        
        [OperationContract()]
        CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeUnitRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeUnitRefContract contract);
        
        [OperationContract()]
        void Delete(string productAttributeUnitRcd);
    }
    
    public partial class CrudeProductAttributeUnitRefService : ICrudeProductAttributeUnitRefService {
        
        public CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            var contract = new CrudeProductAttributeUnitRefContract();

            dataAccessLayer.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            var contract = new CrudeProductAttributeUnitRefContract();

            dataAccessLayer.FetchByProductAttributeUnitName(productAttributeUnitName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductAttributeUnitRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeUnitRefContract> DataListToContractList(List<CrudeProductAttributeUnitRefData> dataList) {
            var contractList = new List<CrudeProductAttributeUnitRefContract>();

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductAttributeUnitRefContract> contractList, List<CrudeProductAttributeUnitRefData> dataList) {
            foreach (CrudeProductAttributeUnitRefContract contract in contractList) {
                var data = new CrudeProductAttributeUnitRefData();
                CrudeProductAttributeUnitRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchAll() {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAll();

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductAttributeUnitRefData.FetchAllCount();
        }
        
        public List<CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchWithFilter(
                productAttributeUnitRcd: productAttributeUnitRcd,
                productAttributeUnitName: productAttributeUnitName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var crudeProductAttributeUnitRefContract = new CrudeProductAttributeUnitRefContract();
                DataToContract(data, crudeProductAttributeUnitRefContract);
                list.Add(crudeProductAttributeUnitRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeUnitRefContract contract) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductAttributeUnitRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductAttributeUnitRefContract contract) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductAttributeUnitRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productAttributeUnitRcd) {
            CrudeProductAttributeUnitRefData.Delete(productAttributeUnitRcd);
        }
        
        public static void ContractToData(CrudeProductAttributeUnitRefContract contract, CrudeProductAttributeUnitRefData data) {
            data.ProductAttributeUnitRcd = contract.ProductAttributeUnitRcd;
            data.ProductAttributeUnitName = contract.ProductAttributeUnitName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductAttributeUnitRefData data, CrudeProductAttributeUnitRefContract contract) {
            contract.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            contract.ProductAttributeUnitName = data.ProductAttributeUnitName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
