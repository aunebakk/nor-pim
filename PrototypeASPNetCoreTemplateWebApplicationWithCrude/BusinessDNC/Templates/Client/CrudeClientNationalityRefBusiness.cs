/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:03 PM
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
    
    
    public partial class CrudeClientNationalityRefBusiness {
        
        public CrudeClientNationalityRefModel FetchByClientNationalityRcd(string clientNationalityRcd) {
            var dataAccessLayer = new CrudeClientNationalityRefData();
            var model = new CrudeClientNationalityRefModel();

            dataAccessLayer.FetchByClientNationalityRcd(clientNationalityRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientNationalityRefModel FetchByClientNationalityName(string clientNationalityName) {
            var dataAccessLayer = new CrudeClientNationalityRefData();
            var model = new CrudeClientNationalityRefModel();

            dataAccessLayer.FetchByClientNationalityName(clientNationalityName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientNationalityRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientNationalityRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientNationalityRefModel> DataListToModelList(List<CrudeClientNationalityRefData> dataList) {
            var modelList = new List<CrudeClientNationalityRefModel>();

            foreach (CrudeClientNationalityRefData data in dataList) {
                var model = new CrudeClientNationalityRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientNationalityRefModel> modelList, List<CrudeClientNationalityRefData> dataList) {
            foreach (CrudeClientNationalityRefModel model in modelList) {
                var data = new CrudeClientNationalityRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientNationalityRefModel> FetchAll() {
            var list = new List<CrudeClientNationalityRefModel>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAll();

            foreach (CrudeClientNationalityRefData crudeClientNationalityRefBusiness in dataList) {
                var model = new CrudeClientNationalityRefModel();
                DataToModel(crudeClientNationalityRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientNationalityRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientNationalityRefModel>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientNationalityRefData crudeClientNationalityRefBusiness in dataList) {
                var model = new CrudeClientNationalityRefModel();
                DataToModel(crudeClientNationalityRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientNationalityRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientNationalityRefModel>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientNationalityRefData crudeClientNationalityRefBusiness in dataList) {
                var model = new CrudeClientNationalityRefModel();
                DataToModel(crudeClientNationalityRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientNationalityRefData.FetchAllCount();

        }
        
        public List<CrudeClientNationalityRefModel> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientNationalityRefModel>();
            List<CrudeClientNationalityRefData> dataList = CrudeClientNationalityRefData.FetchWithFilter(clientNationalityRcd,clientNationalityName,clientNationalityDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientNationalityRefData data in dataList) {
                var crudeClientNationalityRefBusinessModel = new CrudeClientNationalityRefModel();
                DataToModel(data, crudeClientNationalityRefBusinessModel);
                list.Add(crudeClientNationalityRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientNationalityRefModel model) {
            var data = new CrudeClientNationalityRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientNationalityRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientNationalityRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientNationalityRefModel model) {
            var data = new CrudeClientNationalityRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientNationalityRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientNationalityRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientNationalityRcd) {
            CrudeClientNationalityRefData.Delete(clientNationalityRcd);
        }
        
        public static void ModelToData(CrudeClientNationalityRefModel model, CrudeClientNationalityRefData data) {
            data.ClientNationalityRcd = model.ClientNationalityRcd;
            data.ClientNationalityName = model.ClientNationalityName;
            data.ClientNationalityDescription = model.ClientNationalityDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientNationalityRefData data, CrudeClientNationalityRefModel model) {
            model.ClientNationalityRcd = data.ClientNationalityRcd;
            model.ClientNationalityName = data.ClientNationalityName;
            model.ClientNationalityDescription = data.ClientNationalityDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
