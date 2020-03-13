/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:53 AM
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
    
    
    public partial class CrudeProductGatherAttributeTypeRefBusiness {
        
        public CrudeProductGatherAttributeTypeRefModel FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            var model = new CrudeProductGatherAttributeTypeRefModel();

            dataAccessLayer.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductGatherAttributeTypeRefModel FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName) {
            var dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            var model = new CrudeProductGatherAttributeTypeRefModel();

            dataAccessLayer.FetchByProductGatherAttributeTypeName(productGatherAttributeTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductGatherAttributeTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductGatherAttributeTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherAttributeTypeRefModel> DataListToModelList(List<CrudeProductGatherAttributeTypeRefData> dataList) {
            var modelList = new List<CrudeProductGatherAttributeTypeRefModel>();

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                var model = new CrudeProductGatherAttributeTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductGatherAttributeTypeRefModel> modelList, List<CrudeProductGatherAttributeTypeRefData> dataList) {
            foreach (CrudeProductGatherAttributeTypeRefModel model in modelList) {
                var data = new CrudeProductGatherAttributeTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherAttributeTypeRefModel> FetchAll() {
            var list = new List<CrudeProductGatherAttributeTypeRefModel>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAll();

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRefBusiness in dataList) {
                var model = new CrudeProductGatherAttributeTypeRefModel();
                DataToModel(crudeProductGatherAttributeTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductGatherAttributeTypeRefModel>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRefBusiness in dataList) {
                var model = new CrudeProductGatherAttributeTypeRefModel();
                DataToModel(crudeProductGatherAttributeTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductGatherAttributeTypeRefModel>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRefBusiness in dataList) {
                var model = new CrudeProductGatherAttributeTypeRefModel();
                DataToModel(crudeProductGatherAttributeTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherAttributeTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductGatherAttributeTypeRefModel> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherAttributeTypeRefModel>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchWithFilter(productGatherAttributeTypeRcd,productGatherAttributeTypeName,userId,dateTime);

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                var crudeProductGatherAttributeTypeRefBusinessModel = new CrudeProductGatherAttributeTypeRefModel();
                DataToModel(data, crudeProductGatherAttributeTypeRefBusinessModel);
                list.Add(crudeProductGatherAttributeTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherAttributeTypeRefModel model) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherAttributeTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherAttributeTypeRefModel model) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherAttributeTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productGatherAttributeTypeRcd) {
            CrudeProductGatherAttributeTypeRefData.Delete(productGatherAttributeTypeRcd);
        }
        
        public static void ModelToData(CrudeProductGatherAttributeTypeRefModel model, CrudeProductGatherAttributeTypeRefData data) {
            data.ProductGatherAttributeTypeRcd = model.ProductGatherAttributeTypeRcd;
            data.ProductGatherAttributeTypeName = model.ProductGatherAttributeTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductGatherAttributeTypeRefData data, CrudeProductGatherAttributeTypeRefModel model) {
            model.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            model.ProductGatherAttributeTypeName = data.ProductGatherAttributeTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
