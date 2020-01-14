/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:42:52 AM
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
    public partial interface ICrudeProductAttributeService {
        
        [OperationContract()]
        CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByProductAttributeRcd(string productAttributeRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productAttributeId);
    }
    
    public partial class CrudeProductAttributeService : ICrudeProductAttributeService {
        
        public CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId) {
            var dataAccessLayer = new CrudeProductAttributeData();
            var contract = new CrudeProductAttributeContract();

            dataAccessLayer.FetchByProductAttributeId(productAttributeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductAttributeContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductAttributeData.FetchByProductId(productId));
        }
        
        public List<CrudeProductAttributeContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductAttributeData.FetchByUserId(userId));
        }
        
        public List<CrudeProductAttributeContract> FetchByProductAttributeRcd(string productAttributeRcd) {
            return DataListToContractList(CrudeProductAttributeData.FetchByProductAttributeRcd(productAttributeRcd));
        }
        
        public List<CrudeProductAttributeContract> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            return DataListToContractList(CrudeProductAttributeData.FetchByProductAttributeUnitRcd(productAttributeUnitRcd));
        }
        
        public static List<CrudeProductAttributeContract> DataListToContractList(List<CrudeProductAttributeData> dataList) {
            var contractList = new List<CrudeProductAttributeContract>();

            foreach (CrudeProductAttributeData data in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductAttributeContract> contractList, List<CrudeProductAttributeData> dataList) {
            foreach (CrudeProductAttributeContract contract in contractList) {
                var data = new CrudeProductAttributeData();
                CrudeProductAttributeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeContract> FetchAll() {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAll();

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductAttributeData.FetchAllCount();
        }
        
        public List<CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchWithFilter(
                productAttributeId: productAttributeId,
                productId: productId,
                productAttributeRcd: productAttributeRcd,
                productAttributeUnitRcd: productAttributeUnitRcd,
                value: value,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductAttributeData data in dataList) {
                var crudeProductAttributeContract = new CrudeProductAttributeContract();
                DataToContract(data, crudeProductAttributeContract);
                list.Add(crudeProductAttributeContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeContract contract) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductAttributeContract contract) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productAttributeId) {
            CrudeProductAttributeData.Delete(productAttributeId);
        }
        
        public static void ContractToData(CrudeProductAttributeContract contract, CrudeProductAttributeData data) {
            data.ProductAttributeId = contract.ProductAttributeId;
            data.ProductId = contract.ProductId;
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductAttributeUnitRcd = contract.ProductAttributeUnitRcd;
            data.Value = contract.Value;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductAttributeData data, CrudeProductAttributeContract contract) {
            contract.ProductAttributeId = data.ProductAttributeId;
            contract.ProductId = data.ProductId;
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            contract.Value = data.Value;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
