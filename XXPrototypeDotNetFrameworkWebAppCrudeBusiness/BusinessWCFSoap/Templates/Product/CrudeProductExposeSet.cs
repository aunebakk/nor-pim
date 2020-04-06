/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:22:52 PM
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
    public partial interface ICrudeProductExposeSetService {
        
        [OperationContract()]
        CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposeSetId);
    }
    
    public partial class CrudeProductExposeSetService : ICrudeProductExposeSetService {
        
        public CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            var contract = new CrudeProductExposeSetContract();

            dataAccessLayer.FetchByProductExposeSetId(productExposeSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            var contract = new CrudeProductExposeSetContract();

            dataAccessLayer.FetchByProductExposeSetName(productExposeSetName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductExposeSetContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposeSetData.FetchByUserId(userId));
        }
        
        public List<CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return DataListToContractList(CrudeProductExposeSetData.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd));
        }
        
        public static List<CrudeProductExposeSetContract> DataListToContractList(List<CrudeProductExposeSetData> dataList) {
            var contractList = new List<CrudeProductExposeSetContract>();

            foreach (CrudeProductExposeSetData data in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposeSetContract> contractList, List<CrudeProductExposeSetData> dataList) {
            foreach (CrudeProductExposeSetContract contract in contractList) {
                var data = new CrudeProductExposeSetData();
                CrudeProductExposeSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeSetContract> FetchAll() {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAll();

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposeSetData.FetchAllCount();
        }
        
        public List<CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchWithFilter(
                productExposeSetId: productExposeSetId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetName: productExposeSetName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposeSetData data in dataList) {
                var crudeProductExposeSetContract = new CrudeProductExposeSetContract();
                DataToContract(data, crudeProductExposeSetContract);
                list.Add(crudeProductExposeSetContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeSetContract contract) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposeSetContract contract) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposeSetId) {
            CrudeProductExposeSetData.Delete(productExposeSetId);
        }
        
        public static void ContractToData(CrudeProductExposeSetContract contract, CrudeProductExposeSetData data) {
            data.ProductExposeSetId = contract.ProductExposeSetId;
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.ProductExposeSetName = contract.ProductExposeSetName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposeSetData data, CrudeProductExposeSetContract contract) {
            contract.ProductExposeSetId = data.ProductExposeSetId;
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.ProductExposeSetName = data.ProductExposeSetName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
