/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:48 AM
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
    
    
    public partial class CrudeDefaultSystemSettingBusiness {
        
        public CrudeDefaultSystemSettingModel FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            var dataAccessLayer = new CrudeDefaultSystemSettingData();
            var model = new CrudeDefaultSystemSettingModel();

            dataAccessLayer.FetchByDefaultSystemSettingId(defaultSystemSettingId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultSystemSettingModel> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            return DataListToModelList(CrudeDefaultSystemSettingData.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd));
        }
        
        public List<CrudeDefaultSystemSettingModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultSystemSettingData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultSystemSettingModel> DataListToModelList(List<CrudeDefaultSystemSettingData> dataList) {
            var modelList = new List<CrudeDefaultSystemSettingModel>();

            foreach (CrudeDefaultSystemSettingData data in dataList) {
                var model = new CrudeDefaultSystemSettingModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultSystemSettingModel> modelList, List<CrudeDefaultSystemSettingData> dataList) {
            foreach (CrudeDefaultSystemSettingModel model in modelList) {
                var data = new CrudeDefaultSystemSettingData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultSystemSettingModel> FetchAll() {
            var list = new List<CrudeDefaultSystemSettingModel>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchAll();

            foreach (CrudeDefaultSystemSettingData crudeDefaultSystemSettingBusiness in dataList) {
                var model = new CrudeDefaultSystemSettingModel();
                DataToModel(crudeDefaultSystemSettingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultSystemSettingModel>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultSystemSettingData crudeDefaultSystemSettingBusiness in dataList) {
                var model = new CrudeDefaultSystemSettingModel();
                DataToModel(crudeDefaultSystemSettingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultSystemSettingModel>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultSystemSettingData crudeDefaultSystemSettingBusiness in dataList) {
                var model = new CrudeDefaultSystemSettingModel();
                DataToModel(crudeDefaultSystemSettingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultSystemSettingData.FetchAllCount();

        }
        
        public List<CrudeDefaultSystemSettingModel> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemSettingModel>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchWithFilter(defaultSystemSettingId,defaultSystemSettingRcd,defaultSystemSettingValue,defaultUserId,dateTime);

            foreach (CrudeDefaultSystemSettingData data in dataList) {
                var crudeDefaultSystemSettingBusinessModel = new CrudeDefaultSystemSettingModel();
                DataToModel(data, crudeDefaultSystemSettingBusinessModel);
                list.Add(crudeDefaultSystemSettingBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultSystemSettingModel model) {
            var data = new CrudeDefaultSystemSettingData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultSystemSettingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultSystemSettingModel model) {
            var data = new CrudeDefaultSystemSettingData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultSystemSettingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultSystemSettingId) {
            CrudeDefaultSystemSettingData.Delete(defaultSystemSettingId);
        }
        
        public static void ModelToData(CrudeDefaultSystemSettingModel model, CrudeDefaultSystemSettingData data) {
            data.DefaultSystemSettingId = model.DefaultSystemSettingId;
            data.DefaultSystemSettingRcd = model.DefaultSystemSettingRcd;
            data.DefaultSystemSettingValue = model.DefaultSystemSettingValue;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultSystemSettingData data, CrudeDefaultSystemSettingModel model) {
            model.DefaultSystemSettingId = data.DefaultSystemSettingId;
            model.DefaultSystemSettingRcd = data.DefaultSystemSettingRcd;
            model.DefaultSystemSettingValue = data.DefaultSystemSettingValue;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
