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
    
    
    public partial class CrudeFinancialFeeTypeRefBusiness {
        
        public CrudeFinancialFeeTypeRefModel FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd) {
            var dataAccessLayer = new CrudeFinancialFeeTypeRefData();
            var model = new CrudeFinancialFeeTypeRefModel();

            dataAccessLayer.FetchByFinancialFeeTypeRcd(financialFeeTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialFeeTypeRefModel FetchByFinancialFeeTypeName(string financialFeeTypeName) {
            var dataAccessLayer = new CrudeFinancialFeeTypeRefData();
            var model = new CrudeFinancialFeeTypeRefModel();

            dataAccessLayer.FetchByFinancialFeeTypeName(financialFeeTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialFeeTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialFeeTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialFeeTypeRefModel> DataListToModelList(List<CrudeFinancialFeeTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialFeeTypeRefModel>();

            foreach (CrudeFinancialFeeTypeRefData data in dataList) {
                var model = new CrudeFinancialFeeTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialFeeTypeRefModel> modelList, List<CrudeFinancialFeeTypeRefData> dataList) {
            foreach (CrudeFinancialFeeTypeRefModel model in modelList) {
                var data = new CrudeFinancialFeeTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialFeeTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialFeeTypeRefModel>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchAll();

            foreach (CrudeFinancialFeeTypeRefData crudeFinancialFeeTypeRefBusiness in dataList) {
                var model = new CrudeFinancialFeeTypeRefModel();
                DataToModel(crudeFinancialFeeTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialFeeTypeRefModel>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialFeeTypeRefData crudeFinancialFeeTypeRefBusiness in dataList) {
                var model = new CrudeFinancialFeeTypeRefModel();
                DataToModel(crudeFinancialFeeTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialFeeTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialFeeTypeRefModel>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialFeeTypeRefData crudeFinancialFeeTypeRefBusiness in dataList) {
                var model = new CrudeFinancialFeeTypeRefModel();
                DataToModel(crudeFinancialFeeTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialFeeTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialFeeTypeRefModel> FetchWithFilter(string financialFeeTypeRcd, string financialFeeTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialFeeTypeRefModel>();
            List<CrudeFinancialFeeTypeRefData> dataList = CrudeFinancialFeeTypeRefData.FetchWithFilter(financialFeeTypeRcd,financialFeeTypeName,userId,dateTime);

            foreach (CrudeFinancialFeeTypeRefData data in dataList) {
                var crudeFinancialFeeTypeRefBusinessModel = new CrudeFinancialFeeTypeRefModel();
                DataToModel(data, crudeFinancialFeeTypeRefBusinessModel);
                list.Add(crudeFinancialFeeTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialFeeTypeRefModel model) {
            var data = new CrudeFinancialFeeTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialFeeTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialFeeTypeRefModel model) {
            var data = new CrudeFinancialFeeTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialFeeTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFeeTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialFeeTypeRcd) {
            CrudeFinancialFeeTypeRefData.Delete(financialFeeTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialFeeTypeRefModel model, CrudeFinancialFeeTypeRefData data) {
            data.FinancialFeeTypeRcd = model.FinancialFeeTypeRcd;
            data.FinancialFeeTypeName = model.FinancialFeeTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialFeeTypeRefData data, CrudeFinancialFeeTypeRefModel model) {
            model.FinancialFeeTypeRcd = data.FinancialFeeTypeRcd;
            model.FinancialFeeTypeName = data.FinancialFeeTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
