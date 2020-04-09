/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:55 AM
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
    
    
    public partial class CrudeProductGatherSourceTypeRefBusiness {
        
        public CrudeProductGatherSourceTypeRefModel FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            var model = new CrudeProductGatherSourceTypeRefModel();

            dataAccessLayer.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductGatherSourceTypeRefModel FetchByProductGatherSourceTypeName(string productGatherSourceTypeName) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            var model = new CrudeProductGatherSourceTypeRefModel();

            dataAccessLayer.FetchByProductGatherSourceTypeName(productGatherSourceTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductGatherSourceTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductGatherSourceTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherSourceTypeRefModel> DataListToModelList(List<CrudeProductGatherSourceTypeRefData> dataList) {
            var modelList = new List<CrudeProductGatherSourceTypeRefModel>();

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var model = new CrudeProductGatherSourceTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductGatherSourceTypeRefModel> modelList, List<CrudeProductGatherSourceTypeRefData> dataList) {
            foreach (CrudeProductGatherSourceTypeRefModel model in modelList) {
                var data = new CrudeProductGatherSourceTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherSourceTypeRefModel> FetchAll() {
            var list = new List<CrudeProductGatherSourceTypeRefModel>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAll();

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRefBusiness in dataList) {
                var model = new CrudeProductGatherSourceTypeRefModel();
                DataToModel(crudeProductGatherSourceTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductGatherSourceTypeRefModel>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRefBusiness in dataList) {
                var model = new CrudeProductGatherSourceTypeRefModel();
                DataToModel(crudeProductGatherSourceTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductGatherSourceTypeRefModel>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRefBusiness in dataList) {
                var model = new CrudeProductGatherSourceTypeRefModel();
                DataToModel(crudeProductGatherSourceTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherSourceTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductGatherSourceTypeRefModel> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherSourceTypeRefModel>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchWithFilter(productGatherSourceTypeRcd,productGatherSourceTypeName,userId,dateTime);

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var crudeProductGatherSourceTypeRefBusinessModel = new CrudeProductGatherSourceTypeRefModel();
                DataToModel(data, crudeProductGatherSourceTypeRefBusinessModel);
                list.Add(crudeProductGatherSourceTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherSourceTypeRefModel model) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherSourceTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherSourceTypeRefModel model) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherSourceTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productGatherSourceTypeRcd) {
            CrudeProductGatherSourceTypeRefData.Delete(productGatherSourceTypeRcd);
        }
        
        public static void ModelToData(CrudeProductGatherSourceTypeRefModel model, CrudeProductGatherSourceTypeRefData data) {
            data.ProductGatherSourceTypeRcd = model.ProductGatherSourceTypeRcd;
            data.ProductGatherSourceTypeName = model.ProductGatherSourceTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductGatherSourceTypeRefData data, CrudeProductGatherSourceTypeRefModel model) {
            model.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
            model.ProductGatherSourceTypeName = data.ProductGatherSourceTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
