/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:48 AM
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
    
    
    public partial class CrudeFinancialCostcentreBusiness {
        
        public CrudeFinancialCostcentreModel FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            var dataAccessLayer = new CrudeFinancialCostcentreData();
            var model = new CrudeFinancialCostcentreModel();

            dataAccessLayer.FetchByFinancialCostcentreId(financialCostcentreId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialCostcentreModel FetchByFinancialCostcentreName(string financialCostcentreName) {
            var dataAccessLayer = new CrudeFinancialCostcentreData();
            var model = new CrudeFinancialCostcentreModel();

            dataAccessLayer.FetchByFinancialCostcentreName(financialCostcentreName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialCostcentreModel> FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            return DataListToModelList(CrudeFinancialCostcentreData.FetchByFinancialCompanyId(financialCompanyId));
        }
        
        public List<CrudeFinancialCostcentreModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialCostcentreData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCostcentreModel> DataListToModelList(List<CrudeFinancialCostcentreData> dataList) {
            var modelList = new List<CrudeFinancialCostcentreModel>();

            foreach (CrudeFinancialCostcentreData data in dataList) {
                var model = new CrudeFinancialCostcentreModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialCostcentreModel> modelList, List<CrudeFinancialCostcentreData> dataList) {
            foreach (CrudeFinancialCostcentreModel model in modelList) {
                var data = new CrudeFinancialCostcentreData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCostcentreModel> FetchAll() {
            var list = new List<CrudeFinancialCostcentreModel>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchAll();

            foreach (CrudeFinancialCostcentreData crudeFinancialCostcentreBusiness in dataList) {
                var model = new CrudeFinancialCostcentreModel();
                DataToModel(crudeFinancialCostcentreBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCostcentreModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialCostcentreModel>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialCostcentreData crudeFinancialCostcentreBusiness in dataList) {
                var model = new CrudeFinancialCostcentreModel();
                DataToModel(crudeFinancialCostcentreBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCostcentreModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialCostcentreModel>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialCostcentreData crudeFinancialCostcentreBusiness in dataList) {
                var model = new CrudeFinancialCostcentreModel();
                DataToModel(crudeFinancialCostcentreBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCostcentreData.FetchAllCount();

        }
        
        public List<CrudeFinancialCostcentreModel> FetchWithFilter(System.Guid financialCostcentreId, string financialCostcentreName, string financialCostcentreCode, System.Guid financialCompanyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCostcentreModel>();
            List<CrudeFinancialCostcentreData> dataList = CrudeFinancialCostcentreData.FetchWithFilter(financialCostcentreId,financialCostcentreName,financialCostcentreCode,financialCompanyId,userId,dateTime);

            foreach (CrudeFinancialCostcentreData data in dataList) {
                var crudeFinancialCostcentreBusinessModel = new CrudeFinancialCostcentreModel();
                DataToModel(data, crudeFinancialCostcentreBusinessModel);
                list.Add(crudeFinancialCostcentreBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCostcentreModel model) {
            var data = new CrudeFinancialCostcentreData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCostcentreModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCostcentreData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCostcentreModel model) {
            var data = new CrudeFinancialCostcentreData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCostcentreModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCostcentreData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCostcentreId) {
            CrudeFinancialCostcentreData.Delete(financialCostcentreId);
        }
        
        public static void ModelToData(CrudeFinancialCostcentreModel model, CrudeFinancialCostcentreData data) {
            data.FinancialCostcentreId = model.FinancialCostcentreId;
            data.FinancialCostcentreName = model.FinancialCostcentreName;
            data.FinancialCostcentreCode = model.FinancialCostcentreCode;
            data.FinancialCompanyId = model.FinancialCompanyId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialCostcentreData data, CrudeFinancialCostcentreModel model) {
            model.FinancialCostcentreId = data.FinancialCostcentreId;
            model.FinancialCostcentreName = data.FinancialCostcentreName;
            model.FinancialCostcentreCode = data.FinancialCostcentreCode;
            model.FinancialCompanyId = data.FinancialCompanyId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
