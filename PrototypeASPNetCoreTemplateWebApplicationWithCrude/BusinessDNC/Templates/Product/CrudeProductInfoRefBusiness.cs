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
    
    
    public partial class CrudeProductInfoRefBusiness {
        
        public CrudeProductInfoRefModel FetchByProductInfoRcd(string productInfoRcd) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            var model = new CrudeProductInfoRefModel();

            dataAccessLayer.FetchByProductInfoRcd(productInfoRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductInfoRefModel FetchByProductInfoName(string productInfoName) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            var model = new CrudeProductInfoRefModel();

            dataAccessLayer.FetchByProductInfoName(productInfoName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductInfoRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductInfoRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductInfoRefModel> DataListToModelList(List<CrudeProductInfoRefData> dataList) {
            var modelList = new List<CrudeProductInfoRefModel>();

            foreach (CrudeProductInfoRefData data in dataList) {
                var model = new CrudeProductInfoRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductInfoRefModel> modelList, List<CrudeProductInfoRefData> dataList) {
            foreach (CrudeProductInfoRefModel model in modelList) {
                var data = new CrudeProductInfoRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInfoRefModel> FetchAll() {
            var list = new List<CrudeProductInfoRefModel>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAll();

            foreach (CrudeProductInfoRefData crudeProductInfoRefBusiness in dataList) {
                var model = new CrudeProductInfoRefModel();
                DataToModel(crudeProductInfoRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductInfoRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductInfoRefModel>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductInfoRefData crudeProductInfoRefBusiness in dataList) {
                var model = new CrudeProductInfoRefModel();
                DataToModel(crudeProductInfoRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductInfoRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductInfoRefModel>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductInfoRefData crudeProductInfoRefBusiness in dataList) {
                var model = new CrudeProductInfoRefModel();
                DataToModel(crudeProductInfoRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductInfoRefData.FetchAllCount();

        }
        
        public List<CrudeProductInfoRefModel> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoRefModel>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchWithFilter(productInfoRcd,productInfoName,userId,dateTime);

            foreach (CrudeProductInfoRefData data in dataList) {
                var crudeProductInfoRefBusinessModel = new CrudeProductInfoRefModel();
                DataToModel(data, crudeProductInfoRefBusinessModel);
                list.Add(crudeProductInfoRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductInfoRefModel model) {
            var data = new CrudeProductInfoRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductInfoRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductInfoRefModel model) {
            var data = new CrudeProductInfoRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductInfoRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productInfoRcd) {
            CrudeProductInfoRefData.Delete(productInfoRcd);
        }
        
        public static void ModelToData(CrudeProductInfoRefModel model, CrudeProductInfoRefData data) {
            data.ProductInfoRcd = model.ProductInfoRcd;
            data.ProductInfoName = model.ProductInfoName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductInfoRefData data, CrudeProductInfoRefModel model) {
            model.ProductInfoRcd = data.ProductInfoRcd;
            model.ProductInfoName = data.ProductInfoName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
