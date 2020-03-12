/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:05 PM
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
    
    
    public partial class CrudeDefaultSystemReferenceTableBusiness {
        
        public CrudeDefaultSystemReferenceTableModel FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var model = new CrudeDefaultSystemReferenceTableModel();

            dataAccessLayer.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultSystemReferenceTableModel FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var model = new CrudeDefaultSystemReferenceTableModel();

            dataAccessLayer.FetchByDefaultSystemReferenceTableName(defaultSystemReferenceTableName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultSystemReferenceTableModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultSystemReferenceTableData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultSystemReferenceTableModel> DataListToModelList(List<CrudeDefaultSystemReferenceTableData> dataList) {
            var modelList = new List<CrudeDefaultSystemReferenceTableModel>();

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var model = new CrudeDefaultSystemReferenceTableModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultSystemReferenceTableModel> modelList, List<CrudeDefaultSystemReferenceTableData> dataList) {
            foreach (CrudeDefaultSystemReferenceTableModel model in modelList) {
                var data = new CrudeDefaultSystemReferenceTableData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultSystemReferenceTableModel> FetchAll() {
            var list = new List<CrudeDefaultSystemReferenceTableModel>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAll();

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTableBusiness in dataList) {
                var model = new CrudeDefaultSystemReferenceTableModel();
                DataToModel(crudeDefaultSystemReferenceTableBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemReferenceTableModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultSystemReferenceTableModel>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTableBusiness in dataList) {
                var model = new CrudeDefaultSystemReferenceTableModel();
                DataToModel(crudeDefaultSystemReferenceTableBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemReferenceTableModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultSystemReferenceTableModel>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTableBusiness in dataList) {
                var model = new CrudeDefaultSystemReferenceTableModel();
                DataToModel(crudeDefaultSystemReferenceTableBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultSystemReferenceTableData.FetchAllCount();

        }
        
        public List<CrudeDefaultSystemReferenceTableModel> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemReferenceTableModel>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchWithFilter(defaultSystemReferenceTableId,defaultSystemReferenceTableName,defaultSystemReferenceDisplayName,defaultUserId,dateTime);

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var crudeDefaultSystemReferenceTableBusinessModel = new CrudeDefaultSystemReferenceTableModel();
                DataToModel(data, crudeDefaultSystemReferenceTableBusinessModel);
                list.Add(crudeDefaultSystemReferenceTableBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultSystemReferenceTableModel model) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultSystemReferenceTableModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultSystemReferenceTableModel model) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultSystemReferenceTableModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultSystemReferenceTableId) {
            CrudeDefaultSystemReferenceTableData.Delete(defaultSystemReferenceTableId);
        }
        
        public static void ModelToData(CrudeDefaultSystemReferenceTableModel model, CrudeDefaultSystemReferenceTableData data) {
            data.DefaultSystemReferenceTableId = model.DefaultSystemReferenceTableId;
            data.DefaultSystemReferenceTableName = model.DefaultSystemReferenceTableName;
            data.DefaultSystemReferenceDisplayName = model.DefaultSystemReferenceDisplayName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultSystemReferenceTableData data, CrudeDefaultSystemReferenceTableModel model) {
            model.DefaultSystemReferenceTableId = data.DefaultSystemReferenceTableId;
            model.DefaultSystemReferenceTableName = data.DefaultSystemReferenceTableName;
            model.DefaultSystemReferenceDisplayName = data.DefaultSystemReferenceDisplayName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
