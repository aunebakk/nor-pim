/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:41:19 PM
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
    public partial interface ICrudeDefaultChangeLogTypeRefService {
        
        [OperationContract()]
        CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultChangeLogTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultChangeLogTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultChangeLogTypeRcd);
    }
    
    public partial class CrudeDefaultChangeLogTypeRefService : ICrudeDefaultChangeLogTypeRefService {
        
        public CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            var dataAccessLayer = new CrudeDefaultChangeLogTypeRefData();
            var contract = new CrudeDefaultChangeLogTypeRefContract();

            dataAccessLayer.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName) {
            var dataAccessLayer = new CrudeDefaultChangeLogTypeRefData();
            var contract = new CrudeDefaultChangeLogTypeRefContract();

            dataAccessLayer.FetchByDefaultChangeLogTypeName(defaultChangeLogTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultChangeLogTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultChangeLogTypeRefContract> DataListToContractList(List<CrudeDefaultChangeLogTypeRefData> dataList) {
            var contractList = new List<CrudeDefaultChangeLogTypeRefContract>();

            foreach (CrudeDefaultChangeLogTypeRefData data in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultChangeLogTypeRefContract> contractList, List<CrudeDefaultChangeLogTypeRefData> dataList) {
            foreach (CrudeDefaultChangeLogTypeRefContract contract in contractList) {
                var data = new CrudeDefaultChangeLogTypeRefData();
                CrudeDefaultChangeLogTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultChangeLogTypeRefContract> FetchAll() {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAll();

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRef in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(crudeDefaultChangeLogTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRef in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(crudeDefaultChangeLogTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultChangeLogTypeRefData crudeDefaultChangeLogTypeRef in dataList) {
                var contract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(crudeDefaultChangeLogTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultChangeLogTypeRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultChangeLogTypeRefContract>();
            List<CrudeDefaultChangeLogTypeRefData> dataList = CrudeDefaultChangeLogTypeRefData.FetchWithFilter(
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultChangeLogTypeName: defaultChangeLogTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultChangeLogTypeRefData data in dataList) {
                var crudeDefaultChangeLogTypeRefContract = new CrudeDefaultChangeLogTypeRefContract();
                DataToContract(data, crudeDefaultChangeLogTypeRefContract);
                list.Add(crudeDefaultChangeLogTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultChangeLogTypeRefContract contract) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultChangeLogTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultChangeLogTypeRefContract contract) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultChangeLogTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultChangeLogTypeRcd) {
            CrudeDefaultChangeLogTypeRefData.Delete(defaultChangeLogTypeRcd);
        }
        
        public static void ContractToData(CrudeDefaultChangeLogTypeRefContract contract, CrudeDefaultChangeLogTypeRefData data) {
            data.DefaultChangeLogTypeRcd = contract.DefaultChangeLogTypeRcd;
            data.DefaultChangeLogTypeName = contract.DefaultChangeLogTypeName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultChangeLogTypeRefData data, CrudeDefaultChangeLogTypeRefContract contract) {
            contract.DefaultChangeLogTypeRcd = data.DefaultChangeLogTypeRcd;
            contract.DefaultChangeLogTypeName = data.DefaultChangeLogTypeName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
