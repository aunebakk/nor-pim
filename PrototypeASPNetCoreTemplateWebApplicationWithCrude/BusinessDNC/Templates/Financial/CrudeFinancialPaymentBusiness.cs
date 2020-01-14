/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:26 PM
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
    
    
    public partial class CrudeFinancialPaymentBusiness {
        
        public CrudeFinancialPaymentModel FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            var dataAccessLayer = new CrudeFinancialPaymentData();
            var model = new CrudeFinancialPaymentModel();

            dataAccessLayer.FetchByFinancialPaymentId(financialPaymentId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentModel> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd));
        }
        
        public List<CrudeFinancialPaymentModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentModel> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByFinancialPaymentAccountingId(financialPaymentAccountingId));
        }
        
        public List<CrudeFinancialPaymentModel> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByFinancialPaymentBankId(financialPaymentBankId));
        }
        
        public List<CrudeFinancialPaymentModel> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByFinancialPaymentVoucherId(financialPaymentVoucherId));
        }
        
        public List<CrudeFinancialPaymentModel> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByFinancialPaymentCardId(financialPaymentCardId));
        }
        
        public List<CrudeFinancialPaymentModel> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByFinancialPaymentCashId(financialPaymentCashId));
        }
        
        public List<CrudeFinancialPaymentModel> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            return DataListToModelList(CrudeFinancialPaymentData.FetchByFinancialPaymentCouponId(financialPaymentCouponId));
        }
        
        public static List<CrudeFinancialPaymentModel> DataListToModelList(List<CrudeFinancialPaymentData> dataList) {
            var modelList = new List<CrudeFinancialPaymentModel>();

            foreach (CrudeFinancialPaymentData data in dataList) {
                var model = new CrudeFinancialPaymentModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentModel> modelList, List<CrudeFinancialPaymentData> dataList) {
            foreach (CrudeFinancialPaymentModel model in modelList) {
                var data = new CrudeFinancialPaymentData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentModel>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchAll();

            foreach (CrudeFinancialPaymentData crudeFinancialPaymentBusiness in dataList) {
                var model = new CrudeFinancialPaymentModel();
                DataToModel(crudeFinancialPaymentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentModel>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentData crudeFinancialPaymentBusiness in dataList) {
                var model = new CrudeFinancialPaymentModel();
                DataToModel(crudeFinancialPaymentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentModel>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentData crudeFinancialPaymentBusiness in dataList) {
                var model = new CrudeFinancialPaymentModel();
                DataToModel(crudeFinancialPaymentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentModel> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId) {
            var list = new List<CrudeFinancialPaymentModel>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchWithFilter(financialPaymentId,financialPaymentTypeRcd,userId,dateTime,financialPaymentAccountingId,financialPaymentBankId,financialPaymentVoucherId,financialPaymentCardId,financialPaymentCashId,financialPaymentCouponId);

            foreach (CrudeFinancialPaymentData data in dataList) {
                var crudeFinancialPaymentBusinessModel = new CrudeFinancialPaymentModel();
                DataToModel(data, crudeFinancialPaymentBusinessModel);
                list.Add(crudeFinancialPaymentBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentModel model) {
            var data = new CrudeFinancialPaymentData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentModel model) {
            var data = new CrudeFinancialPaymentData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentId) {
            CrudeFinancialPaymentData.Delete(financialPaymentId);
        }
        
        public static void ModelToData(CrudeFinancialPaymentModel model, CrudeFinancialPaymentData data) {
            data.FinancialPaymentId = model.FinancialPaymentId;
            data.FinancialPaymentTypeRcd = model.FinancialPaymentTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.FinancialPaymentAccountingId = model.FinancialPaymentAccountingId;
            data.FinancialPaymentBankId = model.FinancialPaymentBankId;
            data.FinancialPaymentVoucherId = model.FinancialPaymentVoucherId;
            data.FinancialPaymentCardId = model.FinancialPaymentCardId;
            data.FinancialPaymentCashId = model.FinancialPaymentCashId;
            data.FinancialPaymentCouponId = model.FinancialPaymentCouponId;
        }
        
        public static void DataToModel(CrudeFinancialPaymentData data, CrudeFinancialPaymentModel model) {
            model.FinancialPaymentId = data.FinancialPaymentId;
            model.FinancialPaymentTypeRcd = data.FinancialPaymentTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.FinancialPaymentAccountingId = data.FinancialPaymentAccountingId;
            model.FinancialPaymentBankId = data.FinancialPaymentBankId;
            model.FinancialPaymentVoucherId = data.FinancialPaymentVoucherId;
            model.FinancialPaymentCardId = data.FinancialPaymentCardId;
            model.FinancialPaymentCashId = data.FinancialPaymentCashId;
            model.FinancialPaymentCouponId = data.FinancialPaymentCouponId;
        }
    }
}
