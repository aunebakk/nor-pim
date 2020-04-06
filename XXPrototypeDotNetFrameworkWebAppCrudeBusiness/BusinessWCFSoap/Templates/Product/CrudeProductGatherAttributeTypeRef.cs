/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:36:55 PM
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
    public partial interface ICrudeProductGatherAttributeTypeRefService {
        
        [OperationContract()]
        CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherAttributeTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherAttributeTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productGatherAttributeTypeRcd);
    }
    
    public partial class CrudeProductGatherAttributeTypeRefService : ICrudeProductGatherAttributeTypeRefService {
        
        public CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            var contract = new CrudeProductGatherAttributeTypeRefContract();

            dataAccessLayer.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName) {
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            var contract = new CrudeProductGatherAttributeTypeRefContract();

            dataAccessLayer.FetchByProductGatherAttributeTypeName(productGatherAttributeTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherAttributeTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherAttributeTypeRefContract> DataListToContractList(List<CrudeProductGatherAttributeTypeRefData> dataList) {
            var contractList = new List<CrudeProductGatherAttributeTypeRefContract>();

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherAttributeTypeRefContract> contractList, List<CrudeProductGatherAttributeTypeRefData> dataList) {
            foreach (CrudeProductGatherAttributeTypeRefContract contract in contractList) {
                var data = new CrudeProductGatherAttributeTypeRefData();
                CrudeProductGatherAttributeTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAll() {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAll();

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                var contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherAttributeTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchWithFilter(
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherAttributeTypeName: productGatherAttributeTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                var crudeProductGatherAttributeTypeRefContract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(data, crudeProductGatherAttributeTypeRefContract);
                list.Add(crudeProductGatherAttributeTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherAttributeTypeRefContract contract) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherAttributeTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherAttributeTypeRefContract contract) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherAttributeTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productGatherAttributeTypeRcd) {
            CrudeProductGatherAttributeTypeRefData.Delete(productGatherAttributeTypeRcd);
        }
        
        public static void ContractToData(CrudeProductGatherAttributeTypeRefContract contract, CrudeProductGatherAttributeTypeRefData data) {
            data.ProductGatherAttributeTypeRcd = contract.ProductGatherAttributeTypeRcd;
            data.ProductGatherAttributeTypeName = contract.ProductGatherAttributeTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherAttributeTypeRefData data, CrudeProductGatherAttributeTypeRefContract contract) {
            contract.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            contract.ProductGatherAttributeTypeName = data.ProductGatherAttributeTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
