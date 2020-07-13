/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:03 PM
  From Machine: DESKTOP-517I8BU
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
    public partial interface ICrudeProductDocumentationTypeRefService {
        
        [OperationContract()]
        CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeName(string productDocumentationTypeName);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productDocumentationTypeRcd);
    }
    
    public partial class CrudeProductDocumentationTypeRefService : ICrudeProductDocumentationTypeRefService {
        
        public CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            var contract = new CrudeProductDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeName(string productDocumentationTypeName) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            var contract = new CrudeProductDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductDocumentationTypeName(productDocumentationTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductDocumentationTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductDocumentationTypeRefContract> DataListToContractList(List<CrudeProductDocumentationTypeRefData> dataList) {
            var contractList = new List<CrudeProductDocumentationTypeRefContract>();

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductDocumentationTypeRefContract> contractList, List<CrudeProductDocumentationTypeRefData> dataList) {
            foreach (CrudeProductDocumentationTypeRefContract contract in contractList) {
                var data = new CrudeProductDocumentationTypeRefData();
                CrudeProductDocumentationTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchAll() {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAll();

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductDocumentationTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchWithFilter(
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                productDocumentationTypeName: productDocumentationTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var crudeProductDocumentationTypeRefContract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(data, crudeProductDocumentationTypeRefContract);
                list.Add(crudeProductDocumentationTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductDocumentationTypeRefContract contract) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductDocumentationTypeRefContract contract) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productDocumentationTypeRcd) {
            CrudeProductDocumentationTypeRefData.Delete(productDocumentationTypeRcd);
        }
        
        public static void ContractToData(CrudeProductDocumentationTypeRefContract contract, CrudeProductDocumentationTypeRefData data) {
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.ProductDocumentationTypeName = contract.ProductDocumentationTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductDocumentationTypeRefData data, CrudeProductDocumentationTypeRefContract contract) {
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.ProductDocumentationTypeName = data.ProductDocumentationTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
