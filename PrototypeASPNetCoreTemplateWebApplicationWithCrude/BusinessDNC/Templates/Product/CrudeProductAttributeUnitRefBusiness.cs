/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:45 PM
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
    
    
    public partial class CrudeProductAttributeUnitRefBusiness {
        
        public CrudeProductAttributeUnitRefModel FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            var model = new CrudeProductAttributeUnitRefModel();

            dataAccessLayer.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductAttributeUnitRefModel FetchByProductAttributeUnitName(string productAttributeUnitName) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            var model = new CrudeProductAttributeUnitRefModel();

            dataAccessLayer.FetchByProductAttributeUnitName(productAttributeUnitName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductAttributeUnitRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductAttributeUnitRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeUnitRefModel> DataListToModelList(List<CrudeProductAttributeUnitRefData> dataList) {
            var modelList = new List<CrudeProductAttributeUnitRefModel>();

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var model = new CrudeProductAttributeUnitRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductAttributeUnitRefModel> modelList, List<CrudeProductAttributeUnitRefData> dataList) {
            foreach (CrudeProductAttributeUnitRefModel model in modelList) {
                var data = new CrudeProductAttributeUnitRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeUnitRefModel> FetchAll() {
            var list = new List<CrudeProductAttributeUnitRefModel>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAll();

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRefBusiness in dataList) {
                var model = new CrudeProductAttributeUnitRefModel();
                DataToModel(crudeProductAttributeUnitRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductAttributeUnitRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductAttributeUnitRefModel>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRefBusiness in dataList) {
                var model = new CrudeProductAttributeUnitRefModel();
                DataToModel(crudeProductAttributeUnitRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductAttributeUnitRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductAttributeUnitRefModel>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRefBusiness in dataList) {
                var model = new CrudeProductAttributeUnitRefModel();
                DataToModel(crudeProductAttributeUnitRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductAttributeUnitRefData.FetchAllCount();

        }
        
        public List<CrudeProductAttributeUnitRefModel> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeUnitRefModel>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchWithFilter(productAttributeUnitRcd,productAttributeUnitName,userId,dateTime);

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var crudeProductAttributeUnitRefBusinessModel = new CrudeProductAttributeUnitRefModel();
                DataToModel(data, crudeProductAttributeUnitRefBusinessModel);
                list.Add(crudeProductAttributeUnitRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeUnitRefModel model) {
            var data = new CrudeProductAttributeUnitRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductAttributeUnitRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeUnitRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductAttributeUnitRefModel model) {
            var data = new CrudeProductAttributeUnitRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductAttributeUnitRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeUnitRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productAttributeUnitRcd) {
            CrudeProductAttributeUnitRefData.Delete(productAttributeUnitRcd);
        }
        
        public static void ModelToData(CrudeProductAttributeUnitRefModel model, CrudeProductAttributeUnitRefData data) {
            data.ProductAttributeUnitRcd = model.ProductAttributeUnitRcd;
            data.ProductAttributeUnitName = model.ProductAttributeUnitName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductAttributeUnitRefData data, CrudeProductAttributeUnitRefModel model) {
            model.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            model.ProductAttributeUnitName = data.ProductAttributeUnitName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
