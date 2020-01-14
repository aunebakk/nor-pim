/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:29 AM
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
    
    
    public partial class CrudeProductExposePlanBusiness {
        
        public CrudeProductExposePlanModel FetchByProductExposePlanId(System.Guid productExposePlanId) {
            var dataAccessLayer = new CrudeProductExposePlanData();
            var model = new CrudeProductExposePlanModel();

            dataAccessLayer.FetchByProductExposePlanId(productExposePlanId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductExposePlanModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductExposePlanData.FetchByProductId(productId));
        }
        
        public List<CrudeProductExposePlanModel> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return DataListToModelList(CrudeProductExposePlanData.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd));
        }
        
        public List<CrudeProductExposePlanModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductExposePlanData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposePlanModel> DataListToModelList(List<CrudeProductExposePlanData> dataList) {
            var modelList = new List<CrudeProductExposePlanModel>();

            foreach (CrudeProductExposePlanData data in dataList) {
                var model = new CrudeProductExposePlanModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductExposePlanModel> modelList, List<CrudeProductExposePlanData> dataList) {
            foreach (CrudeProductExposePlanModel model in modelList) {
                var data = new CrudeProductExposePlanData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposePlanModel> FetchAll() {
            var list = new List<CrudeProductExposePlanModel>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAll();

            foreach (CrudeProductExposePlanData crudeProductExposePlanBusiness in dataList) {
                var model = new CrudeProductExposePlanModel();
                DataToModel(crudeProductExposePlanBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposePlanModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductExposePlanModel>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductExposePlanData crudeProductExposePlanBusiness in dataList) {
                var model = new CrudeProductExposePlanModel();
                DataToModel(crudeProductExposePlanBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposePlanModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductExposePlanModel>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductExposePlanData crudeProductExposePlanBusiness in dataList) {
                var model = new CrudeProductExposePlanModel();
                DataToModel(crudeProductExposePlanBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposePlanData.FetchAllCount();

        }
        
        public List<CrudeProductExposePlanModel> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposePlanModel>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchWithFilter(productExposePlanId,productId,productExposeSetTypeRcd,userId,dateTime);

            foreach (CrudeProductExposePlanData data in dataList) {
                var crudeProductExposePlanBusinessModel = new CrudeProductExposePlanModel();
                DataToModel(data, crudeProductExposePlanBusinessModel);
                list.Add(crudeProductExposePlanBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposePlanModel model) {
            var data = new CrudeProductExposePlanData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposePlanModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposePlanData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposePlanModel model) {
            var data = new CrudeProductExposePlanData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposePlanModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposePlanData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposePlanId) {
            CrudeProductExposePlanData.Delete(productExposePlanId);
        }
        
        public static void ModelToData(CrudeProductExposePlanModel model, CrudeProductExposePlanData data) {
            data.ProductExposePlanId = model.ProductExposePlanId;
            data.ProductId = model.ProductId;
            data.ProductExposeSetTypeRcd = model.ProductExposeSetTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductExposePlanData data, CrudeProductExposePlanModel model) {
            model.ProductExposePlanId = data.ProductExposePlanId;
            model.ProductId = data.ProductId;
            model.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
