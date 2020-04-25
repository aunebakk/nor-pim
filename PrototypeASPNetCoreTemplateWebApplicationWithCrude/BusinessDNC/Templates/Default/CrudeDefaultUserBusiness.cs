/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:58 AM
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
    
    
    public partial class CrudeDefaultUserBusiness {
        
        public CrudeDefaultUserModel FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataAccessLayer = new CrudeDefaultUserData();
            var model = new CrudeDefaultUserModel();

            dataAccessLayer.FetchByDefaultUserId(defaultUserId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultUserModel FetchByDefaultUserName(string defaultUserName) {
            var dataAccessLayer = new CrudeDefaultUserData();
            var model = new CrudeDefaultUserModel();

            dataAccessLayer.FetchByDefaultUserName(defaultUserName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultUserModel> FetchByDefaultStateRcd(string defaultStateRcd) {
            return DataListToModelList(CrudeDefaultUserData.FetchByDefaultStateRcd(defaultStateRcd));
        }
        
        public List<CrudeDefaultUserModel> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId) {
            return DataListToModelList(CrudeDefaultUserData.FetchByCreatedByDefaultUserId(createdByDefaultUserId));
        }
        
        public static List<CrudeDefaultUserModel> DataListToModelList(List<CrudeDefaultUserData> dataList) {
            var modelList = new List<CrudeDefaultUserModel>();

            foreach (CrudeDefaultUserData data in dataList) {
                var model = new CrudeDefaultUserModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultUserModel> modelList, List<CrudeDefaultUserData> dataList) {
            foreach (CrudeDefaultUserModel model in modelList) {
                var data = new CrudeDefaultUserData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultUserModel> FetchAll() {
            var list = new List<CrudeDefaultUserModel>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAll();

            foreach (CrudeDefaultUserData crudeDefaultUserBusiness in dataList) {
                var model = new CrudeDefaultUserModel();
                DataToModel(crudeDefaultUserBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultUserModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultUserModel>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultUserData crudeDefaultUserBusiness in dataList) {
                var model = new CrudeDefaultUserModel();
                DataToModel(crudeDefaultUserBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultUserModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultUserModel>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultUserData crudeDefaultUserBusiness in dataList) {
                var model = new CrudeDefaultUserModel();
                DataToModel(crudeDefaultUserBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultUserData.FetchAllCount();

        }
        
        public List<CrudeDefaultUserModel> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            var list = new List<CrudeDefaultUserModel>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchWithFilter(defaultUserId,defaultUserCode,defaultUserName,email,password,defaultStateRcd,createdByDefaultUserId,dateTime,lastActivityDateTime);

            foreach (CrudeDefaultUserData data in dataList) {
                var crudeDefaultUserBusinessModel = new CrudeDefaultUserModel();
                DataToModel(data, crudeDefaultUserBusinessModel);
                list.Add(crudeDefaultUserBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultUserModel model) {
            var data = new CrudeDefaultUserData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultUserModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultUserModel model) {
            var data = new CrudeDefaultUserData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultUserModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultUserId) {
            CrudeDefaultUserData.Delete(defaultUserId);
        }
        
        public static void ModelToData(CrudeDefaultUserModel model, CrudeDefaultUserData data) {
            data.DefaultUserId = model.DefaultUserId;
            data.DefaultUserCode = model.DefaultUserCode;
            data.DefaultUserName = model.DefaultUserName;
            data.Email = model.Email;
            data.Password = model.Password;
            data.DefaultStateRcd = model.DefaultStateRcd;
            data.CreatedByDefaultUserId = model.CreatedByDefaultUserId;
            data.DateTime = model.DateTime;
            data.LastActivityDateTime = model.LastActivityDateTime;
        }
        
        public static void DataToModel(CrudeDefaultUserData data, CrudeDefaultUserModel model) {
            model.DefaultUserId = data.DefaultUserId;
            model.DefaultUserCode = data.DefaultUserCode;
            model.DefaultUserName = data.DefaultUserName;
            model.Email = data.Email;
            model.Password = data.Password;
            model.DefaultStateRcd = data.DefaultStateRcd;
            model.CreatedByDefaultUserId = data.CreatedByDefaultUserId;
            model.DateTime = data.DateTime;
            model.LastActivityDateTime = data.LastActivityDateTime;
        }
    }
}
