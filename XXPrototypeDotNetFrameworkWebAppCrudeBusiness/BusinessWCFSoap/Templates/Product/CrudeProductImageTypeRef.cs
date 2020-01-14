/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:50 PM
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
    public partial interface ICrudeProductImageTypeRefService {
        
        [OperationContract()]
        CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductImageTypeRefContract FetchByProductImageTypeName(string productImageTypeName);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductImageTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductImageTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productImageTypeRcd);
    }
    
    public partial class CrudeProductImageTypeRefService : ICrudeProductImageTypeRefService {
        
        public CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            var contract = new CrudeProductImageTypeRefContract();

            dataAccessLayer.FetchByProductImageTypeRcd(productImageTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductImageTypeRefContract FetchByProductImageTypeName(string productImageTypeName) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            var contract = new CrudeProductImageTypeRefContract();

            dataAccessLayer.FetchByProductImageTypeName(productImageTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductImageTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductImageTypeRefContract> DataListToContractList(List<CrudeProductImageTypeRefData> dataList) {
            var contractList = new List<CrudeProductImageTypeRefContract>();

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductImageTypeRefContract> contractList, List<CrudeProductImageTypeRefData> dataList) {
            foreach (CrudeProductImageTypeRefContract contract in contractList) {
                var data = new CrudeProductImageTypeRefData();
                CrudeProductImageTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductImageTypeRefContract> FetchAll() {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAll();

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductImageTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchWithFilter(
                productImageTypeRcd: productImageTypeRcd,
                productImageTypeName: productImageTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var crudeProductImageTypeRefContract = new CrudeProductImageTypeRefContract();
                DataToContract(data, crudeProductImageTypeRefContract);
                list.Add(crudeProductImageTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductImageTypeRefContract contract) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductImageTypeRefContract contract) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productImageTypeRcd) {
            CrudeProductImageTypeRefData.Delete(productImageTypeRcd);
        }
        
        public static void ContractToData(CrudeProductImageTypeRefContract contract, CrudeProductImageTypeRefData data) {
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ProductImageTypeName = contract.ProductImageTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductImageTypeRefData data, CrudeProductImageTypeRefContract contract) {
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ProductImageTypeName = data.ProductImageTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
