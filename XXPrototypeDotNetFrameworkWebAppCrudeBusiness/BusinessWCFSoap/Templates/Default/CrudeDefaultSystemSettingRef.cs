/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:01 AM
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
    public partial interface ICrudeDefaultSystemSettingRefService {
        
        [OperationContract()]
        CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultSystemSettingRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultSystemSettingRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultSystemSettingRcd);
    }
    
    public partial class CrudeDefaultSystemSettingRefService : ICrudeDefaultSystemSettingRefService {
        
        public CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            var dataAccessLayer = new CrudeDefaultSystemSettingRefData();
            var contract = new CrudeDefaultSystemSettingRefContract();

            dataAccessLayer.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName) {
            var dataAccessLayer = new CrudeDefaultSystemSettingRefData();
            var contract = new CrudeDefaultSystemSettingRefContract();

            dataAccessLayer.FetchByDefaultSystemSettingName(defaultSystemSettingName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultSystemSettingRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultSystemSettingRefContract> DataListToContractList(List<CrudeDefaultSystemSettingRefData> dataList) {
            var contractList = new List<CrudeDefaultSystemSettingRefContract>();

            foreach (CrudeDefaultSystemSettingRefData data in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultSystemSettingRefContract> contractList, List<CrudeDefaultSystemSettingRefData> dataList) {
            foreach (CrudeDefaultSystemSettingRefContract contract in contractList) {
                var data = new CrudeDefaultSystemSettingRefData();
                CrudeDefaultSystemSettingRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultSystemSettingRefContract> FetchAll() {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAll();

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRef in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(crudeDefaultSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRef in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(crudeDefaultSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRef in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(crudeDefaultSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultSystemSettingRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchWithFilter(
                defaultSystemSettingRcd: defaultSystemSettingRcd,
                defaultSystemSettingName: defaultSystemSettingName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultSystemSettingRefData data in dataList) {
                var crudeDefaultSystemSettingRefContract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(data, crudeDefaultSystemSettingRefContract);
                list.Add(crudeDefaultSystemSettingRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultSystemSettingRefContract contract) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultSystemSettingRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultSystemSettingRefContract contract) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultSystemSettingRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultSystemSettingRcd) {
            CrudeDefaultSystemSettingRefData.Delete(defaultSystemSettingRcd);
        }
        
        public static void ContractToData(CrudeDefaultSystemSettingRefContract contract, CrudeDefaultSystemSettingRefData data) {
            data.DefaultSystemSettingRcd = contract.DefaultSystemSettingRcd;
            data.DefaultSystemSettingName = contract.DefaultSystemSettingName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultSystemSettingRefData data, CrudeDefaultSystemSettingRefContract contract) {
            contract.DefaultSystemSettingRcd = data.DefaultSystemSettingRcd;
            contract.DefaultSystemSettingName = data.DefaultSystemSettingName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
