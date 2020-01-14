/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:07 AM
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
    
    
    public partial class CrudeProductImageTypeRefBusiness {
        
        public CrudeProductImageTypeRefModel FetchByProductImageTypeRcd(string productImageTypeRcd) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            var model = new CrudeProductImageTypeRefModel();

            dataAccessLayer.FetchByProductImageTypeRcd(productImageTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductImageTypeRefModel FetchByProductImageTypeName(string productImageTypeName) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            var model = new CrudeProductImageTypeRefModel();

            dataAccessLayer.FetchByProductImageTypeName(productImageTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductImageTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductImageTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductImageTypeRefModel> DataListToModelList(List<CrudeProductImageTypeRefData> dataList) {
            var modelList = new List<CrudeProductImageTypeRefModel>();

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var model = new CrudeProductImageTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductImageTypeRefModel> modelList, List<CrudeProductImageTypeRefData> dataList) {
            foreach (CrudeProductImageTypeRefModel model in modelList) {
                var data = new CrudeProductImageTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductImageTypeRefModel> FetchAll() {
            var list = new List<CrudeProductImageTypeRefModel>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAll();

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRefBusiness in dataList) {
                var model = new CrudeProductImageTypeRefModel();
                DataToModel(crudeProductImageTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductImageTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductImageTypeRefModel>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRefBusiness in dataList) {
                var model = new CrudeProductImageTypeRefModel();
                DataToModel(crudeProductImageTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductImageTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductImageTypeRefModel>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRefBusiness in dataList) {
                var model = new CrudeProductImageTypeRefModel();
                DataToModel(crudeProductImageTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductImageTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductImageTypeRefModel> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductImageTypeRefModel>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchWithFilter(productImageTypeRcd,productImageTypeName,userId,dateTime);

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var crudeProductImageTypeRefBusinessModel = new CrudeProductImageTypeRefModel();
                DataToModel(data, crudeProductImageTypeRefBusinessModel);
                list.Add(crudeProductImageTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductImageTypeRefModel model) {
            var data = new CrudeProductImageTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductImageTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductImageTypeRefModel model) {
            var data = new CrudeProductImageTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductImageTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productImageTypeRcd) {
            CrudeProductImageTypeRefData.Delete(productImageTypeRcd);
        }
        
        public static void ModelToData(CrudeProductImageTypeRefModel model, CrudeProductImageTypeRefData data) {
            data.ProductImageTypeRcd = model.ProductImageTypeRcd;
            data.ProductImageTypeName = model.ProductImageTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductImageTypeRefData data, CrudeProductImageTypeRefModel model) {
            model.ProductImageTypeRcd = data.ProductImageTypeRcd;
            model.ProductImageTypeName = data.ProductImageTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
