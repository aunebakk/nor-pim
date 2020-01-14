/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:35 PM
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
    public partial interface ICrudeDefaultUserActivityTypeRefService {
        
        [OperationContract()]
        CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultUserActivityTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultUserActivityTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultUserActivityTypeRcd);
    }
    
    public partial class CrudeDefaultUserActivityTypeRefService : ICrudeDefaultUserActivityTypeRefService {
        
        public CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            var dataAccessLayer = new CrudeDefaultUserActivityTypeRefData();
            var contract = new CrudeDefaultUserActivityTypeRefContract();

            dataAccessLayer.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName) {
            var dataAccessLayer = new CrudeDefaultUserActivityTypeRefData();
            var contract = new CrudeDefaultUserActivityTypeRefContract();

            dataAccessLayer.FetchByDefaultUserActivityTypeName(defaultUserActivityTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultUserActivityTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultUserActivityTypeRefContract> DataListToContractList(List<CrudeDefaultUserActivityTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultUserActivityTypeRefContract>();

            foreach (CrudeDefaultUserActivityTypeRefData data in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultUserActivityTypeRefContract> contractList, List<CrudeDefaultUserActivityTypeRefData> dataList) {
            foreach (CrudeDefaultUserActivityTypeRefContract contract in contractList) {
                var data = new CrudeDefaultUserActivityTypeRefData();
                CrudeDefaultUserActivityTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultUserActivityTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAll();

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRef in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(crudeDefaultUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRef in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(crudeDefaultUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultUserActivityTypeRefData crudeDefaultUserActivityTypeRef in dataList) {
                var contract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(crudeDefaultUserActivityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultUserActivityTypeRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultUserActivityTypeRefContract>();
            List<CrudeDefaultUserActivityTypeRefData> dataList = CrudeDefaultUserActivityTypeRefData.FetchWithFilter(
                defaultUserActivityTypeRcd: defaultUserActivityTypeRcd,
                defaultUserActivityTypeName: defaultUserActivityTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultUserActivityTypeRefData data in dataList) {
                var crudeDefaultUserActivityTypeRefContract = new CrudeDefaultUserActivityTypeRefContract();
                DataToContract(data, crudeDefaultUserActivityTypeRefContract);
                list.Add(crudeDefaultUserActivityTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultUserActivityTypeRefContract contract) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultUserActivityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultUserActivityTypeRefContract contract) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultUserActivityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultUserActivityTypeRcd) {
            CrudeDefaultUserActivityTypeRefData.Delete(defaultUserActivityTypeRcd);
        }
        
        public static void ContractToData(CrudeDefaultUserActivityTypeRefContract contract, CrudeDefaultUserActivityTypeRefData data) {
            data.DefaultUserActivityTypeRcd = contract.DefaultUserActivityTypeRcd;
            data.DefaultUserActivityTypeName = contract.DefaultUserActivityTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultUserActivityTypeRefData data, CrudeDefaultUserActivityTypeRefContract contract) {
            contract.DefaultUserActivityTypeRcd = data.DefaultUserActivityTypeRcd;
            contract.DefaultUserActivityTypeName = data.DefaultUserActivityTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
