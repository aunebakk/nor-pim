/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:29 PM
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
    
    
    public partial class CrudeProductInfoBusiness {
        
        public CrudeProductInfoModel FetchByProductInfoId(System.Guid productInfoId) {
            var dataAccessLayer = new CrudeProductInfoData();
            var model = new CrudeProductInfoModel();

            dataAccessLayer.FetchByProductInfoId(productInfoId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductInfoModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductInfoData.FetchByProductId(productId));
        }
        
        public List<CrudeProductInfoModel> FetchByProductInfoRcd(string productInfoRcd) {
            return DataListToModelList(CrudeProductInfoData.FetchByProductInfoRcd(productInfoRcd));
        }
        
        public List<CrudeProductInfoModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductInfoData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductInfoModel> DataListToModelList(List<CrudeProductInfoData> dataList) {
            var modelList = new List<CrudeProductInfoModel>();

            foreach (CrudeProductInfoData data in dataList) {
                var model = new CrudeProductInfoModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductInfoModel> modelList, List<CrudeProductInfoData> dataList) {
            foreach (CrudeProductInfoModel model in modelList) {
                var data = new CrudeProductInfoData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInfoModel> FetchAll() {
            var list = new List<CrudeProductInfoModel>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAll();

            foreach (CrudeProductInfoData crudeProductInfoBusiness in dataList) {
                var model = new CrudeProductInfoModel();
                DataToModel(crudeProductInfoBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductInfoModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductInfoModel>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductInfoData crudeProductInfoBusiness in dataList) {
                var model = new CrudeProductInfoModel();
                DataToModel(crudeProductInfoBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductInfoModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductInfoModel>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductInfoData crudeProductInfoBusiness in dataList) {
                var model = new CrudeProductInfoModel();
                DataToModel(crudeProductInfoBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductInfoData.FetchAllCount();

        }
        
        public List<CrudeProductInfoModel> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoModel>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchWithFilter(productInfoId,productId,productInfoRcd,productInfoValue,userId,dateTime);

            foreach (CrudeProductInfoData data in dataList) {
                var crudeProductInfoBusinessModel = new CrudeProductInfoModel();
                DataToModel(data, crudeProductInfoBusinessModel);
                list.Add(crudeProductInfoBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductInfoModel model) {
            var data = new CrudeProductInfoData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductInfoModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductInfoModel model) {
            var data = new CrudeProductInfoData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductInfoModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productInfoId) {
            CrudeProductInfoData.Delete(productInfoId);
        }
        
        public static void ModelToData(CrudeProductInfoModel model, CrudeProductInfoData data) {
            data.ProductInfoId = model.ProductInfoId;
            data.ProductId = model.ProductId;
            data.ProductInfoRcd = model.ProductInfoRcd;
            data.ProductInfoValue = model.ProductInfoValue;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductInfoData data, CrudeProductInfoModel model) {
            model.ProductInfoId = data.ProductInfoId;
            model.ProductId = data.ProductId;
            model.ProductInfoRcd = data.ProductInfoRcd;
            model.ProductInfoValue = data.ProductInfoValue;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
