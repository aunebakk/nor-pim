/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:43 AM
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
    
    
    public partial class CrudeProductSupplierBusiness {
        
        public CrudeProductSupplierModel FetchByProductSupplierId(System.Guid productSupplierId) {
            var dataAccessLayer = new CrudeProductSupplierData();
            var model = new CrudeProductSupplierModel();

            dataAccessLayer.FetchByProductSupplierId(productSupplierId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductSupplierModel FetchBySupplierName(string supplierName) {
            var dataAccessLayer = new CrudeProductSupplierData();
            var model = new CrudeProductSupplierModel();

            dataAccessLayer.FetchBySupplierName(supplierName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductSupplierModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductSupplierData.FetchByProductId(productId));
        }
        
        public List<CrudeProductSupplierModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductSupplierData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductSupplierModel> DataListToModelList(List<CrudeProductSupplierData> dataList) {
            var modelList = new List<CrudeProductSupplierModel>();

            foreach (CrudeProductSupplierData data in dataList) {
                var model = new CrudeProductSupplierModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductSupplierModel> modelList, List<CrudeProductSupplierData> dataList) {
            foreach (CrudeProductSupplierModel model in modelList) {
                var data = new CrudeProductSupplierData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductSupplierModel> FetchAll() {
            var list = new List<CrudeProductSupplierModel>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAll();

            foreach (CrudeProductSupplierData crudeProductSupplierBusiness in dataList) {
                var model = new CrudeProductSupplierModel();
                DataToModel(crudeProductSupplierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductSupplierModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductSupplierModel>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductSupplierData crudeProductSupplierBusiness in dataList) {
                var model = new CrudeProductSupplierModel();
                DataToModel(crudeProductSupplierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductSupplierModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductSupplierModel>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductSupplierData crudeProductSupplierBusiness in dataList) {
                var model = new CrudeProductSupplierModel();
                DataToModel(crudeProductSupplierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductSupplierData.FetchAllCount();

        }
        
        public List<CrudeProductSupplierModel> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductSupplierModel>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchWithFilter(productSupplierId,productId,supplierName,userId,dateTime);

            foreach (CrudeProductSupplierData data in dataList) {
                var crudeProductSupplierBusinessModel = new CrudeProductSupplierModel();
                DataToModel(data, crudeProductSupplierBusinessModel);
                list.Add(crudeProductSupplierBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductSupplierModel model) {
            var data = new CrudeProductSupplierData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductSupplierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductSupplierData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductSupplierModel model) {
            var data = new CrudeProductSupplierData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductSupplierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductSupplierData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productSupplierId) {
            CrudeProductSupplierData.Delete(productSupplierId);
        }
        
        public static void ModelToData(CrudeProductSupplierModel model, CrudeProductSupplierData data) {
            data.ProductSupplierId = model.ProductSupplierId;
            data.ProductId = model.ProductId;
            data.SupplierName = model.SupplierName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductSupplierData data, CrudeProductSupplierModel model) {
            model.ProductSupplierId = data.ProductSupplierId;
            model.ProductId = data.ProductId;
            model.SupplierName = data.SupplierName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
