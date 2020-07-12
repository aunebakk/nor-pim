/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:04 AM
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
    public partial interface ICrudeProductCategoryDocumentationService {
        
        [OperationContract()]
        CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryDocumentationContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryDocumentationContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productCategoryDocumentationId);
    }
    
    public partial class CrudeProductCategoryDocumentationService : ICrudeProductCategoryDocumentationService {
        
        public CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            var contract = new CrudeProductCategoryDocumentationContract();

            dataAccessLayer.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToContractList(CrudeProductCategoryDocumentationData.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryDocumentationData.FetchByUserId(userId));
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return DataListToContractList(CrudeProductCategoryDocumentationData.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd));
        }
        
        public static List<CrudeProductCategoryDocumentationContract> DataListToContractList(List<CrudeProductCategoryDocumentationData> dataList) {
            var contractList = new List<CrudeProductCategoryDocumentationContract>();

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryDocumentationContract> contractList, List<CrudeProductCategoryDocumentationData> dataList) {
            foreach (CrudeProductCategoryDocumentationContract contract in contractList) {
                var data = new CrudeProductCategoryDocumentationData();
                CrudeProductCategoryDocumentationService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAll();

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryDocumentationData.FetchAllCount();
        }
        
        public List<CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchWithFilter(
                productCategoryDocumentationId: productCategoryDocumentationId,
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryId: productCategoryId,
                documentation: documentation,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var crudeProductCategoryDocumentationContract = new CrudeProductCategoryDocumentationContract();
                DataToContract(data, crudeProductCategoryDocumentationContract);
                list.Add(crudeProductCategoryDocumentationContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryDocumentationContract contract) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryDocumentationContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryDocumentationContract contract) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryDocumentationContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryDocumentationId) {
            CrudeProductCategoryDocumentationData.Delete(productCategoryDocumentationId);
        }
        
        public static void ContractToData(CrudeProductCategoryDocumentationContract contract, CrudeProductCategoryDocumentationData data) {
            data.ProductCategoryDocumentationId = contract.ProductCategoryDocumentationId;
            data.ProductCategoryDocumentationTypeRcd = contract.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryId = contract.ProductCategoryId;
            data.Documentation = contract.Documentation;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryDocumentationData data, CrudeProductCategoryDocumentationContract contract) {
            contract.ProductCategoryDocumentationId = data.ProductCategoryDocumentationId;
            contract.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.Documentation = data.Documentation;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
