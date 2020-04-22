/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
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
    
    
    public partial class CrudeFinancialCouponBusiness {
        
        public CrudeFinancialCouponModel FetchByFinancialCouponId(System.Guid financialCouponId) {
            var dataAccessLayer = new CrudeFinancialCouponData();
            var model = new CrudeFinancialCouponModel();

            dataAccessLayer.FetchByFinancialCouponId(financialCouponId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialCouponModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialCouponData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialCouponModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialCouponData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialCouponModel> FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            return DataListToModelList(CrudeFinancialCouponData.FetchByFinancialCouponTypeRcd(financialCouponTypeRcd));
        }
        
        public static List<CrudeFinancialCouponModel> DataListToModelList(List<CrudeFinancialCouponData> dataList) {
            var modelList = new List<CrudeFinancialCouponModel>();

            foreach (CrudeFinancialCouponData data in dataList) {
                var model = new CrudeFinancialCouponModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialCouponModel> modelList, List<CrudeFinancialCouponData> dataList) {
            foreach (CrudeFinancialCouponModel model in modelList) {
                var data = new CrudeFinancialCouponData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCouponModel> FetchAll() {
            var list = new List<CrudeFinancialCouponModel>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchAll();

            foreach (CrudeFinancialCouponData crudeFinancialCouponBusiness in dataList) {
                var model = new CrudeFinancialCouponModel();
                DataToModel(crudeFinancialCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialCouponModel>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialCouponData crudeFinancialCouponBusiness in dataList) {
                var model = new CrudeFinancialCouponModel();
                DataToModel(crudeFinancialCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialCouponModel>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialCouponData crudeFinancialCouponBusiness in dataList) {
                var model = new CrudeFinancialCouponModel();
                DataToModel(crudeFinancialCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCouponData.FetchAllCount();

        }
        
        public List<CrudeFinancialCouponModel> FetchWithFilter(System.Guid financialCouponId, int couponNumber, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, string couponDescription, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialCouponTypeRcd) {
            var list = new List<CrudeFinancialCouponModel>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchWithFilter(financialCouponId,couponNumber,valueAmount,validFromDateTime,validUntilDateTime,couponDescription,financialCurrencyId,userId,dateTime,financialCouponTypeRcd);

            foreach (CrudeFinancialCouponData data in dataList) {
                var crudeFinancialCouponBusinessModel = new CrudeFinancialCouponModel();
                DataToModel(data, crudeFinancialCouponBusinessModel);
                list.Add(crudeFinancialCouponBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCouponModel model) {
            var data = new CrudeFinancialCouponData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCouponModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCouponModel model) {
            var data = new CrudeFinancialCouponData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCouponModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCouponId) {
            CrudeFinancialCouponData.Delete(financialCouponId);
        }
        
        public static void ModelToData(CrudeFinancialCouponModel model, CrudeFinancialCouponData data) {
            data.FinancialCouponId = model.FinancialCouponId;
            data.CouponNumber = model.CouponNumber;
            data.ValueAmount = model.ValueAmount;
            data.ValidFromDateTime = model.ValidFromDateTime;
            data.ValidUntilDateTime = model.ValidUntilDateTime;
            data.CouponDescription = model.CouponDescription;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.FinancialCouponTypeRcd = model.FinancialCouponTypeRcd;
        }
        
        public static void DataToModel(CrudeFinancialCouponData data, CrudeFinancialCouponModel model) {
            model.FinancialCouponId = data.FinancialCouponId;
            model.CouponNumber = data.CouponNumber;
            model.ValueAmount = data.ValueAmount;
            model.ValidFromDateTime = data.ValidFromDateTime;
            model.ValidUntilDateTime = data.ValidUntilDateTime;
            model.CouponDescription = data.CouponDescription;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.FinancialCouponTypeRcd = data.FinancialCouponTypeRcd;
        }
    }
}
