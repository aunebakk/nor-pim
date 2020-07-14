/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:57:21 AM
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
    public partial interface ICrudeProductCategoryImageTypeRefService {
        
        [OperationContract()]
        CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryImageTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryImageTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productCategoryImageTypeRcd);
    }
    
    public partial class CrudeProductCategoryImageTypeRefService : ICrudeProductCategoryImageTypeRefService {
        
        public CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            var contract = new CrudeProductCategoryImageTypeRefContract();

            dataAccessLayer.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            var contract = new CrudeProductCategoryImageTypeRefContract();

            dataAccessLayer.FetchByProductCategoryImageTypeName(productCategoryImageTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryImageTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryImageTypeRefContract> DataListToContractList(List<CrudeProductCategoryImageTypeRefData> dataList) {
            var contractList = new List<CrudeProductCategoryImageTypeRefContract>();

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryImageTypeRefContract> contractList, List<CrudeProductCategoryImageTypeRefData> dataList) {
            foreach (CrudeProductCategoryImageTypeRefContract contract in contractList) {
                var data = new CrudeProductCategoryImageTypeRefData();
                CrudeProductCategoryImageTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchAll() {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAll();

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryImageTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchWithFilter(
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                productCategoryImageTypeName: productCategoryImageTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var crudeProductCategoryImageTypeRefContract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(data, crudeProductCategoryImageTypeRefContract);
                list.Add(crudeProductCategoryImageTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryImageTypeRefContract contract) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryImageTypeRefContract contract) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productCategoryImageTypeRcd) {
            CrudeProductCategoryImageTypeRefData.Delete(productCategoryImageTypeRcd);
        }
        
        public static void ContractToData(CrudeProductCategoryImageTypeRefContract contract, CrudeProductCategoryImageTypeRefData data) {
            data.ProductCategoryImageTypeRcd = contract.ProductCategoryImageTypeRcd;
            data.ProductCategoryImageTypeName = contract.ProductCategoryImageTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryImageTypeRefData data, CrudeProductCategoryImageTypeRefContract contract) {
            contract.ProductCategoryImageTypeRcd = data.ProductCategoryImageTypeRcd;
            contract.ProductCategoryImageTypeName = data.ProductCategoryImageTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
