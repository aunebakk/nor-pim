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
    
    
    public partial class CrudeFinancialPaymentCouponBusiness {
        
        public CrudeFinancialPaymentCouponModel FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            var dataAccessLayer = new CrudeFinancialPaymentCouponData();
            var model = new CrudeFinancialPaymentCouponModel();

            dataAccessLayer.FetchByFinancialPaymentCouponId(financialPaymentCouponId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentCouponModel> FetchByFinancialCouponId(System.Guid financialCouponId) {
            return DataListToModelList(CrudeFinancialPaymentCouponData.FetchByFinancialCouponId(financialCouponId));
        }
        
        public List<CrudeFinancialPaymentCouponModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentCouponData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentCouponModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialPaymentCouponData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentCouponModel> DataListToModelList(List<CrudeFinancialPaymentCouponData> dataList) {
            var modelList = new List<CrudeFinancialPaymentCouponModel>();

            foreach (CrudeFinancialPaymentCouponData data in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentCouponModel> modelList, List<CrudeFinancialPaymentCouponData> dataList) {
            foreach (CrudeFinancialPaymentCouponModel model in modelList) {
                var data = new CrudeFinancialPaymentCouponData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentCouponModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAll();

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCouponBusiness in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(crudeFinancialPaymentCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCouponModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCouponBusiness in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(crudeFinancialPaymentCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCouponModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCouponBusiness in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(crudeFinancialPaymentCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentCouponData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentCouponModel> FetchWithFilter(System.Guid financialPaymentCouponId, System.Guid financialCouponId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchWithFilter(financialPaymentCouponId,financialCouponId,userId,dateTime,amount,financialCurrencyId);

            foreach (CrudeFinancialPaymentCouponData data in dataList) {
                var crudeFinancialPaymentCouponBusinessModel = new CrudeFinancialPaymentCouponModel();
                DataToModel(data, crudeFinancialPaymentCouponBusinessModel);
                list.Add(crudeFinancialPaymentCouponBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentCouponModel model) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentCouponModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentCouponModel model) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentCouponModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentCouponId) {
            CrudeFinancialPaymentCouponData.Delete(financialPaymentCouponId);
        }
        
        public static void ModelToData(CrudeFinancialPaymentCouponModel model, CrudeFinancialPaymentCouponData data) {
            data.FinancialPaymentCouponId = model.FinancialPaymentCouponId;
            data.FinancialCouponId = model.FinancialCouponId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
        }
        
        public static void DataToModel(CrudeFinancialPaymentCouponData data, CrudeFinancialPaymentCouponModel model) {
            model.FinancialPaymentCouponId = data.FinancialPaymentCouponId;
            model.FinancialCouponId = data.FinancialCouponId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
