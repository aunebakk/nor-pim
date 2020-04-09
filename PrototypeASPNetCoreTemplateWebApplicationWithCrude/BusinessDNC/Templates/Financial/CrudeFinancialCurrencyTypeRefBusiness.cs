/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:49 AM
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
    
    
    public partial class CrudeFinancialCurrencyTypeRefBusiness {
        
        public CrudeFinancialCurrencyTypeRefModel FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            var dataAccessLayer = new CrudeFinancialCurrencyTypeRefData();
            var model = new CrudeFinancialCurrencyTypeRefModel();

            dataAccessLayer.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialCurrencyTypeRefModel FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            var dataAccessLayer = new CrudeFinancialCurrencyTypeRefData();
            var model = new CrudeFinancialCurrencyTypeRefModel();

            dataAccessLayer.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialCurrencyTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialCurrencyTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCurrencyTypeRefModel> DataListToModelList(List<CrudeFinancialCurrencyTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialCurrencyTypeRefModel>();

            foreach (CrudeFinancialCurrencyTypeRefData data in dataList) {
                var model = new CrudeFinancialCurrencyTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialCurrencyTypeRefModel> modelList, List<CrudeFinancialCurrencyTypeRefData> dataList) {
            foreach (CrudeFinancialCurrencyTypeRefModel model in modelList) {
                var data = new CrudeFinancialCurrencyTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCurrencyTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialCurrencyTypeRefModel>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchAll();

            foreach (CrudeFinancialCurrencyTypeRefData crudeFinancialCurrencyTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCurrencyTypeRefModel();
                DataToModel(crudeFinancialCurrencyTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialCurrencyTypeRefModel>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialCurrencyTypeRefData crudeFinancialCurrencyTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCurrencyTypeRefModel();
                DataToModel(crudeFinancialCurrencyTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCurrencyTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialCurrencyTypeRefModel>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialCurrencyTypeRefData crudeFinancialCurrencyTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCurrencyTypeRefModel();
                DataToModel(crudeFinancialCurrencyTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCurrencyTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialCurrencyTypeRefModel> FetchWithFilter(string financialCurrencyTypeRcd, string financialCurrencyTypeName, System.Guid userId, System.DateTime dateTime, int decimalCount, string financialCurrencyTypeCode) {
            var list = new List<CrudeFinancialCurrencyTypeRefModel>();
            List<CrudeFinancialCurrencyTypeRefData> dataList = CrudeFinancialCurrencyTypeRefData.FetchWithFilter(financialCurrencyTypeRcd,financialCurrencyTypeName,userId,dateTime,decimalCount,financialCurrencyTypeCode);

            foreach (CrudeFinancialCurrencyTypeRefData data in dataList) {
                var crudeFinancialCurrencyTypeRefBusinessModel = new CrudeFinancialCurrencyTypeRefModel();
                DataToModel(data, crudeFinancialCurrencyTypeRefBusinessModel);
                list.Add(crudeFinancialCurrencyTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCurrencyTypeRefModel model) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCurrencyTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCurrencyTypeRefModel model) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCurrencyTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCurrencyTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialCurrencyTypeRcd) {
            CrudeFinancialCurrencyTypeRefData.Delete(financialCurrencyTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialCurrencyTypeRefModel model, CrudeFinancialCurrencyTypeRefData data) {
            data.FinancialCurrencyTypeRcd = model.FinancialCurrencyTypeRcd;
            data.FinancialCurrencyTypeName = model.FinancialCurrencyTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.DecimalCount = model.DecimalCount;
            data.FinancialCurrencyTypeCode = model.FinancialCurrencyTypeCode;
        }
        
        public static void DataToModel(CrudeFinancialCurrencyTypeRefData data, CrudeFinancialCurrencyTypeRefModel model) {
            model.FinancialCurrencyTypeRcd = data.FinancialCurrencyTypeRcd;
            model.FinancialCurrencyTypeName = data.FinancialCurrencyTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.DecimalCount = data.DecimalCount;
            model.FinancialCurrencyTypeCode = data.FinancialCurrencyTypeCode;
        }
    }
}
