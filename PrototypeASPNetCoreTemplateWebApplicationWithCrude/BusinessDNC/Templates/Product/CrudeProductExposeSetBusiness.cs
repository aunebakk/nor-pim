/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:50 PM
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
    
    
    public partial class CrudeProductExposeSetBusiness {
        
        public CrudeProductExposeSetModel FetchByProductExposeSetId(System.Guid productExposeSetId) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            var model = new CrudeProductExposeSetModel();

            dataAccessLayer.FetchByProductExposeSetId(productExposeSetId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductExposeSetModel FetchByProductExposeSetName(string productExposeSetName) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            var model = new CrudeProductExposeSetModel();

            dataAccessLayer.FetchByProductExposeSetName(productExposeSetName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductExposeSetModel> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return DataListToModelList(CrudeProductExposeSetData.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd));
        }
        
        public List<CrudeProductExposeSetModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductExposeSetData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeSetModel> DataListToModelList(List<CrudeProductExposeSetData> dataList) {
            var modelList = new List<CrudeProductExposeSetModel>();

            foreach (CrudeProductExposeSetData data in dataList) {
                var model = new CrudeProductExposeSetModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductExposeSetModel> modelList, List<CrudeProductExposeSetData> dataList) {
            foreach (CrudeProductExposeSetModel model in modelList) {
                var data = new CrudeProductExposeSetData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeSetModel> FetchAll() {
            var list = new List<CrudeProductExposeSetModel>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAll();

            foreach (CrudeProductExposeSetData crudeProductExposeSetBusiness in dataList) {
                var model = new CrudeProductExposeSetModel();
                DataToModel(crudeProductExposeSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductExposeSetModel>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductExposeSetData crudeProductExposeSetBusiness in dataList) {
                var model = new CrudeProductExposeSetModel();
                DataToModel(crudeProductExposeSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductExposeSetModel>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductExposeSetData crudeProductExposeSetBusiness in dataList) {
                var model = new CrudeProductExposeSetModel();
                DataToModel(crudeProductExposeSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposeSetData.FetchAllCount();

        }
        
        public List<CrudeProductExposeSetModel> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetModel>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchWithFilter(productExposeSetId,productExposeSetTypeRcd,productExposeSetName,userId,dateTime);

            foreach (CrudeProductExposeSetData data in dataList) {
                var crudeProductExposeSetBusinessModel = new CrudeProductExposeSetModel();
                DataToModel(data, crudeProductExposeSetBusinessModel);
                list.Add(crudeProductExposeSetBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeSetModel model) {
            var data = new CrudeProductExposeSetData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposeSetModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposeSetModel model) {
            var data = new CrudeProductExposeSetData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposeSetModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposeSetId) {
            CrudeProductExposeSetData.Delete(productExposeSetId);
        }
        
        public static void ModelToData(CrudeProductExposeSetModel model, CrudeProductExposeSetData data) {
            data.ProductExposeSetId = model.ProductExposeSetId;
            data.ProductExposeSetTypeRcd = model.ProductExposeSetTypeRcd;
            data.ProductExposeSetName = model.ProductExposeSetName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductExposeSetData data, CrudeProductExposeSetModel model) {
            model.ProductExposeSetId = data.ProductExposeSetId;
            model.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            model.ProductExposeSetName = data.ProductExposeSetName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
