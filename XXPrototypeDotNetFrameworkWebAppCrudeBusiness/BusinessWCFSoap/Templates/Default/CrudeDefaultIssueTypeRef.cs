/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:51:09 AM
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
    public partial interface ICrudeDefaultIssueTypeRefService {
        
        [OperationContract()]
        CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeName(string defaultIssueTypeName);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultIssueTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultIssueTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultIssueTypeRcd);
    }
    
    public partial class CrudeDefaultIssueTypeRefService : ICrudeDefaultIssueTypeRefService {
        
        public CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var contract = new CrudeDefaultIssueTypeRefContract();

            dataAccessLayer.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeName(string defaultIssueTypeName) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var contract = new CrudeDefaultIssueTypeRefContract();

            dataAccessLayer.FetchByDefaultIssueTypeName(defaultIssueTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultIssueTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultIssueTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultIssueTypeRefContract> DataListToContractList(List<CrudeDefaultIssueTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultIssueTypeRefContract>();

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultIssueTypeRefContract> contractList, List<CrudeDefaultIssueTypeRefData> dataList) {
            foreach (CrudeDefaultIssueTypeRefContract contract in contractList) {
                var data = new CrudeDefaultIssueTypeRefData();
                CrudeDefaultIssueTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultIssueTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAll();

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRef in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(crudeDefaultIssueTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRef in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(crudeDefaultIssueTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRef in dataList) {
                var contract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(crudeDefaultIssueTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultIssueTypeRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultIssueTypeRefContract> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultIssueTypeRefContract>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchWithFilter(
                defaultIssueTypeRcd: defaultIssueTypeRcd,
                defaultIssueTypeName: defaultIssueTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var crudeDefaultIssueTypeRefContract = new CrudeDefaultIssueTypeRefContract();
                DataToContract(data, crudeDefaultIssueTypeRefContract);
                list.Add(crudeDefaultIssueTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultIssueTypeRefContract contract) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultIssueTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultIssueTypeRefContract contract) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultIssueTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultIssueTypeRcd) {
            CrudeDefaultIssueTypeRefData.Delete(defaultIssueTypeRcd);
        }
        
        public static void ContractToData(CrudeDefaultIssueTypeRefContract contract, CrudeDefaultIssueTypeRefData data) {
            data.DefaultIssueTypeRcd = contract.DefaultIssueTypeRcd;
            data.DefaultIssueTypeName = contract.DefaultIssueTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultIssueTypeRefData data, CrudeDefaultIssueTypeRefContract contract) {
            contract.DefaultIssueTypeRcd = data.DefaultIssueTypeRcd;
            contract.DefaultIssueTypeName = data.DefaultIssueTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
