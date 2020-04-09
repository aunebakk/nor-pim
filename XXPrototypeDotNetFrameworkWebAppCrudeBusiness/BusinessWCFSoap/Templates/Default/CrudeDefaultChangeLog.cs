/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:00 PM
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
    public partial interface ICrudeDefaultChangeLogService {
        
        [OperationContract()]
        CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);
        
        [OperationContract()]
        CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultChangeLogContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultChangeLogContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultChangeLogId);
    }
    
    public partial class CrudeDefaultChangeLogService : ICrudeDefaultChangeLogService {
        
        public CrudeDefaultChangeLogContract FetchByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            var dataAccessLayer = new CrudeDefaultChangeLogData();
            var contract = new CrudeDefaultChangeLogContract();

            dataAccessLayer.FetchByDefaultChangeLogId(defaultChangeLogId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultChangeLogContract FetchByDefaultChangeName(string defaultChangeName) {
            var dataAccessLayer = new CrudeDefaultChangeLogData();
            var contract = new CrudeDefaultChangeLogContract();

            dataAccessLayer.FetchByDefaultChangeName(defaultChangeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultChangeLogContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultChangeLogData.FetchByDefaultUserId(defaultUserId));
        }
        
        public List<CrudeDefaultChangeLogContract> FetchByDefaultIssueId(System.Guid defaultIssueId) {
            return DataListToContractList(CrudeDefaultChangeLogData.FetchByDefaultIssueId(defaultIssueId));
        }
        
        public List<CrudeDefaultChangeLogContract> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            return DataListToContractList(CrudeDefaultChangeLogData.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd));
        }
        
        public static List<CrudeDefaultChangeLogContract> DataListToContractList(List<CrudeDefaultChangeLogData> dataList) {
            var contractList = new List<CrudeDefaultChangeLogContract>();

            foreach (CrudeDefaultChangeLogData data in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultChangeLogContract> contractList, List<CrudeDefaultChangeLogData> dataList) {
            foreach (CrudeDefaultChangeLogContract contract in contractList) {
                var data = new CrudeDefaultChangeLogData();
                CrudeDefaultChangeLogService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultChangeLogContract> FetchAll() {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAll();

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLog in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(crudeDefaultChangeLog, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLog in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(crudeDefaultChangeLog, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultChangeLogContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultChangeLogData crudeDefaultChangeLog in dataList) {
                var contract = new CrudeDefaultChangeLogContract();
                DataToContract(crudeDefaultChangeLog, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultChangeLogData.FetchAllCount();
        }
        
        public List<CrudeDefaultChangeLogContract> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            var list = new List<CrudeDefaultChangeLogContract>();
            List<CrudeDefaultChangeLogData> dataList = CrudeDefaultChangeLogData.FetchWithFilter(
                defaultChangeLogId: defaultChangeLogId,
                defaultChangeName: defaultChangeName,
                defaultChangeDescription: defaultChangeDescription,
                defaultUserId: defaultUserId,
                dateTime: dateTime,
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultIssueId: defaultIssueId
                );

            foreach (CrudeDefaultChangeLogData data in dataList) {
                var crudeDefaultChangeLogContract = new CrudeDefaultChangeLogContract();
                DataToContract(data, crudeDefaultChangeLogContract);
                list.Add(crudeDefaultChangeLogContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultChangeLogContract contract) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultChangeLogContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultChangeLogContract contract) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultChangeLogContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultChangeLogData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultChangeLogId) {
            CrudeDefaultChangeLogData.Delete(defaultChangeLogId);
        }
        
        public static void ContractToData(CrudeDefaultChangeLogContract contract, CrudeDefaultChangeLogData data) {
            data.DefaultChangeLogId = contract.DefaultChangeLogId;
            data.DefaultChangeName = contract.DefaultChangeName;
            data.DefaultChangeDescription = contract.DefaultChangeDescription;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
            data.DefaultChangeLogTypeRcd = contract.DefaultChangeLogTypeRcd;
            data.DefaultIssueId = contract.DefaultIssueId;
        }
        
        public static void DataToContract(CrudeDefaultChangeLogData data, CrudeDefaultChangeLogContract contract) {
            contract.DefaultChangeLogId = data.DefaultChangeLogId;
            contract.DefaultChangeName = data.DefaultChangeName;
            contract.DefaultChangeDescription = data.DefaultChangeDescription;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
            contract.DefaultChangeLogTypeRcd = data.DefaultChangeLogTypeRcd;
            contract.DefaultIssueId = data.DefaultIssueId;
        }
    }
}
