/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:55 AM
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
    
    
    public partial class CrudeFinancialVoucherBusiness {
        
        public CrudeFinancialVoucherModel FetchByFinancialVoucherId(System.Guid financialVoucherId) {
            var dataAccessLayer = new CrudeFinancialVoucherData();
            var model = new CrudeFinancialVoucherModel();

            dataAccessLayer.FetchByFinancialVoucherId(financialVoucherId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialVoucherModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialVoucherData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialVoucherModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialVoucherData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialVoucherModel> FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            return DataListToModelList(CrudeFinancialVoucherData.FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd));
        }
        
        public static List<CrudeFinancialVoucherModel> DataListToModelList(List<CrudeFinancialVoucherData> dataList) {
            var modelList = new List<CrudeFinancialVoucherModel>();

            foreach (CrudeFinancialVoucherData data in dataList) {
                var model = new CrudeFinancialVoucherModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialVoucherModel> modelList, List<CrudeFinancialVoucherData> dataList) {
            foreach (CrudeFinancialVoucherModel model in modelList) {
                var data = new CrudeFinancialVoucherData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialVoucherModel> FetchAll() {
            var list = new List<CrudeFinancialVoucherModel>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchAll();

            foreach (CrudeFinancialVoucherData crudeFinancialVoucherBusiness in dataList) {
                var model = new CrudeFinancialVoucherModel();
                DataToModel(crudeFinancialVoucherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialVoucherModel>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialVoucherData crudeFinancialVoucherBusiness in dataList) {
                var model = new CrudeFinancialVoucherModel();
                DataToModel(crudeFinancialVoucherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialVoucherModel>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialVoucherData crudeFinancialVoucherBusiness in dataList) {
                var model = new CrudeFinancialVoucherModel();
                DataToModel(crudeFinancialVoucherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialVoucherData.FetchAllCount();

        }
        
        public List<CrudeFinancialVoucherModel> FetchWithFilter(System.Guid financialVoucherId, System.Guid userId, System.DateTime dateTime, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, System.Guid financialCurrencyId, int voucherNumber, string voucherDescription, string financialVoucherTypeRcd) {
            var list = new List<CrudeFinancialVoucherModel>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchWithFilter(financialVoucherId,userId,dateTime,valueAmount,validFromDateTime,validUntilDateTime,financialCurrencyId,voucherNumber,voucherDescription,financialVoucherTypeRcd);

            foreach (CrudeFinancialVoucherData data in dataList) {
                var crudeFinancialVoucherBusinessModel = new CrudeFinancialVoucherModel();
                DataToModel(data, crudeFinancialVoucherBusinessModel);
                list.Add(crudeFinancialVoucherBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialVoucherModel model) {
            var data = new CrudeFinancialVoucherData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialVoucherModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialVoucherModel model) {
            var data = new CrudeFinancialVoucherData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialVoucherModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialVoucherId) {
            CrudeFinancialVoucherData.Delete(financialVoucherId);
        }
        
        public static void ModelToData(CrudeFinancialVoucherModel model, CrudeFinancialVoucherData data) {
            data.FinancialVoucherId = model.FinancialVoucherId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.ValueAmount = model.ValueAmount;
            data.ValidFromDateTime = model.ValidFromDateTime;
            data.ValidUntilDateTime = model.ValidUntilDateTime;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.VoucherNumber = model.VoucherNumber;
            data.VoucherDescription = model.VoucherDescription;
            data.FinancialVoucherTypeRcd = model.FinancialVoucherTypeRcd;
        }
        
        public static void DataToModel(CrudeFinancialVoucherData data, CrudeFinancialVoucherModel model) {
            model.FinancialVoucherId = data.FinancialVoucherId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.ValueAmount = data.ValueAmount;
            model.ValidFromDateTime = data.ValidFromDateTime;
            model.ValidUntilDateTime = data.ValidUntilDateTime;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.VoucherNumber = data.VoucherNumber;
            model.VoucherDescription = data.VoucherDescription;
            model.FinancialVoucherTypeRcd = data.FinancialVoucherTypeRcd;
        }
    }
}
