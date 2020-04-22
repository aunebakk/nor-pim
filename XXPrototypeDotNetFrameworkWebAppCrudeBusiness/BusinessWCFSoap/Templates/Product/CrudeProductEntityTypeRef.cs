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
    public partial interface ICrudeProductEntityTypeRefService {
        
        [OperationContract()]
        CrudeProductEntityTypeRefContract FetchByProductEntityTypeRcd(string productEntityTypeRcd);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductEntityTypeRefContract FetchByProductEntityTypeName(string productEntityTypeName);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductEntityTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductEntityTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productEntityTypeRcd);
    }
    
    public partial class CrudeProductEntityTypeRefService : ICrudeProductEntityTypeRefService {
        
        public CrudeProductEntityTypeRefContract FetchByProductEntityTypeRcd(string productEntityTypeRcd) {
            var dataAccessLayer = new CrudeProductEntityTypeRefData();
            var contract = new CrudeProductEntityTypeRefContract();

            dataAccessLayer.FetchByProductEntityTypeRcd(productEntityTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductEntityTypeRefContract FetchByProductEntityTypeName(string productEntityTypeName) {
            var dataAccessLayer = new CrudeProductEntityTypeRefData();
            var contract = new CrudeProductEntityTypeRefContract();

            dataAccessLayer.FetchByProductEntityTypeName(productEntityTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductEntityTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductEntityTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductEntityTypeRefContract> DataListToContractList(List<CrudeProductEntityTypeRefData> dataList) {
            var contractList = new List<CrudeProductEntityTypeRefContract>();

            foreach (CrudeProductEntityTypeRefData data in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductEntityTypeRefContract> contractList, List<CrudeProductEntityTypeRefData> dataList) {
            foreach (CrudeProductEntityTypeRefContract contract in contractList) {
                var data = new CrudeProductEntityTypeRefData();
                CrudeProductEntityTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductEntityTypeRefContract> FetchAll() {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAll();

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRef in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(crudeProductEntityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductEntityTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRef in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(crudeProductEntityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductEntityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRef in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(crudeProductEntityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductEntityTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductEntityTypeRefContract> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchWithFilter(
                productEntityTypeRcd: productEntityTypeRcd,
                productEntityTypeName: productEntityTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductEntityTypeRefData data in dataList) {
                var crudeProductEntityTypeRefContract = new CrudeProductEntityTypeRefContract();
                DataToContract(data, crudeProductEntityTypeRefContract);
                list.Add(crudeProductEntityTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductEntityTypeRefContract contract) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductEntityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductEntityTypeRefContract contract) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductEntityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productEntityTypeRcd) {
            CrudeProductEntityTypeRefData.Delete(productEntityTypeRcd);
        }
        
        public static void ContractToData(CrudeProductEntityTypeRefContract contract, CrudeProductEntityTypeRefData data) {
            data.ProductEntityTypeRcd = contract.ProductEntityTypeRcd;
            data.ProductEntityTypeName = contract.ProductEntityTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductEntityTypeRefData data, CrudeProductEntityTypeRefContract contract) {
            contract.ProductEntityTypeRcd = data.ProductEntityTypeRcd;
            contract.ProductEntityTypeName = data.ProductEntityTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
