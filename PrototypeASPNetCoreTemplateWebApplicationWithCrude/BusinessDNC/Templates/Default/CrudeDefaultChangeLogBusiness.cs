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
    
    
    public partial class CrudeDefaultChangeLogBusiness {
        
        public CrudeDefaultChangeLogModel FetchByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            var dataAccessLayer = new CrudeDefaultChangeLogData();
            var model = new CrudeDefaultChangeLogModel();

            dataAccessLayer.FetchByDefaultChangeLogId(defaultChangeLogId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultChangeLogModel FetchByDefaultChangeName(string defaultChangeName) {
            var dataAccessLayer = new CrudeDefaultChangeLogData();
            var model = new CrudeDefaultChangeLogModel();

            dataAccessLayer.FetchByDefaultChangeName(defaultChangeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultChangeLogModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultChangeLogData.FetchByDefaultUserId(defaultUserId));
        }
        
        public List<CrudeDefaultChangeLogModel> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            return DataListToModelList(CrudeDefaultChangeLogData.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd));
        }
        
        public List<CrudeDefaultChangeLogModel> FetchByDefaultIssueId(System.Guid defaultIssueId) {
            return DataListToModelList(CrudeDefaultChangeLogData.FetchByDefaultIssueId(defaultIssueId));
        }
        
        public static List<CrudeDefaultChangeLogModel> DataListToModelList(List<CrudeDefaultChangeLogData> dataList) {
            var modelList = new List<CrudeDefaultChangeLogModel>();

            foreach (CrudeDefaultChangeLogData data in dataList) {
                var model = new CrudeDefaultChangeLogModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultChangeLogModel> modelList, List<CrudeDefaultChangeLogData> dataList) {
            foreach (CrudeDefaultChangeLogModel model in modelList) {
                var data = new CrudeDefaultChangeLogData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultChangeLogModel> FetchAll() {
            var list = new List<CrudeDefaultChangeLogModel>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAll();

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLogBusiness in dataList) {
                var model = new CrudeDefaultChangeLogModel();
                DataToModel(crudeDefaultChangeLogBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultChangeLogModel>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLogBusiness in dataList) {
                var model = new CrudeDefaultChangeLogModel();
                DataToModel(crudeDefaultChangeLogBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultChangeLogModel>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLogBusiness in dataList) {
                var model = new CrudeDefaultChangeLogModel();
                DataToModel(crudeDefaultChangeLogBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultChangeLogData.FetchAllCount();

        }
        
        public List<CrudeDefaultChangeLogModel> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            var list = new List<CrudeDefaultChangeLogModel>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchWithFilter(defaultChangeLogId,defaultChangeName,defaultChangeDescription,defaultUserId,dateTime,defaultChangeLogTypeRcd,defaultIssueId);

            foreach (CrudeDefaultChangeLogData data in dataList) {
                var crudeDefaultChangeLogBusinessModel = new CrudeDefaultChangeLogModel();
                DataToModel(data, crudeDefaultChangeLogBusinessModel);
                list.Add(crudeDefaultChangeLogBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultChangeLogModel model) {
            var data = new CrudeDefaultChangeLogData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultChangeLogModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultChangeLogModel model) {
            var data = new CrudeDefaultChangeLogData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultChangeLogModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultChangeLogId) {
            CrudeDefaultChangeLogData.Delete(defaultChangeLogId);
        }
        
        public static void ModelToData(CrudeDefaultChangeLogModel model, CrudeDefaultChangeLogData data) {
            data.DefaultChangeLogId = model.DefaultChangeLogId;
            data.DefaultChangeName = model.DefaultChangeName;
            data.DefaultChangeDescription = model.DefaultChangeDescription;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
            data.DefaultChangeLogTypeRcd = model.DefaultChangeLogTypeRcd;
            data.DefaultIssueId = model.DefaultIssueId;
        }
        
        public static void DataToModel(CrudeDefaultChangeLogData data, CrudeDefaultChangeLogModel model) {
            model.DefaultChangeLogId = data.DefaultChangeLogId;
            model.DefaultChangeName = data.DefaultChangeName;
            model.DefaultChangeDescription = data.DefaultChangeDescription;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
            model.DefaultChangeLogTypeRcd = data.DefaultChangeLogTypeRcd;
            model.DefaultIssueId = data.DefaultIssueId;
        }
    }
}
