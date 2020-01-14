/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:53 AM
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
    
    
    public partial class CrudeFinancialOrderTransactionTypeRefBusiness {
        
        public CrudeFinancialOrderTransactionTypeRefModel FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd) {
            var dataAccessLayer = new CrudeFinancialOrderTransactionTypeRefData();
            var model = new CrudeFinancialOrderTransactionTypeRefModel();

            dataAccessLayer.FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialOrderTransactionTypeRefModel FetchByFinancialOrderTransactionTypeName(string financialOrderTransactionTypeName) {
            var dataAccessLayer = new CrudeFinancialOrderTransactionTypeRefData();
            var model = new CrudeFinancialOrderTransactionTypeRefModel();

            dataAccessLayer.FetchByFinancialOrderTransactionTypeName(financialOrderTransactionTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderTransactionTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderTransactionTypeRefModel> DataListToModelList(List<CrudeFinancialOrderTransactionTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialOrderTransactionTypeRefModel>();

            foreach (CrudeFinancialOrderTransactionTypeRefData data in dataList) {
                var model = new CrudeFinancialOrderTransactionTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderTransactionTypeRefModel> modelList, List<CrudeFinancialOrderTransactionTypeRefData> dataList) {
            foreach (CrudeFinancialOrderTransactionTypeRefModel model in modelList) {
                var data = new CrudeFinancialOrderTransactionTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialOrderTransactionTypeRefModel>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchAll();

            foreach (CrudeFinancialOrderTransactionTypeRefData crudeFinancialOrderTransactionTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderTransactionTypeRefModel();
                DataToModel(crudeFinancialOrderTransactionTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderTransactionTypeRefModel>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderTransactionTypeRefData crudeFinancialOrderTransactionTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderTransactionTypeRefModel();
                DataToModel(crudeFinancialOrderTransactionTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderTransactionTypeRefModel>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderTransactionTypeRefData crudeFinancialOrderTransactionTypeRefBusiness in dataList) {
                var model = new CrudeFinancialOrderTransactionTypeRefModel();
                DataToModel(crudeFinancialOrderTransactionTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderTransactionTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderTransactionTypeRefModel> FetchWithFilter(string financialOrderTransactionTypeRcd, string financialOrderTransactionTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderTransactionTypeRefModel>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchWithFilter(financialOrderTransactionTypeRcd,financialOrderTransactionTypeName,userId,dateTime);

            foreach (CrudeFinancialOrderTransactionTypeRefData data in dataList) {
                var crudeFinancialOrderTransactionTypeRefBusinessModel = new CrudeFinancialOrderTransactionTypeRefModel();
                DataToModel(data, crudeFinancialOrderTransactionTypeRefBusinessModel);
                list.Add(crudeFinancialOrderTransactionTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderTransactionTypeRefModel model) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderTransactionTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderTransactionTypeRefModel model) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderTransactionTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderTransactionTypeRcd) {
            CrudeFinancialOrderTransactionTypeRefData.Delete(financialOrderTransactionTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialOrderTransactionTypeRefModel model, CrudeFinancialOrderTransactionTypeRefData data) {
            data.FinancialOrderTransactionTypeRcd = model.FinancialOrderTransactionTypeRcd;
            data.FinancialOrderTransactionTypeName = model.FinancialOrderTransactionTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialOrderTransactionTypeRefData data, CrudeFinancialOrderTransactionTypeRefModel model) {
            model.FinancialOrderTransactionTypeRcd = data.FinancialOrderTransactionTypeRcd;
            model.FinancialOrderTransactionTypeName = data.FinancialOrderTransactionTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
