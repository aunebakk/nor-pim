/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:36:53 PM
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public partial interface ICrudeProductExposePlanService {
        
        [OperationContract()]
        CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposePlanContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposePlanContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposePlanId);
    }
    
    public partial class CrudeProductExposePlanService : ICrudeProductExposePlanService {
        
        public CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId) {
            var dataAccessLayer = new CrudeProductExposePlanData();
            var contract = new CrudeProductExposePlanContract();

            dataAccessLayer.FetchByProductExposePlanId(productExposePlanId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductExposePlanContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductExposePlanData.FetchByProductId(productId));
        }
        
        public List<CrudeProductExposePlanContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposePlanData.FetchByUserId(userId));
        }
        
        public List<CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return DataListToContractList(CrudeProductExposePlanData.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd));
        }
        
        public static List<CrudeProductExposePlanContract> DataListToContractList(List<CrudeProductExposePlanData> dataList) {
            var contractList = new List<CrudeProductExposePlanContract>();

            foreach (CrudeProductExposePlanData data in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposePlanContract> contractList, List<CrudeProductExposePlanData> dataList) {
            foreach (CrudeProductExposePlanContract contract in contractList) {
                var data = new CrudeProductExposePlanData();
                CrudeProductExposePlanService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposePlanContract> FetchAll() {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAll();

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposePlanContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposePlanData.FetchAllCount();
        }
        
        public List<CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchWithFilter(
                productExposePlanId: productExposePlanId,
                productId: productId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposePlanData data in dataList) {
                var crudeProductExposePlanContract = new CrudeProductExposePlanContract();
                DataToContract(data, crudeProductExposePlanContract);
                list.Add(crudeProductExposePlanContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposePlanContract contract) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposePlanContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposePlanContract contract) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposePlanContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposePlanId) {
            CrudeProductExposePlanData.Delete(productExposePlanId);
        }
        
        public static void ContractToData(CrudeProductExposePlanContract contract, CrudeProductExposePlanData data) {
            data.ProductExposePlanId = contract.ProductExposePlanId;
            data.ProductId = contract.ProductId;
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposePlanData data, CrudeProductExposePlanContract contract) {
            contract.ProductExposePlanId = data.ProductExposePlanId;
            contract.ProductId = data.ProductId;
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
