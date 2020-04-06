/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:49 PM
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
    
    
    public partial class CrudeProductDocumentationTypeRefBusiness {
        
        public CrudeProductDocumentationTypeRefModel FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            var model = new CrudeProductDocumentationTypeRefModel();

            dataAccessLayer.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductDocumentationTypeRefModel FetchByProductDocumentationTypeName(string productDocumentationTypeName) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            var model = new CrudeProductDocumentationTypeRefModel();

            dataAccessLayer.FetchByProductDocumentationTypeName(productDocumentationTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductDocumentationTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductDocumentationTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductDocumentationTypeRefModel> DataListToModelList(List<CrudeProductDocumentationTypeRefData> dataList) {
            var modelList = new List<CrudeProductDocumentationTypeRefModel>();

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var model = new CrudeProductDocumentationTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductDocumentationTypeRefModel> modelList, List<CrudeProductDocumentationTypeRefData> dataList) {
            foreach (CrudeProductDocumentationTypeRefModel model in modelList) {
                var data = new CrudeProductDocumentationTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductDocumentationTypeRefModel> FetchAll() {
            var list = new List<CrudeProductDocumentationTypeRefModel>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAll();

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRefBusiness in dataList) {
                var model = new CrudeProductDocumentationTypeRefModel();
                DataToModel(crudeProductDocumentationTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductDocumentationTypeRefModel>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRefBusiness in dataList) {
                var model = new CrudeProductDocumentationTypeRefModel();
                DataToModel(crudeProductDocumentationTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductDocumentationTypeRefModel>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRefBusiness in dataList) {
                var model = new CrudeProductDocumentationTypeRefModel();
                DataToModel(crudeProductDocumentationTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductDocumentationTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductDocumentationTypeRefModel> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductDocumentationTypeRefModel>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchWithFilter(productDocumentationTypeRcd,productDocumentationTypeName,userId,dateTime);

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var crudeProductDocumentationTypeRefBusinessModel = new CrudeProductDocumentationTypeRefModel();
                DataToModel(data, crudeProductDocumentationTypeRefBusinessModel);
                list.Add(crudeProductDocumentationTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductDocumentationTypeRefModel model) {
            var data = new CrudeProductDocumentationTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductDocumentationTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductDocumentationTypeRefModel model) {
            var data = new CrudeProductDocumentationTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductDocumentationTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productDocumentationTypeRcd) {
            CrudeProductDocumentationTypeRefData.Delete(productDocumentationTypeRcd);
        }
        
        public static void ModelToData(CrudeProductDocumentationTypeRefModel model, CrudeProductDocumentationTypeRefData data) {
            data.ProductDocumentationTypeRcd = model.ProductDocumentationTypeRcd;
            data.ProductDocumentationTypeName = model.ProductDocumentationTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductDocumentationTypeRefData data, CrudeProductDocumentationTypeRefModel model) {
            model.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            model.ProductDocumentationTypeName = data.ProductDocumentationTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
