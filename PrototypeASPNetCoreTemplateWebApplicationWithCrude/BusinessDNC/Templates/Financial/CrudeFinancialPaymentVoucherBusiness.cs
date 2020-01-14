/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:28 AM
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
    
    
    public partial class CrudeFinancialPaymentVoucherBusiness {
        
        public CrudeFinancialPaymentVoucherModel FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            var dataAccessLayer = new CrudeFinancialPaymentVoucherData();
            var model = new CrudeFinancialPaymentVoucherModel();

            dataAccessLayer.FetchByFinancialPaymentVoucherId(financialPaymentVoucherId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentVoucherModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentVoucherData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentVoucherModel> FetchByFinancialVoucherId(System.Guid financialVoucherId) {
            return DataListToModelList(CrudeFinancialPaymentVoucherData.FetchByFinancialVoucherId(financialVoucherId));
        }
        
        public List<CrudeFinancialPaymentVoucherModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialPaymentVoucherData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentVoucherModel> DataListToModelList(List<CrudeFinancialPaymentVoucherData> dataList) {
            var modelList = new List<CrudeFinancialPaymentVoucherModel>();

            foreach (CrudeFinancialPaymentVoucherData data in dataList) {
                var model = new CrudeFinancialPaymentVoucherModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentVoucherModel> modelList, List<CrudeFinancialPaymentVoucherData> dataList) {
            foreach (CrudeFinancialPaymentVoucherModel model in modelList) {
                var data = new CrudeFinancialPaymentVoucherData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentVoucherModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentVoucherModel>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchAll();

            foreach (CrudeFinancialPaymentVoucherData crudeFinancialPaymentVoucherBusiness in dataList) {
                var model = new CrudeFinancialPaymentVoucherModel();
                DataToModel(crudeFinancialPaymentVoucherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentVoucherModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentVoucherModel>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentVoucherData crudeFinancialPaymentVoucherBusiness in dataList) {
                var model = new CrudeFinancialPaymentVoucherModel();
                DataToModel(crudeFinancialPaymentVoucherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentVoucherModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentVoucherModel>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentVoucherData crudeFinancialPaymentVoucherBusiness in dataList) {
                var model = new CrudeFinancialPaymentVoucherModel();
                DataToModel(crudeFinancialPaymentVoucherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentVoucherData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentVoucherModel> FetchWithFilter(System.Guid financialPaymentVoucherId, System.Guid userId, System.DateTime dateTime, System.Guid financialVoucherId, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentVoucherModel>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchWithFilter(financialPaymentVoucherId,userId,dateTime,financialVoucherId,amount,financialCurrencyId);

            foreach (CrudeFinancialPaymentVoucherData data in dataList) {
                var crudeFinancialPaymentVoucherBusinessModel = new CrudeFinancialPaymentVoucherModel();
                DataToModel(data, crudeFinancialPaymentVoucherBusinessModel);
                list.Add(crudeFinancialPaymentVoucherBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentVoucherModel model) {
            var data = new CrudeFinancialPaymentVoucherData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentVoucherModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentVoucherData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentVoucherModel model) {
            var data = new CrudeFinancialPaymentVoucherData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentVoucherModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentVoucherData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentVoucherId) {
            CrudeFinancialPaymentVoucherData.Delete(financialPaymentVoucherId);
        }
        
        public static void ModelToData(CrudeFinancialPaymentVoucherModel model, CrudeFinancialPaymentVoucherData data) {
            data.FinancialPaymentVoucherId = model.FinancialPaymentVoucherId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.FinancialVoucherId = model.FinancialVoucherId;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
        }
        
        public static void DataToModel(CrudeFinancialPaymentVoucherData data, CrudeFinancialPaymentVoucherModel model) {
            model.FinancialPaymentVoucherId = data.FinancialPaymentVoucherId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.FinancialVoucherId = data.FinancialVoucherId;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
