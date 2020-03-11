/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:37:34 PM
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
    
    
    public partial class CrudeDefaultStateRefBusiness {
        
        public CrudeDefaultStateRefModel FetchByDefaultStateRcd(string defaultStateRcd) {
            var dataAccessLayer = new CrudeDefaultStateRefData();
            var model = new CrudeDefaultStateRefModel();

            dataAccessLayer.FetchByDefaultStateRcd(defaultStateRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultStateRefModel FetchByDefaultStateName(string defaultStateName) {
            var dataAccessLayer = new CrudeDefaultStateRefData();
            var model = new CrudeDefaultStateRefModel();

            dataAccessLayer.FetchByDefaultStateName(defaultStateName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultStateRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultStateRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultStateRefModel> DataListToModelList(List<CrudeDefaultStateRefData> dataList) {
            var modelList = new List<CrudeDefaultStateRefModel>();

            foreach (CrudeDefaultStateRefData data in dataList) {
                var model = new CrudeDefaultStateRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultStateRefModel> modelList, List<CrudeDefaultStateRefData> dataList) {
            foreach (CrudeDefaultStateRefModel model in modelList) {
                var data = new CrudeDefaultStateRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultStateRefModel> FetchAll() {
            var list = new List<CrudeDefaultStateRefModel>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAll();

            foreach (CrudeDefaultStateRefData crudeDefaultStateRefBusiness in dataList) {
                var model = new CrudeDefaultStateRefModel();
                DataToModel(crudeDefaultStateRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultStateRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultStateRefModel>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultStateRefData crudeDefaultStateRefBusiness in dataList) {
                var model = new CrudeDefaultStateRefModel();
                DataToModel(crudeDefaultStateRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultStateRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultStateRefModel>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultStateRefData crudeDefaultStateRefBusiness in dataList) {
                var model = new CrudeDefaultStateRefModel();
                DataToModel(crudeDefaultStateRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultStateRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultStateRefModel> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultStateRefModel>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchWithFilter(defaultStateRcd,defaultStateName,defaultUserId,dateTime);

            foreach (CrudeDefaultStateRefData data in dataList) {
                var crudeDefaultStateRefBusinessModel = new CrudeDefaultStateRefModel();
                DataToModel(data, crudeDefaultStateRefBusinessModel);
                list.Add(crudeDefaultStateRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultStateRefModel model) {
            var data = new CrudeDefaultStateRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultStateRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultStateRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultStateRefModel model) {
            var data = new CrudeDefaultStateRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultStateRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultStateRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultStateRcd) {
            CrudeDefaultStateRefData.Delete(defaultStateRcd);
        }
        
        public static void ModelToData(CrudeDefaultStateRefModel model, CrudeDefaultStateRefData data) {
            data.DefaultStateRcd = model.DefaultStateRcd;
            data.DefaultStateName = model.DefaultStateName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultStateRefData data, CrudeDefaultStateRefModel model) {
            model.DefaultStateRcd = data.DefaultStateRcd;
            model.DefaultStateName = data.DefaultStateName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
