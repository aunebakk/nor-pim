/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
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
    
    
    public partial class CrudeFinancialCurrencyBusiness {
        
        public CrudeFinancialCurrencyModel FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataAccessLayer = new CrudeFinancialCurrencyData();
            var model = new CrudeFinancialCurrencyModel();

            dataAccessLayer.FetchByFinancialCurrencyId(financialCurrencyId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialCurrencyModel FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            var dataAccessLayer = new CrudeFinancialCurrencyData();
            var model = new CrudeFinancialCurrencyModel();

            dataAccessLayer.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialCurrencyModel> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            return DataListToModelList(CrudeFinancialCurrencyData.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd));
        }
        
        public List<CrudeFinancialCurrencyModel> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            return DataListToModelList(CrudeFinancialCurrencyData.FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(financialCurrencyAgainstFinancialCurrencyTypeRcd));
        }
        
        public List<CrudeFinancialCurrencyModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialCurrencyData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCurrencyModel> DataListToModelList(List<CrudeFinancialCurrencyData> dataList) {
            var modelList = new List<CrudeFinancialCurrencyModel>();

            foreach (CrudeFinancialCurrencyData data in dataList) {
                var model = new CrudeFinancialCurrencyModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialCurrencyModel> modelList, List<CrudeFinancialCurrencyData> dataList) {
            foreach (CrudeFinancialCurrencyModel model in modelList) {
                var data = new CrudeFinancialCurrencyData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCurrencyModel> FetchAll() {
            var list = new List<CrudeFinancialCurrencyModel>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAll();

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrencyBusiness in dataList) {
                var model = new CrudeFinancialCurrencyModel();
                DataToModel(crudeFinancialCurrencyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialCurrencyModel>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrencyBusiness in dataList) {
                var model = new CrudeFinancialCurrencyModel();
                DataToModel(crudeFinancialCurrencyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialCurrencyModel>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialCurrencyData crudeFinancialCurrencyBusiness in dataList) {
                var model = new CrudeFinancialCurrencyModel();
                DataToModel(crudeFinancialCurrencyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCurrencyData.FetchAllCount();

        }
        
        public List<CrudeFinancialCurrencyModel> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName) {
            var list = new List<CrudeFinancialCurrencyModel>();
            List<CrudeFinancialCurrencyData> dataList = CrudeFinancialCurrencyData.FetchWithFilter(financialCurrencyId,financialCurrencyTypeRcd,financialCurrencyAgainstFinancialCurrencyTypeRcd,userId,dateTime,validFromDateTime,validUntilDateTime,amount,equalsAmount,decimalCount,financialCurrencyTypeCode,financialCurrencyTypeName);

            foreach (CrudeFinancialCurrencyData data in dataList) {
                var crudeFinancialCurrencyBusinessModel = new CrudeFinancialCurrencyModel();
                DataToModel(data, crudeFinancialCurrencyBusinessModel);
                list.Add(crudeFinancialCurrencyBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCurrencyModel model) {
            var data = new CrudeFinancialCurrencyData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCurrencyModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCurrencyModel model) {
            var data = new CrudeFinancialCurrencyData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCurrencyModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCurrencyId) {
            CrudeFinancialCurrencyData.Delete(financialCurrencyId);
        }
        
        public static void ModelToData(CrudeFinancialCurrencyModel model, CrudeFinancialCurrencyData data) {
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.FinancialCurrencyTypeRcd = model.FinancialCurrencyTypeRcd;
            data.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = model.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.ValidFromDateTime = model.ValidFromDateTime;
            data.ValidUntilDateTime = model.ValidUntilDateTime;
            data.Amount = model.Amount;
            data.EqualsAmount = model.EqualsAmount;
            data.DecimalCount = model.DecimalCount;
            data.FinancialCurrencyTypeCode = model.FinancialCurrencyTypeCode;
            data.FinancialCurrencyTypeName = model.FinancialCurrencyTypeName;
        }
        
        public static void DataToModel(CrudeFinancialCurrencyData data, CrudeFinancialCurrencyModel model) {
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.FinancialCurrencyTypeRcd = data.FinancialCurrencyTypeRcd;
            model.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = data.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.ValidFromDateTime = data.ValidFromDateTime;
            model.ValidUntilDateTime = data.ValidUntilDateTime;
            model.Amount = data.Amount;
            model.EqualsAmount = data.EqualsAmount;
            model.DecimalCount = data.DecimalCount;
            model.FinancialCurrencyTypeCode = data.FinancialCurrencyTypeCode;
            model.FinancialCurrencyTypeName = data.FinancialCurrencyTypeName;
        }
    }
}
