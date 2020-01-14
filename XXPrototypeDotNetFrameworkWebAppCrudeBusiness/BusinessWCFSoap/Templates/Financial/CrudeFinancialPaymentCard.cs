/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:54 PM
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
    public partial interface ICrudeFinancialPaymentCardService {
        
        [OperationContract()]
        CrudeFinancialPaymentCardContract FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchByFinancialCardTypeRcd(string financialCardTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchWithFilter(System.Guid financialPaymentCardId, System.Guid userId, System.DateTime dateTime, string cardNumber, string nameOnCard, int expiryYear, int expiryMonth, string financialCardTypeRcd, int cardVerificationValue, int issuedMonth, int issuedYear, string addressVerificationCode, decimal amount, System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentCardContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentCardContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentCardId);
    }
    
    public partial class CrudeFinancialPaymentCardService : ICrudeFinancialPaymentCardService {
        
        public CrudeFinancialPaymentCardContract FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            var dataAccessLayer = new CrudeFinancialPaymentCardData();
            var contract = new CrudeFinancialPaymentCardContract();

            dataAccessLayer.FetchByFinancialPaymentCardId(financialPaymentCardId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentCardContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentCardData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentCardContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialPaymentCardData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialPaymentCardContract> FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            return DataListToContractList(CrudeFinancialPaymentCardData.FetchByFinancialCardTypeRcd(financialCardTypeRcd));
        }
        
        public static List<CrudeFinancialPaymentCardContract> DataListToContractList(List<CrudeFinancialPaymentCardData> dataList) {
            var contractList = new List<CrudeFinancialPaymentCardContract>();

            foreach (CrudeFinancialPaymentCardData data in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentCardContract> contractList, List<CrudeFinancialPaymentCardData> dataList) {
            foreach (CrudeFinancialPaymentCardContract contract in contractList) {
                var data = new CrudeFinancialPaymentCardData();
                CrudeFinancialPaymentCardService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentCardContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAll();

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCard in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(crudeFinancialPaymentCard, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCardContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCard in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(crudeFinancialPaymentCard, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCardContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCard in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(crudeFinancialPaymentCard, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentCardData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentCardContract> FetchWithFilter(System.Guid financialPaymentCardId, System.Guid userId, System.DateTime dateTime, string cardNumber, string nameOnCard, int expiryYear, int expiryMonth, string financialCardTypeRcd, int cardVerificationValue, int issuedMonth, int issuedYear, string addressVerificationCode, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchWithFilter(
                financialPaymentCardId: financialPaymentCardId,
                userId: userId,
                dateTime: dateTime,
                cardNumber: cardNumber,
                nameOnCard: nameOnCard,
                expiryYear: expiryYear,
                expiryMonth: expiryMonth,
                financialCardTypeRcd: financialCardTypeRcd,
                cardVerificationValue: cardVerificationValue,
                issuedMonth: issuedMonth,
                issuedYear: issuedYear,
                addressVerificationCode: addressVerificationCode,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );

            foreach (CrudeFinancialPaymentCardData data in dataList) {
                var crudeFinancialPaymentCardContract = new CrudeFinancialPaymentCardContract();
                DataToContract(data, crudeFinancialPaymentCardContract);
                list.Add(crudeFinancialPaymentCardContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentCardContract contract) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentCardContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentCardContract contract) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentCardContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentCardId) {
            CrudeFinancialPaymentCardData.Delete(financialPaymentCardId);
        }
        
        public static void ContractToData(CrudeFinancialPaymentCardContract contract, CrudeFinancialPaymentCardData data) {
            data.FinancialPaymentCardId = contract.FinancialPaymentCardId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.CardNumber = contract.CardNumber;
            data.NameOnCard = contract.NameOnCard;
            data.ExpiryYear = contract.ExpiryYear;
            data.ExpiryMonth = contract.ExpiryMonth;
            data.FinancialCardTypeRcd = contract.FinancialCardTypeRcd;
            data.CardVerificationValue = contract.CardVerificationValue;
            data.IssuedMonth = contract.IssuedMonth;
            data.IssuedYear = contract.IssuedYear;
            data.AddressVerificationCode = contract.AddressVerificationCode;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
        }
        
        public static void DataToContract(CrudeFinancialPaymentCardData data, CrudeFinancialPaymentCardContract contract) {
            contract.FinancialPaymentCardId = data.FinancialPaymentCardId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.CardNumber = data.CardNumber;
            contract.NameOnCard = data.NameOnCard;
            contract.ExpiryYear = data.ExpiryYear;
            contract.ExpiryMonth = data.ExpiryMonth;
            contract.FinancialCardTypeRcd = data.FinancialCardTypeRcd;
            contract.CardVerificationValue = data.CardVerificationValue;
            contract.IssuedMonth = data.IssuedMonth;
            contract.IssuedYear = data.IssuedYear;
            contract.AddressVerificationCode = data.AddressVerificationCode;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
