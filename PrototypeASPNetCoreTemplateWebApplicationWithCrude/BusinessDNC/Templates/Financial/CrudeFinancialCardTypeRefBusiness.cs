/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:53 PM
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
    
    
    public partial class CrudeFinancialCardTypeRefBusiness {
        
        public CrudeFinancialCardTypeRefModel FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            var dataAccessLayer = new CrudeFinancialCardTypeRefData();
            var model = new CrudeFinancialCardTypeRefModel();

            dataAccessLayer.FetchByFinancialCardTypeRcd(financialCardTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialCardTypeRefModel FetchByFinancialCardTypeName(string financialCardTypeName) {
            var dataAccessLayer = new CrudeFinancialCardTypeRefData();
            var model = new CrudeFinancialCardTypeRefModel();

            dataAccessLayer.FetchByFinancialCardTypeName(financialCardTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialCardTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialCardTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCardTypeRefModel> DataListToModelList(List<CrudeFinancialCardTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialCardTypeRefModel>();

            foreach (CrudeFinancialCardTypeRefData data in dataList) {
                var model = new CrudeFinancialCardTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialCardTypeRefModel> modelList, List<CrudeFinancialCardTypeRefData> dataList) {
            foreach (CrudeFinancialCardTypeRefModel model in modelList) {
                var data = new CrudeFinancialCardTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCardTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialCardTypeRefModel>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchAll();

            foreach (CrudeFinancialCardTypeRefData crudeFinancialCardTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCardTypeRefModel();
                DataToModel(crudeFinancialCardTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCardTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialCardTypeRefModel>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialCardTypeRefData crudeFinancialCardTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCardTypeRefModel();
                DataToModel(crudeFinancialCardTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCardTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialCardTypeRefModel>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialCardTypeRefData crudeFinancialCardTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCardTypeRefModel();
                DataToModel(crudeFinancialCardTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCardTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialCardTypeRefModel> FetchWithFilter(string financialCardTypeRcd, string financialCardTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCardTypeRefModel>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchWithFilter(financialCardTypeRcd,financialCardTypeName,userId,dateTime);

            foreach (CrudeFinancialCardTypeRefData data in dataList) {
                var crudeFinancialCardTypeRefBusinessModel = new CrudeFinancialCardTypeRefModel();
                DataToModel(data, crudeFinancialCardTypeRefBusinessModel);
                list.Add(crudeFinancialCardTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCardTypeRefModel model) {
            var data = new CrudeFinancialCardTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCardTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCardTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCardTypeRefModel model) {
            var data = new CrudeFinancialCardTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCardTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCardTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialCardTypeRcd) {
            CrudeFinancialCardTypeRefData.Delete(financialCardTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialCardTypeRefModel model, CrudeFinancialCardTypeRefData data) {
            data.FinancialCardTypeRcd = model.FinancialCardTypeRcd;
            data.FinancialCardTypeName = model.FinancialCardTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialCardTypeRefData data, CrudeFinancialCardTypeRefModel model) {
            model.FinancialCardTypeRcd = data.FinancialCardTypeRcd;
            model.FinancialCardTypeName = data.FinancialCardTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
