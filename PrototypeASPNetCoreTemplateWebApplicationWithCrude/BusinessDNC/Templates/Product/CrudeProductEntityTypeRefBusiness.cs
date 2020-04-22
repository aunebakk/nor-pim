/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
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
    
    
    public partial class CrudeProductEntityTypeRefBusiness {
        
        public CrudeProductEntityTypeRefModel FetchByProductEntityTypeRcd(string productEntityTypeRcd) {
            var dataAccessLayer = new CrudeProductEntityTypeRefData();
            var model = new CrudeProductEntityTypeRefModel();

            dataAccessLayer.FetchByProductEntityTypeRcd(productEntityTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductEntityTypeRefModel FetchByProductEntityTypeName(string productEntityTypeName) {
            var dataAccessLayer = new CrudeProductEntityTypeRefData();
            var model = new CrudeProductEntityTypeRefModel();

            dataAccessLayer.FetchByProductEntityTypeName(productEntityTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductEntityTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductEntityTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductEntityTypeRefModel> DataListToModelList(List<CrudeProductEntityTypeRefData> dataList) {
            var modelList = new List<CrudeProductEntityTypeRefModel>();

            foreach (CrudeProductEntityTypeRefData data in dataList) {
                var model = new CrudeProductEntityTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductEntityTypeRefModel> modelList, List<CrudeProductEntityTypeRefData> dataList) {
            foreach (CrudeProductEntityTypeRefModel model in modelList) {
                var data = new CrudeProductEntityTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductEntityTypeRefModel> FetchAll() {
            var list = new List<CrudeProductEntityTypeRefModel>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAll();

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRefBusiness in dataList) {
                var model = new CrudeProductEntityTypeRefModel();
                DataToModel(crudeProductEntityTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductEntityTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductEntityTypeRefModel>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRefBusiness in dataList) {
                var model = new CrudeProductEntityTypeRefModel();
                DataToModel(crudeProductEntityTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductEntityTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductEntityTypeRefModel>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRefBusiness in dataList) {
                var model = new CrudeProductEntityTypeRefModel();
                DataToModel(crudeProductEntityTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductEntityTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductEntityTypeRefModel> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductEntityTypeRefModel>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchWithFilter(productEntityTypeRcd,productEntityTypeName,userId,dateTime);

            foreach (CrudeProductEntityTypeRefData data in dataList) {
                var crudeProductEntityTypeRefBusinessModel = new CrudeProductEntityTypeRefModel();
                DataToModel(data, crudeProductEntityTypeRefBusinessModel);
                list.Add(crudeProductEntityTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductEntityTypeRefModel model) {
            var data = new CrudeProductEntityTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductEntityTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductEntityTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductEntityTypeRefModel model) {
            var data = new CrudeProductEntityTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductEntityTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductEntityTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productEntityTypeRcd) {
            CrudeProductEntityTypeRefData.Delete(productEntityTypeRcd);
        }
        
        public static void ModelToData(CrudeProductEntityTypeRefModel model, CrudeProductEntityTypeRefData data) {
            data.ProductEntityTypeRcd = model.ProductEntityTypeRcd;
            data.ProductEntityTypeName = model.ProductEntityTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductEntityTypeRefData data, CrudeProductEntityTypeRefModel model) {
            model.ProductEntityTypeRcd = data.ProductEntityTypeRcd;
            model.ProductEntityTypeName = data.ProductEntityTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
