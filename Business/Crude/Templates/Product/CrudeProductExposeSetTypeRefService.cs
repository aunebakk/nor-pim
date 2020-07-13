/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:49:25 PM
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
    public partial interface ICrudeProductExposeSetTypeRefService {
        
        [OperationContract()]
        CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productExposeSetTypeRcd);
    }
    
    public partial class CrudeProductExposeSetTypeRefService : ICrudeProductExposeSetTypeRefService {
        
        public CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var contract = new CrudeProductExposeSetTypeRefContract();

            dataAccessLayer.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var contract = new CrudeProductExposeSetTypeRefContract();

            dataAccessLayer.FetchByProductExposeSetTypeName(productExposeSetTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposeSetTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeSetTypeRefContract> DataListToContractList(List<CrudeProductExposeSetTypeRefData> dataList) {
            var contractList = new List<CrudeProductExposeSetTypeRefContract>();

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposeSetTypeRefContract> contractList, List<CrudeProductExposeSetTypeRefData> dataList) {
            foreach (CrudeProductExposeSetTypeRefContract contract in contractList) {
                var data = new CrudeProductExposeSetTypeRefData();
                CrudeProductExposeSetTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAll() {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAll();

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposeSetTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchWithFilter(
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetTypeName: productExposeSetTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var crudeProductExposeSetTypeRefContract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, crudeProductExposeSetTypeRefContract);
                list.Add(crudeProductExposeSetTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposeSetTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposeSetTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productExposeSetTypeRcd) {
            CrudeProductExposeSetTypeRefData.Delete(productExposeSetTypeRcd);
        }
        
        public static void ContractToData(CrudeProductExposeSetTypeRefContract contract, CrudeProductExposeSetTypeRefData data) {
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.ProductExposeSetTypeName = contract.ProductExposeSetTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposeSetTypeRefData data, CrudeProductExposeSetTypeRefContract contract) {
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.ProductExposeSetTypeName = data.ProductExposeSetTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
