/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:44 AM
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
    
    
    public partial class CrudeDefaultErrorLayerRefBusiness {
        
        public CrudeDefaultErrorLayerRefModel FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            var dataAccessLayer = new CrudeDefaultErrorLayerRefData();
            var model = new CrudeDefaultErrorLayerRefModel();

            dataAccessLayer.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultErrorLayerRefModel FetchByDefaultErrorLayerName(string defaultErrorLayerName) {
            var dataAccessLayer = new CrudeDefaultErrorLayerRefData();
            var model = new CrudeDefaultErrorLayerRefModel();

            dataAccessLayer.FetchByDefaultErrorLayerName(defaultErrorLayerName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultErrorLayerRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultErrorLayerRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultErrorLayerRefModel> DataListToModelList(List<CrudeDefaultErrorLayerRefData> dataList) {
            var modelList = new List<CrudeDefaultErrorLayerRefModel>();

            foreach (CrudeDefaultErrorLayerRefData data in dataList) {
                var model = new CrudeDefaultErrorLayerRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultErrorLayerRefModel> modelList, List<CrudeDefaultErrorLayerRefData> dataList) {
            foreach (CrudeDefaultErrorLayerRefModel model in modelList) {
                var data = new CrudeDefaultErrorLayerRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultErrorLayerRefModel> FetchAll() {
            var list = new List<CrudeDefaultErrorLayerRefModel>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAll();

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRefBusiness in dataList) {
                var model = new CrudeDefaultErrorLayerRefModel();
                DataToModel(crudeDefaultErrorLayerRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorLayerRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultErrorLayerRefModel>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRefBusiness in dataList) {
                var model = new CrudeDefaultErrorLayerRefModel();
                DataToModel(crudeDefaultErrorLayerRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorLayerRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultErrorLayerRefModel>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRefBusiness in dataList) {
                var model = new CrudeDefaultErrorLayerRefModel();
                DataToModel(crudeDefaultErrorLayerRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultErrorLayerRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultErrorLayerRefModel> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorLayerRefModel>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchWithFilter(defaultErrorLayerRcd,defaultErrorLayerName,defaultUserId,dateTime);

            foreach (CrudeDefaultErrorLayerRefData data in dataList) {
                var crudeDefaultErrorLayerRefBusinessModel = new CrudeDefaultErrorLayerRefModel();
                DataToModel(data, crudeDefaultErrorLayerRefBusinessModel);
                list.Add(crudeDefaultErrorLayerRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultErrorLayerRefModel model) {
            var data = new CrudeDefaultErrorLayerRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultErrorLayerRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorLayerRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultErrorLayerRefModel model) {
            var data = new CrudeDefaultErrorLayerRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultErrorLayerRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorLayerRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultErrorLayerRcd) {
            CrudeDefaultErrorLayerRefData.Delete(defaultErrorLayerRcd);
        }
        
        public static void ModelToData(CrudeDefaultErrorLayerRefModel model, CrudeDefaultErrorLayerRefData data) {
            data.DefaultErrorLayerRcd = model.DefaultErrorLayerRcd;
            data.DefaultErrorLayerName = model.DefaultErrorLayerName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultErrorLayerRefData data, CrudeDefaultErrorLayerRefModel model) {
            model.DefaultErrorLayerRcd = data.DefaultErrorLayerRcd;
            model.DefaultErrorLayerName = data.DefaultErrorLayerName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
