/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:22:55 PM
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
    public partial interface ICrudeProductGatherSourceService {
        
        [OperationContract()]
        CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherSourceContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherSourceContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherSourceId);
    }
    
    public partial class CrudeProductGatherSourceService : ICrudeProductGatherSourceService {
        
        public CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            var dataAccessLayer = new CrudeProductGatherSourceData();
            var contract = new CrudeProductGatherSourceContract();

            dataAccessLayer.FetchByProductGatherSourceId(productGatherSourceId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId) {
            return DataListToContractList(CrudeProductGatherSourceData.FetchByProductGatherId(productGatherId));
        }
        
        public List<CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherSourceData.FetchByUserId(userId));
        }
        
        public List<CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            return DataListToContractList(CrudeProductGatherSourceData.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd));
        }
        
        public static List<CrudeProductGatherSourceContract> DataListToContractList(List<CrudeProductGatherSourceData> dataList) {
            var contractList = new List<CrudeProductGatherSourceContract>();

            foreach (CrudeProductGatherSourceData data in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherSourceContract> contractList, List<CrudeProductGatherSourceData> dataList) {
            foreach (CrudeProductGatherSourceContract contract in contractList) {
                var data = new CrudeProductGatherSourceData();
                CrudeProductGatherSourceService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherSourceContract> FetchAll() {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAll();

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherSourceData.FetchAllCount();
        }
        
        public List<CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchWithFilter(
                productGatherSourceId: productGatherSourceId,
                productGatherId: productGatherId,
                productGatherSourceTypeRcd: productGatherSourceTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherSourceData data in dataList) {
                var crudeProductGatherSourceContract = new CrudeProductGatherSourceContract();
                DataToContract(data, crudeProductGatherSourceContract);
                list.Add(crudeProductGatherSourceContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherSourceContract contract) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherSourceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherSourceContract contract) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherSourceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherSourceId) {
            CrudeProductGatherSourceData.Delete(productGatherSourceId);
        }
        
        public static void ContractToData(CrudeProductGatherSourceContract contract, CrudeProductGatherSourceData data) {
            data.ProductGatherSourceId = contract.ProductGatherSourceId;
            data.ProductGatherId = contract.ProductGatherId;
            data.ProductGatherSourceTypeRcd = contract.ProductGatherSourceTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherSourceData data, CrudeProductGatherSourceContract contract) {
            contract.ProductGatherSourceId = data.ProductGatherSourceId;
            contract.ProductGatherId = data.ProductGatherId;
            contract.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
