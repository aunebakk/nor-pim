/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:12:19 AM
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
    public partial interface ICrudeProductFieldSetMappingService {
        
        [OperationContract()]
        CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductFieldSetMappingContract contract);
        
        [OperationContract()]
        void Update(CrudeProductFieldSetMappingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productFieldSetMappingId);
    }
    
    public partial class CrudeProductFieldSetMappingService : ICrudeProductFieldSetMappingService {
        
        public CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            var contract = new CrudeProductFieldSetMappingContract();

            dataAccessLayer.FetchByProductFieldSetMappingId(productFieldSetMappingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductFieldSetId(productFieldSetId));
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByUserId(userId));
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductIdentifierRcd(productIdentifierRcd));
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductAttributeRcd(productAttributeRcd));
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductInfoRcd(productInfoRcd));
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductImageTypeRcd(productImageTypeRcd));
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd));
        }
        
        public static List<CrudeProductFieldSetMappingContract> DataListToContractList(List<CrudeProductFieldSetMappingData> dataList) {
            var contractList = new List<CrudeProductFieldSetMappingContract>();

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductFieldSetMappingContract> contractList, List<CrudeProductFieldSetMappingData> dataList) {
            foreach (CrudeProductFieldSetMappingContract contract in contractList) {
                var data = new CrudeProductFieldSetMappingData();
                CrudeProductFieldSetMappingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchAll() {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAll();

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAllWithLimit(limit);

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductFieldSetMappingData.FetchAllCount();
        }
        
        public List<CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchWithFilter(
                productFieldSetMappingId: productFieldSetMappingId,
                productFieldSetId: productFieldSetId,
                productIdentifierRcd: productIdentifierRcd,
                productAttributeRcd: productAttributeRcd,
                productInfoRcd: productInfoRcd,
                productImageTypeRcd: productImageTypeRcd,
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var crudeProductFieldSetMappingContract = new CrudeProductFieldSetMappingContract();
                DataToContract(data, crudeProductFieldSetMappingContract);
                list.Add(crudeProductFieldSetMappingContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductFieldSetMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductFieldSetMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productFieldSetMappingId) {
            CrudeProductFieldSetMappingData.Delete(productFieldSetMappingId);
        }
        
        public static void ContractToData(CrudeProductFieldSetMappingContract contract, CrudeProductFieldSetMappingData data) {
            data.ProductFieldSetMappingId = contract.ProductFieldSetMappingId;
            data.ProductFieldSetId = contract.ProductFieldSetId;
            data.ProductIdentifierRcd = contract.ProductIdentifierRcd;
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductFieldSetMappingData data, CrudeProductFieldSetMappingContract contract) {
            contract.ProductFieldSetMappingId = data.ProductFieldSetMappingId;
            contract.ProductFieldSetId = data.ProductFieldSetId;
            contract.ProductIdentifierRcd = data.ProductIdentifierRcd;
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
