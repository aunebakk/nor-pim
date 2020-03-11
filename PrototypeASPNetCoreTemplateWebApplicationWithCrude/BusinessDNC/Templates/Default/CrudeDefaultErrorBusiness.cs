/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:21:28 PM
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
    
    
    public partial class CrudeDefaultErrorBusiness {
        
        public CrudeDefaultErrorModel FetchByDefaultErrorId(System.Guid defaultErrorId) {
            var dataAccessLayer = new CrudeDefaultErrorData();
            var model = new CrudeDefaultErrorModel();

            dataAccessLayer.FetchByDefaultErrorId(defaultErrorId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultErrorModel FetchByMethodName(string methodName) {
            var dataAccessLayer = new CrudeDefaultErrorData();
            var model = new CrudeDefaultErrorModel();

            dataAccessLayer.FetchByMethodName(methodName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultErrorModel> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            return DataListToModelList(CrudeDefaultErrorData.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd));
        }
        
        public List<CrudeDefaultErrorModel> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            return DataListToModelList(CrudeDefaultErrorData.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd));
        }
        
        public List<CrudeDefaultErrorModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultErrorData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultErrorModel> DataListToModelList(List<CrudeDefaultErrorData> dataList) {
            var modelList = new List<CrudeDefaultErrorModel>();

            foreach (CrudeDefaultErrorData data in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultErrorModel> modelList, List<CrudeDefaultErrorData> dataList) {
            foreach (CrudeDefaultErrorModel model in modelList) {
                var data = new CrudeDefaultErrorData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultErrorModel> FetchAll() {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAll();

            foreach (CrudeDefaultErrorData crudeDefaultErrorBusiness in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(crudeDefaultErrorBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultErrorData crudeDefaultErrorBusiness in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(crudeDefaultErrorBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultErrorData crudeDefaultErrorBusiness in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(crudeDefaultErrorBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultErrorData.FetchAllCount();

        }
        
        public List<CrudeDefaultErrorModel> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchWithFilter(defaultErrorId,defaultErrorLayerRcd,defaultErrorTypeRcd,layerAddress,errorMessage,stackTrace,methodName,domainName,className,defaultUserId,dateTime);

            foreach (CrudeDefaultErrorData data in dataList) {
                var crudeDefaultErrorBusinessModel = new CrudeDefaultErrorModel();
                DataToModel(data, crudeDefaultErrorBusinessModel);
                list.Add(crudeDefaultErrorBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultErrorModel model) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultErrorModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultErrorModel model) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultErrorModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultErrorId) {
            CrudeDefaultErrorData.Delete(defaultErrorId);
        }
        
        public static void ModelToData(CrudeDefaultErrorModel model, CrudeDefaultErrorData data) {
            data.DefaultErrorId = model.DefaultErrorId;
            data.DefaultErrorLayerRcd = model.DefaultErrorLayerRcd;
            data.DefaultErrorTypeRcd = model.DefaultErrorTypeRcd;
            data.LayerAddress = model.LayerAddress;
            data.ErrorMessage = model.ErrorMessage;
            data.StackTrace = model.StackTrace;
            data.MethodName = model.MethodName;
            data.DomainName = model.DomainName;
            data.ClassName = model.ClassName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultErrorData data, CrudeDefaultErrorModel model) {
            model.DefaultErrorId = data.DefaultErrorId;
            model.DefaultErrorLayerRcd = data.DefaultErrorLayerRcd;
            model.DefaultErrorTypeRcd = data.DefaultErrorTypeRcd;
            model.LayerAddress = data.LayerAddress;
            model.ErrorMessage = data.ErrorMessage;
            model.StackTrace = data.StackTrace;
            model.MethodName = data.MethodName;
            model.DomainName = data.DomainName;
            model.ClassName = data.ClassName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
