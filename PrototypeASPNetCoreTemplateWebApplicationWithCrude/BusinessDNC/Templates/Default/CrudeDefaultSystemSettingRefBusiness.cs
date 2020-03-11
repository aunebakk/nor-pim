/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:37:36 PM
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
    
    
    public partial class CrudeDefaultSystemSettingRefBusiness {
        
        public CrudeDefaultSystemSettingRefModel FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            var dataAccessLayer = new CrudeDefaultSystemSettingRefData();
            var model = new CrudeDefaultSystemSettingRefModel();

            dataAccessLayer.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultSystemSettingRefModel FetchByDefaultSystemSettingName(string defaultSystemSettingName) {
            var dataAccessLayer = new CrudeDefaultSystemSettingRefData();
            var model = new CrudeDefaultSystemSettingRefModel();

            dataAccessLayer.FetchByDefaultSystemSettingName(defaultSystemSettingName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultSystemSettingRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultSystemSettingRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultSystemSettingRefModel> DataListToModelList(List<CrudeDefaultSystemSettingRefData> dataList) {
            var modelList = new List<CrudeDefaultSystemSettingRefModel>();

            foreach (CrudeDefaultSystemSettingRefData data in dataList) {
                var model = new CrudeDefaultSystemSettingRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultSystemSettingRefModel> modelList, List<CrudeDefaultSystemSettingRefData> dataList) {
            foreach (CrudeDefaultSystemSettingRefModel model in modelList) {
                var data = new CrudeDefaultSystemSettingRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultSystemSettingRefModel> FetchAll() {
            var list = new List<CrudeDefaultSystemSettingRefModel>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAll();

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRefBusiness in dataList) {
                var model = new CrudeDefaultSystemSettingRefModel();
                DataToModel(crudeDefaultSystemSettingRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultSystemSettingRefModel>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRefBusiness in dataList) {
                var model = new CrudeDefaultSystemSettingRefModel();
                DataToModel(crudeDefaultSystemSettingRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultSystemSettingRefModel>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRefBusiness in dataList) {
                var model = new CrudeDefaultSystemSettingRefModel();
                DataToModel(crudeDefaultSystemSettingRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultSystemSettingRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultSystemSettingRefModel> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemSettingRefModel>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchWithFilter(defaultSystemSettingRcd,defaultSystemSettingName,defaultUserId,dateTime);

            foreach (CrudeDefaultSystemSettingRefData data in dataList) {
                var crudeDefaultSystemSettingRefBusinessModel = new CrudeDefaultSystemSettingRefModel();
                DataToModel(data, crudeDefaultSystemSettingRefBusinessModel);
                list.Add(crudeDefaultSystemSettingRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultSystemSettingRefModel model) {
            var data = new CrudeDefaultSystemSettingRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultSystemSettingRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultSystemSettingRefModel model) {
            var data = new CrudeDefaultSystemSettingRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultSystemSettingRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultSystemSettingRcd) {
            CrudeDefaultSystemSettingRefData.Delete(defaultSystemSettingRcd);
        }
        
        public static void ModelToData(CrudeDefaultSystemSettingRefModel model, CrudeDefaultSystemSettingRefData data) {
            data.DefaultSystemSettingRcd = model.DefaultSystemSettingRcd;
            data.DefaultSystemSettingName = model.DefaultSystemSettingName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultSystemSettingRefData data, CrudeDefaultSystemSettingRefModel model) {
            model.DefaultSystemSettingRcd = data.DefaultSystemSettingRcd;
            model.DefaultSystemSettingName = data.DefaultSystemSettingName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
