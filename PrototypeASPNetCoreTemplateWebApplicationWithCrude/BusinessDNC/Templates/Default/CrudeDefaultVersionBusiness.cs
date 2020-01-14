/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:25 PM
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
    
    
    public partial class CrudeDefaultVersionBusiness {
        
        public CrudeDefaultVersionModel FetchByDefaultVersionId(System.Guid defaultVersionId) {
            var dataAccessLayer = new CrudeDefaultVersionData();
            var model = new CrudeDefaultVersionModel();

            dataAccessLayer.FetchByDefaultVersionId(defaultVersionId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultVersionModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultVersionData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultVersionModel> DataListToModelList(List<CrudeDefaultVersionData> dataList) {
            var modelList = new List<CrudeDefaultVersionModel>();

            foreach (CrudeDefaultVersionData data in dataList) {
                var model = new CrudeDefaultVersionModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultVersionModel> modelList, List<CrudeDefaultVersionData> dataList) {
            foreach (CrudeDefaultVersionModel model in modelList) {
                var data = new CrudeDefaultVersionData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultVersionModel> FetchAll() {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAll();

            foreach (CrudeDefaultVersionData crudeDefaultVersionBusiness in dataList) {
                var model = new CrudeDefaultVersionModel();
                DataToModel(crudeDefaultVersionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultVersionModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultVersionData crudeDefaultVersionBusiness in dataList) {
                var model = new CrudeDefaultVersionModel();
                DataToModel(crudeDefaultVersionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultVersionModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultVersionData crudeDefaultVersionBusiness in dataList) {
                var model = new CrudeDefaultVersionModel();
                DataToModel(crudeDefaultVersionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultVersionData.FetchAllCount();

        }
        
        public List<CrudeDefaultVersionModel> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchWithFilter(defaultVersionId,funVersion,number,majorNumber,minorNumber,sequenceNumber,defaultUserId,dateTime);

            foreach (CrudeDefaultVersionData data in dataList) {
                var crudeDefaultVersionBusinessModel = new CrudeDefaultVersionModel();
                DataToModel(data, crudeDefaultVersionBusinessModel);
                list.Add(crudeDefaultVersionBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultVersionModel model) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultVersionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultVersionModel model) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultVersionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultVersionId) {
            CrudeDefaultVersionData.Delete(defaultVersionId);
        }
        
        public static void ModelToData(CrudeDefaultVersionModel model, CrudeDefaultVersionData data) {
            data.DefaultVersionId = model.DefaultVersionId;
            data.FunVersion = model.FunVersion;
            data.Number = model.Number;
            data.MajorNumber = model.MajorNumber;
            data.MinorNumber = model.MinorNumber;
            data.SequenceNumber = model.SequenceNumber;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultVersionData data, CrudeDefaultVersionModel model) {
            model.DefaultVersionId = data.DefaultVersionId;
            model.FunVersion = data.FunVersion;
            model.Number = data.Number;
            model.MajorNumber = data.MajorNumber;
            model.MinorNumber = data.MinorNumber;
            model.SequenceNumber = data.SequenceNumber;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
