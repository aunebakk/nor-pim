/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:39:12 PM
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
    
    
    public partial class CrudeProductExposeSetTypeRefBusiness {
        
        public CrudeProductExposeSetTypeRefModel FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var model = new CrudeProductExposeSetTypeRefModel();

            dataAccessLayer.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductExposeSetTypeRefModel FetchByProductExposeSetTypeName(string productExposeSetTypeName) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var model = new CrudeProductExposeSetTypeRefModel();

            dataAccessLayer.FetchByProductExposeSetTypeName(productExposeSetTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductExposeSetTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductExposeSetTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeSetTypeRefModel> DataListToModelList(List<CrudeProductExposeSetTypeRefData> dataList) {
            var modelList = new List<CrudeProductExposeSetTypeRefModel>();

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var model = new CrudeProductExposeSetTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductExposeSetTypeRefModel> modelList, List<CrudeProductExposeSetTypeRefData> dataList) {
            foreach (CrudeProductExposeSetTypeRefModel model in modelList) {
                var data = new CrudeProductExposeSetTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeSetTypeRefModel> FetchAll() {
            var list = new List<CrudeProductExposeSetTypeRefModel>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAll();

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRefBusiness in dataList) {
                var model = new CrudeProductExposeSetTypeRefModel();
                DataToModel(crudeProductExposeSetTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductExposeSetTypeRefModel>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRefBusiness in dataList) {
                var model = new CrudeProductExposeSetTypeRefModel();
                DataToModel(crudeProductExposeSetTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductExposeSetTypeRefModel>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRefBusiness in dataList) {
                var model = new CrudeProductExposeSetTypeRefModel();
                DataToModel(crudeProductExposeSetTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposeSetTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductExposeSetTypeRefModel> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetTypeRefModel>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchWithFilter(productExposeSetTypeRcd,productExposeSetTypeName,userId,dateTime);

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var crudeProductExposeSetTypeRefBusinessModel = new CrudeProductExposeSetTypeRefModel();
                DataToModel(data, crudeProductExposeSetTypeRefBusinessModel);
                list.Add(crudeProductExposeSetTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeSetTypeRefModel model) {
            var data = new CrudeProductExposeSetTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposeSetTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposeSetTypeRefModel model) {
            var data = new CrudeProductExposeSetTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposeSetTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productExposeSetTypeRcd) {
            CrudeProductExposeSetTypeRefData.Delete(productExposeSetTypeRcd);
        }
        
        public static void ModelToData(CrudeProductExposeSetTypeRefModel model, CrudeProductExposeSetTypeRefData data) {
            data.ProductExposeSetTypeRcd = model.ProductExposeSetTypeRcd;
            data.ProductExposeSetTypeName = model.ProductExposeSetTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductExposeSetTypeRefData data, CrudeProductExposeSetTypeRefModel model) {
            model.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            model.ProductExposeSetTypeName = data.ProductExposeSetTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
