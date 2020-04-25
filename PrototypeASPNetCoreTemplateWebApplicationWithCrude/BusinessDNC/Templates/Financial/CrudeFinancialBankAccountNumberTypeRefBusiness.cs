/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:42 AM
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
    
    
    public partial class CrudeFinancialBankAccountNumberTypeRefBusiness {
        
        public CrudeFinancialBankAccountNumberTypeRefModel FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd) {
            var dataAccessLayer = new CrudeFinancialBankAccountNumberTypeRefData();
            var model = new CrudeFinancialBankAccountNumberTypeRefModel();

            dataAccessLayer.FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeFinancialBankAccountNumberTypeRefModel FetchByFinancialBankAccountNumberTypeName(string financialBankAccountNumberTypeName) {
            var dataAccessLayer = new CrudeFinancialBankAccountNumberTypeRefData();
            var model = new CrudeFinancialBankAccountNumberTypeRefModel();

            dataAccessLayer.FetchByFinancialBankAccountNumberTypeName(financialBankAccountNumberTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialBankAccountNumberTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialBankAccountNumberTypeRefModel> DataListToModelList(List<CrudeFinancialBankAccountNumberTypeRefData> dataList) {
            var modelList = new List<CrudeFinancialBankAccountNumberTypeRefModel>();

            foreach (CrudeFinancialBankAccountNumberTypeRefData data in dataList) {
                var model = new CrudeFinancialBankAccountNumberTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialBankAccountNumberTypeRefModel> modelList, List<CrudeFinancialBankAccountNumberTypeRefData> dataList) {
            foreach (CrudeFinancialBankAccountNumberTypeRefModel model in modelList) {
                var data = new CrudeFinancialBankAccountNumberTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefModel> FetchAll() {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefModel>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchAll();

            foreach (CrudeFinancialBankAccountNumberTypeRefData crudeFinancialBankAccountNumberTypeRefBusiness in dataList) {
                var model = new CrudeFinancialBankAccountNumberTypeRefModel();
                DataToModel(crudeFinancialBankAccountNumberTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefModel>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialBankAccountNumberTypeRefData crudeFinancialBankAccountNumberTypeRefBusiness in dataList) {
                var model = new CrudeFinancialBankAccountNumberTypeRefModel();
                DataToModel(crudeFinancialBankAccountNumberTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefModel>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialBankAccountNumberTypeRefData crudeFinancialBankAccountNumberTypeRefBusiness in dataList) {
                var model = new CrudeFinancialBankAccountNumberTypeRefModel();
                DataToModel(crudeFinancialBankAccountNumberTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialBankAccountNumberTypeRefData.FetchAllCount();

        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefModel> FetchWithFilter(string financialBankAccountNumberTypeRcd, string financialBankAccountNumberTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefModel>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchWithFilter(financialBankAccountNumberTypeRcd,financialBankAccountNumberTypeName,userId,dateTime);

            foreach (CrudeFinancialBankAccountNumberTypeRefData data in dataList) {
                var crudeFinancialBankAccountNumberTypeRefBusinessModel = new CrudeFinancialBankAccountNumberTypeRefModel();
                DataToModel(data, crudeFinancialBankAccountNumberTypeRefBusinessModel);
                list.Add(crudeFinancialBankAccountNumberTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialBankAccountNumberTypeRefModel model) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialBankAccountNumberTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialBankAccountNumberTypeRefModel model) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialBankAccountNumberTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialBankAccountNumberTypeRcd) {
            CrudeFinancialBankAccountNumberTypeRefData.Delete(financialBankAccountNumberTypeRcd);
        }
        
        public static void ModelToData(CrudeFinancialBankAccountNumberTypeRefModel model, CrudeFinancialBankAccountNumberTypeRefData data) {
            data.FinancialBankAccountNumberTypeRcd = model.FinancialBankAccountNumberTypeRcd;
            data.FinancialBankAccountNumberTypeName = model.FinancialBankAccountNumberTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialBankAccountNumberTypeRefData data, CrudeFinancialBankAccountNumberTypeRefModel model) {
            model.FinancialBankAccountNumberTypeRcd = data.FinancialBankAccountNumberTypeRcd;
            model.FinancialBankAccountNumberTypeName = data.FinancialBankAccountNumberTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
