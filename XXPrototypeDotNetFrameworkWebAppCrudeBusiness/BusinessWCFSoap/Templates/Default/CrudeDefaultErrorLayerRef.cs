/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:22:28 PM
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
    public partial interface ICrudeDefaultErrorLayerRefService {
        
        [OperationContract()]
        CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultErrorLayerRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultErrorLayerRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultErrorLayerRcd);
    }
    
    public partial class CrudeDefaultErrorLayerRefService : ICrudeDefaultErrorLayerRefService {
        
        public CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            var dataAccessLayer = new CrudeDefaultErrorLayerRefData();
            var contract = new CrudeDefaultErrorLayerRefContract();

            dataAccessLayer.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName) {
            var dataAccessLayer = new CrudeDefaultErrorLayerRefData();
            var contract = new CrudeDefaultErrorLayerRefContract();

            dataAccessLayer.FetchByDefaultErrorLayerName(defaultErrorLayerName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultErrorLayerRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultErrorLayerRefContract> DataListToContractList(List<CrudeDefaultErrorLayerRefData> dataList) {
            var contractList = new List<CrudeDefaultErrorLayerRefContract>();

            foreach (CrudeDefaultErrorLayerRefData data in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultErrorLayerRefContract> contractList, List<CrudeDefaultErrorLayerRefData> dataList) {
            foreach (CrudeDefaultErrorLayerRefContract contract in contractList) {
                var data = new CrudeDefaultErrorLayerRefData();
                CrudeDefaultErrorLayerRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchAll() {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAll();

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRef in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(crudeDefaultErrorLayerRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRef in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(crudeDefaultErrorLayerRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRef in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(crudeDefaultErrorLayerRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultErrorLayerRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchWithFilter(
                defaultErrorLayerRcd: defaultErrorLayerRcd,
                defaultErrorLayerName: defaultErrorLayerName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultErrorLayerRefData data in dataList) {
                var crudeDefaultErrorLayerRefContract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(data, crudeDefaultErrorLayerRefContract);
                list.Add(crudeDefaultErrorLayerRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultErrorLayerRefContract contract) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultErrorLayerRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultErrorLayerRefContract contract) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultErrorLayerRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultErrorLayerRcd) {
            CrudeDefaultErrorLayerRefData.Delete(defaultErrorLayerRcd);
        }
        
        public static void ContractToData(CrudeDefaultErrorLayerRefContract contract, CrudeDefaultErrorLayerRefData data) {
            data.DefaultErrorLayerRcd = contract.DefaultErrorLayerRcd;
            data.DefaultErrorLayerName = contract.DefaultErrorLayerName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultErrorLayerRefData data, CrudeDefaultErrorLayerRefContract contract) {
            contract.DefaultErrorLayerRcd = data.DefaultErrorLayerRcd;
            contract.DefaultErrorLayerName = data.DefaultErrorLayerName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
