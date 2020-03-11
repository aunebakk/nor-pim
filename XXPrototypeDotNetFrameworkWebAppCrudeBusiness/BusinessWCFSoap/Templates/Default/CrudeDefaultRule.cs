/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:26:49 PM
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
    public partial interface ICrudeDefaultRuleService {
        
        [OperationContract()]
        CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultRuleContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultRuleContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultRuleId);
    }
    
    public partial class CrudeDefaultRuleService : ICrudeDefaultRuleService {
        
        public CrudeDefaultRuleContract FetchByDefaultRuleId(System.Guid defaultRuleId) {
            var dataAccessLayer = new CrudeDefaultRuleData();
            var contract = new CrudeDefaultRuleContract();

            dataAccessLayer.FetchByDefaultRuleId(defaultRuleId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultRuleContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultRuleData.FetchByDefaultUserId(defaultUserId));
        }
        
        public List<CrudeDefaultRuleContract> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            return DataListToContractList(CrudeDefaultRuleData.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd));
        }
        
        public static List<CrudeDefaultRuleContract> DataListToContractList(List<CrudeDefaultRuleData> dataList) {
            var contractList = new List<CrudeDefaultRuleContract>();

            foreach (CrudeDefaultRuleData data in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultRuleContract> contractList, List<CrudeDefaultRuleData> dataList) {
            foreach (CrudeDefaultRuleContract contract in contractList) {
                var data = new CrudeDefaultRuleData();
                CrudeDefaultRuleService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultRuleContract> FetchAll() {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAll();

            foreach (CrudeDefaultRuleData crudeDefaultRule in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(crudeDefaultRule, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultRuleData crudeDefaultRule in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(crudeDefaultRule, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultRuleData crudeDefaultRule in dataList) {
                var contract = new CrudeDefaultRuleContract();
                DataToContract(crudeDefaultRule, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultRuleData.FetchAllCount();
        }
        
        public List<CrudeDefaultRuleContract> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultRuleContract>();
            List<CrudeDefaultRuleData> dataList = CrudeDefaultRuleData.FetchWithFilter(
                defaultRuleId: defaultRuleId,
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                address: address,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultRuleData data in dataList) {
                var crudeDefaultRuleContract = new CrudeDefaultRuleContract();
                DataToContract(data, crudeDefaultRuleContract);
                list.Add(crudeDefaultRuleContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultRuleContract contract) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultRuleContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultRuleContract contract) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultRuleContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultRuleId) {
            CrudeDefaultRuleData.Delete(defaultRuleId);
        }
        
        public static void ContractToData(CrudeDefaultRuleContract contract, CrudeDefaultRuleData data) {
            data.DefaultRuleId = contract.DefaultRuleId;
            data.DefaultRuleTypeRcd = contract.DefaultRuleTypeRcd;
            data.Address = contract.Address;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultRuleData data, CrudeDefaultRuleContract contract) {
            contract.DefaultRuleId = data.DefaultRuleId;
            contract.DefaultRuleTypeRcd = data.DefaultRuleTypeRcd;
            contract.Address = data.Address;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
