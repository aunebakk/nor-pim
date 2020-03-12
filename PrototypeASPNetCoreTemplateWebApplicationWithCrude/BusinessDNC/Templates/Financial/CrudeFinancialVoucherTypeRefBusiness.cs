/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:09 PM
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
    
    
    public partial class CrudeFinancialVoucherTypeRefBusiness {
        
        public CrudeFinancialVoucherTypeRefModel FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            var dataAccessLayer = new CrudeFinancialVoucherTypeRefData();
            var model = new CrudeFinancialVoucherTypeRefModel();

            dataAccessLayer.FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialVoucherTypeRefModel FetchByFinancialVoucherTypeName(string financialVoucherTypeName) {
            var dataAccessLayer = new CrudeFinancialVoucherTypeRefData();
            var model = new CrudeFinancialVoucherTypeRefModel();

            dataAccessLayer.FetchByFinancialVoucherTypeName(financialVoucherTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialVoucherTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialVoucherTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialVoucherTypeRefModel> DataListToModelList(List<CrudeFinancialVoucherTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialVoucherTypeRefModel>();

            foreach (CrudeFinancialVoucherTypeRefData data in dataList) {
                var model = new CrudeFinancialVoucherTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialVoucherTypeRefModel> modelList, List<CrudeFinancialVoucherTypeRefData> dataList) {
            foreach (CrudeFinancialVoucherTypeRefModel model in modelList) {
                var data = new CrudeFinancialVoucherTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialVoucherTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialVoucherTypeRefModel>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchAll();

            foreach (CrudeFinancialVoucherTypeRefData crudeFinancialVoucherTypeRefBusiness in dataList) {
                var model = new CrudeFinancialVoucherTypeRefModel();
                DataToModel(crudeFinancialVoucherTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialVoucherTypeRefModel>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialVoucherTypeRefData crudeFinancialVoucherTypeRefBusiness in dataList) {
                var model = new CrudeFinancialVoucherTypeRefModel();
                DataToModel(crudeFinancialVoucherTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialVoucherTypeRefModel>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialVoucherTypeRefData crudeFinancialVoucherTypeRefBusiness in dataList) {
                var model = new CrudeFinancialVoucherTypeRefModel();
                DataToModel(crudeFinancialVoucherTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialVoucherTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialVoucherTypeRefModel> FetchWithFilter(string financialVoucherTypeRcd, string financialVoucherTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialVoucherTypeRefModel>();
            List<CrudeFinancialVoucherTypeRefData> dataList = CrudeFinancialVoucherTypeRefData.FetchWithFilter(financialVoucherTypeRcd,financialVoucherTypeName,userId,dateTime);

            foreach (CrudeFinancialVoucherTypeRefData data in dataList) {
                var crudeFinancialVoucherTypeRefBusinessModel = new CrudeFinancialVoucherTypeRefModel();
                DataToModel(data, crudeFinancialVoucherTypeRefBusinessModel);
                list.Add(crudeFinancialVoucherTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialVoucherTypeRefModel model) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialVoucherTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialVoucherTypeRefModel model) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialVoucherTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialVoucherTypeRcd) {
            CrudeFinancialVoucherTypeRefData.Delete(financialVoucherTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialVoucherTypeRefModel model, CrudeFinancialVoucherTypeRefData data) {
            data.FinancialVoucherTypeRcd = model.FinancialVoucherTypeRcd;
            data.FinancialVoucherTypeName = model.FinancialVoucherTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialVoucherTypeRefData data, CrudeFinancialVoucherTypeRefModel model) {
            model.FinancialVoucherTypeRcd = data.FinancialVoucherTypeRcd;
            model.FinancialVoucherTypeName = data.FinancialVoucherTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
