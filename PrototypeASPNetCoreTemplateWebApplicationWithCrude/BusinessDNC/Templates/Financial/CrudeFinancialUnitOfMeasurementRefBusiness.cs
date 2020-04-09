/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:54 PM
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
    
    
    public partial class CrudeFinancialUnitOfMeasurementRefBusiness {
        
        public CrudeFinancialUnitOfMeasurementRefModel FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            var dataAccessLayer = new CrudeFinancialUnitOfMeasurementRefData();
            var model = new CrudeFinancialUnitOfMeasurementRefModel();

            dataAccessLayer.FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialUnitOfMeasurementRefModel FetchByFinancialUnitOfMeasurementName(string financialUnitOfMeasurementName) {
            var dataAccessLayer = new CrudeFinancialUnitOfMeasurementRefData();
            var model = new CrudeFinancialUnitOfMeasurementRefModel();

            dataAccessLayer.FetchByFinancialUnitOfMeasurementName(financialUnitOfMeasurementName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialUnitOfMeasurementRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialUnitOfMeasurementRefModel> DataListToModelList(List<CrudeFinancialUnitOfMeasurementRefData> dataList) {
            var modelList = new List<CrudeFinancialUnitOfMeasurementRefModel>();

            foreach (CrudeFinancialUnitOfMeasurementRefData data in dataList) {
                var model = new CrudeFinancialUnitOfMeasurementRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialUnitOfMeasurementRefModel> modelList, List<CrudeFinancialUnitOfMeasurementRefData> dataList) {
            foreach (CrudeFinancialUnitOfMeasurementRefModel model in modelList) {
                var data = new CrudeFinancialUnitOfMeasurementRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefModel> FetchAll() {
            var list = new List<CrudeFinancialUnitOfMeasurementRefModel>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchAll();

            foreach (CrudeFinancialUnitOfMeasurementRefData crudeFinancialUnitOfMeasurementRefBusiness in dataList) {
                var model = new CrudeFinancialUnitOfMeasurementRefModel();
                DataToModel(crudeFinancialUnitOfMeasurementRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialUnitOfMeasurementRefModel>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialUnitOfMeasurementRefData crudeFinancialUnitOfMeasurementRefBusiness in dataList) {
                var model = new CrudeFinancialUnitOfMeasurementRefModel();
                DataToModel(crudeFinancialUnitOfMeasurementRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialUnitOfMeasurementRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialUnitOfMeasurementRefModel>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialUnitOfMeasurementRefData crudeFinancialUnitOfMeasurementRefBusiness in dataList) {
                var model = new CrudeFinancialUnitOfMeasurementRefModel();
                DataToModel(crudeFinancialUnitOfMeasurementRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialUnitOfMeasurementRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialUnitOfMeasurementRefModel> FetchWithFilter(string financialUnitOfMeasurementRcd, int sortSequenceNumber, bool changeFlag, string statusCode, string financialUnitOfMeasurementName, string financialUnitOfMeasurementCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialUnitOfMeasurementRefModel>();
            List<CrudeFinancialUnitOfMeasurementRefData> dataList = CrudeFinancialUnitOfMeasurementRefData.FetchWithFilter(financialUnitOfMeasurementRcd,sortSequenceNumber,changeFlag,statusCode,financialUnitOfMeasurementName,financialUnitOfMeasurementCode,userId,dateTime);

            foreach (CrudeFinancialUnitOfMeasurementRefData data in dataList) {
                var crudeFinancialUnitOfMeasurementRefBusinessModel = new CrudeFinancialUnitOfMeasurementRefModel();
                DataToModel(data, crudeFinancialUnitOfMeasurementRefBusinessModel);
                list.Add(crudeFinancialUnitOfMeasurementRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialUnitOfMeasurementRefModel model) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialUnitOfMeasurementRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialUnitOfMeasurementRefModel model) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialUnitOfMeasurementRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialUnitOfMeasurementRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialUnitOfMeasurementRcd) {
            CrudeFinancialUnitOfMeasurementRefData.Delete(financialUnitOfMeasurementRcd);
        }
        
        public static void ModelToData(CrudeFinancialUnitOfMeasurementRefModel model, CrudeFinancialUnitOfMeasurementRefData data) {
            data.FinancialUnitOfMeasurementRcd = model.FinancialUnitOfMeasurementRcd;
            data.SortSequenceNumber = model.SortSequenceNumber;
            data.ChangeFlag = model.ChangeFlag;
            data.StatusCode = model.StatusCode;
            data.FinancialUnitOfMeasurementName = model.FinancialUnitOfMeasurementName;
            data.FinancialUnitOfMeasurementCode = model.FinancialUnitOfMeasurementCode;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialUnitOfMeasurementRefData data, CrudeFinancialUnitOfMeasurementRefModel model) {
            model.FinancialUnitOfMeasurementRcd = data.FinancialUnitOfMeasurementRcd;
            model.SortSequenceNumber = data.SortSequenceNumber;
            model.ChangeFlag = data.ChangeFlag;
            model.StatusCode = data.StatusCode;
            model.FinancialUnitOfMeasurementName = data.FinancialUnitOfMeasurementName;
            model.FinancialUnitOfMeasurementCode = data.FinancialUnitOfMeasurementCode;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
