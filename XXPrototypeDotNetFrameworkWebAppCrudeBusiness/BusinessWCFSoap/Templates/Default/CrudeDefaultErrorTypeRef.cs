/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:31 PM
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
    public partial interface ICrudeDefaultErrorTypeRefService {
        
        [OperationContract()]
        CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeName(string defaultErrorTypeName);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultErrorTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultErrorTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultErrorTypeRcd);
    }
    
    public partial class CrudeDefaultErrorTypeRefService : ICrudeDefaultErrorTypeRefService {
        
        public CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            var dataAccessLayer = new CrudeDefaultErrorTypeRefData();
            var contract = new CrudeDefaultErrorTypeRefContract();

            dataAccessLayer.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeName(string defaultErrorTypeName) {
            var dataAccessLayer = new CrudeDefaultErrorTypeRefData();
            var contract = new CrudeDefaultErrorTypeRefContract();

            dataAccessLayer.FetchByDefaultErrorTypeName(defaultErrorTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultErrorTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultErrorTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultErrorTypeRefContract> DataListToContractList(List<CrudeDefaultErrorTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultErrorTypeRefContract>();

            foreach (CrudeDefaultErrorTypeRefData data in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultErrorTypeRefContract> contractList, List<CrudeDefaultErrorTypeRefData> dataList) {
            foreach (CrudeDefaultErrorTypeRefContract contract in contractList) {
                var data = new CrudeDefaultErrorTypeRefData();
                CrudeDefaultErrorTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultErrorTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAll();

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRef in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(crudeDefaultErrorTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRef in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(crudeDefaultErrorTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultErrorTypeRefData crudeDefaultErrorTypeRef in dataList) {
                var contract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(crudeDefaultErrorTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultErrorTypeRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultErrorTypeRefContract> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorTypeRefContract>();
            List<CrudeDefaultErrorTypeRefData> dataList = CrudeDefaultErrorTypeRefData.FetchWithFilter(
                defaultErrorTypeRcd: defaultErrorTypeRcd,
                defaultErrorTypeName: defaultErrorTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultErrorTypeRefData data in dataList) {
                var crudeDefaultErrorTypeRefContract = new CrudeDefaultErrorTypeRefContract();
                DataToContract(data, crudeDefaultErrorTypeRefContract);
                list.Add(crudeDefaultErrorTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultErrorTypeRefContract contract) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultErrorTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultErrorTypeRefContract contract) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultErrorTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultErrorTypeRcd) {
            CrudeDefaultErrorTypeRefData.Delete(defaultErrorTypeRcd);
        }
        
        public static void ContractToData(CrudeDefaultErrorTypeRefContract contract, CrudeDefaultErrorTypeRefData data) {
            data.DefaultErrorTypeRcd = contract.DefaultErrorTypeRcd;
            data.DefaultErrorTypeName = contract.DefaultErrorTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultErrorTypeRefData data, CrudeDefaultErrorTypeRefContract contract) {
            contract.DefaultErrorTypeRcd = data.DefaultErrorTypeRcd;
            contract.DefaultErrorTypeName = data.DefaultErrorTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
