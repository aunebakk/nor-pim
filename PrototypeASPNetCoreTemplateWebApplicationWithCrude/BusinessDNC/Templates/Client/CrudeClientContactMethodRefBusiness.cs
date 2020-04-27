/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:10 PM
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
    
    
    public partial class CrudeClientContactMethodRefBusiness {
        
        public CrudeClientContactMethodRefModel FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            var dataAccessLayer = new CrudeClientContactMethodRefData();
            var model = new CrudeClientContactMethodRefModel();

            dataAccessLayer.FetchByClientContactMethodRcd(clientContactMethodRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientContactMethodRefModel FetchByClientContactMethodName(string clientContactMethodName) {
            var dataAccessLayer = new CrudeClientContactMethodRefData();
            var model = new CrudeClientContactMethodRefModel();

            dataAccessLayer.FetchByClientContactMethodName(clientContactMethodName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientContactMethodRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientContactMethodRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientContactMethodRefModel> DataListToModelList(List<CrudeClientContactMethodRefData> dataList) {
            var modelList = new List<CrudeClientContactMethodRefModel>();

            foreach (CrudeClientContactMethodRefData data in dataList) {
                var model = new CrudeClientContactMethodRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientContactMethodRefModel> modelList, List<CrudeClientContactMethodRefData> dataList) {
            foreach (CrudeClientContactMethodRefModel model in modelList) {
                var data = new CrudeClientContactMethodRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientContactMethodRefModel> FetchAll() {
            var list = new List<CrudeClientContactMethodRefModel>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAll();

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRefBusiness in dataList) {
                var model = new CrudeClientContactMethodRefModel();
                DataToModel(crudeClientContactMethodRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientContactMethodRefModel>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRefBusiness in dataList) {
                var model = new CrudeClientContactMethodRefModel();
                DataToModel(crudeClientContactMethodRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientContactMethodRefModel>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRefBusiness in dataList) {
                var model = new CrudeClientContactMethodRefModel();
                DataToModel(crudeClientContactMethodRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientContactMethodRefData.FetchAllCount();

        }
        
        public List<CrudeClientContactMethodRefModel> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContactMethodRefModel>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchWithFilter(clientContactMethodRcd,clientContactMethodName,clientContactMethodDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientContactMethodRefData data in dataList) {
                var crudeClientContactMethodRefBusinessModel = new CrudeClientContactMethodRefModel();
                DataToModel(data, crudeClientContactMethodRefBusinessModel);
                list.Add(crudeClientContactMethodRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientContactMethodRefModel model) {
            var data = new CrudeClientContactMethodRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientContactMethodRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientContactMethodRefModel model) {
            var data = new CrudeClientContactMethodRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientContactMethodRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientContactMethodRcd) {
            CrudeClientContactMethodRefData.Delete(clientContactMethodRcd);
        }
        
        public static void ModelToData(CrudeClientContactMethodRefModel model, CrudeClientContactMethodRefData data) {
            data.ClientContactMethodRcd = model.ClientContactMethodRcd;
            data.ClientContactMethodName = model.ClientContactMethodName;
            data.ClientContactMethodDescription = model.ClientContactMethodDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientContactMethodRefData data, CrudeClientContactMethodRefModel model) {
            model.ClientContactMethodRcd = data.ClientContactMethodRcd;
            model.ClientContactMethodName = data.ClientContactMethodName;
            model.ClientContactMethodDescription = data.ClientContactMethodDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
