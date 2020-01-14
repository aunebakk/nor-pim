/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:58 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreBusiness
*/
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class CrudeFinancialPaymentCardBusiness {
        
        public CrudeFinancialPaymentCardModel FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            var dataAccessLayer = new CrudeFinancialPaymentCardData();
            var model = new CrudeFinancialPaymentCardModel();

            dataAccessLayer.FetchByFinancialPaymentCardId(financialPaymentCardId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentCardModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentCardData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentCardModel> FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            return DataListToModelList(CrudeFinancialPaymentCardData.FetchByFinancialCardTypeRcd(financialCardTypeRcd));
        }
        
        public List<CrudeFinancialPaymentCardModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialPaymentCardData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentCardModel> DataListToModelList(List<CrudeFinancialPaymentCardData> dataList) {
            var modelList = new List<CrudeFinancialPaymentCardModel>();

            foreach (CrudeFinancialPaymentCardData data in dataList) {
                var model = new CrudeFinancialPaymentCardModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentCardModel> modelList, List<CrudeFinancialPaymentCardData> dataList) {
            foreach (CrudeFinancialPaymentCardModel model in modelList) {
                var data = new CrudeFinancialPaymentCardData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentCardModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentCardModel>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAll();

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCardBusiness in dataList) {
                var model = new CrudeFinancialPaymentCardModel();
                DataToModel(crudeFinancialPaymentCardBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCardModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentCardModel>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCardBusiness in dataList) {
                var model = new CrudeFinancialPaymentCardModel();
                DataToModel(crudeFinancialPaymentCardBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCardModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentCardModel>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCardBusiness in dataList) {
                var model = new CrudeFinancialPaymentCardModel();
                DataToModel(crudeFinancialPaymentCardBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentCardData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentCardModel> FetchWithFilter(System.Guid financialPaymentCardId, System.Guid userId, System.DateTime dateTime, string cardNumber, string nameOnCard, int expiryYear, int expiryMonth, string financialCardTypeRcd, int cardVerificationValue, int issuedMonth, int issuedYear, string addressVerificationCode, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentCardModel>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchWithFilter(financialPaymentCardId,userId,dateTime,cardNumber,nameOnCard,expiryYear,expiryMonth,financialCardTypeRcd,cardVerificationValue,issuedMonth,issuedYear,addressVerificationCode,amount,financialCurrencyId);

            foreach (CrudeFinancialPaymentCardData data in dataList) {
                var crudeFinancialPaymentCardBusinessModel = new CrudeFinancialPaymentCardModel();
                DataToModel(data, crudeFinancialPaymentCardBusinessModel);
                list.Add(crudeFinancialPaymentCardBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentCardModel model) {
            var data = new CrudeFinancialPaymentCardData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentCardModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCardData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentCardModel model) {
            var data = new CrudeFinancialPaymentCardData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentCardModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCardData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentCardId) {
            CrudeFinancialPaymentCardData.Delete(financialPaymentCardId);
        }
        
        public static void ModelToData(CrudeFinancialPaymentCardModel model, CrudeFinancialPaymentCardData data) {
            data.FinancialPaymentCardId = model.FinancialPaymentCardId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.CardNumber = model.CardNumber;
            data.NameOnCard = model.NameOnCard;
            data.ExpiryYear = model.ExpiryYear;
            data.ExpiryMonth = model.ExpiryMonth;
            data.FinancialCardTypeRcd = model.FinancialCardTypeRcd;
            data.CardVerificationValue = model.CardVerificationValue;
            data.IssuedMonth = model.IssuedMonth;
            data.IssuedYear = model.IssuedYear;
            data.AddressVerificationCode = model.AddressVerificationCode;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
        }
        
        public static void DataToModel(CrudeFinancialPaymentCardData data, CrudeFinancialPaymentCardModel model) {
            model.FinancialPaymentCardId = data.FinancialPaymentCardId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.CardNumber = data.CardNumber;
            model.NameOnCard = data.NameOnCard;
            model.ExpiryYear = data.ExpiryYear;
            model.ExpiryMonth = data.ExpiryMonth;
            model.FinancialCardTypeRcd = data.FinancialCardTypeRcd;
            model.CardVerificationValue = data.CardVerificationValue;
            model.IssuedMonth = data.IssuedMonth;
            model.IssuedYear = data.IssuedYear;
            model.AddressVerificationCode = data.AddressVerificationCode;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
