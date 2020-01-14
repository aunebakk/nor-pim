/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:28 PM
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
    
    
    public partial class CrudeFinancialOrderSourceRefBusiness {
        
        public CrudeFinancialOrderSourceRefModel FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            var dataAccessLayer = new CrudeFinancialOrderSourceRefData();
            var model = new CrudeFinancialOrderSourceRefModel();

            dataAccessLayer.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialOrderSourceRefModel FetchByFinancialOrderSourceName(string financialOrderSourceName) {
            var dataAccessLayer = new CrudeFinancialOrderSourceRefData();
            var model = new CrudeFinancialOrderSourceRefModel();

            dataAccessLayer.FetchByFinancialOrderSourceName(financialOrderSourceName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderSourceRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderSourceRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderSourceRefModel> DataListToModelList(List<CrudeFinancialOrderSourceRefData> dataList) {
            var modelList = new List<CrudeFinancialOrderSourceRefModel>();

            foreach (CrudeFinancialOrderSourceRefData data in dataList) {
                var model = new CrudeFinancialOrderSourceRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderSourceRefModel> modelList, List<CrudeFinancialOrderSourceRefData> dataList) {
            foreach (CrudeFinancialOrderSourceRefModel model in modelList) {
                var data = new CrudeFinancialOrderSourceRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderSourceRefModel> FetchAll() {
            var list = new List<CrudeFinancialOrderSourceRefModel>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchAll();

            foreach (CrudeFinancialOrderSourceRefData crudeFinancialOrderSourceRefBusiness in dataList) {
                var model = new CrudeFinancialOrderSourceRefModel();
                DataToModel(crudeFinancialOrderSourceRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderSourceRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderSourceRefModel>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderSourceRefData crudeFinancialOrderSourceRefBusiness in dataList) {
                var model = new CrudeFinancialOrderSourceRefModel();
                DataToModel(crudeFinancialOrderSourceRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderSourceRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderSourceRefModel>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderSourceRefData crudeFinancialOrderSourceRefBusiness in dataList) {
                var model = new CrudeFinancialOrderSourceRefModel();
                DataToModel(crudeFinancialOrderSourceRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderSourceRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderSourceRefModel> FetchWithFilter(string financialOrderSourceRcd, string financialOrderSourceName, string financialOrderSourceCode, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderSourceRefModel>();
            List<CrudeFinancialOrderSourceRefData> dataList = CrudeFinancialOrderSourceRefData.FetchWithFilter(financialOrderSourceRcd,financialOrderSourceName,financialOrderSourceCode,sortSequenceNumber,changeFlag,statusCode,userId,dateTime);

            foreach (CrudeFinancialOrderSourceRefData data in dataList) {
                var crudeFinancialOrderSourceRefBusinessModel = new CrudeFinancialOrderSourceRefModel();
                DataToModel(data, crudeFinancialOrderSourceRefBusinessModel);
                list.Add(crudeFinancialOrderSourceRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderSourceRefModel model) {
            var data = new CrudeFinancialOrderSourceRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderSourceRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderSourceRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderSourceRefModel model) {
            var data = new CrudeFinancialOrderSourceRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderSourceRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderSourceRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderSourceRcd) {
            CrudeFinancialOrderSourceRefData.Delete(financialOrderSourceRcd);
        }
        
        public static void ModelToData(CrudeFinancialOrderSourceRefModel model, CrudeFinancialOrderSourceRefData data) {
            data.FinancialOrderSourceRcd = model.FinancialOrderSourceRcd;
            data.FinancialOrderSourceName = model.FinancialOrderSourceName;
            data.FinancialOrderSourceCode = model.FinancialOrderSourceCode;
            data.SortSequenceNumber = model.SortSequenceNumber;
            data.ChangeFlag = model.ChangeFlag;
            data.StatusCode = model.StatusCode;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialOrderSourceRefData data, CrudeFinancialOrderSourceRefModel model) {
            model.FinancialOrderSourceRcd = data.FinancialOrderSourceRcd;
            model.FinancialOrderSourceName = data.FinancialOrderSourceName;
            model.FinancialOrderSourceCode = data.FinancialOrderSourceCode;
            model.SortSequenceNumber = data.SortSequenceNumber;
            model.ChangeFlag = data.ChangeFlag;
            model.StatusCode = data.StatusCode;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
