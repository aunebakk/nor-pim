/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:30 PM
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
    
    
    public partial class CrudeProductChangeSetBusiness {
        
        public CrudeProductChangeSetModel FetchByProductChangeSetId(System.Guid productChangeSetId) {
            var dataAccessLayer = new CrudeProductChangeSetData();
            var model = new CrudeProductChangeSetModel();

            dataAccessLayer.FetchByProductChangeSetId(productChangeSetId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductChangeSetModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductChangeSetData.FetchByProductId(productId));
        }
        
        public List<CrudeProductChangeSetModel> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return DataListToModelList(CrudeProductChangeSetData.FetchByProductGatherKeyId(productGatherKeyId));
        }
        
        public List<CrudeProductChangeSetModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductChangeSetData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductChangeSetModel> DataListToModelList(List<CrudeProductChangeSetData> dataList) {
            var modelList = new List<CrudeProductChangeSetModel>();

            foreach (CrudeProductChangeSetData data in dataList) {
                var model = new CrudeProductChangeSetModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductChangeSetModel> modelList, List<CrudeProductChangeSetData> dataList) {
            foreach (CrudeProductChangeSetModel model in modelList) {
                var data = new CrudeProductChangeSetData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductChangeSetModel> FetchAll() {
            var list = new List<CrudeProductChangeSetModel>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAll();

            foreach (CrudeProductChangeSetData crudeProductChangeSetBusiness in dataList) {
                var model = new CrudeProductChangeSetModel();
                DataToModel(crudeProductChangeSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductChangeSetModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductChangeSetModel>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductChangeSetData crudeProductChangeSetBusiness in dataList) {
                var model = new CrudeProductChangeSetModel();
                DataToModel(crudeProductChangeSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductChangeSetModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductChangeSetModel>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductChangeSetData crudeProductChangeSetBusiness in dataList) {
                var model = new CrudeProductChangeSetModel();
                DataToModel(crudeProductChangeSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductChangeSetData.FetchAllCount();

        }
        
        public List<CrudeProductChangeSetModel> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductChangeSetModel>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchWithFilter(productChangeSetId,productId,productGatherKeyId,userId,dateTime);

            foreach (CrudeProductChangeSetData data in dataList) {
                var crudeProductChangeSetBusinessModel = new CrudeProductChangeSetModel();
                DataToModel(data, crudeProductChangeSetBusinessModel);
                list.Add(crudeProductChangeSetBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductChangeSetModel model) {
            var data = new CrudeProductChangeSetData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductChangeSetModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductChangeSetData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductChangeSetModel model) {
            var data = new CrudeProductChangeSetData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductChangeSetModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductChangeSetData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productChangeSetId) {
            CrudeProductChangeSetData.Delete(productChangeSetId);
        }
        
        public static void ModelToData(CrudeProductChangeSetModel model, CrudeProductChangeSetData data) {
            data.ProductChangeSetId = model.ProductChangeSetId;
            data.ProductId = model.ProductId;
            data.ProductGatherKeyId = model.ProductGatherKeyId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductChangeSetData data, CrudeProductChangeSetModel model) {
            model.ProductChangeSetId = data.ProductChangeSetId;
            model.ProductId = data.ProductId;
            model.ProductGatherKeyId = data.ProductGatherKeyId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
