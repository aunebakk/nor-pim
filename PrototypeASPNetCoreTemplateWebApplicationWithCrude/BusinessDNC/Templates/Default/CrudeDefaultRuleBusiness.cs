/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:11 PM
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
    
    
    public partial class CrudeDefaultRuleBusiness {
        
        public CrudeDefaultRuleModel FetchByDefaultRuleId(System.Guid defaultRuleId) {
            var dataAccessLayer = new CrudeDefaultRuleData();
            var model = new CrudeDefaultRuleModel();

            dataAccessLayer.FetchByDefaultRuleId(defaultRuleId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultRuleModel> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            return DataListToModelList(CrudeDefaultRuleData.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd));
        }
        
        public List<CrudeDefaultRuleModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultRuleData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultRuleModel> DataListToModelList(List<CrudeDefaultRuleData> dataList) {
            var modelList = new List<CrudeDefaultRuleModel>();

            foreach (CrudeDefaultRuleData data in dataList) {
                var model = new CrudeDefaultRuleModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultRuleModel> modelList, List<CrudeDefaultRuleData> dataList) {
            foreach (CrudeDefaultRuleModel model in modelList) {
                var data = new CrudeDefaultRuleData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultRuleModel> FetchAll() {
            var list = new List<CrudeDefaultRuleModel>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAll();

            foreach (CrudeDefaultRuleData crudeDefaultRuleBusiness in dataList) {
                var model = new CrudeDefaultRuleModel();
                DataToModel(crudeDefaultRuleBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultRuleModel>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultRuleData crudeDefaultRuleBusiness in dataList) {
                var model = new CrudeDefaultRuleModel();
                DataToModel(crudeDefaultRuleBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultRuleModel>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultRuleData crudeDefaultRuleBusiness in dataList) {
                var model = new CrudeDefaultRuleModel();
                DataToModel(crudeDefaultRuleBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultRuleData.FetchAllCount();

        }
        
        public List<CrudeDefaultRuleModel> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultRuleModel>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchWithFilter(defaultRuleId,defaultRuleTypeRcd,address,defaultUserId,dateTime);

            foreach (CrudeDefaultRuleData data in dataList) {
                var crudeDefaultRuleBusinessModel = new CrudeDefaultRuleModel();
                DataToModel(data, crudeDefaultRuleBusinessModel);
                list.Add(crudeDefaultRuleBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultRuleModel model) {
            var data = new CrudeDefaultRuleData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultRuleModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultRuleModel model) {
            var data = new CrudeDefaultRuleData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultRuleModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultRuleId) {
            CrudeDefaultRuleData.Delete(defaultRuleId);
        }
        
        public static void ModelToData(CrudeDefaultRuleModel model, CrudeDefaultRuleData data) {
            data.DefaultRuleId = model.DefaultRuleId;
            data.DefaultRuleTypeRcd = model.DefaultRuleTypeRcd;
            data.Address = model.Address;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultRuleData data, CrudeDefaultRuleModel model) {
            model.DefaultRuleId = data.DefaultRuleId;
            model.DefaultRuleTypeRcd = data.DefaultRuleTypeRcd;
            model.Address = data.Address;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
