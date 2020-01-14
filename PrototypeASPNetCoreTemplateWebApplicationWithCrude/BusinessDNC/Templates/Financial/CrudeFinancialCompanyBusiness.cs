/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:03 AM
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
    
    
    public partial class CrudeFinancialCompanyBusiness {
        
        public CrudeFinancialCompanyModel FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            var dataAccessLayer = new CrudeFinancialCompanyData();
            var model = new CrudeFinancialCompanyModel();

            dataAccessLayer.FetchByFinancialCompanyId(financialCompanyId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialCompanyModel FetchByFinancialCompanyName(string financialCompanyName) {
            var dataAccessLayer = new CrudeFinancialCompanyData();
            var model = new CrudeFinancialCompanyModel();

            dataAccessLayer.FetchByFinancialCompanyName(financialCompanyName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialCompanyModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialCompanyData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCompanyModel> DataListToModelList(List<CrudeFinancialCompanyData> dataList) {
            var modelList = new List<CrudeFinancialCompanyModel>();

            foreach (CrudeFinancialCompanyData data in dataList) {
                var model = new CrudeFinancialCompanyModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialCompanyModel> modelList, List<CrudeFinancialCompanyData> dataList) {
            foreach (CrudeFinancialCompanyModel model in modelList) {
                var data = new CrudeFinancialCompanyData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCompanyModel> FetchAll() {
            var list = new List<CrudeFinancialCompanyModel>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchAll();

            foreach (CrudeFinancialCompanyData crudeFinancialCompanyBusiness in dataList) {
                var model = new CrudeFinancialCompanyModel();
                DataToModel(crudeFinancialCompanyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCompanyModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialCompanyModel>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialCompanyData crudeFinancialCompanyBusiness in dataList) {
                var model = new CrudeFinancialCompanyModel();
                DataToModel(crudeFinancialCompanyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCompanyModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialCompanyModel>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialCompanyData crudeFinancialCompanyBusiness in dataList) {
                var model = new CrudeFinancialCompanyModel();
                DataToModel(crudeFinancialCompanyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCompanyData.FetchAllCount();

        }
        
        public List<CrudeFinancialCompanyModel> FetchWithFilter(System.Guid financialCompanyId, string financialCompanyName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCompanyModel>();
            List<CrudeFinancialCompanyData> dataList = CrudeFinancialCompanyData.FetchWithFilter(financialCompanyId,financialCompanyName,userId,dateTime);

            foreach (CrudeFinancialCompanyData data in dataList) {
                var crudeFinancialCompanyBusinessModel = new CrudeFinancialCompanyModel();
                DataToModel(data, crudeFinancialCompanyBusinessModel);
                list.Add(crudeFinancialCompanyBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCompanyModel model) {
            var data = new CrudeFinancialCompanyData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCompanyModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCompanyData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCompanyModel model) {
            var data = new CrudeFinancialCompanyData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCompanyModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCompanyData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCompanyId) {
            CrudeFinancialCompanyData.Delete(financialCompanyId);
        }
        
        public static void ModelToData(CrudeFinancialCompanyModel model, CrudeFinancialCompanyData data) {
            data.FinancialCompanyId = model.FinancialCompanyId;
            data.FinancialCompanyName = model.FinancialCompanyName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialCompanyData data, CrudeFinancialCompanyModel model) {
            model.FinancialCompanyId = data.FinancialCompanyId;
            model.FinancialCompanyName = data.FinancialCompanyName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
