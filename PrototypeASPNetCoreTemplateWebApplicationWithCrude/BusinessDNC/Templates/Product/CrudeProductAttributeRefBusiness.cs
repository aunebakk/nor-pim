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
    
    
    public partial class CrudeProductAttributeRefBusiness {
        
        public CrudeProductAttributeRefModel FetchByProductAttributeRcd(string productAttributeRcd) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            var model = new CrudeProductAttributeRefModel();

            dataAccessLayer.FetchByProductAttributeRcd(productAttributeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductAttributeRefModel FetchByProductAttributeName(string productAttributeName) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            var model = new CrudeProductAttributeRefModel();

            dataAccessLayer.FetchByProductAttributeName(productAttributeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductAttributeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductAttributeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeRefModel> DataListToModelList(List<CrudeProductAttributeRefData> dataList) {
            var modelList = new List<CrudeProductAttributeRefModel>();

            foreach (CrudeProductAttributeRefData data in dataList) {
                var model = new CrudeProductAttributeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductAttributeRefModel> modelList, List<CrudeProductAttributeRefData> dataList) {
            foreach (CrudeProductAttributeRefModel model in modelList) {
                var data = new CrudeProductAttributeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeRefModel> FetchAll() {
            var list = new List<CrudeProductAttributeRefModel>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAll();

            foreach (CrudeProductAttributeRefData crudeProductAttributeRefBusiness in dataList) {
                var model = new CrudeProductAttributeRefModel();
                DataToModel(crudeProductAttributeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductAttributeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductAttributeRefModel>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductAttributeRefData crudeProductAttributeRefBusiness in dataList) {
                var model = new CrudeProductAttributeRefModel();
                DataToModel(crudeProductAttributeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductAttributeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductAttributeRefModel>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductAttributeRefData crudeProductAttributeRefBusiness in dataList) {
                var model = new CrudeProductAttributeRefModel();
                DataToModel(crudeProductAttributeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductAttributeRefData.FetchAllCount();

        }
        
        public List<CrudeProductAttributeRefModel> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeRefModel>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchWithFilter(productAttributeRcd,productAttributeName,userId,dateTime);

            foreach (CrudeProductAttributeRefData data in dataList) {
                var crudeProductAttributeRefBusinessModel = new CrudeProductAttributeRefModel();
                DataToModel(data, crudeProductAttributeRefBusinessModel);
                list.Add(crudeProductAttributeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeRefModel model) {
            var data = new CrudeProductAttributeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductAttributeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductAttributeRefModel model) {
            var data = new CrudeProductAttributeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductAttributeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productAttributeRcd) {
            CrudeProductAttributeRefData.Delete(productAttributeRcd);
        }
        
        public static void ModelToData(CrudeProductAttributeRefModel model, CrudeProductAttributeRefData data) {
            data.ProductAttributeRcd = model.ProductAttributeRcd;
            data.ProductAttributeName = model.ProductAttributeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductAttributeRefData data, CrudeProductAttributeRefModel model) {
            model.ProductAttributeRcd = data.ProductAttributeRcd;
            model.ProductAttributeName = data.ProductAttributeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
