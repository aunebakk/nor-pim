/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:04 PM
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
    public partial interface ICrudeProductFieldSetService {
        
        [OperationContract()]
        CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductFieldSetContract FetchByProductFieldSetName(string productFieldSetName);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductFieldSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductFieldSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productFieldSetId);
    }
    
    public partial class CrudeProductFieldSetService : ICrudeProductFieldSetService {
        
        public CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            var contract = new CrudeProductFieldSetContract();

            dataAccessLayer.FetchByProductFieldSetId(productFieldSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductFieldSetContract FetchByProductFieldSetName(string productFieldSetName) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            var contract = new CrudeProductFieldSetContract();

            dataAccessLayer.FetchByProductFieldSetName(productFieldSetName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductFieldSetContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductFieldSetData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductFieldSetContract> DataListToContractList(List<CrudeProductFieldSetData> dataList) {
            var contractList = new List<CrudeProductFieldSetContract>();

            foreach (CrudeProductFieldSetData data in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductFieldSetContract> contractList, List<CrudeProductFieldSetData> dataList) {
            foreach (CrudeProductFieldSetContract contract in contractList) {
                var data = new CrudeProductFieldSetData();
                CrudeProductFieldSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductFieldSetContract> FetchAll() {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAll();

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAllWithLimit(limit);

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductFieldSetData.FetchAllCount();
        }
        
        public List<CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchWithFilter(
                productFieldSetId: productFieldSetId,
                productFieldSetName: productFieldSetName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductFieldSetData data in dataList) {
                var crudeProductFieldSetContract = new CrudeProductFieldSetContract();
                DataToContract(data, crudeProductFieldSetContract);
                list.Add(crudeProductFieldSetContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductFieldSetContract contract) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductFieldSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductFieldSetContract contract) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductFieldSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productFieldSetId) {
            CrudeProductFieldSetData.Delete(productFieldSetId);
        }
        
        public static void ContractToData(CrudeProductFieldSetContract contract, CrudeProductFieldSetData data) {
            data.ProductFieldSetId = contract.ProductFieldSetId;
            data.ProductFieldSetName = contract.ProductFieldSetName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductFieldSetData data, CrudeProductFieldSetContract contract) {
            contract.ProductFieldSetId = data.ProductFieldSetId;
            contract.ProductFieldSetName = data.ProductFieldSetName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
