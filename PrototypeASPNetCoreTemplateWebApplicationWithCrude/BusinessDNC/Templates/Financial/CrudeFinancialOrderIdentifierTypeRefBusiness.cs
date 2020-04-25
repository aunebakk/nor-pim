/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:43 AM
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
    
    
    public partial class CrudeFinancialOrderIdentifierTypeRefBusiness {
        
        public CrudeFinancialOrderIdentifierTypeRefModel FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            var dataAccessLayer = new CrudeFinancialOrderIdentifierTypeRefData();
            var model = new CrudeFinancialOrderIdentifierTypeRefModel();

            dataAccessLayer.FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialOrderIdentifierTypeRefModel FetchByFinancialOrderIdentifierTypeName(string financialOrderIdentifierTypeName) {
            var dataAccessLayer = new CrudeFinancialOrderIdentifierTypeRefData();
            var model = new CrudeFinancialOrderIdentifierTypeRefModel();

            dataAccessLayer.FetchByFinancialOrderIdentifierTypeName(financialOrderIdentifierTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderIdentifierTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderIdentifierTypeRefModel> DataListToModelList(List<CrudeFinancialOrderIdentifierTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialOrderIdentifierTypeRefModel>();

            foreach (CrudeFinancialOrderIdentifierTypeRefData data in dataList) {
                var model = new CrudeFinancialOrderIdentifierTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderIdentifierTypeRefModel> modelList, List<CrudeFinancialOrderIdentifierTypeRefData> dataList) {
            foreach (CrudeFinancialOrderIdentifierTypeRefModel model in modelList) {
                var data = new CrudeFinancialOrderIdentifierTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefModel>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchAll();

            foreach (CrudeFinancialOrderIdentifierTypeRefData crudeFinancialOrderIdentifierTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderIdentifierTypeRefModel();
                DataToModel(crudeFinancialOrderIdentifierTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefModel>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderIdentifierTypeRefData crudeFinancialOrderIdentifierTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderIdentifierTypeRefModel();
                DataToModel(crudeFinancialOrderIdentifierTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefModel>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderIdentifierTypeRefData crudeFinancialOrderIdentifierTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderIdentifierTypeRefModel();
                DataToModel(crudeFinancialOrderIdentifierTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderIdentifierTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderIdentifierTypeRefModel> FetchWithFilter(string financialOrderIdentifierTypeRcd, string financialOrderIdentifierTypeCode, string financialOrderIdentifierTypeName, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderIdentifierTypeRefModel>();
            List<CrudeFinancialOrderIdentifierTypeRefData> dataList = CrudeFinancialOrderIdentifierTypeRefData.FetchWithFilter(financialOrderIdentifierTypeRcd,financialOrderIdentifierTypeCode,financialOrderIdentifierTypeName,sortSequenceNumber,changeFlag,statusCode,userId,dateTime);

            foreach (CrudeFinancialOrderIdentifierTypeRefData data in dataList) {
                var crudeFinancialOrderIdentifierTypeRefBusinessModel = new CrudeFinancialOrderIdentifierTypeRefModel();
                DataToModel(data, crudeFinancialOrderIdentifierTypeRefBusinessModel);
                list.Add(crudeFinancialOrderIdentifierTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderIdentifierTypeRefModel model) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderIdentifierTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderIdentifierTypeRefModel model) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderIdentifierTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderIdentifierTypeRcd) {
            CrudeFinancialOrderIdentifierTypeRefData.Delete(financialOrderIdentifierTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialOrderIdentifierTypeRefModel model, CrudeFinancialOrderIdentifierTypeRefData data) {
            data.FinancialOrderIdentifierTypeRcd = model.FinancialOrderIdentifierTypeRcd;
            data.FinancialOrderIdentifierTypeCode = model.FinancialOrderIdentifierTypeCode;
            data.FinancialOrderIdentifierTypeName = model.FinancialOrderIdentifierTypeName;
            data.SortSequenceNumber = model.SortSequenceNumber;
            data.ChangeFlag = model.ChangeFlag;
            data.StatusCode = model.StatusCode;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialOrderIdentifierTypeRefData data, CrudeFinancialOrderIdentifierTypeRefModel model) {
            model.FinancialOrderIdentifierTypeRcd = data.FinancialOrderIdentifierTypeRcd;
            model.FinancialOrderIdentifierTypeCode = data.FinancialOrderIdentifierTypeCode;
            model.FinancialOrderIdentifierTypeName = data.FinancialOrderIdentifierTypeName;
            model.SortSequenceNumber = data.SortSequenceNumber;
            model.ChangeFlag = data.ChangeFlag;
            model.StatusCode = data.StatusCode;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
