/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:43:30 AM
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
    public partial interface ICrudeProductGatherSourceTypeRefService {
        
        [OperationContract()]
        CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeName(string productGatherSourceTypeName);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherSourceTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherSourceTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productGatherSourceTypeRcd);
    }
    
    public partial class CrudeProductGatherSourceTypeRefService : ICrudeProductGatherSourceTypeRefService {
        
        public CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            var contract = new CrudeProductGatherSourceTypeRefContract();

            dataAccessLayer.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeName(string productGatherSourceTypeName) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            var contract = new CrudeProductGatherSourceTypeRefContract();

            dataAccessLayer.FetchByProductGatherSourceTypeName(productGatherSourceTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherSourceTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherSourceTypeRefContract> DataListToContractList(List<CrudeProductGatherSourceTypeRefData> dataList) {
            var contractList = new List<CrudeProductGatherSourceTypeRefContract>();

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherSourceTypeRefContract> contractList, List<CrudeProductGatherSourceTypeRefData> dataList) {
            foreach (CrudeProductGatherSourceTypeRefContract contract in contractList) {
                var data = new CrudeProductGatherSourceTypeRefData();
                CrudeProductGatherSourceTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchAll() {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAll();

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherSourceTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchWithFilter(
                productGatherSourceTypeRcd: productGatherSourceTypeRcd,
                productGatherSourceTypeName: productGatherSourceTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var crudeProductGatherSourceTypeRefContract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(data, crudeProductGatherSourceTypeRefContract);
                list.Add(crudeProductGatherSourceTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherSourceTypeRefContract contract) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherSourceTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherSourceTypeRefContract contract) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherSourceTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productGatherSourceTypeRcd) {
            CrudeProductGatherSourceTypeRefData.Delete(productGatherSourceTypeRcd);
        }
        
        public static void ContractToData(CrudeProductGatherSourceTypeRefContract contract, CrudeProductGatherSourceTypeRefData data) {
            data.ProductGatherSourceTypeRcd = contract.ProductGatherSourceTypeRcd;
            data.ProductGatherSourceTypeName = contract.ProductGatherSourceTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherSourceTypeRefData data, CrudeProductGatherSourceTypeRefContract contract) {
            contract.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
            contract.ProductGatherSourceTypeName = data.ProductGatherSourceTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
