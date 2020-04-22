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
    
    
    public partial class CrudeFinancialFeeBusiness {
        
        public CrudeFinancialFeeModel FetchByFinancialFeeId(System.Guid financialFeeId) {
            var dataAccessLayer = new CrudeFinancialFeeData();
            var model = new CrudeFinancialFeeModel();

            dataAccessLayer.FetchByFinancialFeeId(financialFeeId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialFeeModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialFeeData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialFeeModel> FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd) {
            return DataListToModelList(CrudeFinancialFeeData.FetchByFinancialFeeTypeRcd(financialFeeTypeRcd));
        }
        
        public List<CrudeFinancialFeeModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialFeeData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialFeeModel> DataListToModelList(List<CrudeFinancialFeeData> dataList) {
            var modelList = new List<CrudeFinancialFeeModel>();

            foreach (CrudeFinancialFeeData data in dataList) {
                var model = new CrudeFinancialFeeModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialFeeModel> modelList, List<CrudeFinancialFeeData> dataList) {
            foreach (CrudeFinancialFeeModel model in modelList) {
                var data = new CrudeFinancialFeeData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialFeeModel> FetchAll() {
            var list = new List<CrudeFinancialFeeModel>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchAll();

            foreach (CrudeFinancialFeeData crudeFinancialFeeBusiness in dataList) {
                var model = new CrudeFinancialFeeModel();
                DataToModel(crudeFinancialFeeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialFeeModel>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialFeeData crudeFinancialFeeBusiness in dataList) {
                var model = new CrudeFinancialFeeModel();
                DataToModel(crudeFinancialFeeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialFeeModel>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialFeeData crudeFinancialFeeBusiness in dataList) {
                var model = new CrudeFinancialFeeModel();
                DataToModel(crudeFinancialFeeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialFeeData.FetchAllCount();

        }
        
        public List<CrudeFinancialFeeModel> FetchWithFilter(System.Guid financialFeeId, System.Guid userId, System.DateTime dateTime, string financialFeeTypeRcd, System.Guid financialCurrencyId, decimal amount) {
            var list = new List<CrudeFinancialFeeModel>();
            List<CrudeFinancialFeeData> dataList = CrudeFinancialFeeData.FetchWithFilter(financialFeeId,userId,dateTime,financialFeeTypeRcd,financialCurrencyId,amount);

            foreach (CrudeFinancialFeeData data in dataList) {
                var crudeFinancialFeeBusinessModel = new CrudeFinancialFeeModel();
                DataToModel(data, crudeFinancialFeeBusinessModel);
                list.Add(crudeFinancialFeeBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialFeeModel model) {
            var data = new CrudeFinancialFeeData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialFeeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialFeeModel model) {
            var data = new CrudeFinancialFeeData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialFeeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialFeeId) {
            CrudeFinancialFeeData.Delete(financialFeeId);
        }
        
        public static void ModelToData(CrudeFinancialFeeModel model, CrudeFinancialFeeData data) {
            data.FinancialFeeId = model.FinancialFeeId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.FinancialFeeTypeRcd = model.FinancialFeeTypeRcd;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.Amount = model.Amount;
        }
        
        public static void DataToModel(CrudeFinancialFeeData data, CrudeFinancialFeeModel model) {
            model.FinancialFeeId = data.FinancialFeeId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.FinancialFeeTypeRcd = data.FinancialFeeTypeRcd;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.Amount = data.Amount;
        }
    }
}
