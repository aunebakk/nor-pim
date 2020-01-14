/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:23:00 PM
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
    
    
    public partial class CrudeProductGatherSourceBusiness {
        
        public CrudeProductGatherSourceModel FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            var dataAccessLayer = new CrudeProductGatherSourceData();
            var model = new CrudeProductGatherSourceModel();

            dataAccessLayer.FetchByProductGatherSourceId(productGatherSourceId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductGatherSourceModel> FetchByProductGatherId(System.Guid productGatherId) {
            return DataListToModelList(CrudeProductGatherSourceData.FetchByProductGatherId(productGatherId));
        }
        
        public List<CrudeProductGatherSourceModel> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            return DataListToModelList(CrudeProductGatherSourceData.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd));
        }
        
        public List<CrudeProductGatherSourceModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductGatherSourceData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherSourceModel> DataListToModelList(List<CrudeProductGatherSourceData> dataList) {
            var modelList = new List<CrudeProductGatherSourceModel>();

            foreach (CrudeProductGatherSourceData data in dataList) {
                var model = new CrudeProductGatherSourceModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductGatherSourceModel> modelList, List<CrudeProductGatherSourceData> dataList) {
            foreach (CrudeProductGatherSourceModel model in modelList) {
                var data = new CrudeProductGatherSourceData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherSourceModel> FetchAll() {
            var list = new List<CrudeProductGatherSourceModel>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAll();

            foreach (CrudeProductGatherSourceData crudeProductGatherSourceBusiness in dataList) {
                var model = new CrudeProductGatherSourceModel();
                DataToModel(crudeProductGatherSourceBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductGatherSourceModel>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductGatherSourceData crudeProductGatherSourceBusiness in dataList) {
                var model = new CrudeProductGatherSourceModel();
                DataToModel(crudeProductGatherSourceBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductGatherSourceModel>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductGatherSourceData crudeProductGatherSourceBusiness in dataList) {
                var model = new CrudeProductGatherSourceModel();
                DataToModel(crudeProductGatherSourceBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherSourceData.FetchAllCount();

        }
        
        public List<CrudeProductGatherSourceModel> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherSourceModel>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchWithFilter(productGatherSourceId,productGatherId,productGatherSourceTypeRcd,userId,dateTime);

            foreach (CrudeProductGatherSourceData data in dataList) {
                var crudeProductGatherSourceBusinessModel = new CrudeProductGatherSourceModel();
                DataToModel(data, crudeProductGatherSourceBusinessModel);
                list.Add(crudeProductGatherSourceBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherSourceModel model) {
            var data = new CrudeProductGatherSourceData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherSourceModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherSourceModel model) {
            var data = new CrudeProductGatherSourceData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherSourceModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherSourceId) {
            CrudeProductGatherSourceData.Delete(productGatherSourceId);
        }
        
        public static void ModelToData(CrudeProductGatherSourceModel model, CrudeProductGatherSourceData data) {
            data.ProductGatherSourceId = model.ProductGatherSourceId;
            data.ProductGatherId = model.ProductGatherId;
            data.ProductGatherSourceTypeRcd = model.ProductGatherSourceTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductGatherSourceData data, CrudeProductGatherSourceModel model) {
            model.ProductGatherSourceId = data.ProductGatherSourceId;
            model.ProductGatherId = data.ProductGatherId;
            model.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
