/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:53 AM
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
    
    
    public partial class CrudeFinancialPaymentBankBusiness {
        
        public CrudeFinancialPaymentBankModel FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            var dataAccessLayer = new CrudeFinancialPaymentBankData();
            var model = new CrudeFinancialPaymentBankModel();

            dataAccessLayer.FetchByFinancialPaymentBankId(financialPaymentBankId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialPaymentBankModel FetchByBankName(string bankName) {
            var dataAccessLayer = new CrudeFinancialPaymentBankData();
            var model = new CrudeFinancialPaymentBankModel();

            dataAccessLayer.FetchByBankName(bankName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentBankModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentBankData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentBankModel> FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd) {
            return DataListToModelList(CrudeFinancialPaymentBankData.FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd));
        }
        
        public List<CrudeFinancialPaymentBankModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialPaymentBankData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentBankModel> DataListToModelList(List<CrudeFinancialPaymentBankData> dataList) {
            var modelList = new List<CrudeFinancialPaymentBankModel>();

            foreach (CrudeFinancialPaymentBankData data in dataList) {
                var model = new CrudeFinancialPaymentBankModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentBankModel> modelList, List<CrudeFinancialPaymentBankData> dataList) {
            foreach (CrudeFinancialPaymentBankModel model in modelList) {
                var data = new CrudeFinancialPaymentBankData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentBankModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentBankModel>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchAll();

            foreach (CrudeFinancialPaymentBankData crudeFinancialPaymentBankBusiness in dataList) {
                var model = new CrudeFinancialPaymentBankModel();
                DataToModel(crudeFinancialPaymentBankBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentBankModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentBankModel>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentBankData crudeFinancialPaymentBankBusiness in dataList) {
                var model = new CrudeFinancialPaymentBankModel();
                DataToModel(crudeFinancialPaymentBankBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentBankModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentBankModel>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentBankData crudeFinancialPaymentBankBusiness in dataList) {
                var model = new CrudeFinancialPaymentBankModel();
                DataToModel(crudeFinancialPaymentBankBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentBankData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentBankModel> FetchWithFilter(System.Guid financialPaymentBankId, System.Guid userId, System.DateTime dateTime, string bankName, string bankAccount, string bankNumber, string financialBankAccountNumberTypeRcd, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentBankModel>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchWithFilter(financialPaymentBankId,userId,dateTime,bankName,bankAccount,bankNumber,financialBankAccountNumberTypeRcd,amount,financialCurrencyId);

            foreach (CrudeFinancialPaymentBankData data in dataList) {
                var crudeFinancialPaymentBankBusinessModel = new CrudeFinancialPaymentBankModel();
                DataToModel(data, crudeFinancialPaymentBankBusinessModel);
                list.Add(crudeFinancialPaymentBankBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentBankModel model) {
            var data = new CrudeFinancialPaymentBankData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentBankModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentBankData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentBankModel model) {
            var data = new CrudeFinancialPaymentBankData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentBankModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentBankData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentBankId) {
            CrudeFinancialPaymentBankData.Delete(financialPaymentBankId);
        }
        
        public static void ModelToData(CrudeFinancialPaymentBankModel model, CrudeFinancialPaymentBankData data) {
            data.FinancialPaymentBankId = model.FinancialPaymentBankId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.BankName = model.BankName;
            data.BankAccount = model.BankAccount;
            data.BankNumber = model.BankNumber;
            data.FinancialBankAccountNumberTypeRcd = model.FinancialBankAccountNumberTypeRcd;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
        }
        
        public static void DataToModel(CrudeFinancialPaymentBankData data, CrudeFinancialPaymentBankModel model) {
            model.FinancialPaymentBankId = data.FinancialPaymentBankId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.BankName = data.BankName;
            model.BankAccount = data.BankAccount;
            model.BankNumber = data.BankNumber;
            model.FinancialBankAccountNumberTypeRcd = data.FinancialBankAccountNumberTypeRcd;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
