/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:50:47 AM
  From Machine: DESKTOP-517I8BU
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
    public partial interface ICrudeProductGatherService {
        
        [OperationContract()]
        CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherId);
    }
    
    public partial class CrudeProductGatherService : ICrudeProductGatherService {
        
        public CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId) {
            var dataAccessLayer = new CrudeProductGatherData();
            var contract = new CrudeProductGatherContract();

            dataAccessLayer.FetchByProductGatherId(productGatherId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeProductGatherContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherContract> DataListToContractList(List<CrudeProductGatherData> dataList) {
            var contractList = new List<CrudeProductGatherContract>();

            foreach (CrudeProductGatherData data in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherContract> contractList, List<CrudeProductGatherData> dataList) {
            foreach (CrudeProductGatherContract contract in contractList) {
                var data = new CrudeProductGatherData();
                CrudeProductGatherService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherContract> FetchAll() {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAll();

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherData.FetchAllCount();
        }
        
        public List<CrudeProductGatherContract> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchWithFilter(
                productGatherId: productGatherId,
                startDateTime: startDateTime,
                finishDateTime: finishDateTime,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherData data in dataList) {
                var crudeProductGatherContract = new CrudeProductGatherContract();
                DataToContract(data, crudeProductGatherContract);
                list.Add(crudeProductGatherContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherContract contract) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherContract contract) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherId) {
            CrudeProductGatherData.Delete(productGatherId);
        }
        
        public static void ContractToData(CrudeProductGatherContract contract, CrudeProductGatherData data) {
            data.ProductGatherId = contract.ProductGatherId;
            data.StartDateTime = contract.StartDateTime;
            data.FinishDateTime = contract.FinishDateTime;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherData data, CrudeProductGatherContract contract) {
            contract.ProductGatherId = data.ProductGatherId;
            contract.StartDateTime = data.StartDateTime;
            contract.FinishDateTime = data.FinishDateTime;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
