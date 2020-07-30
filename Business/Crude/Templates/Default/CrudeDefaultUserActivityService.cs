/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:40:26 AM
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
    public partial interface ICrudeDefaultUserActivityService {
        
        [OperationContract()]
        CrudeDefaultUserActivityContract FetchByDefaultUserActivityId(System.Guid defaultUserActivityId);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultUserActivityContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultUserActivityContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultUserActivityId);
    }
    
    public partial class CrudeDefaultUserActivityService : ICrudeDefaultUserActivityService {
        
        public CrudeDefaultUserActivityContract FetchByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            var dataAccessLayer = new CrudeDefaultUserActivityData();
            var contract = new CrudeDefaultUserActivityContract();

            dataAccessLayer.FetchByDefaultUserActivityId(defaultUserActivityId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultUserActivityContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultUserActivityData.FetchByDefaultUserId(defaultUserId));
        }
        
        public List<CrudeDefaultUserActivityContract> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            return DataListToContractList(CrudeDefaultUserActivityData.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd));
        }
        
        public static List<CrudeDefaultUserActivityContract> DataListToContractList(List<CrudeDefaultUserActivityData> dataList) {
            var contractList = new List<CrudeDefaultUserActivityContract>();

            foreach (CrudeDefaultUserActivityData data in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultUserActivityContract> contractList, List<CrudeDefaultUserActivityData> dataList) {
            foreach (CrudeDefaultUserActivityContract contract in contractList) {
                var data = new CrudeDefaultUserActivityData();
                CrudeDefaultUserActivityService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultUserActivityContract> FetchAll() {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAll();

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivity in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(crudeDefaultUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivity in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(crudeDefaultUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivity in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(crudeDefaultUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultUserActivityData.FetchAllCount();
        }
        
        public List<CrudeDefaultUserActivityContract> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchWithFilter(
                defaultUserActivityId: defaultUserActivityId,
                defaultUserActivityTypeRcd: defaultUserActivityTypeRcd,
                userActivityNote: userActivityNote,
                originatingAddress: originatingAddress,
                referrer: referrer,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultUserActivityData data in dataList) {
                var crudeDefaultUserActivityContract = new CrudeDefaultUserActivityContract();
                DataToContract(data, crudeDefaultUserActivityContract);
                list.Add(crudeDefaultUserActivityContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultUserActivityContract contract) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultUserActivityContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultUserActivityContract contract) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultUserActivityContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultUserActivityId) {
            CrudeDefaultUserActivityData.Delete(defaultUserActivityId);
        }
        
        public static void ContractToData(CrudeDefaultUserActivityContract contract, CrudeDefaultUserActivityData data) {
            data.DefaultUserActivityId = contract.DefaultUserActivityId;
            data.DefaultUserActivityTypeRcd = contract.DefaultUserActivityTypeRcd;
            data.UserActivityNote = contract.UserActivityNote;
            data.OriginatingAddress = contract.OriginatingAddress;
            data.Referrer = contract.Referrer;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultUserActivityData data, CrudeDefaultUserActivityContract contract) {
            contract.DefaultUserActivityId = data.DefaultUserActivityId;
            contract.DefaultUserActivityTypeRcd = data.DefaultUserActivityTypeRcd;
            contract.UserActivityNote = data.UserActivityNote;
            contract.OriginatingAddress = data.OriginatingAddress;
            contract.Referrer = data.Referrer;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
