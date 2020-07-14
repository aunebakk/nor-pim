/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:57:24 AM
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
    public partial interface ICrudeProductGatherAttributeService {
        
        [OperationContract()]
        CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherAttributeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherAttributeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherAttributeId);
    }
    
    public partial class CrudeProductGatherAttributeService : ICrudeProductGatherAttributeService {
        
        public CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            var contract = new CrudeProductGatherAttributeContract();

            dataAccessLayer.FetchByProductGatherAttributeId(productGatherAttributeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return DataListToContractList(CrudeProductGatherAttributeData.FetchByProductGatherKeyId(productGatherKeyId));
        }
        
        public List<CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherAttributeData.FetchByUserId(userId));
        }
        
        public List<CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return DataListToContractList(CrudeProductGatherAttributeData.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd));
        }
        
        public static List<CrudeProductGatherAttributeContract> DataListToContractList(List<CrudeProductGatherAttributeData> dataList) {
            var contractList = new List<CrudeProductGatherAttributeContract>();

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherAttributeContract> contractList, List<CrudeProductGatherAttributeData> dataList) {
            foreach (CrudeProductGatherAttributeContract contract in contractList) {
                var data = new CrudeProductGatherAttributeData();
                CrudeProductGatherAttributeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherAttributeContract> FetchAll() {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAll();

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherAttributeData.FetchAllCount();
        }
        
        public List<CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchWithFilter(
                productGatherAttributeId: productGatherAttributeId,
                productGatherAttributeValue: productGatherAttributeValue,
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var crudeProductGatherAttributeContract = new CrudeProductGatherAttributeContract();
                DataToContract(data, crudeProductGatherAttributeContract);
                list.Add(crudeProductGatherAttributeContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherAttributeContract contract) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherAttributeContract contract) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherAttributeId) {
            CrudeProductGatherAttributeData.Delete(productGatherAttributeId);
        }
        
        public static void ContractToData(CrudeProductGatherAttributeContract contract, CrudeProductGatherAttributeData data) {
            data.ProductGatherAttributeId = contract.ProductGatherAttributeId;
            data.ProductGatherAttributeValue = contract.ProductGatherAttributeValue;
            data.ProductGatherAttributeTypeRcd = contract.ProductGatherAttributeTypeRcd;
            data.ProductGatherKeyId = contract.ProductGatherKeyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherAttributeData data, CrudeProductGatherAttributeContract contract) {
            contract.ProductGatherAttributeId = data.ProductGatherAttributeId;
            contract.ProductGatherAttributeValue = data.ProductGatherAttributeValue;
            contract.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            contract.ProductGatherKeyId = data.ProductGatherKeyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
