/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
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
    
    
    public partial class CrudeFinancialOrderEventTypeRefBusiness {
        
        public CrudeFinancialOrderEventTypeRefModel FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd) {
            var dataAccessLayer = new CrudeFinancialOrderEventTypeRefData();
            var model = new CrudeFinancialOrderEventTypeRefModel();

            dataAccessLayer.FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialOrderEventTypeRefModel FetchByFinancialOrderEventTypeName(string financialOrderEventTypeName) {
            var dataAccessLayer = new CrudeFinancialOrderEventTypeRefData();
            var model = new CrudeFinancialOrderEventTypeRefModel();

            dataAccessLayer.FetchByFinancialOrderEventTypeName(financialOrderEventTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderEventTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderEventTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderEventTypeRefModel> DataListToModelList(List<CrudeFinancialOrderEventTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialOrderEventTypeRefModel>();

            foreach (CrudeFinancialOrderEventTypeRefData data in dataList) {
                var model = new CrudeFinancialOrderEventTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderEventTypeRefModel> modelList, List<CrudeFinancialOrderEventTypeRefData> dataList) {
            foreach (CrudeFinancialOrderEventTypeRefModel model in modelList) {
                var data = new CrudeFinancialOrderEventTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderEventTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialOrderEventTypeRefModel>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchAll();

            foreach (CrudeFinancialOrderEventTypeRefData crudeFinancialOrderEventTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderEventTypeRefModel();
                DataToModel(crudeFinancialOrderEventTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderEventTypeRefModel>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderEventTypeRefData crudeFinancialOrderEventTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderEventTypeRefModel();
                DataToModel(crudeFinancialOrderEventTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderEventTypeRefModel>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderEventTypeRefData crudeFinancialOrderEventTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderEventTypeRefModel();
                DataToModel(crudeFinancialOrderEventTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderEventTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderEventTypeRefModel> FetchWithFilter(string financialOrderEventTypeRcd, string financialOrderEventTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderEventTypeRefModel>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchWithFilter(financialOrderEventTypeRcd,financialOrderEventTypeName,userId,dateTime);

            foreach (CrudeFinancialOrderEventTypeRefData data in dataList) {
                var crudeFinancialOrderEventTypeRefBusinessModel = new CrudeFinancialOrderEventTypeRefModel();
                DataToModel(data, crudeFinancialOrderEventTypeRefBusinessModel);
                list.Add(crudeFinancialOrderEventTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderEventTypeRefModel model) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderEventTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderEventTypeRefModel model) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderEventTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderEventTypeRcd) {
            CrudeFinancialOrderEventTypeRefData.Delete(financialOrderEventTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialOrderEventTypeRefModel model, CrudeFinancialOrderEventTypeRefData data) {
            data.FinancialOrderEventTypeRcd = model.FinancialOrderEventTypeRcd;
            data.FinancialOrderEventTypeName = model.FinancialOrderEventTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialOrderEventTypeRefData data, CrudeFinancialOrderEventTypeRefModel model) {
            model.FinancialOrderEventTypeRcd = data.FinancialOrderEventTypeRcd;
            model.FinancialOrderEventTypeName = data.FinancialOrderEventTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
