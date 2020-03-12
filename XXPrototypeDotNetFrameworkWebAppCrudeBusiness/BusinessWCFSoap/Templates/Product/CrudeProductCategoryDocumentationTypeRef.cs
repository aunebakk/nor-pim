/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:39:30 PM
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
    public partial interface ICrudeProductCategoryDocumentationTypeRefService {
        
        [OperationContract()]
        CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productCategoryDocumentationTypeRcd);
    }
    
    public partial class CrudeProductCategoryDocumentationTypeRefService : ICrudeProductCategoryDocumentationTypeRefService {
        
        public CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductCategoryDocumentationTypeName(productCategoryDocumentationTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryDocumentationTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefContract> DataListToContractList(List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            var contractList = new List<CrudeProductCategoryDocumentationTypeRefContract>();

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryDocumentationTypeRefContract> contractList, List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            foreach (CrudeProductCategoryDocumentationTypeRefContract contract in contractList) {
                var data = new CrudeProductCategoryDocumentationTypeRefData();
                CrudeProductCategoryDocumentationTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAll();

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryDocumentationTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchWithFilter(
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryDocumentationTypeName: productCategoryDocumentationTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var crudeProductCategoryDocumentationTypeRefContract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(data, crudeProductCategoryDocumentationTypeRefContract);
                list.Add(crudeProductCategoryDocumentationTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productCategoryDocumentationTypeRcd) {
            CrudeProductCategoryDocumentationTypeRefData.Delete(productCategoryDocumentationTypeRcd);
        }
        
        public static void ContractToData(CrudeProductCategoryDocumentationTypeRefContract contract, CrudeProductCategoryDocumentationTypeRefData data) {
            data.ProductCategoryDocumentationTypeRcd = contract.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryDocumentationTypeName = contract.ProductCategoryDocumentationTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryDocumentationTypeRefData data, CrudeProductCategoryDocumentationTypeRefContract contract) {
            contract.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            contract.ProductCategoryDocumentationTypeName = data.ProductCategoryDocumentationTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
