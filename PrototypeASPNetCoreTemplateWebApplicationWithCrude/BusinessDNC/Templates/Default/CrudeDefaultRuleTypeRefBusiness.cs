/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
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
    
    
    public partial class CrudeDefaultRuleTypeRefBusiness {
        
        public CrudeDefaultRuleTypeRefModel FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            var dataAccessLayer = new CrudeDefaultRuleTypeRefData();
            var model = new CrudeDefaultRuleTypeRefModel();

            dataAccessLayer.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultRuleTypeRefModel FetchByDefaultRuleTypeName(string defaultRuleTypeName) {
            var dataAccessLayer = new CrudeDefaultRuleTypeRefData();
            var model = new CrudeDefaultRuleTypeRefModel();

            dataAccessLayer.FetchByDefaultRuleTypeName(defaultRuleTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultRuleTypeRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultRuleTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultRuleTypeRefModel> DataListToModelList(List<CrudeDefaultRuleTypeRefData> dataList) {
            var modelList = new List<CrudeDefaultRuleTypeRefModel>();

            foreach (CrudeDefaultRuleTypeRefData data in dataList) {
                var model = new CrudeDefaultRuleTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultRuleTypeRefModel> modelList, List<CrudeDefaultRuleTypeRefData> dataList) {
            foreach (CrudeDefaultRuleTypeRefModel model in modelList) {
                var data = new CrudeDefaultRuleTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultRuleTypeRefModel> FetchAll() {
            var list = new List<CrudeDefaultRuleTypeRefModel>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAll();

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRefBusiness in dataList) {
                var model = new CrudeDefaultRuleTypeRefModel();
                DataToModel(crudeDefaultRuleTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultRuleTypeRefModel>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRefBusiness in dataList) {
                var model = new CrudeDefaultRuleTypeRefModel();
                DataToModel(crudeDefaultRuleTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultRuleTypeRefModel>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRefBusiness in dataList) {
                var model = new CrudeDefaultRuleTypeRefModel();
                DataToModel(crudeDefaultRuleTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultRuleTypeRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultRuleTypeRefModel> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultRuleTypeRefModel>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchWithFilter(defaultRuleTypeRcd,defaultRuleTypeName,defaultUserId,dateTime);

            foreach (CrudeDefaultRuleTypeRefData data in dataList) {
                var crudeDefaultRuleTypeRefBusinessModel = new CrudeDefaultRuleTypeRefModel();
                DataToModel(data, crudeDefaultRuleTypeRefBusinessModel);
                list.Add(crudeDefaultRuleTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultRuleTypeRefModel model) {
            var data = new CrudeDefaultRuleTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultRuleTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultRuleTypeRefModel model) {
            var data = new CrudeDefaultRuleTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultRuleTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultRuleTypeRcd) {
            CrudeDefaultRuleTypeRefData.Delete(defaultRuleTypeRcd);
        }
        
        public static void ModelToData(CrudeDefaultRuleTypeRefModel model, CrudeDefaultRuleTypeRefData data) {
            data.DefaultRuleTypeRcd = model.DefaultRuleTypeRcd;
            data.DefaultRuleTypeName = model.DefaultRuleTypeName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultRuleTypeRefData data, CrudeDefaultRuleTypeRefModel model) {
            model.DefaultRuleTypeRcd = data.DefaultRuleTypeRcd;
            model.DefaultRuleTypeName = data.DefaultRuleTypeName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
