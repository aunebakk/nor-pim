/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:53:18 AM
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
    public partial interface ICrudeProductSupplierService {
        
        [OperationContract()]
        CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductSupplierContract FetchBySupplierName(string supplierName);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductSupplierContract contract);
        
        [OperationContract()]
        void Update(CrudeProductSupplierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productSupplierId);
    }
    
    public partial class CrudeProductSupplierService : ICrudeProductSupplierService {
        
        public CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId) {
            var dataAccessLayer = new CrudeProductSupplierData();
            var contract = new CrudeProductSupplierContract();

            dataAccessLayer.FetchByProductSupplierId(productSupplierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductSupplierContract FetchBySupplierName(string supplierName) {
            var dataAccessLayer = new CrudeProductSupplierData();
            var contract = new CrudeProductSupplierContract();

            dataAccessLayer.FetchBySupplierName(supplierName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductSupplierContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductSupplierData.FetchByProductId(productId));
        }
        
        public List<CrudeProductSupplierContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductSupplierData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductSupplierContract> DataListToContractList(List<CrudeProductSupplierData> dataList) {
            var contractList = new List<CrudeProductSupplierContract>();

            foreach (CrudeProductSupplierData data in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductSupplierContract> contractList, List<CrudeProductSupplierData> dataList) {
            foreach (CrudeProductSupplierContract contract in contractList) {
                var data = new CrudeProductSupplierData();
                CrudeProductSupplierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductSupplierContract> FetchAll() {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAll();

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductSupplierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAllWithLimit(limit);

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductSupplierData.FetchAllCount();
        }
        
        public List<CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchWithFilter(
                productSupplierId: productSupplierId,
                productId: productId,
                supplierName: supplierName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductSupplierData data in dataList) {
                var crudeProductSupplierContract = new CrudeProductSupplierContract();
                DataToContract(data, crudeProductSupplierContract);
                list.Add(crudeProductSupplierContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductSupplierContract contract) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductSupplierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductSupplierContract contract) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductSupplierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productSupplierId) {
            CrudeProductSupplierData.Delete(productSupplierId);
        }
        
        public static void ContractToData(CrudeProductSupplierContract contract, CrudeProductSupplierData data) {
            data.ProductSupplierId = contract.ProductSupplierId;
            data.ProductId = contract.ProductId;
            data.SupplierName = contract.SupplierName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductSupplierData data, CrudeProductSupplierContract contract) {
            contract.ProductSupplierId = data.ProductSupplierId;
            contract.ProductId = data.ProductId;
            contract.SupplierName = data.SupplierName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
