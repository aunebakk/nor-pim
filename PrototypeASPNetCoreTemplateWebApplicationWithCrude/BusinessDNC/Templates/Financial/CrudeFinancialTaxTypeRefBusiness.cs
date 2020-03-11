/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:38:14 PM
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
    
    
    public partial class CrudeFinancialTaxTypeRefBusiness {
        
        public CrudeFinancialTaxTypeRefModel FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            var dataAccessLayer = new CrudeFinancialTaxTypeRefData();
            var model = new CrudeFinancialTaxTypeRefModel();

            dataAccessLayer.FetchByFinancialTaxTypeRcd(financialTaxTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialTaxTypeRefModel FetchByFinancialTaxTypeName(string financialTaxTypeName) {
            var dataAccessLayer = new CrudeFinancialTaxTypeRefData();
            var model = new CrudeFinancialTaxTypeRefModel();

            dataAccessLayer.FetchByFinancialTaxTypeName(financialTaxTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialTaxTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialTaxTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialTaxTypeRefModel> DataListToModelList(List<CrudeFinancialTaxTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialTaxTypeRefModel>();

            foreach (CrudeFinancialTaxTypeRefData data in dataList) {
                var model = new CrudeFinancialTaxTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialTaxTypeRefModel> modelList, List<CrudeFinancialTaxTypeRefData> dataList) {
            foreach (CrudeFinancialTaxTypeRefModel model in modelList) {
                var data = new CrudeFinancialTaxTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialTaxTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialTaxTypeRefModel>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchAll();

            foreach (CrudeFinancialTaxTypeRefData crudeFinancialTaxTypeRefBusiness in dataList) {
                var model = new CrudeFinancialTaxTypeRefModel();
                DataToModel(crudeFinancialTaxTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialTaxTypeRefModel>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialTaxTypeRefData crudeFinancialTaxTypeRefBusiness in dataList) {
                var model = new CrudeFinancialTaxTypeRefModel();
                DataToModel(crudeFinancialTaxTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialTaxTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialTaxTypeRefModel>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialTaxTypeRefData crudeFinancialTaxTypeRefBusiness in dataList) {
                var model = new CrudeFinancialTaxTypeRefModel();
                DataToModel(crudeFinancialTaxTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialTaxTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialTaxTypeRefModel> FetchWithFilter(string financialTaxTypeName, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialTaxTypeRefModel>();
            List<CrudeFinancialTaxTypeRefData> dataList = CrudeFinancialTaxTypeRefData.FetchWithFilter(financialTaxTypeName,financialTaxTypeRcd,userId,dateTime);

            foreach (CrudeFinancialTaxTypeRefData data in dataList) {
                var crudeFinancialTaxTypeRefBusinessModel = new CrudeFinancialTaxTypeRefModel();
                DataToModel(data, crudeFinancialTaxTypeRefBusinessModel);
                list.Add(crudeFinancialTaxTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialTaxTypeRefModel model) {
            var data = new CrudeFinancialTaxTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialTaxTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialTaxTypeRefModel model) {
            var data = new CrudeFinancialTaxTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialTaxTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialTaxTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialTaxTypeRcd) {
            CrudeFinancialTaxTypeRefData.Delete(financialTaxTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialTaxTypeRefModel model, CrudeFinancialTaxTypeRefData data) {
            data.FinancialTaxTypeName = model.FinancialTaxTypeName;
            data.FinancialTaxTypeRcd = model.FinancialTaxTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialTaxTypeRefData data, CrudeFinancialTaxTypeRefModel model) {
            model.FinancialTaxTypeName = data.FinancialTaxTypeName;
            model.FinancialTaxTypeRcd = data.FinancialTaxTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
