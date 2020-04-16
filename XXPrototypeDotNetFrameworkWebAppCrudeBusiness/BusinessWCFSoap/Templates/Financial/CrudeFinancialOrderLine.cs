/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:30:50 PM
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
    public partial interface ICrudeFinancialOrderLineService {
        
        [OperationContract()]
        CrudeFinancialOrderLineContract FetchByFinancialOrderLineId(System.Guid financialOrderLineId);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchWithFilter(System.Guid financialOrderLineId, System.Guid financialOrderId, System.Guid productId, System.Guid userId, System.DateTime dateTime, string comment, int lineNumber, string financialUnitOfMeasurementRcd, int quantityNumber, System.Guid financialCurrencyId, decimal amount);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderLineContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderLineContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderLineContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialOrderLineId);
    }
    
    public partial class CrudeFinancialOrderLineService : ICrudeFinancialOrderLineService {
        
        public CrudeFinancialOrderLineContract FetchByFinancialOrderLineId(System.Guid financialOrderLineId) {
            var dataAccessLayer = new CrudeFinancialOrderLineData();
            var contract = new CrudeFinancialOrderLineContract();

            dataAccessLayer.FetchByFinancialOrderLineId(financialOrderLineId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderLineContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToContractList(CrudeFinancialOrderLineData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public List<CrudeFinancialOrderLineContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeFinancialOrderLineData.FetchByProductId(productId));
        }
        
        public List<CrudeFinancialOrderLineContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderLineData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderLineContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialOrderLineData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialOrderLineContract> FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            return DataListToContractList(CrudeFinancialOrderLineData.FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd));
        }
        
        public static List<CrudeFinancialOrderLineContract> DataListToContractList(List<CrudeFinancialOrderLineData> dataList) {
            var contractList = new List<CrudeFinancialOrderLineContract>();

            foreach (CrudeFinancialOrderLineData data in dataList) {
                var contract = new CrudeFinancialOrderLineContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderLineContract> contractList, List<CrudeFinancialOrderLineData> dataList) {
            foreach (CrudeFinancialOrderLineContract contract in contractList) {
                var data = new CrudeFinancialOrderLineData();
                CrudeFinancialOrderLineService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderLineContract> FetchAll() {
            var list = new List<CrudeFinancialOrderLineContract>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchAll();

            foreach (CrudeFinancialOrderLineData crudeFinancialOrderLine in dataList) {
                var contract = new CrudeFinancialOrderLineContract();
                DataToContract(crudeFinancialOrderLine, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderLineContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderLineContract>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderLineData crudeFinancialOrderLine in dataList) {
                var contract = new CrudeFinancialOrderLineContract();
                DataToContract(crudeFinancialOrderLine, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderLineContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderLineContract>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderLineData crudeFinancialOrderLine in dataList) {
                var contract = new CrudeFinancialOrderLineContract();
                DataToContract(crudeFinancialOrderLine, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderLineData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderLineContract> FetchWithFilter(System.Guid financialOrderLineId, System.Guid financialOrderId, System.Guid productId, System.Guid userId, System.DateTime dateTime, string comment, int lineNumber, string financialUnitOfMeasurementRcd, int quantityNumber, System.Guid financialCurrencyId, decimal amount) {
            var list = new List<CrudeFinancialOrderLineContract>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchWithFilter(
                financialOrderLineId: financialOrderLineId,
                financialOrderId: financialOrderId,
                productId: productId,
                userId: userId,
                dateTime: dateTime,
                comment: comment,
                lineNumber: lineNumber,
                financialUnitOfMeasurementRcd: financialUnitOfMeasurementRcd,
                quantityNumber: quantityNumber,
                financialCurrencyId: financialCurrencyId,
                amount: amount
                );

            foreach (CrudeFinancialOrderLineData data in dataList) {
                var crudeFinancialOrderLineContract = new CrudeFinancialOrderLineContract();
                DataToContract(data, crudeFinancialOrderLineContract);
                list.Add(crudeFinancialOrderLineContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderLineContract contract) {
            var data = new CrudeFinancialOrderLineData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderLineContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderLineData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderLineContract contract) {
            var data = new CrudeFinancialOrderLineData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderLineContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderLineData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialOrderLineId) {
            CrudeFinancialOrderLineData.Delete(financialOrderLineId);
        }
        
        public static void ContractToData(CrudeFinancialOrderLineContract contract, CrudeFinancialOrderLineData data) {
            data.FinancialOrderLineId = contract.FinancialOrderLineId;
            data.FinancialOrderId = contract.FinancialOrderId;
            data.ProductId = contract.ProductId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Comment = contract.Comment;
            data.LineNumber = contract.LineNumber;
            data.FinancialUnitOfMeasurementRcd = contract.FinancialUnitOfMeasurementRcd;
            data.QuantityNumber = contract.QuantityNumber;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
        }
        
        public static void DataToContract(CrudeFinancialOrderLineData data, CrudeFinancialOrderLineContract contract) {
            contract.FinancialOrderLineId = data.FinancialOrderLineId;
            contract.FinancialOrderId = data.FinancialOrderId;
            contract.ProductId = data.ProductId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Comment = data.Comment;
            contract.LineNumber = data.LineNumber;
            contract.FinancialUnitOfMeasurementRcd = data.FinancialUnitOfMeasurementRcd;
            contract.QuantityNumber = data.QuantityNumber;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
        }
    }
}
