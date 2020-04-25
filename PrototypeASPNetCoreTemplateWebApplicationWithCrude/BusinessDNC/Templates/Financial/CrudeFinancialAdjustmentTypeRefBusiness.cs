/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:58 AM
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
    
    
    public partial class CrudeFinancialAdjustmentTypeRefBusiness {
        
        public CrudeFinancialAdjustmentTypeRefModel FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd) {
            var dataAccessLayer = new CrudeFinancialAdjustmentTypeRefData();
            var model = new CrudeFinancialAdjustmentTypeRefModel();

            dataAccessLayer.FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialAdjustmentTypeRefModel FetchByFinancialAdjustmentTypeName(string financialAdjustmentTypeName) {
            var dataAccessLayer = new CrudeFinancialAdjustmentTypeRefData();
            var model = new CrudeFinancialAdjustmentTypeRefModel();

            dataAccessLayer.FetchByFinancialAdjustmentTypeName(financialAdjustmentTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialAdjustmentTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialAdjustmentTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialAdjustmentTypeRefModel> DataListToModelList(List<CrudeFinancialAdjustmentTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialAdjustmentTypeRefModel>();

            foreach (CrudeFinancialAdjustmentTypeRefData data in dataList) {
                var model = new CrudeFinancialAdjustmentTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialAdjustmentTypeRefModel> modelList, List<CrudeFinancialAdjustmentTypeRefData> dataList) {
            foreach (CrudeFinancialAdjustmentTypeRefModel model in modelList) {
                var data = new CrudeFinancialAdjustmentTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialAdjustmentTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialAdjustmentTypeRefModel>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchAll();

            foreach (CrudeFinancialAdjustmentTypeRefData crudeFinancialAdjustmentTypeRefBusiness in dataList) {
                var model = new CrudeFinancialAdjustmentTypeRefModel();
                DataToModel(crudeFinancialAdjustmentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialAdjustmentTypeRefModel>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialAdjustmentTypeRefData crudeFinancialAdjustmentTypeRefBusiness in dataList) {
                var model = new CrudeFinancialAdjustmentTypeRefModel();
                DataToModel(crudeFinancialAdjustmentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialAdjustmentTypeRefModel>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialAdjustmentTypeRefData crudeFinancialAdjustmentTypeRefBusiness in dataList) {
                var model = new CrudeFinancialAdjustmentTypeRefModel();
                DataToModel(crudeFinancialAdjustmentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialAdjustmentTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialAdjustmentTypeRefModel> FetchWithFilter(string financialAdjustmentTypeRcd, string financialAdjustmentTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialAdjustmentTypeRefModel>();
            List<CrudeFinancialAdjustmentTypeRefData> dataList = CrudeFinancialAdjustmentTypeRefData.FetchWithFilter(financialAdjustmentTypeRcd,financialAdjustmentTypeName,userId,dateTime);

            foreach (CrudeFinancialAdjustmentTypeRefData data in dataList) {
                var crudeFinancialAdjustmentTypeRefBusinessModel = new CrudeFinancialAdjustmentTypeRefModel();
                DataToModel(data, crudeFinancialAdjustmentTypeRefBusinessModel);
                list.Add(crudeFinancialAdjustmentTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialAdjustmentTypeRefModel model) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialAdjustmentTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialAdjustmentTypeRefModel model) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialAdjustmentTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialAdjustmentTypeRcd) {
            CrudeFinancialAdjustmentTypeRefData.Delete(financialAdjustmentTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialAdjustmentTypeRefModel model, CrudeFinancialAdjustmentTypeRefData data) {
            data.FinancialAdjustmentTypeRcd = model.FinancialAdjustmentTypeRcd;
            data.FinancialAdjustmentTypeName = model.FinancialAdjustmentTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialAdjustmentTypeRefData data, CrudeFinancialAdjustmentTypeRefModel model) {
            model.FinancialAdjustmentTypeRcd = data.FinancialAdjustmentTypeRcd;
            model.FinancialAdjustmentTypeName = data.FinancialAdjustmentTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
