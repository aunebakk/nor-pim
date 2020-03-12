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
    
    
    public partial class CrudeClientTitleRefBusiness {
        
        public CrudeClientTitleRefModel FetchByClientTitleRcd(string clientTitleRcd) {
            var dataAccessLayer = new CrudeClientTitleRefData();
            var model = new CrudeClientTitleRefModel();

            dataAccessLayer.FetchByClientTitleRcd(clientTitleRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientTitleRefModel FetchByClientTitleName(string clientTitleName) {
            var dataAccessLayer = new CrudeClientTitleRefData();
            var model = new CrudeClientTitleRefModel();

            dataAccessLayer.FetchByClientTitleName(clientTitleName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientTitleRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientTitleRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientTitleRefModel> DataListToModelList(List<CrudeClientTitleRefData> dataList) {
            var modelList = new List<CrudeClientTitleRefModel>();

            foreach (CrudeClientTitleRefData data in dataList) {
                var model = new CrudeClientTitleRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientTitleRefModel> modelList, List<CrudeClientTitleRefData> dataList) {
            foreach (CrudeClientTitleRefModel model in modelList) {
                var data = new CrudeClientTitleRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientTitleRefModel> FetchAll() {
            var list = new List<CrudeClientTitleRefModel>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAll();

            foreach (CrudeClientTitleRefData crudeClientTitleRefBusiness in dataList) {
                var model = new CrudeClientTitleRefModel();
                DataToModel(crudeClientTitleRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientTitleRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientTitleRefModel>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientTitleRefData crudeClientTitleRefBusiness in dataList) {
                var model = new CrudeClientTitleRefModel();
                DataToModel(crudeClientTitleRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientTitleRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientTitleRefModel>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientTitleRefData crudeClientTitleRefBusiness in dataList) {
                var model = new CrudeClientTitleRefModel();
                DataToModel(crudeClientTitleRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientTitleRefData.FetchAllCount();

        }
        
        public List<CrudeClientTitleRefModel> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientTitleRefModel>();
            List<CrudeClientTitleRefData> dataList = CrudeClientTitleRefData.FetchWithFilter(clientTitleRcd,clientTitleName,clientTitleDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientTitleRefData data in dataList) {
                var crudeClientTitleRefBusinessModel = new CrudeClientTitleRefModel();
                DataToModel(data, crudeClientTitleRefBusinessModel);
                list.Add(crudeClientTitleRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientTitleRefModel model) {
            var data = new CrudeClientTitleRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientTitleRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTitleRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientTitleRefModel model) {
            var data = new CrudeClientTitleRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientTitleRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTitleRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientTitleRcd) {
            CrudeClientTitleRefData.Delete(clientTitleRcd);
        }
        
        public static void ModelToData(CrudeClientTitleRefModel model, CrudeClientTitleRefData data) {
            data.ClientTitleRcd = model.ClientTitleRcd;
            data.ClientTitleName = model.ClientTitleName;
            data.ClientTitleDescription = model.ClientTitleDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientTitleRefData data, CrudeClientTitleRefModel model) {
            model.ClientTitleRcd = data.ClientTitleRcd;
            model.ClientTitleName = data.ClientTitleName;
            model.ClientTitleDescription = data.ClientTitleDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
