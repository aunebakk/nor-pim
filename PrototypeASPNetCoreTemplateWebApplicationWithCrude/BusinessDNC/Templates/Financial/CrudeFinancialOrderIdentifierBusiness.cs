/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:26 PM
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
    
    
    public partial class CrudeFinancialOrderIdentifierBusiness {
        
        public CrudeFinancialOrderIdentifierModel FetchByFinancialOrderIdentifierId(System.Guid financialOrderIdentifierId) {
            var dataAccessLayer = new CrudeFinancialOrderIdentifierData();
            var model = new CrudeFinancialOrderIdentifierModel();

            dataAccessLayer.FetchByFinancialOrderIdentifierId(financialOrderIdentifierId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderIdentifierModel> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToModelList(CrudeFinancialOrderIdentifierData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public List<CrudeFinancialOrderIdentifierModel> FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            return DataListToModelList(CrudeFinancialOrderIdentifierData.FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd));
        }
        
        public List<CrudeFinancialOrderIdentifierModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderIdentifierData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderIdentifierModel> DataListToModelList(List<CrudeFinancialOrderIdentifierData> dataList) {
            var modelList = new List<CrudeFinancialOrderIdentifierModel>();

            foreach (CrudeFinancialOrderIdentifierData data in dataList) {
                var model = new CrudeFinancialOrderIdentifierModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderIdentifierModel> modelList, List<CrudeFinancialOrderIdentifierData> dataList) {
            foreach (CrudeFinancialOrderIdentifierModel model in modelList) {
                var data = new CrudeFinancialOrderIdentifierData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderIdentifierModel> FetchAll() {
            var list = new List<CrudeFinancialOrderIdentifierModel>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchAll();

            foreach (CrudeFinancialOrderIdentifierData crudeFinancialOrderIdentifierBusiness in dataList) {
                var model = new CrudeFinancialOrderIdentifierModel();
                DataToModel(crudeFinancialOrderIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderIdentifierModel>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderIdentifierData crudeFinancialOrderIdentifierBusiness in dataList) {
                var model = new CrudeFinancialOrderIdentifierModel();
                DataToModel(crudeFinancialOrderIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderIdentifierModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderIdentifierModel>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderIdentifierData crudeFinancialOrderIdentifierBusiness in dataList) {
                var model = new CrudeFinancialOrderIdentifierModel();
                DataToModel(crudeFinancialOrderIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderIdentifierData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderIdentifierModel> FetchWithFilter(System.Guid financialOrderIdentifierId, System.Guid financialOrderId, string financialOrderIdentifierTypeRcd, string financialOrderIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderIdentifierModel>();
            List<CrudeFinancialOrderIdentifierData> dataList = CrudeFinancialOrderIdentifierData.FetchWithFilter(financialOrderIdentifierId,financialOrderId,financialOrderIdentifierTypeRcd,financialOrderIdentifierCode,userId,dateTime);

            foreach (CrudeFinancialOrderIdentifierData data in dataList) {
                var crudeFinancialOrderIdentifierBusinessModel = new CrudeFinancialOrderIdentifierModel();
                DataToModel(data, crudeFinancialOrderIdentifierBusinessModel);
                list.Add(crudeFinancialOrderIdentifierBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderIdentifierModel model) {
            var data = new CrudeFinancialOrderIdentifierData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderIdentifierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderIdentifierModel model) {
            var data = new CrudeFinancialOrderIdentifierData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderIdentifierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderIdentifierData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialOrderIdentifierId) {
            CrudeFinancialOrderIdentifierData.Delete(financialOrderIdentifierId);
        }
        
        public static void ModelToData(CrudeFinancialOrderIdentifierModel model, CrudeFinancialOrderIdentifierData data) {
            data.FinancialOrderIdentifierId = model.FinancialOrderIdentifierId;
            data.FinancialOrderId = model.FinancialOrderId;
            data.FinancialOrderIdentifierTypeRcd = model.FinancialOrderIdentifierTypeRcd;
            data.FinancialOrderIdentifierCode = model.FinancialOrderIdentifierCode;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeFinancialOrderIdentifierData data, CrudeFinancialOrderIdentifierModel model) {
            model.FinancialOrderIdentifierId = data.FinancialOrderIdentifierId;
            model.FinancialOrderId = data.FinancialOrderId;
            model.FinancialOrderIdentifierTypeRcd = data.FinancialOrderIdentifierTypeRcd;
            model.FinancialOrderIdentifierCode = data.FinancialOrderIdentifierCode;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
