/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:42 PM
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
    
    
    public partial class CrudeFinancialOrderEventBusiness {
        
        public CrudeFinancialOrderEventModel FetchByFiancialOrderEventId(System.Guid fiancialOrderEventId) {
            var dataAccessLayer = new CrudeFinancialOrderEventData();
            var model = new CrudeFinancialOrderEventModel();

            dataAccessLayer.FetchByFiancialOrderEventId(fiancialOrderEventId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderEventModel> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToModelList(CrudeFinancialOrderEventData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public List<CrudeFinancialOrderEventModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderEventData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderEventModel> FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd) {
            return DataListToModelList(CrudeFinancialOrderEventData.FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd));
        }
        
        public static List<CrudeFinancialOrderEventModel> DataListToModelList(List<CrudeFinancialOrderEventData> dataList) {
            var modelList = new List<CrudeFinancialOrderEventModel>();

            foreach (CrudeFinancialOrderEventData data in dataList) {
                var model = new CrudeFinancialOrderEventModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderEventModel> modelList, List<CrudeFinancialOrderEventData> dataList) {
            foreach (CrudeFinancialOrderEventModel model in modelList) {
                var data = new CrudeFinancialOrderEventData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderEventModel> FetchAll() {
            var list = new List<CrudeFinancialOrderEventModel>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchAll();

            foreach (CrudeFinancialOrderEventData crudeFinancialOrderEventBusiness in dataList) {
                var model = new CrudeFinancialOrderEventModel();
                DataToModel(crudeFinancialOrderEventBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderEventModel>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderEventData crudeFinancialOrderEventBusiness in dataList) {
                var model = new CrudeFinancialOrderEventModel();
                DataToModel(crudeFinancialOrderEventBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderEventModel>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderEventData crudeFinancialOrderEventBusiness in dataList) {
                var model = new CrudeFinancialOrderEventModel();
                DataToModel(crudeFinancialOrderEventBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderEventData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderEventModel> FetchWithFilter(System.Guid fiancialOrderEventId, System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, string financialOrderEventTypeRcd) {
            var list = new List<CrudeFinancialOrderEventModel>();
            List<CrudeFinancialOrderEventData> dataList = CrudeFinancialOrderEventData.FetchWithFilter(fiancialOrderEventId,financialOrderId,userId,dateTime,comment,financialOrderEventTypeRcd);

            foreach (CrudeFinancialOrderEventData data in dataList) {
                var crudeFinancialOrderEventBusinessModel = new CrudeFinancialOrderEventModel();
                DataToModel(data, crudeFinancialOrderEventBusinessModel);
                list.Add(crudeFinancialOrderEventBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderEventModel model) {
            var data = new CrudeFinancialOrderEventData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderEventModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderEventModel model) {
            var data = new CrudeFinancialOrderEventData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderEventModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid fiancialOrderEventId) {
            CrudeFinancialOrderEventData.Delete(fiancialOrderEventId);
        }
        
        public static void ModelToData(CrudeFinancialOrderEventModel model, CrudeFinancialOrderEventData data) {
            data.FiancialOrderEventId = model.FiancialOrderEventId;
            data.FinancialOrderId = model.FinancialOrderId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.Comment = model.Comment;
            data.FinancialOrderEventTypeRcd = model.FinancialOrderEventTypeRcd;
        }
        
        public static void DataToModel(CrudeFinancialOrderEventData data, CrudeFinancialOrderEventModel model) {
            model.FiancialOrderEventId = data.FiancialOrderEventId;
            model.FinancialOrderId = data.FinancialOrderId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.Comment = data.Comment;
            model.FinancialOrderEventTypeRcd = data.FinancialOrderEventTypeRcd;
        }
    }
}
