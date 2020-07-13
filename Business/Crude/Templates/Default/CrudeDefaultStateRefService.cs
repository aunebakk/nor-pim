/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:56:21 AM
  From Machine: DESKTOP-00MSEIL
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
    public partial interface ICrudeDefaultStateRefService {
        
        [OperationContract()]
        CrudeDefaultStateRefContract FetchByDefaultStateRcd(string defaultStateRcd);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultStateRefContract FetchByDefaultStateName(string defaultStateName);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultStateRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultStateRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultStateRcd);
    }
    
    public partial class CrudeDefaultStateRefService : ICrudeDefaultStateRefService {
        
        public CrudeDefaultStateRefContract FetchByDefaultStateRcd(string defaultStateRcd) {
            var dataAccessLayer = new CrudeDefaultStateRefData();
            var contract = new CrudeDefaultStateRefContract();

            dataAccessLayer.FetchByDefaultStateRcd(defaultStateRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultStateRefContract FetchByDefaultStateName(string defaultStateName) {
            var dataAccessLayer = new CrudeDefaultStateRefData();
            var contract = new CrudeDefaultStateRefContract();

            dataAccessLayer.FetchByDefaultStateName(defaultStateName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultStateRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultStateRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultStateRefContract> DataListToContractList(List<CrudeDefaultStateRefData> dataList) {
            var contractList = new List<CrudeDefaultStateRefContract>();

            foreach (CrudeDefaultStateRefData data in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultStateRefContract> contractList, List<CrudeDefaultStateRefData> dataList) {
            foreach (CrudeDefaultStateRefContract contract in contractList) {
                var data = new CrudeDefaultStateRefData();
                CrudeDefaultStateRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultStateRefContract> FetchAll() {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAll();

            foreach (CrudeDefaultStateRefData crudeDefaultStateRef in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(crudeDefaultStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultStateRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultStateRefData crudeDefaultStateRef in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(crudeDefaultStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultStateRefData crudeDefaultStateRef in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(crudeDefaultStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultStateRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultStateRefContract> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchWithFilter(
                defaultStateRcd: defaultStateRcd,
                defaultStateName: defaultStateName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultStateRefData data in dataList) {
                var crudeDefaultStateRefContract = new CrudeDefaultStateRefContract();
                DataToContract(data, crudeDefaultStateRefContract);
                list.Add(crudeDefaultStateRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultStateRefContract contract) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultStateRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultStateRefContract contract) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultStateRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultStateRcd) {
            CrudeDefaultStateRefData.Delete(defaultStateRcd);
        }
        
        public static void ContractToData(CrudeDefaultStateRefContract contract, CrudeDefaultStateRefData data) {
            data.DefaultStateRcd = contract.DefaultStateRcd;
            data.DefaultStateName = contract.DefaultStateName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultStateRefData data, CrudeDefaultStateRefContract contract) {
            contract.DefaultStateRcd = data.DefaultStateRcd;
            contract.DefaultStateName = data.DefaultStateName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
