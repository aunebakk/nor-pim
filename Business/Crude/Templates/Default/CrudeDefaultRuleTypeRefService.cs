/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:06:34 AM
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
    public partial interface ICrudeDefaultRuleTypeRefService {
        
        [OperationContract()]
        CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultRuleTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultRuleTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultRuleTypeRcd);
    }
    
    public partial class CrudeDefaultRuleTypeRefService : ICrudeDefaultRuleTypeRefService {
        
        public CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            var dataAccessLayer = new CrudeDefaultRuleTypeRefData();
            var contract = new CrudeDefaultRuleTypeRefContract();

            dataAccessLayer.FetchByDefaultRuleTypeRcd(defaultRuleTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultRuleTypeRefContract FetchByDefaultRuleTypeName(string defaultRuleTypeName) {
            var dataAccessLayer = new CrudeDefaultRuleTypeRefData();
            var contract = new CrudeDefaultRuleTypeRefContract();

            dataAccessLayer.FetchByDefaultRuleTypeName(defaultRuleTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultRuleTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultRuleTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultRuleTypeRefContract> DataListToContractList(List<CrudeDefaultRuleTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultRuleTypeRefContract>();

            foreach (CrudeDefaultRuleTypeRefData data in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultRuleTypeRefContract> contractList, List<CrudeDefaultRuleTypeRefData> dataList) {
            foreach (CrudeDefaultRuleTypeRefContract contract in contractList) {
                var data = new CrudeDefaultRuleTypeRefData();
                CrudeDefaultRuleTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultRuleTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAll();

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRef in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(crudeDefaultRuleTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRef in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(crudeDefaultRuleTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultRuleTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultRuleTypeRefData crudeDefaultRuleTypeRef in dataList) {
                var contract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(crudeDefaultRuleTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultRuleTypeRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultRuleTypeRefContract> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultRuleTypeRefContract>();
            List<CrudeDefaultRuleTypeRefData> dataList = CrudeDefaultRuleTypeRefData.FetchWithFilter(
                defaultRuleTypeRcd: defaultRuleTypeRcd,
                defaultRuleTypeName: defaultRuleTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultRuleTypeRefData data in dataList) {
                var crudeDefaultRuleTypeRefContract = new CrudeDefaultRuleTypeRefContract();
                DataToContract(data, crudeDefaultRuleTypeRefContract);
                list.Add(crudeDefaultRuleTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultRuleTypeRefContract contract) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultRuleTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultRuleTypeRefContract contract) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultRuleTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultRuleTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultRuleTypeRcd) {
            CrudeDefaultRuleTypeRefData.Delete(defaultRuleTypeRcd);
        }
        
        public static void ContractToData(CrudeDefaultRuleTypeRefContract contract, CrudeDefaultRuleTypeRefData data) {
            data.DefaultRuleTypeRcd = contract.DefaultRuleTypeRcd;
            data.DefaultRuleTypeName = contract.DefaultRuleTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultRuleTypeRefData data, CrudeDefaultRuleTypeRefContract contract) {
            contract.DefaultRuleTypeRcd = data.DefaultRuleTypeRcd;
            contract.DefaultRuleTypeName = data.DefaultRuleTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
