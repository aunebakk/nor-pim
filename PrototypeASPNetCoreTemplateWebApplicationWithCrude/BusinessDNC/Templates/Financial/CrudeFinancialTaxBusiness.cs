/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:59 AM
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
    
    
    public partial class CrudeFinancialTaxBusiness {
        
        public CrudeFinancialTaxModel FetchByFinancialTaxId(System.Guid financialTaxId) {
            var dataAccessLayer = new CrudeFinancialTaxData();
            var model = new CrudeFinancialTaxModel();

            dataAccessLayer.FetchByFinancialTaxId(financialTaxId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialTaxModel> FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            return DataListToModelList(CrudeFinancialTaxData.FetchByFinancialTaxTypeRcd(financialTaxTypeRcd));
        }
        
        public List<CrudeFinancialTaxModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialTaxData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialTaxModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialTaxData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialTaxModel> DataListToModelList(List<CrudeFinancialTaxData> dataList) {
            var modelList = new List<CrudeFinancialTaxModel>();

            foreach (CrudeFinancialTaxData data in dataList) {
                var model = new CrudeFinancialTaxModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialTaxModel> modelList, List<CrudeFinancialTaxData> dataList) {
            foreach (CrudeFinancialTaxModel model in modelList) {
                var data = new CrudeFinancialTaxData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialTaxModel> FetchAll() {
            var list = new List<CrudeFinancialTaxModel>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchAll();

            foreach (CrudeFinancialTaxData crudeFinancialTaxBusiness in dataList) {
                var model = new CrudeFinancialTaxModel();
                DataToModel(crudeFinancialTaxBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialTaxModel>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialTaxData crudeFinancialTaxBusiness in dataList) {
                var model = new CrudeFinancialTaxModel();
                DataToModel(crudeFinancialTaxBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialTaxModel>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialTaxData crudeFinancialTaxBusiness in dataList) {
                var model = new CrudeFinancialTaxModel();
                DataToModel(crudeFinancialTaxBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialTaxData.FetchAllCount();

        }
        
        public List<CrudeFinancialTaxModel> FetchWithFilter(System.Guid financialTaxId, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialCurrencyId, decimal amount) {
            var list = new List<CrudeFinancialTaxModel>();
            List<CrudeFinancialTaxData> dataList = CrudeFinancialTaxData.FetchWithFilter(financialTaxId,financialTaxTypeRcd,userId,dateTime,financialCurrencyId,amount);

            foreach (CrudeFinancialTaxData data in dataList) {
                var crudeFinancialTaxBusinessModel = new CrudeFinancialTaxModel();
                DataToModel(data, crudeFinancialTaxBusinessModel);
                list.Add(crudeFinancialTaxBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialTaxModel model) {
            var data = new CrudeFinancialTaxData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialTaxModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialTaxModel model) {
            var data = new CrudeFinancialTaxData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialTaxModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialTaxId) {
            CrudeFinancialTaxData.Delete(financialTaxId);
        }
        
        public static void ModelToData(CrudeFinancialTaxModel model, CrudeFinancialTaxData data) {
            data.FinancialTaxId = model.FinancialTaxId;
            data.FinancialTaxTypeRcd = model.FinancialTaxTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.Amount = model.Amount;
        }
        
        public static void DataToModel(CrudeFinancialTaxData data, CrudeFinancialTaxModel model) {
            model.FinancialTaxId = data.FinancialTaxId;
            model.FinancialTaxTypeRcd = data.FinancialTaxTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.Amount = data.Amount;
        }
    }
}
