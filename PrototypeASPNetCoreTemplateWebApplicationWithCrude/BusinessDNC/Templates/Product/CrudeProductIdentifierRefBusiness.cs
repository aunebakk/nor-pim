/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:59 AM
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
    
    
    public partial class CrudeProductIdentifierRefBusiness {
        
        public CrudeProductIdentifierRefModel FetchByProductIdentifierRcd(string productIdentifierRcd) {
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            var model = new CrudeProductIdentifierRefModel();

            dataAccessLayer.FetchByProductIdentifierRcd(productIdentifierRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductIdentifierRefModel FetchByProductIdentifierName(string productIdentifierName) {
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            var model = new CrudeProductIdentifierRefModel();

            dataAccessLayer.FetchByProductIdentifierName(productIdentifierName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductIdentifierRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductIdentifierRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductIdentifierRefModel> DataListToModelList(List<CrudeProductIdentifierRefData> dataList) {
            var modelList = new List<CrudeProductIdentifierRefModel>();

            foreach (CrudeProductIdentifierRefData data in dataList) {
                var model = new CrudeProductIdentifierRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductIdentifierRefModel> modelList, List<CrudeProductIdentifierRefData> dataList) {
            foreach (CrudeProductIdentifierRefModel model in modelList) {
                var data = new CrudeProductIdentifierRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductIdentifierRefModel> FetchAll() {
            var list = new List<CrudeProductIdentifierRefModel>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchAll();

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRefBusiness in dataList) {
                var model = new CrudeProductIdentifierRefModel();
                DataToModel(crudeProductIdentifierRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductIdentifierRefModel>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRefBusiness in dataList) {
                var model = new CrudeProductIdentifierRefModel();
                DataToModel(crudeProductIdentifierRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductIdentifierRefModel>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRefBusiness in dataList) {
                var model = new CrudeProductIdentifierRefModel();
                DataToModel(crudeProductIdentifierRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductIdentifierRefData.FetchAllCount();

        }
        
        public List<CrudeProductIdentifierRefModel> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductIdentifierRefModel>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchWithFilter(productIdentifierRcd,productIdentifierName,userId,dateTime);

            foreach (CrudeProductIdentifierRefData data in dataList) {
                var crudeProductIdentifierRefBusinessModel = new CrudeProductIdentifierRefModel();
                DataToModel(data, crudeProductIdentifierRefBusinessModel);
                list.Add(crudeProductIdentifierRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductIdentifierRefModel model) {
            var data = new CrudeProductIdentifierRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductIdentifierRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductIdentifierRefModel model) {
            var data = new CrudeProductIdentifierRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductIdentifierRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productIdentifierRcd) {
            CrudeProductIdentifierRefData.Delete(productIdentifierRcd);
        }
        
        public static void ModelToData(CrudeProductIdentifierRefModel model, CrudeProductIdentifierRefData data) {
            data.ProductIdentifierRcd = model.ProductIdentifierRcd;
            data.ProductIdentifierName = model.ProductIdentifierName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductIdentifierRefData data, CrudeProductIdentifierRefModel model) {
            model.ProductIdentifierRcd = data.ProductIdentifierRcd;
            model.ProductIdentifierName = data.ProductIdentifierName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
