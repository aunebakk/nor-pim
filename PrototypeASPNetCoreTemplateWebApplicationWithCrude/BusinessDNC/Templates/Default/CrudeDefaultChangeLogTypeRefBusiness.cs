/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:18 AM
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
    
    
    public partial class CrudeDefaultChangeLogTypeRefBusiness {
        
        public CrudeDefaultChangeLogTypeRefModel FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            var dataAccessLayer = new CrudeDefaultChangeLogTypeRefData();
            var model = new CrudeDefaultChangeLogTypeRefModel();

            dataAccessLayer.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultChangeLogTypeRefModel FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName) {
            var dataAccessLayer = new CrudeDefaultChangeLogTypeRefData();
            var model = new CrudeDefaultChangeLogTypeRefModel();

            dataAccessLayer.FetchByDefaultChangeLogTypeName(defaultChangeLogTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultChangeLogTypeRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultChangeLogTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultChangeLogTypeRefModel> DataListToModelList(List<CrudeDefaultChangeLogTypeRefData> dataList) {
            var modelList = new List<CrudeDefaultChangeLogTypeRefModel>();

            foreach (CrudeDefaultChangeLogTypeRefData data in dataList) {
                var model = new CrudeDefaultChangeLogTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultChangeLogTypeRefModel> modelList, List<CrudeDefaultChangeLogTypeRefData> dataList) {
            foreach (CrudeDefaultChangeLogTypeRefModel model in modelList) {
                var data = new CrudeDefaultChangeLogTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultChangeLogTypeRefModel> FetchAll() {
            var list = new List<CrudeDefaultChangeLogTypeRefModel>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAll();

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRefBusiness in dataList) {
                var model = new CrudeDefaultChangeLogTypeRefModel();
                DataToModel(crudeDefaultChangeLogTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultChangeLogTypeRefModel>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRefBusiness in dataList) {
                var model = new CrudeDefaultChangeLogTypeRefModel();
                DataToModel(crudeDefaultChangeLogTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultChangeLogTypeRefModel>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRefBusiness in dataList) {
                var model = new CrudeDefaultChangeLogTypeRefModel();
                DataToModel(crudeDefaultChangeLogTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultChangeLogTypeRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultChangeLogTypeRefModel> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultChangeLogTypeRefModel>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchWithFilter(defaultChangeLogTypeRcd,defaultChangeLogTypeName,defaultUserId,dateTime);

            foreach (CrudeDefaultChangeLogTypeRefData data in dataList) {
                var crudeDefaultChangeLogTypeRefBusinessModel = new CrudeDefaultChangeLogTypeRefModel();
                DataToModel(data, crudeDefaultChangeLogTypeRefBusinessModel);
                list.Add(crudeDefaultChangeLogTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultChangeLogTypeRefModel model) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultChangeLogTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultChangeLogTypeRefModel model) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultChangeLogTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultChangeLogTypeRcd) {
            CrudeDefaultChangeLogTypeRefData.Delete(defaultChangeLogTypeRcd);
        }
        
        public static void ModelToData(CrudeDefaultChangeLogTypeRefModel model, CrudeDefaultChangeLogTypeRefData data) {
            data.DefaultChangeLogTypeRcd = model.DefaultChangeLogTypeRcd;
            data.DefaultChangeLogTypeName = model.DefaultChangeLogTypeName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultChangeLogTypeRefData data, CrudeDefaultChangeLogTypeRefModel model) {
            model.DefaultChangeLogTypeRcd = data.DefaultChangeLogTypeRcd;
            model.DefaultChangeLogTypeName = data.DefaultChangeLogTypeName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
