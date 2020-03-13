/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:45 AM
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
    
    
    public partial class CrudeClientGenderRefBusiness {
        
        public CrudeClientGenderRefModel FetchByClientGenderRcd(string clientGenderRcd) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var model = new CrudeClientGenderRefModel();

            dataAccessLayer.FetchByClientGenderRcd(clientGenderRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientGenderRefModel FetchByClientGenderName(string clientGenderName) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var model = new CrudeClientGenderRefModel();

            dataAccessLayer.FetchByClientGenderName(clientGenderName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientGenderRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientGenderRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientGenderRefModel> DataListToModelList(List<CrudeClientGenderRefData> dataList) {
            var modelList = new List<CrudeClientGenderRefModel>();

            foreach (CrudeClientGenderRefData data in dataList) {
                var model = new CrudeClientGenderRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientGenderRefModel> modelList, List<CrudeClientGenderRefData> dataList) {
            foreach (CrudeClientGenderRefModel model in modelList) {
                var data = new CrudeClientGenderRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientGenderRefModel> FetchAll() {
            var list = new List<CrudeClientGenderRefModel>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAll();

            foreach (CrudeClientGenderRefData crudeClientGenderRefBusiness in dataList) {
                var model = new CrudeClientGenderRefModel();
                DataToModel(crudeClientGenderRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientGenderRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientGenderRefModel>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientGenderRefData crudeClientGenderRefBusiness in dataList) {
                var model = new CrudeClientGenderRefModel();
                DataToModel(crudeClientGenderRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientGenderRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientGenderRefModel>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientGenderRefData crudeClientGenderRefBusiness in dataList) {
                var model = new CrudeClientGenderRefModel();
                DataToModel(crudeClientGenderRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientGenderRefData.FetchAllCount();

        }
        
        public List<CrudeClientGenderRefModel> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientGenderRefModel>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchWithFilter(clientGenderRcd,clientGenderName,clientGenderDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientGenderRefData data in dataList) {
                var crudeClientGenderRefBusinessModel = new CrudeClientGenderRefModel();
                DataToModel(data, crudeClientGenderRefBusinessModel);
                list.Add(crudeClientGenderRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientGenderRefModel model) {
            var data = new CrudeClientGenderRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientGenderRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientGenderRefModel model) {
            var data = new CrudeClientGenderRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientGenderRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientGenderRcd) {
            CrudeClientGenderRefData.Delete(clientGenderRcd);
        }
        
        public static void ModelToData(CrudeClientGenderRefModel model, CrudeClientGenderRefData data) {
            data.ClientGenderRcd = model.ClientGenderRcd;
            data.ClientGenderName = model.ClientGenderName;
            data.ClientGenderDescription = model.ClientGenderDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientGenderRefData data, CrudeClientGenderRefModel model) {
            model.ClientGenderRcd = data.ClientGenderRcd;
            model.ClientGenderName = data.ClientGenderName;
            model.ClientGenderDescription = data.ClientGenderDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
