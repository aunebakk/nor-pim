/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:35:04 PM
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
    
    
    public partial class CrudeProductCategoryImageTypeRefBusiness {
        
        public CrudeProductCategoryImageTypeRefModel FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            var model = new CrudeProductCategoryImageTypeRefModel();

            dataAccessLayer.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductCategoryImageTypeRefModel FetchByProductCategoryImageTypeName(string productCategoryImageTypeName) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            var model = new CrudeProductCategoryImageTypeRefModel();

            dataAccessLayer.FetchByProductCategoryImageTypeName(productCategoryImageTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductCategoryImageTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductCategoryImageTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryImageTypeRefModel> DataListToModelList(List<CrudeProductCategoryImageTypeRefData> dataList) {
            var modelList = new List<CrudeProductCategoryImageTypeRefModel>();

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var model = new CrudeProductCategoryImageTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductCategoryImageTypeRefModel> modelList, List<CrudeProductCategoryImageTypeRefData> dataList) {
            foreach (CrudeProductCategoryImageTypeRefModel model in modelList) {
                var data = new CrudeProductCategoryImageTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryImageTypeRefModel> FetchAll() {
            var list = new List<CrudeProductCategoryImageTypeRefModel>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAll();

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRefBusiness in dataList) {
                var model = new CrudeProductCategoryImageTypeRefModel();
                DataToModel(crudeProductCategoryImageTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductCategoryImageTypeRefModel>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRefBusiness in dataList) {
                var model = new CrudeProductCategoryImageTypeRefModel();
                DataToModel(crudeProductCategoryImageTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductCategoryImageTypeRefModel>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRefBusiness in dataList) {
                var model = new CrudeProductCategoryImageTypeRefModel();
                DataToModel(crudeProductCategoryImageTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryImageTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductCategoryImageTypeRefModel> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageTypeRefModel>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchWithFilter(productCategoryImageTypeRcd,productCategoryImageTypeName,userId,dateTime);

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var crudeProductCategoryImageTypeRefBusinessModel = new CrudeProductCategoryImageTypeRefModel();
                DataToModel(data, crudeProductCategoryImageTypeRefBusinessModel);
                list.Add(crudeProductCategoryImageTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryImageTypeRefModel model) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryImageTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryImageTypeRefModel model) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryImageTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productCategoryImageTypeRcd) {
            CrudeProductCategoryImageTypeRefData.Delete(productCategoryImageTypeRcd);
        }
        
        public static void ModelToData(CrudeProductCategoryImageTypeRefModel model, CrudeProductCategoryImageTypeRefData data) {
            data.ProductCategoryImageTypeRcd = model.ProductCategoryImageTypeRcd;
            data.ProductCategoryImageTypeName = model.ProductCategoryImageTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductCategoryImageTypeRefData data, CrudeProductCategoryImageTypeRefModel model) {
            model.ProductCategoryImageTypeRcd = data.ProductCategoryImageTypeRcd;
            model.ProductCategoryImageTypeName = data.ProductCategoryImageTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
