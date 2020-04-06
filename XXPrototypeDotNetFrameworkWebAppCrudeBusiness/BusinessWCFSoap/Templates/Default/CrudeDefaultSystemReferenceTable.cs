/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:22:32 PM
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
    public partial interface ICrudeDefaultSystemReferenceTableService {
        
        [OperationContract()]
        CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultSystemReferenceTableId);
    }
    
    public partial class CrudeDefaultSystemReferenceTableService : ICrudeDefaultSystemReferenceTableService {
        
        public CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var contract = new CrudeDefaultSystemReferenceTableContract();

            dataAccessLayer.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var contract = new CrudeDefaultSystemReferenceTableContract();

            dataAccessLayer.FetchByDefaultSystemReferenceTableName(defaultSystemReferenceTableName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultSystemReferenceTableData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultSystemReferenceTableContract> DataListToContractList(List<CrudeDefaultSystemReferenceTableData> dataList) {
            var contractList = new List<CrudeDefaultSystemReferenceTableContract>();

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultSystemReferenceTableContract> contractList, List<CrudeDefaultSystemReferenceTableData> dataList) {
            foreach (CrudeDefaultSystemReferenceTableContract contract in contractList) {
                var data = new CrudeDefaultSystemReferenceTableData();
                CrudeDefaultSystemReferenceTableService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchAll() {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAll();

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultSystemReferenceTableData.FetchAllCount();
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchWithFilter(
                defaultSystemReferenceTableId: defaultSystemReferenceTableId,
                defaultSystemReferenceTableName: defaultSystemReferenceTableName,
                defaultSystemReferenceDisplayName: defaultSystemReferenceDisplayName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var crudeDefaultSystemReferenceTableContract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(data, crudeDefaultSystemReferenceTableContract);
                list.Add(crudeDefaultSystemReferenceTableContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultSystemReferenceTableContract contract) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultSystemReferenceTableContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultSystemReferenceTableContract contract) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultSystemReferenceTableContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultSystemReferenceTableId) {
            CrudeDefaultSystemReferenceTableData.Delete(defaultSystemReferenceTableId);
        }
        
        public static void ContractToData(CrudeDefaultSystemReferenceTableContract contract, CrudeDefaultSystemReferenceTableData data) {
            data.DefaultSystemReferenceTableId = contract.DefaultSystemReferenceTableId;
            data.DefaultSystemReferenceTableName = contract.DefaultSystemReferenceTableName;
            data.DefaultSystemReferenceDisplayName = contract.DefaultSystemReferenceDisplayName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultSystemReferenceTableData data, CrudeDefaultSystemReferenceTableContract contract) {
            contract.DefaultSystemReferenceTableId = data.DefaultSystemReferenceTableId;
            contract.DefaultSystemReferenceTableName = data.DefaultSystemReferenceTableName;
            contract.DefaultSystemReferenceDisplayName = data.DefaultSystemReferenceDisplayName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
