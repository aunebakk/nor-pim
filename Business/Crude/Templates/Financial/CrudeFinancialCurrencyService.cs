/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:02 AM
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
    public partial interface ICrudeFinancialCurrencyService {
        
        [OperationContract()]
        CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd);
        
        [OperationContract()]
        CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCurrencyContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCurrencyContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialCurrencyId);
    }
    
    public partial class CrudeFinancialCurrencyService : ICrudeFinancialCurrencyService {
        
        public CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataAccessLayer = new CrudeFinancialCurrencyData();
            var contract = new CrudeFinancialCurrencyContract();

            dataAccessLayer.FetchByFinancialCurrencyId(financialCurrencyId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            var dataAccessLayer = new CrudeFinancialCurrencyData();
            var contract = new CrudeFinancialCurrencyContract();

            dataAccessLayer.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCurrencyData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            return DataListToContractList(CrudeFinancialCurrencyData.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd));
        }
        
        public List<CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            return DataListToContractList(CrudeFinancialCurrencyData.FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(financialCurrencyAgainstFinancialCurrencyTypeRcd));
        }
        
        public static List<CrudeFinancialCurrencyContract> DataListToContractList(List<CrudeFinancialCurrencyData> dataList) {
            var contractList = new List<CrudeFinancialCurrencyContract>();

            foreach (CrudeFinancialCurrencyData data in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialCurrencyContract> contractList, List<CrudeFinancialCurrencyData> dataList) {
            foreach (CrudeFinancialCurrencyContract contract in contractList) {
                var data = new CrudeFinancialCurrencyData();
                CrudeFinancialCurrencyService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCurrencyContract> FetchAll() {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAll();

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrency in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(crudeFinancialCurrency, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrency in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(crudeFinancialCurrency, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrency in dataList) {
                var contract = new CrudeFinancialCurrencyContract();
                DataToContract(crudeFinancialCurrency, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCurrencyData.FetchAllCount();
        }
        
        public List<CrudeFinancialCurrencyContract> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName) {
            var list = new List<CrudeFinancialCurrencyContract>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchWithFilter(
                financialCurrencyId: financialCurrencyId,
                financialCurrencyTypeRcd: financialCurrencyTypeRcd,
                financialCurrencyAgainstFinancialCurrencyTypeRcd: financialCurrencyAgainstFinancialCurrencyTypeRcd,
                userId: userId,
                dateTime: dateTime,
                validFromDateTime: validFromDateTime,
                validUntilDateTime: validUntilDateTime,
                amount: amount,
                equalsAmount: equalsAmount,
                decimalCount: decimalCount,
                financialCurrencyTypeCode: financialCurrencyTypeCode,
                financialCurrencyTypeName: financialCurrencyTypeName
                );

            foreach (CrudeFinancialCurrencyData data in dataList) {
                var crudeFinancialCurrencyContract = new CrudeFinancialCurrencyContract();
                DataToContract(data, crudeFinancialCurrencyContract);
                list.Add(crudeFinancialCurrencyContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCurrencyContract contract) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCurrencyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCurrencyContract contract) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCurrencyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCurrencyId) {
            CrudeFinancialCurrencyData.Delete(financialCurrencyId);
        }
        
        public static void ContractToData(CrudeFinancialCurrencyContract contract, CrudeFinancialCurrencyData data) {
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.FinancialCurrencyTypeRcd = contract.FinancialCurrencyTypeRcd;
            data.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ValidFromDateTime = contract.ValidFromDateTime;
            data.ValidUntilDateTime = contract.ValidUntilDateTime;
            data.Amount = contract.Amount;
            data.EqualsAmount = contract.EqualsAmount;
            data.DecimalCount = contract.DecimalCount;
            data.FinancialCurrencyTypeCode = contract.FinancialCurrencyTypeCode;
            data.FinancialCurrencyTypeName = contract.FinancialCurrencyTypeName;
        }
        
        public static void DataToContract(CrudeFinancialCurrencyData data, CrudeFinancialCurrencyContract contract) {
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.FinancialCurrencyTypeRcd = data.FinancialCurrencyTypeRcd;
            contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = data.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ValidFromDateTime = data.ValidFromDateTime;
            contract.ValidUntilDateTime = data.ValidUntilDateTime;
            contract.Amount = data.Amount;
            contract.EqualsAmount = data.EqualsAmount;
            contract.DecimalCount = data.DecimalCount;
            contract.FinancialCurrencyTypeCode = data.FinancialCurrencyTypeCode;
            contract.FinancialCurrencyTypeName = data.FinancialCurrencyTypeName;
        }
    }
}
