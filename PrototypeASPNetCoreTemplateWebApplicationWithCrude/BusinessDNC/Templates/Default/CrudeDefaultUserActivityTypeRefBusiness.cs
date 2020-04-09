/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:49 AM
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
    
    
    public partial class CrudeDefaultUserActivityTypeRefBusiness {
        
        public CrudeDefaultUserActivityTypeRefModel FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            var dataAccessLayer = new CrudeDefaultUserActivityTypeRefData();
            var model = new CrudeDefaultUserActivityTypeRefModel();

            dataAccessLayer.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultUserActivityTypeRefModel FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName) {
            var dataAccessLayer = new CrudeDefaultUserActivityTypeRefData();
            var model = new CrudeDefaultUserActivityTypeRefModel();

            dataAccessLayer.FetchByDefaultUserActivityTypeName(defaultUserActivityTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultUserActivityTypeRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultUserActivityTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultUserActivityTypeRefModel> DataListToModelList(List<CrudeDefaultUserActivityTypeRefData> dataList) {
            var modelList = new List<CrudeDefaultUserActivityTypeRefModel>();

            foreach (CrudeDefaultUserActivityTypeRefData data in dataList) {
                var model = new CrudeDefaultUserActivityTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultUserActivityTypeRefModel> modelList, List<CrudeDefaultUserActivityTypeRefData> dataList) {
            foreach (CrudeDefaultUserActivityTypeRefModel model in modelList) {
                var data = new CrudeDefaultUserActivityTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultUserActivityTypeRefModel> FetchAll() {
            var list = new List<CrudeDefaultUserActivityTypeRefModel>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAll();

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRefBusiness in dataList) {
                var model = new CrudeDefaultUserActivityTypeRefModel();
                DataToModel(crudeDefaultUserActivityTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultUserActivityTypeRefModel>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRefBusiness in dataList) {
                var model = new CrudeDefaultUserActivityTypeRefModel();
                DataToModel(crudeDefaultUserActivityTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultUserActivityTypeRefModel>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRefBusiness in dataList) {
                var model = new CrudeDefaultUserActivityTypeRefModel();
                DataToModel(crudeDefaultUserActivityTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultUserActivityTypeRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultUserActivityTypeRefModel> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultUserActivityTypeRefModel>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchWithFilter(defaultUserActivityTypeRcd,defaultUserActivityTypeName,defaultUserId,dateTime);

            foreach (CrudeDefaultUserActivityTypeRefData data in dataList) {
                var crudeDefaultUserActivityTypeRefBusinessModel = new CrudeDefaultUserActivityTypeRefModel();
                DataToModel(data, crudeDefaultUserActivityTypeRefBusinessModel);
                list.Add(crudeDefaultUserActivityTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultUserActivityTypeRefModel model) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultUserActivityTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultUserActivityTypeRefModel model) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultUserActivityTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultUserActivityTypeRcd) {
            CrudeDefaultUserActivityTypeRefData.Delete(defaultUserActivityTypeRcd);
        }
        
        public static void ModelToData(CrudeDefaultUserActivityTypeRefModel model, CrudeDefaultUserActivityTypeRefData data) {
            data.DefaultUserActivityTypeRcd = model.DefaultUserActivityTypeRcd;
            data.DefaultUserActivityTypeName = model.DefaultUserActivityTypeName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultUserActivityTypeRefData data, CrudeDefaultUserActivityTypeRefModel model) {
            model.DefaultUserActivityTypeRcd = data.DefaultUserActivityTypeRcd;
            model.DefaultUserActivityTypeName = data.DefaultUserActivityTypeName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
