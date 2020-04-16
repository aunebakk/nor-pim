/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
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
    
    
    public partial class CrudeFinancialCouponTypeRefBusiness {
        
        public CrudeFinancialCouponTypeRefModel FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            var dataAccessLayer = new CrudeFinancialCouponTypeRefData();
            var model = new CrudeFinancialCouponTypeRefModel();

            dataAccessLayer.FetchByFinancialCouponTypeRcd(financialCouponTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialCouponTypeRefModel FetchByFinancialCouponTypeName(string financialCouponTypeName) {
            var dataAccessLayer = new CrudeFinancialCouponTypeRefData();
            var model = new CrudeFinancialCouponTypeRefModel();

            dataAccessLayer.FetchByFinancialCouponTypeName(financialCouponTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialCouponTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialCouponTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCouponTypeRefModel> DataListToModelList(List<CrudeFinancialCouponTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialCouponTypeRefModel>();

            foreach (CrudeFinancialCouponTypeRefData data in dataList) {
                var model = new CrudeFinancialCouponTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialCouponTypeRefModel> modelList, List<CrudeFinancialCouponTypeRefData> dataList) {
            foreach (CrudeFinancialCouponTypeRefModel model in modelList) {
                var data = new CrudeFinancialCouponTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCouponTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialCouponTypeRefModel>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchAll();

            foreach (CrudeFinancialCouponTypeRefData crudeFinancialCouponTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCouponTypeRefModel();
                DataToModel(crudeFinancialCouponTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialCouponTypeRefModel>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialCouponTypeRefData crudeFinancialCouponTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCouponTypeRefModel();
                DataToModel(crudeFinancialCouponTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialCouponTypeRefModel>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialCouponTypeRefData crudeFinancialCouponTypeRefBusiness in dataList) {
                var model = new CrudeFinancialCouponTypeRefModel();
                DataToModel(crudeFinancialCouponTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCouponTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialCouponTypeRefModel> FetchWithFilter(string financialCouponTypeRcd, string financialCouponTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCouponTypeRefModel>();
            List<CrudeFinancialCouponTypeRefData> dataList = CrudeFinancialCouponTypeRefData.FetchWithFilter(financialCouponTypeRcd,financialCouponTypeName,userId,dateTime);

            foreach (CrudeFinancialCouponTypeRefData data in dataList) {
                var crudeFinancialCouponTypeRefBusinessModel = new CrudeFinancialCouponTypeRefModel();
                DataToModel(data, crudeFinancialCouponTypeRefBusinessModel);
                list.Add(crudeFinancialCouponTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCouponTypeRefModel model) {
            var data = new CrudeFinancialCouponTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCouponTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCouponTypeRefModel model) {
            var data = new CrudeFinancialCouponTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCouponTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialCouponTypeRcd) {
            CrudeFinancialCouponTypeRefData.Delete(financialCouponTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialCouponTypeRefModel model, CrudeFinancialCouponTypeRefData data) {
            data.FinancialCouponTypeRcd = model.FinancialCouponTypeRcd;
            data.FinancialCouponTypeName = model.FinancialCouponTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialCouponTypeRefData data, CrudeFinancialCouponTypeRefModel model) {
            model.FinancialCouponTypeRcd = data.FinancialCouponTypeRcd;
            model.FinancialCouponTypeName = data.FinancialCouponTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
