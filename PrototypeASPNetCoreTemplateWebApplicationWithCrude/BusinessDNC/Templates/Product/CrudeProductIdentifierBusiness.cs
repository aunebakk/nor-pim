/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:30 AM
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
    
    
    public partial class CrudeProductIdentifierBusiness {
        
        public CrudeProductIdentifierModel FetchByProductIdentifierId(System.Guid productIdentifierId) {
            var dataAccessLayer = new CrudeProductIdentifierData();
            var model = new CrudeProductIdentifierModel();

            dataAccessLayer.FetchByProductIdentifierId(productIdentifierId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductIdentifierModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductIdentifierData.FetchByProductId(productId));
        }
        
        public List<CrudeProductIdentifierModel> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return DataListToModelList(CrudeProductIdentifierData.FetchByProductIdentifierRcd(productIdentifierRcd));
        }
        
        public List<CrudeProductIdentifierModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductIdentifierData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductIdentifierModel> DataListToModelList(List<CrudeProductIdentifierData> dataList) {
            var modelList = new List<CrudeProductIdentifierModel>();

            foreach (CrudeProductIdentifierData data in dataList) {
                var model = new CrudeProductIdentifierModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductIdentifierModel> modelList, List<CrudeProductIdentifierData> dataList) {
            foreach (CrudeProductIdentifierModel model in modelList) {
                var data = new CrudeProductIdentifierData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductIdentifierModel> FetchAll() {
            var list = new List<CrudeProductIdentifierModel>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchAll();

            foreach (CrudeProductIdentifierData crudeProductIdentifierBusiness in dataList) {
                var model = new CrudeProductIdentifierModel();
                DataToModel(crudeProductIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductIdentifierModel>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductIdentifierData crudeProductIdentifierBusiness in dataList) {
                var model = new CrudeProductIdentifierModel();
                DataToModel(crudeProductIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductIdentifierModel>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductIdentifierData crudeProductIdentifierBusiness in dataList) {
                var model = new CrudeProductIdentifierModel();
                DataToModel(crudeProductIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductIdentifierData.FetchAllCount();

        }
        
        public List<CrudeProductIdentifierModel> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductIdentifierModel>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchWithFilter(productIdentifierId,productId,productIdentifierRcd,identifier,userId,dateTime);

            foreach (CrudeProductIdentifierData data in dataList) {
                var crudeProductIdentifierBusinessModel = new CrudeProductIdentifierModel();
                DataToModel(data, crudeProductIdentifierBusinessModel);
                list.Add(crudeProductIdentifierBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductIdentifierModel model) {
            var data = new CrudeProductIdentifierData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductIdentifierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductIdentifierModel model) {
            var data = new CrudeProductIdentifierData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductIdentifierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productIdentifierId) {
            CrudeProductIdentifierData.Delete(productIdentifierId);
        }
        
        public static void ModelToData(CrudeProductIdentifierModel model, CrudeProductIdentifierData data) {
            data.ProductIdentifierId = model.ProductIdentifierId;
            data.ProductId = model.ProductId;
            data.ProductIdentifierRcd = model.ProductIdentifierRcd;
            data.Identifier = model.Identifier;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductIdentifierData data, CrudeProductIdentifierModel model) {
            model.ProductIdentifierId = data.ProductIdentifierId;
            model.ProductId = data.ProductId;
            model.ProductIdentifierRcd = data.ProductIdentifierRcd;
            model.Identifier = data.Identifier;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
