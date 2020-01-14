/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:28 AM
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
    
    
    public partial class CrudeFinancialPaymentTypeRefBusiness {
        
        public CrudeFinancialPaymentTypeRefModel FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            var dataAccessLayer = new CrudeFinancialPaymentTypeRefData();
            var model = new CrudeFinancialPaymentTypeRefModel();

            dataAccessLayer.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialPaymentTypeRefModel FetchByFinancialPaymentTypeName(string financialPaymentTypeName) {
            var dataAccessLayer = new CrudeFinancialPaymentTypeRefData();
            var model = new CrudeFinancialPaymentTypeRefModel();

            dataAccessLayer.FetchByFinancialPaymentTypeName(financialPaymentTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialPaymentTypeRefModel> DataListToModelList(List<CrudeFinancialPaymentTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialPaymentTypeRefModel>();

            foreach (CrudeFinancialPaymentTypeRefData data in dataList) {
                var model = new CrudeFinancialPaymentTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentTypeRefModel> modelList, List<CrudeFinancialPaymentTypeRefData> dataList) {
            foreach (CrudeFinancialPaymentTypeRefModel model in modelList) {
                var data = new CrudeFinancialPaymentTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentTypeRefModel>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchAll();

            foreach (CrudeFinancialPaymentTypeRefData crudeFinancialPaymentTypeRefBusiness in dataList) {
                var model = new CrudeFinancialPaymentTypeRefModel();
                DataToModel(crudeFinancialPaymentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentTypeRefModel>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentTypeRefData crudeFinancialPaymentTypeRefBusiness in dataList) {
                var model = new CrudeFinancialPaymentTypeRefModel();
                DataToModel(crudeFinancialPaymentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentTypeRefModel>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentTypeRefData crudeFinancialPaymentTypeRefBusiness in dataList) {
                var model = new CrudeFinancialPaymentTypeRefModel();
                DataToModel(crudeFinancialPaymentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentTypeRefModel> FetchWithFilter(string financialPaymentTypeRcd, string financialPaymentTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialPaymentTypeRefModel>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchWithFilter(financialPaymentTypeRcd,financialPaymentTypeName,userId,dateTime);

            foreach (CrudeFinancialPaymentTypeRefData data in dataList) {
                var crudeFinancialPaymentTypeRefBusinessModel = new CrudeFinancialPaymentTypeRefModel();
                DataToModel(data, crudeFinancialPaymentTypeRefBusinessModel);
                list.Add(crudeFinancialPaymentTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentTypeRefModel model) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentTypeRefModel model) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialPaymentTypeRcd) {
            CrudeFinancialPaymentTypeRefData.Delete(financialPaymentTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialPaymentTypeRefModel model, CrudeFinancialPaymentTypeRefData data) {
            data.FinancialPaymentTypeRcd = model.FinancialPaymentTypeRcd;
            data.FinancialPaymentTypeName = model.FinancialPaymentTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialPaymentTypeRefData data, CrudeFinancialPaymentTypeRefModel model) {
            model.FinancialPaymentTypeRcd = data.FinancialPaymentTypeRcd;
            model.FinancialPaymentTypeName = data.FinancialPaymentTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
