/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:21 AM
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
    
    
    public partial class CrudeDefaultErrorTypeRefBusiness {
        
        public CrudeDefaultErrorTypeRefModel FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            var dataAccessLayer = new CrudeDefaultErrorTypeRefData();
            var model = new CrudeDefaultErrorTypeRefModel();

            dataAccessLayer.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultErrorTypeRefModel FetchByDefaultErrorTypeName(string defaultErrorTypeName) {
            var dataAccessLayer = new CrudeDefaultErrorTypeRefData();
            var model = new CrudeDefaultErrorTypeRefModel();

            dataAccessLayer.FetchByDefaultErrorTypeName(defaultErrorTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultErrorTypeRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultErrorTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultErrorTypeRefModel> DataListToModelList(List<CrudeDefaultErrorTypeRefData> dataList) {
            var modelList = new List<CrudeDefaultErrorTypeRefModel>();

            foreach (CrudeDefaultErrorTypeRefData data in dataList) {
                var model = new CrudeDefaultErrorTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultErrorTypeRefModel> modelList, List<CrudeDefaultErrorTypeRefData> dataList) {
            foreach (CrudeDefaultErrorTypeRefModel model in modelList) {
                var data = new CrudeDefaultErrorTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultErrorTypeRefModel> FetchAll() {
            var list = new List<CrudeDefaultErrorTypeRefModel>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAll();

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRefBusiness in dataList) {
                var model = new CrudeDefaultErrorTypeRefModel();
                DataToModel(crudeDefaultErrorTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultErrorTypeRefModel>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRefBusiness in dataList) {
                var model = new CrudeDefaultErrorTypeRefModel();
                DataToModel(crudeDefaultErrorTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultErrorTypeRefModel>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRefBusiness in dataList) {
                var model = new CrudeDefaultErrorTypeRefModel();
                DataToModel(crudeDefaultErrorTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultErrorTypeRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultErrorTypeRefModel> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorTypeRefModel>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchWithFilter(defaultErrorTypeRcd,defaultErrorTypeName,defaultUserId,dateTime);

            foreach (CrudeDefaultErrorTypeRefData data in dataList) {
                var crudeDefaultErrorTypeRefBusinessModel = new CrudeDefaultErrorTypeRefModel();
                DataToModel(data, crudeDefaultErrorTypeRefBusinessModel);
                list.Add(crudeDefaultErrorTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultErrorTypeRefModel model) {
            var data = new CrudeDefaultErrorTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultErrorTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultErrorTypeRefModel model) {
            var data = new CrudeDefaultErrorTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultErrorTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultErrorTypeRcd) {
            CrudeDefaultErrorTypeRefData.Delete(defaultErrorTypeRcd);
        }
        
        public static void ModelToData(CrudeDefaultErrorTypeRefModel model, CrudeDefaultErrorTypeRefData data) {
            data.DefaultErrorTypeRcd = model.DefaultErrorTypeRcd;
            data.DefaultErrorTypeName = model.DefaultErrorTypeName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultErrorTypeRefData data, CrudeDefaultErrorTypeRefModel model) {
            model.DefaultErrorTypeRcd = data.DefaultErrorTypeRcd;
            model.DefaultErrorTypeName = data.DefaultErrorTypeName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
