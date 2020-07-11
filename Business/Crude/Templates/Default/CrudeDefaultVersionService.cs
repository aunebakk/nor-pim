/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:41:24 PM
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
    public partial interface ICrudeDefaultVersionService {
        
        [OperationContract()]
        CrudeDefaultVersionContract FetchByDefaultVersionId(System.Guid defaultVersionId);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultVersionContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultVersionContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultVersionId);
    }
    
    public partial class CrudeDefaultVersionService : ICrudeDefaultVersionService {
        
        public CrudeDefaultVersionContract FetchByDefaultVersionId(System.Guid defaultVersionId) {
            var dataAccessLayer = new CrudeDefaultVersionData();
            var contract = new CrudeDefaultVersionContract();

            dataAccessLayer.FetchByDefaultVersionId(defaultVersionId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultVersionContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultVersionData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultVersionContract> DataListToContractList(List<CrudeDefaultVersionData> dataList) {
            var contractList = new List<CrudeDefaultVersionContract>();

            foreach (CrudeDefaultVersionData data in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultVersionContract> contractList, List<CrudeDefaultVersionData> dataList) {
            foreach (CrudeDefaultVersionContract contract in contractList) {
                var data = new CrudeDefaultVersionData();
                CrudeDefaultVersionService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultVersionContract> FetchAll() {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAll();

            foreach (CrudeDefaultVersionData crudeDefaultVersion in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(crudeDefaultVersion, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultVersionContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultVersionData crudeDefaultVersion in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(crudeDefaultVersion, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultVersionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultVersionData crudeDefaultVersion in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(crudeDefaultVersion, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultVersionData.FetchAllCount();
        }
        
        public List<CrudeDefaultVersionContract> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchWithFilter(
                defaultVersionId: defaultVersionId,
                funVersion: funVersion,
                number: number,
                majorNumber: majorNumber,
                minorNumber: minorNumber,
                sequenceNumber: sequenceNumber,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultVersionData data in dataList) {
                var crudeDefaultVersionContract = new CrudeDefaultVersionContract();
                DataToContract(data, crudeDefaultVersionContract);
                list.Add(crudeDefaultVersionContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultVersionContract contract) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultVersionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultVersionContract contract) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultVersionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultVersionId) {
            CrudeDefaultVersionData.Delete(defaultVersionId);
        }
        
        public static void ContractToData(CrudeDefaultVersionContract contract, CrudeDefaultVersionData data) {
            data.DefaultVersionId = contract.DefaultVersionId;
            data.FunVersion = contract.FunVersion;
            data.Number = contract.Number;
            data.MajorNumber = contract.MajorNumber;
            data.MinorNumber = contract.MinorNumber;
            data.SequenceNumber = contract.SequenceNumber;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultVersionData data, CrudeDefaultVersionContract contract) {
            contract.DefaultVersionId = data.DefaultVersionId;
            contract.FunVersion = data.FunVersion;
            contract.Number = data.Number;
            contract.MajorNumber = data.MajorNumber;
            contract.MinorNumber = data.MinorNumber;
            contract.SequenceNumber = data.SequenceNumber;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
