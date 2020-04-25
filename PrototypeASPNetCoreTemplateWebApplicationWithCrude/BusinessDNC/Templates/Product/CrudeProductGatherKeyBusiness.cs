/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:43 AM
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
    
    
    public partial class CrudeProductGatherKeyBusiness {
        
        public CrudeProductGatherKeyModel FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            var dataAccessLayer = new CrudeProductGatherKeyData();
            var model = new CrudeProductGatherKeyModel();

            dataAccessLayer.FetchByProductGatherKeyId(productGatherKeyId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductGatherKeyModel> FetchByProductGatherId(System.Guid productGatherId) {
            return DataListToModelList(CrudeProductGatherKeyData.FetchByProductGatherId(productGatherId));
        }
        
        public List<CrudeProductGatherKeyModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductGatherKeyData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherKeyModel> DataListToModelList(List<CrudeProductGatherKeyData> dataList) {
            var modelList = new List<CrudeProductGatherKeyModel>();

            foreach (CrudeProductGatherKeyData data in dataList) {
                var model = new CrudeProductGatherKeyModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductGatherKeyModel> modelList, List<CrudeProductGatherKeyData> dataList) {
            foreach (CrudeProductGatherKeyModel model in modelList) {
                var data = new CrudeProductGatherKeyData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherKeyModel> FetchAll() {
            var list = new List<CrudeProductGatherKeyModel>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAll();

            foreach (CrudeProductGatherKeyData crudeProductGatherKeyBusiness in dataList) {
                var model = new CrudeProductGatherKeyModel();
                DataToModel(crudeProductGatherKeyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductGatherKeyModel>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductGatherKeyData crudeProductGatherKeyBusiness in dataList) {
                var model = new CrudeProductGatherKeyModel();
                DataToModel(crudeProductGatherKeyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductGatherKeyModel>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductGatherKeyData crudeProductGatherKeyBusiness in dataList) {
                var model = new CrudeProductGatherKeyModel();
                DataToModel(crudeProductGatherKeyBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherKeyData.FetchAllCount();

        }
        
        public List<CrudeProductGatherKeyModel> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherKeyModel>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchWithFilter(productGatherKeyId,productGatherKeyValue,productGatherId,userId,dateTime);

            foreach (CrudeProductGatherKeyData data in dataList) {
                var crudeProductGatherKeyBusinessModel = new CrudeProductGatherKeyModel();
                DataToModel(data, crudeProductGatherKeyBusinessModel);
                list.Add(crudeProductGatherKeyBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherKeyModel model) {
            var data = new CrudeProductGatherKeyData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherKeyModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherKeyData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherKeyModel model) {
            var data = new CrudeProductGatherKeyData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherKeyModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherKeyData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherKeyId) {
            CrudeProductGatherKeyData.Delete(productGatherKeyId);
        }
        
        public static void ModelToData(CrudeProductGatherKeyModel model, CrudeProductGatherKeyData data) {
            data.ProductGatherKeyId = model.ProductGatherKeyId;
            data.ProductGatherKeyValue = model.ProductGatherKeyValue;
            data.ProductGatherId = model.ProductGatherId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductGatherKeyData data, CrudeProductGatherKeyModel model) {
            model.ProductGatherKeyId = data.ProductGatherKeyId;
            model.ProductGatherKeyValue = data.ProductGatherKeyValue;
            model.ProductGatherId = data.ProductGatherId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
