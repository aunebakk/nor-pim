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
    
    
    public partial class CrudeClientLinkTypeRefBusiness {
        
        public CrudeClientLinkTypeRefModel FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            var dataAccessLayer = new CrudeClientLinkTypeRefData();
            var model = new CrudeClientLinkTypeRefModel();

            dataAccessLayer.FetchByClientLinkTypeRcd(clientLinkTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientLinkTypeRefModel FetchByClientLinkTypeName(string clientLinkTypeName) {
            var dataAccessLayer = new CrudeClientLinkTypeRefData();
            var model = new CrudeClientLinkTypeRefModel();

            dataAccessLayer.FetchByClientLinkTypeName(clientLinkTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientLinkTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientLinkTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientLinkTypeRefModel> DataListToModelList(List<CrudeClientLinkTypeRefData> dataList) {
            var modelList = new List<CrudeClientLinkTypeRefModel>();

            foreach (CrudeClientLinkTypeRefData data in dataList) {
                var model = new CrudeClientLinkTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientLinkTypeRefModel> modelList, List<CrudeClientLinkTypeRefData> dataList) {
            foreach (CrudeClientLinkTypeRefModel model in modelList) {
                var data = new CrudeClientLinkTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientLinkTypeRefModel> FetchAll() {
            var list = new List<CrudeClientLinkTypeRefModel>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAll();

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRefBusiness in dataList) {
                var model = new CrudeClientLinkTypeRefModel();
                DataToModel(crudeClientLinkTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientLinkTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientLinkTypeRefModel>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRefBusiness in dataList) {
                var model = new CrudeClientLinkTypeRefModel();
                DataToModel(crudeClientLinkTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientLinkTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientLinkTypeRefModel>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRefBusiness in dataList) {
                var model = new CrudeClientLinkTypeRefModel();
                DataToModel(crudeClientLinkTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientLinkTypeRefData.FetchAllCount();

        }
        
        public List<CrudeClientLinkTypeRefModel> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientLinkTypeRefModel>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchWithFilter(clientLinkTypeRcd,clientLinkTypeName,clientLinkTypeDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientLinkTypeRefData data in dataList) {
                var crudeClientLinkTypeRefBusinessModel = new CrudeClientLinkTypeRefModel();
                DataToModel(data, crudeClientLinkTypeRefBusinessModel);
                list.Add(crudeClientLinkTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientLinkTypeRefModel model) {
            var data = new CrudeClientLinkTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientLinkTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientLinkTypeRefModel model) {
            var data = new CrudeClientLinkTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientLinkTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientLinkTypeRcd) {
            CrudeClientLinkTypeRefData.Delete(clientLinkTypeRcd);
        }
        
        public static void ModelToData(CrudeClientLinkTypeRefModel model, CrudeClientLinkTypeRefData data) {
            data.ClientLinkTypeRcd = model.ClientLinkTypeRcd;
            data.ClientLinkTypeName = model.ClientLinkTypeName;
            data.ClientLinkTypeDescription = model.ClientLinkTypeDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientLinkTypeRefData data, CrudeClientLinkTypeRefModel model) {
            model.ClientLinkTypeRcd = data.ClientLinkTypeRcd;
            model.ClientLinkTypeName = data.ClientLinkTypeName;
            model.ClientLinkTypeDescription = data.ClientLinkTypeDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
